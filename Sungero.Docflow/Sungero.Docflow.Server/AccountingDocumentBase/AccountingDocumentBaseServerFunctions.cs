using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.AccountingDocumentBase;
using Sungero.Domain;

namespace Sungero.Docflow.Server
{
  partial class AccountingDocumentBaseFunctions
  {    
    [Remote(IsPure = true)]
    public static Structures.AccountingDocumentBase.AfterExportDialog PrepareExportFinancialDocumentDialogDocuments(List<int> objsId,
                                                                                                                    Structures.AccountingDocumentBase.ExportDialogParams parameters)
    {
      var objs = new List<IOfficialDocument>();
      AccessRights.AllowRead(
        () =>
        {
          objs = Docflow.OfficialDocuments.GetAll().Where(x => objsId.Contains(x.Id)).ToList();
        });
      return PrepareExportFinancialDocumentDialogDocuments(objs.AsQueryable(), parameters);
    }
    
    [Remote(IsPure = true)]
    public static Structures.AccountingDocumentBase.AfterExportDialog PrepareExportFinancialDocumentDialogDocuments(Structures.AccountingDocumentBase.IExportDialogSearch search,
                                                                                                                    Structures.AccountingDocumentBase.ExportDialogParams parameters)
    {
      var query = Functions.AccountingDocumentBase.SearchByRequisites(search);
      return PrepareExportFinancialDocumentDialogDocuments(query, parameters);
    }
    
    private static Structures.AccountingDocumentBase.AfterExportDialog PrepareExportFinancialDocumentDialogDocuments(IQueryable<IOfficialDocument> objs,
                                                                                                                     Structures.AccountingDocumentBase.ExportDialogParams parameters)
    {
      var now = Calendar.UserNow;
      var tempFolderName = AccountingDocumentBases.Resources.ExportDocumentFolderNameFormat(now.ToShortDateString() + " " + now.ToLongTimeString()).ToString();
      tempFolderName = CommonLibrary.FileUtils.NormalizeFileName(tempFolderName);
      var result = Structures.AccountingDocumentBase.AfterExportDialog.Create(tempFolderName, string.Empty, now,
                                                                              new List<Structures.AccountingDocumentBase.ExportedDocument>());
      
      // Проверить, приобретена ли лицензия на модуль Финансовый архив.
      var moduleGuid = Constants.AccountingDocumentBase.FinancialArchiveUIGuid;
      if (!Sungero.Docflow.PublicFunctions.Module.Remote.IsModuleAvailableByLicense(moduleGuid))
      {
        throw AppliedCodeException.Create(AccountingDocumentBases.Resources.NoFinancialArchiveLicense);
      }
      
      foreach (var counterparty in objs.GroupBy(d => AccountingDocumentBases.Is(d) ? AccountingDocumentBases.As(d).Counterparty : ContractualDocumentBases.As(d).Counterparty))
      {
        foreach (var type in counterparty.GroupBy(c => c.DocumentKind.DocumentType))
        {
          foreach (var document in type)
          {
            var isFormalized = AccountingDocumentBases.Is(document) && AccountingDocumentBases.As(document).IsFormalized == true;
            var docStructure = Structures.AccountingDocumentBase.ExportedDocument
              .Create(document.Id, isFormalized, false, string.Empty, false, parameters.ForPrint, string.Empty, Structures.AccountingDocumentBase.ExportedFolder
                      .Create(string.Empty, new List<Structures.AccountingDocumentBase.ExportedFile>(),
                              new List<Structures.AccountingDocumentBase.ExportedFolder>(), string.Empty), document.Name, null);
            
            result.Documents.Add(docStructure);

            Logger.DebugFormat("Document with id '{0}' has been prepared for export financial documents. Is formalized: '{1}', for print: '{2}'.",
                               document.Id, isFormalized, parameters.ForPrint);
            
            var folder = docStructure.Folder;
            if (parameters.GroupCounterparty)
            {
              var folderName = CommonLibrary.FileUtils.NormalizeFileName(counterparty.Key.Name);
              var subfolder = Structures.AccountingDocumentBase.ExportedFolder
                .Create(folderName, new List<Structures.AccountingDocumentBase.ExportedFile>(),
                        new List<Structures.AccountingDocumentBase.ExportedFolder>(), folder.FolderName);
              folder.Folders.Add(subfolder);
              folder = subfolder;
            }
            
            if (parameters.GroupDocumentType)
            {
              var folderName = CommonLibrary.FileUtils.NormalizeFileName(type.Key.Name);
              var subfolder = Structures.AccountingDocumentBase.ExportedFolder
                .Create(folderName, new List<Structures.AccountingDocumentBase.ExportedFile>(),
                        new List<Structures.AccountingDocumentBase.ExportedFolder>(), folder.FolderName);
              folder.Folders.Add(subfolder);
              folder = subfolder;
            }
            
            if (!docStructure.IsFormalized)
            {
              if (Contracts.ContractualDocuments.Is(document))
              {
                var parentName = GetExportedDocumentFileName(docStructure, document);
                var parentFolder = GetRealDocumentFolder(docStructure, document);
                var addendum = document.Relations.GetRelated(Constants.Module.AddendumRelationName)
                  .Where(x => OfficialDocuments.Is(x))
                  .Select(d => OfficialDocuments.As(d))
                  .ToList();
                foreach (var addendumDocument in addendum)
                {
                  var isAddendumFormalized = AccountingDocumentBases.Is(addendumDocument) && AccountingDocumentBases.As(addendumDocument).IsFormalized == true;
                  Structures.AccountingDocumentBase.ExportedDocument structure;
                  structure = Structures.AccountingDocumentBase.ExportedDocument.Create(addendumDocument.Id, isAddendumFormalized, true, parentName,
                                                                                        false, parameters.ForPrint, string.Empty,
                                                                                        docStructure.Folder, addendumDocument.Name, document.Id);
                  result.Documents.Add(structure);
                  
                  Logger.DebugFormat("Addendum with id '{0}' has been prepared for export financial documents. Is formalized: '{1}', for print: '{2}', lead document id '{3}'.",
                                     addendumDocument.Id, isAddendumFormalized, parameters.ForPrint, document.Id);
                }
              }
            }
          }
        }
      }
      
      return result;
    }

    [Remote]
    public static List<Structures.AccountingDocumentBase.ExportedDocument> AfterExportFinancialDocumentDialog(List<Structures.AccountingDocumentBase.ExportedDocument> objs,
                                                                                                              Structures.AccountingDocumentBase.ExportDialogParams parameters)
    {
      foreach (var obj in objs)
      {
        try
        {
          if (obj.IsAddendum)
          {
            var leadingDocument = objs.Where(x => Equals(x.Id, obj.LeadDocumentId)).FirstOrDefault();
            if (leadingDocument != null && leadingDocument.IsFaulted == true)
            {
              obj.IsFaulted = true;
              obj.Error = AccountingDocumentBases.Resources.ExportDialog_Error_LeadDocumentNoVersion;
              continue;
            }
          }
          
          if (obj.IsFormalized)
            ExportFormalizedDocumentsToFolder(obj, null);
          else
            ExportNonformalizedDocumentsToFolder(obj, null);
          
          Logger.DebugFormat("Document with id '{0}' has been processed for export financial documents. Is formalized: '{1}', for print: '{2}', lead document id '{3}', is faulted: '{4}', error message: '{5}'",
                             obj.Id, obj.IsFormalized, obj.IsPrint, obj.LeadDocumentId, obj.IsFaulted, obj.Error);
        }
        catch (Exception ex)
        {
          Logger.Debug(ex.ToString());
          obj.Error = AccountingDocumentBases.Resources.ExportDialog_Error_ClientFormat(ex.Message.TrimEnd('.'));
          obj.IsFaulted = true;
        }
      }
      return objs;
    }
    
    [Remote]
    public static Structures.AccountingDocumentBase.ExportResult AfterExportFinancialDocumentDialogToWeb(List<Structures.AccountingDocumentBase.ExportedDocument> objs,
                                                                                                         Structures.AccountingDocumentBase.ExportDialogParams parameters,
                                                                                                         string fileName)
    {
      var result = Structures.AccountingDocumentBase.ExportResult.Create();
      var zipModels = new List<Structures.AccountingDocumentBase.ZipModel>();
      foreach (var obj in objs)
      {
        try
        {
          if (obj.IsAddendum)
          {
            var leadingDocument = objs.Where(x => Equals(x.Id, obj.LeadDocumentId)).FirstOrDefault();
            if (leadingDocument != null && leadingDocument.IsFaulted == true)
            {
              obj.IsFaulted = true;
              obj.Error = AccountingDocumentBases.Resources.ExportDialog_Error_LeadDocumentNoVersion;
              continue;
            }
          }
          
          if (obj.IsFormalized)
            ExportFormalizedDocumentsToFolder(obj, zipModels);
          else
            ExportNonformalizedDocumentsToFolder(obj, zipModels);
          
          Logger.DebugFormat("Document with id '{0}' has been processed for export financial documents. Is formalized: '{1}', for print: '{2}', lead document Id: '{3}', is faulted: '{4}', error message: '{5}'",
                             obj.Id, obj.IsFormalized, obj.IsPrint, obj.LeadDocumentId, obj.IsFaulted, obj.Error);
        }
        catch (Exception ex)
        {
          Logger.Debug(ex.ToString());
          obj.Error = AccountingDocumentBases.Resources.ExportDialog_Error_ClientFormat(ex.Message.TrimEnd('.'));
          obj.IsFaulted = true;
        }
      }
      
      result.ExportedDocuments = objs;
      result.ZipModels = zipModels;
      return result;
    }

    [Remote]
    public static IZip CreateZipFromZipModel(List<Structures.AccountingDocumentBase.ZipModel> zipModels, List<Structures.AccountingDocumentBase.ExportedDocument> objs, string fileName)
    {
      var zip = Zip.Create();
      foreach (var zipModel in zipModels)
      {
        var document = Docflow.OfficialDocuments.Get(zipModel.DocumentId);
        var version = document.Versions.Where(x => x.Id == zipModel.VersionId).FirstOrDefault();
        if (zipModel.SignatureId != null)
        {
          
          var signature = Signatures.Get(version).Where(x => x.Id == zipModel.SignatureId).SingleOrDefault();
          zip.Add(signature, zipModel.FileName, zipModel.FolderRelativePath.ToArray());
          continue;
        }
        var body = zipModel.IsPublicBody ? version.PublicBody : version.Body;
        zip.Add(body, zipModel.FileName, zipModel.FolderRelativePath.ToArray());
        Logger.DebugFormat("Document with Id '{0}', version id '{1}', is PublicBody: '{2}' has been added to zip model",
                           zipModel.DocumentId, zipModel.VersionId, zipModel.IsPublicBody);
      }
      
      // Отчет
      var now = Calendar.UserNow;
      var generated = Functions.AccountingDocumentBase.GetFinArchiveExportReport(objs, now);
      zip.Add(generated, Sungero.FinancialArchive.Reports.Resources.FinArchiveExportReport.HeaderFormat(now.ToShortDateString() + " " + now.ToLongTimeString()));
      Logger.DebugFormat("Report has been added to zip model");
      
      zip.Save(fileName);
      Logger.DebugFormat("Zip model has been saved");
      return zip;
    }
    
    private static string GetExportedDocumentFolderName(Structures.AccountingDocumentBase.ExportedDocument document, IOfficialDocument officialDocument)
    {
      // Имя папки всегда формируется как "Договор №Д-17_10 от 10.12.2017 (123)".
      var name = GetDocumentNameForExport(officialDocument, true);
      return CommonLibrary.FileUtils.NormalizeFileName(name) + " (" + document.Id + ")";
    }
    
    private static string GetExportedDocumentFileName(Structures.AccountingDocumentBase.ExportedDocument document, IOfficialDocument officialDocument)
    {
      //// Формализованные:
      //// Для печати: Акт №2 от 12.12.12 (123).pdf
      //// В эл. формате: ON_SCHFDOPPR_2TS1adcbec8-89da-4744-855d-0a9566479eff_....xml
      //// Как приложения для печати: %формат имени договорного документа для печати%_Приложение (123).pdf
      //// Как приложения в эл формате: ON_SCHFDOPPR_2TS1adcbec8-89da-4744-855d-0a9566479eff_....xml

      //// Неформализованные (разные форматы для бухгалтерских документов и остальных):
      //// Для печати: Акт №2 от 12.12.12 (123).pdf / Договор №Д-17_10 от 10.12.2017 с Уник, ООО _Поставка электроизмерительного оборудования_для_печати (123).pdf
      //// В эл. формате: Акт №2 от 12.12.12.pdf / Договор №Д-17_10 от 10.12.2017 с Уник, ООО _Поставка электроизмерительного оборудования_для_печати.pdf
      //// Как приложения для печати: %формат имени договорного документа для печати%_Приложение (123).pdf
      //// Как приложения в эл формате: Акт №2 от 12.12.12.pdf / Договор №Д-17_10 от 10.12.2017 с Уник, ООО _Поставка электроизмерительного оборудования_для_печати.pdf

      //// Печатные формы неформализованных документов в эл. формате дополняются постфиксом "_для_печати".
      //// Подписи неформализованных документов в эл. формате дополняются постфиксом "__" или "_1_".
      //// Эл форматы формализованных не реализованы в функции а сделаны на местах, т.к. имя надо получать из тела.
      
      var name = string.Empty;
      
      // Приложения для печати имеют собственный формат имени. Все остальные - как эл. формат неформализованных.
      if (document.IsAddendum && document.IsPrint)
        name = AccountingDocumentBases.Resources.ExportDocumentAddendumNameFormat(document.ParentShortName);
      else
        name = GetDocumentNameForExport(officialDocument, false);
      
      // Файлы для печати должны быть с ID документа.
      if (document.IsPrint)
        name = name + " (" + document.Id + ")";
      
      return CommonLibrary.FileUtils.NormalizeFileName(name);
    }
    
    private static string GetDocumentNameForExport(IOfficialDocument document, bool forFolder)
    {
      var name = string.Empty;
      
      using (TenantInfo.Culture.SwitchTo())
      {
        if (document.RegistrationNumber != null)
          name += OfficialDocuments.Resources.Number + document.RegistrationNumber;
        
        if (document.RegistrationDate != null)
          name += OfficialDocuments.Resources.DateFrom + document.RegistrationDate.Value.ToString("d");
      }
      
      var accounting = AccountingDocumentBases.As(document);
      var type = string.Empty;
      if (FinancialArchive.ContractStatements.Is(document))
        type = AccountingDocumentBases.Resources.NameForExport_ContractStatement;
      if (FinancialArchive.Waybills.Is(document))
        type = AccountingDocumentBases.Resources.NameForExport_Waybill;
      if (FinancialArchive.IncomingTaxInvoices.Is(document))
        type = accounting.IsAdjustment == true ? AccountingDocumentBases.Resources.NameForExport_IncomingTaxInvoiceAdjustment : AccountingDocumentBases.Resources.NameForExport_IncomingTaxInvoce;
      if (FinancialArchive.OutgoingTaxInvoices.Is(document))
        type = accounting.IsAdjustment == true ? AccountingDocumentBases.Resources.NameForExport_OutgoingTaxInvoiceAdjustment : AccountingDocumentBases.Resources.NameForExport_OutgoingTaxInvoice;
      if (FinancialArchive.UniversalTransferDocuments.Is(document))
        type = accounting.IsAdjustment == true ? AccountingDocumentBases.Resources.NameForExport_UTDAdjustment : AccountingDocumentBases.Resources.NameForExport_UTD;
      
      if (forFolder)
      {
        if (Contracts.Contracts.Is(document))
          type = AccountingDocumentBases.Resources.NameForExport_Contract;
        if (Contracts.SupAgreements.Is(document))
          type = AccountingDocumentBases.Resources.NameForExport_SupAgreement;
      }
      
      // Если тип документа не удалось определить, берем просто его имя ограниченной длины. Только для имен файлов.
      if (!string.IsNullOrWhiteSpace(type))
        name = type + name;
      else if (!forFolder)
        name = document.Name.Substring(0, Math.Min(document.Name.Length, 125));
      
      return name;
    }
    
    private static Structures.AccountingDocumentBase.ExportedFolder GetRealDocumentFolder(Structures.AccountingDocumentBase.ExportedDocument document,
                                                                                          IOfficialDocument officialDocument)
    {
      var innerFolder = document.Folder;
      while (innerFolder.Folders != null && innerFolder.Folders.Any())
        innerFolder = innerFolder.Folders.Single();
      
      if (!document.IsPrint && !document.IsAddendum)
      {
        var folderName = GetExportedDocumentFolderName(document, officialDocument);
        if (folderName == innerFolder.FolderName)
          return innerFolder;
        
        var subFolder = Structures.AccountingDocumentBase.ExportedFolder
          .Create(folderName,
                  new List<Structures.AccountingDocumentBase.ExportedFile>(),
                  new List<Structures.AccountingDocumentBase.ExportedFolder>(), innerFolder.FolderName);
        innerFolder.Folders.Add(subFolder);
        return subFolder;
      }
      return innerFolder;
    }
    
    private static void ExportNonformalizedDocumentsToFolder(Structures.AccountingDocumentBase.ExportedDocument document, List<Structures.AccountingDocumentBase.ZipModel> zipModels)
    {
      var doc = OfficialDocuments.Get(document.Id);
      if (!doc.HasVersions)
      {
        document.IsFaulted = true;
        document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_NoVersion;
        return;
      }
      
      var version = doc.LastVersion;
      var fileName = GetExportedDocumentFileName(document, doc);
      var folder = GetRealDocumentFolder(document, doc);
      
      if (Sungero.FinancialArchive.PublicFunctions.Module.CanExportWithSignatures(doc, version))
      {
        var queue = Sungero.ExchangeCore.BodyConverterQueueItems.GetAll().Where(x => Equals(x.Document, doc) && Equals(x.VersionId, version.Id));
        if (queue.Any())
        {
          document.IsFaulted = true;
          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_InProcess;
          return;
        }
        
        // Для неформализованных документов могут не генерироваться pdf неподдерживаемых форматов, поэтому проверяем их размер, чтобы не создавать пустой файл.
        if (version.PublicBody.Size != 0)
          WriteTokenToFile(version, fileName + AccountingDocumentBases.Resources.ExportForPrintAdditionalName, true, folder, doc.Id, zipModels);
        else if (document.IsPrint)
          WriteTokenToFile(version, fileName + AccountingDocumentBases.Resources.ExportForPrintAdditionalName, false, folder, doc.Id, zipModels);
        if (!document.IsPrint)
        {
          WriteTokenToFile(version, fileName, false, folder, doc.Id, zipModels);
          var senderSignId = Sungero.FinancialArchive.PublicFunctions.Module.GetSenderSignatureId(doc, version);
          var receiverSignId = Sungero.FinancialArchive.PublicFunctions.Module.GetReceiverSignatureId(doc, version);
          var senderSign = Signatures.Get(version).Where(x => x.Id == senderSignId).SingleOrDefault();
          var receiverSign = Signatures.Get(version).Where(x => x.Id == receiverSignId).SingleOrDefault();
          ExportSignature(version, fileName + "__", folder, senderSign, zipModels);
          ExportSignature(version, fileName + "_1_", folder, receiverSign, zipModels);
        }
      }
      else
      {
        WriteTokenToFile(version, fileName, false, folder, doc.Id, zipModels);
      }
      
      if (zipModels == null)
      {
        var operation = new Enumeration(Constants.AccountingDocumentBase.ExportToFolder);
        doc.History.Write(operation, operation, string.Empty, version.Number);
      }
    }
    
    private static string[] GetFolderRelativePath(Structures.AccountingDocumentBase.ExportedFolder folder)
    {
      if (string.IsNullOrWhiteSpace(folder.FolderName))
        return new string[0];
      
      if (string.IsNullOrWhiteSpace(folder.ParentRelativePath))
        return new string[] { folder.FolderName };
      
      return new string[] { folder.ParentRelativePath, folder.FolderName };
    }
    
    private static void WriteTokenToFile(Sungero.Content.IElectronicDocumentVersions version, string docName, bool isPublicBody,
                                         Structures.AccountingDocumentBase.ExportedFolder folder, int id,
                                         List<Structures.AccountingDocumentBase.ZipModel> zipModels)
    {
      var ticketServicePath = string.Empty;
      var ticketToken = string.Empty;
      var body = isPublicBody ? version.PublicBody : version.Body;
      var extension = isPublicBody ? version.AssociatedApplication.Extension : version.BodyAssociatedApplication.Extension;
      var fileName = docName + "." + extension;
      if (zipModels != null)
      {
        var zipModel = Structures.AccountingDocumentBase.ZipModel.Create();
        zipModel.DocumentId = id;
        zipModel.VersionId = version.Id;
        zipModel.IsPublicBody = isPublicBody;
        zipModel.FileName = fileName;
        zipModel.FolderRelativePath = GetFolderRelativePath(folder).ToList();
        zipModel.Size = body.Size;
        zipModels.Add(zipModel);
      }
      else
      {
        #warning Нелегал на сервис хранилищ, см 62340
        var dependency = Type.GetType("CommonLibrary.Dependencies.Dependency, CommonLibrary");
        var resolveMethod = dependency.GetMethods().Single(m => m.Name == "Resolve" && m.GetParameters().Length == 0);
        var providerType = Type.GetType("Sungero.StorageService.Client.IStorageServiceTokenProvider, Sungero.StorageService.Client");
        var generic = resolveMethod.MakeGenericMethod(providerType);
        dynamic tokenProvider = generic.Invoke(null, null);
        
        var currentUser = Users.Current.Name;
        ticketToken = tokenProvider.GenerateReadToken(body.Id.Value, Sungero.Core.TenantInfo.TenantId, currentUser);
        ticketServicePath = body.Storage.Address;
      }
      
      var file = Structures.AccountingDocumentBase.ExportedFile
        .Create(id, fileName, null, ticketServicePath, ticketToken);
      folder.Files.Add(file);
    }

    private static void ExportFormalizedDocumentsToFolder(Structures.AccountingDocumentBase.ExportedDocument document, List<Structures.AccountingDocumentBase.ZipModel> zipModels)
    {
      var doc = AccountingDocumentBases.Get(document.Id);
      var onlyOneSign = doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.Sent ||
        doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.Received;
      var operation = new Enumeration(Constants.AccountingDocumentBase.ExportToFolder);
      int? versionNumber = null;
      
      if (doc.ExchangeState == null)
      {
        document.IsFaulted = true;
        document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_Imported;
        return;
      }

      if (doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.Rejected)
      {
        document.IsFaulted = true;
        document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_Rejected;
        return;
      }
      
      if (doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.SignRequired)
      {
        document.IsFaulted = true;
        document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_LastSignNotFound;
        return;
      }
      
      if (doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.Obsolete ||
          doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.Terminated)
      {
        document.IsFaulted = true;
        document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_Obsolete;
        return;
      }
      
      if (doc.ExchangeState == Sungero.Docflow.AccountingDocumentBase.ExchangeState.SignAwaited)
      {
        document.IsFaulted = true;
        document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_CounterpartySignNotFound;
        return;
      }

      var folder = GetRealDocumentFolder(document, doc);
      if (document.IsPrint)
      {
        try
        {
          var queue = Sungero.ExchangeCore.BodyConverterQueueItems.GetAll().Where(x => Equals(x.Document, doc));
          if (queue.Any())
          {
            document.IsFaulted = true;
            document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_InProcess;
            return;
          }
          
          var fileName = GetExportedDocumentFileName(document, doc);
          var version = doc.LastVersion;
          WriteTokenToFile(version, fileName, true, folder, doc.Id, zipModels);
          if (zipModels == null)
            doc.History.Write(operation, operation, string.Empty, versionNumber);
        }
        catch (Exception ex)
        {
          Logger.Debug(ex.ToString());
          document.IsFaulted = true;
          document.Error = ex.Message;
          return;
        }
      }
      else
      {
        var sellerTitle = doc.Versions.Where(x => x.Id == doc.SellerTitleId).FirstOrDefault();
        if (sellerTitle == null)
        {
          document.IsFaulted = true;
          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_SellerTitleNotFound;
          return;
        }
        
        var sellerSign = Signatures.Get(sellerTitle).Where(x => x.Id == doc.SellerSignatureId).SingleOrDefault();
        if (sellerSign == null)
        {
          document.IsFaulted = true;
          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_SellerSignatureNotFound;
          return;
        }
        
        ExportFormalizedVersion(sellerTitle, folder, sellerSign, zipModels);
        
        if (onlyOneSign)
          versionNumber = sellerTitle.Number;
        if (zipModels == null)
          doc.History.Write(operation, operation, string.Empty, versionNumber);
        
        if (onlyOneSign)
          return;
        
        var buyerTitle = doc.Versions.Where(x => x.Id == doc.BuyerTitleId).FirstOrDefault();
        if (buyerTitle == null)
        {
          document.IsFaulted = true;
          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_BuyerTitleNotFound;
          return;
        }
        
        var buyerSign = Signatures.Get(buyerTitle).Where(x => x.Id == doc.BuyerSignatureId).SingleOrDefault();
        if (buyerSign == null)
        {
          document.IsFaulted = true;
          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_BuyerSignNotFound;
          return;
        }
        
        ExportFormalizedVersion(buyerTitle, folder, buyerSign, zipModels);
      }
    }
    
    /// <summary>
    /// Экспортировать версию с подписью.
    /// </summary>
    /// <param name="version">Версия.</param>
    /// <param name="folder">Папка для экспорта.</param>
    /// <param name="signature">Подпись.</param>
    /// <param name="zipModels">Модель zip архива для выгрузки в веб.</param>
    private static void ExportFormalizedVersion(Sungero.Content.IElectronicDocumentVersions version, Structures.AccountingDocumentBase.ExportedFolder folder,
                                                Sungero.Domain.Shared.ISignature signature, List<Structures.AccountingDocumentBase.ZipModel> zipModels)
    {
      byte[] memoryArray = null;
      var xdoc = System.Xml.Linq.XDocument.Load(version.Body.Read());
      Sungero.Exchange.PublicFunctions.Module.RemoveNamespaces(xdoc);
      var docElement = xdoc.Element("Файл");
      var fileName = docElement.Attribute("ИдФайл").Value;
      
      var fullFileName = fileName + ".xml";
      
      var body = version.Body;
      
      if (zipModels == null)
      {
        using (var memory = new System.IO.MemoryStream())
        {
          body.Read().CopyTo(memory);
          memoryArray = memory.ToArray();
        }
      }
      else
      {
        var zipModel = Structures.AccountingDocumentBase.ZipModel.Create();
        zipModel.DocumentId = version.ElectronicDocument.Id;
        zipModel.VersionId = version.Id;
        zipModel.IsPublicBody = false;
        zipModel.FileName = fullFileName;
        zipModel.FolderRelativePath = GetFolderRelativePath(folder).ToList();
        zipModel.Size = body.Size;
        zipModels.Add(zipModel);
      }
      
      var file = Structures.AccountingDocumentBase.ExportedFile.Create(version.ElectronicDocument.Id, fullFileName, memoryArray, null, null);
      folder.Files.Add(file);
      
      ExportSignature(version, fileName, folder, signature, zipModels);
    }
    
    private static void ExportSignature(Sungero.Content.IElectronicDocumentVersions version, string fileName, Structures.AccountingDocumentBase.ExportedFolder folder,
                                        Sungero.Domain.Shared.ISignature signature, List<Structures.AccountingDocumentBase.ZipModel> zipModels)
    {
      if (signature != null)
      {
        var signData = signature.GetDataSignature();
        var signFullFileName = fileName + "SGN" + ".sgn";
        
        if (zipModels != null)
        {
          var zipModel = Structures.AccountingDocumentBase.ZipModel.Create();
          zipModel.DocumentId = version.ElectronicDocument.Id;
          zipModel.VersionId = version.Id;
          zipModel.FileName = signFullFileName;
          zipModel.FolderRelativePath = GetFolderRelativePath(folder).ToList();
          zipModel.SignatureId = signature.Id;
          zipModel.Size = signData.LongLength;
          zipModels.Add(zipModel);
          signData = null;
        }
        
        var file = Structures.AccountingDocumentBase.ExportedFile.Create(-1, signFullFileName, signData, null, null);
        folder.Files.Add(file);
      }
    }
    
    [Remote]
    public static string GenerateFinArchiveExportReport(List<Sungero.Docflow.Structures.AccountingDocumentBase.ExportedDocument> documents, string pathToRoot)
    {
      var exportTable = new List<Sungero.Docflow.Structures.AccountingDocumentBase.ExportReport>();
      var orderId = 0;
      var reportSessionId = System.Guid.NewGuid().ToString();
      foreach (var d in documents
               .OrderBy(t => t.IsFaulted)
               .ThenBy(t => t.Id))
      {
        var doc = Structures.AccountingDocumentBase.ExportReport.Create();
        doc.ReportSessionId = reportSessionId;
        doc.Id = d.Id;
        doc.Document = d.Name;
        doc.Hyperlink = Hyperlinks.Get(AccountingDocumentBases.Info, d.Id);
        
        if (d.IsFaulted)
        {
          doc.Exported = FinancialArchive.Reports.Resources.FinArchiveExportReport.No;
          doc.Note = d.Error;
          doc.IOHyperlink = string.Empty;
        }
        else
        {
          doc.Exported = FinancialArchive.Reports.Resources.FinArchiveExportReport.Yes;
          FillDocumentPathAndNote(doc, d.Folder, pathToRoot, d.IsPrint, d.Id);
        }
        
        doc.OrderId = ++orderId;
        exportTable.Add(doc);
      }
      Functions.Module.WriteStructuresToTable(Sungero.FinancialArchive.PublicConstants.FinArchiveExportReport.SourceTableName, exportTable);
      
      return reportSessionId;
    }
    
    private static void FillDocumentPathAndNote(Structures.AccountingDocumentBase.ExportReport doc, Structures.AccountingDocumentBase.ExportedFolder folder, string rootPath, bool isPrint, int id)
    {
      var currentPath = System.IO.Path.Combine(rootPath, folder.FolderName);
      if (folder.Folders.Any())
      {
        FillDocumentPathAndNote(doc, folder.Folders.First(), currentPath, isPrint, id);
        return;
      }
      
      if (!folder.Files.Any())
        return;
      
      if (!isPrint)
      {
        doc.IOHyperlink = currentPath;
        doc.Note = FinancialArchive.Reports.Resources.FinArchiveExportReport.OpenFolder;
      }
      else
      {
        doc.IOHyperlink = System.IO.Path.Combine(currentPath, folder.Files.Where(x => x.Id == id).FirstOrDefault().FileName);
        doc.Note = FinancialArchive.Reports.Resources.FinArchiveExportReport.OpenFile;
      }
    }
    
    [Remote, Public]
    public static IQueryable<Docflow.IOfficialDocument> SearchByRequisites(Docflow.Structures.AccountingDocumentBase.IExportDialogSearch filter)
    {
      var officialDocuments = OfficialDocuments.GetAll(d => ContractualDocumentBases.Is(d) || AccountingDocumentBases.Is(d)).Where(d => !Contracts.IncomingInvoices.Is(d));
      
      if (filter.Counterparty != null)
      {
        officialDocuments = officialDocuments.Where(d => (AccountingDocumentBases.Is(d) && Equals(AccountingDocumentBases.As(d).Counterparty, filter.Counterparty) ||
                                                          ContractualDocumentBases.Is(d) && Equals(ContractualDocumentBases.As(d).Counterparty, filter.Counterparty)));
      }
      
      if (filter.BusinessUnit != null)
        officialDocuments = officialDocuments.Where(d => Equals(d.BusinessUnit, filter.BusinessUnit));
      
      if (filter.DocumentKinds != null && filter.DocumentKinds.Any())
        officialDocuments = officialDocuments.Where(d => filter.DocumentKinds.Contains(d.DocumentKind));
      
      if (filter.Contract != null)
      {
        // Вниз по дереву ссылок
        var allRelated = new List<Docflow.IOfficialDocument>() { filter.Contract };
        var lastRelated = allRelated.ToList();
        while (true)
        {
          var newRelated = Docflow.OfficialDocuments.GetAll(a => lastRelated.Contains(a.LeadingDocument)).ToList();
          lastRelated = newRelated.Except(allRelated).ToList();
          
          // Пока что-то находится - ищем.
          if (lastRelated.Any())
            allRelated.AddRange(lastRelated);
          else
            break;
        }
        
        officialDocuments = officialDocuments.Where(d => allRelated.Contains(d));
      }
      
      if (filter.From.HasValue)
        officialDocuments = officialDocuments.Where(q => q.RegistrationDate != null && q.RegistrationDate >= filter.From);
      
      if (filter.To.HasValue)
        officialDocuments = officialDocuments.Where(q => q.RegistrationDate != null && q.RegistrationDate <= filter.To);
      return officialDocuments;
    }
    
    /// <summary>
    /// Получить права подписания финансовых документов.
    /// </summary>
    /// <returns>Список подходящих правил.</returns>
    public override List<ISignatureSetting> GetSignatureSettings()
    {
      var basedSettings = base.GetSignatureSettings()
        .Where(s => s.Limit == Docflow.SignatureSetting.Limit.NoLimit || (s.Limit == Docflow.SignatureSetting.Limit.Amount &&
                                                                          s.Amount >= _obj.TotalAmount && Equals(s.Currency, _obj.Currency)))
        .ToList();
      
      if (_obj.DocumentKind.DocumentFlow == Docflow.DocumentKind.DocumentFlow.Contracts)
      {
        var category = Docflow.PublicFunctions.OfficialDocument.GetDocumentGroup(_obj);
        basedSettings = basedSettings
          .Where(s => !s.Categories.Any() || s.Categories.Any(c => Equals(c.Category, category)))
          .ToList();
      }
      return basedSettings;
    }
    
    /// <summary>
    /// Получить дату начала квартала.
    /// </summary>
    /// <param name="currentDate">Дата.</param>
    /// <returns>Дата начала квартала.</returns>
    [Public]
    public static DateTime BeginningOfQuarter(DateTime currentDate)
    {
      if (currentDate.Month < 4)
        return currentDate.BeginningOfYear();
      if (currentDate.Month > 3 && currentDate.Month < 7)
        return new DateTime(currentDate.Year, 4, 1);
      if (currentDate.Month > 6 && currentDate.Month < 10)
        return new DateTime(currentDate.Year, 7, 1);
      return new DateTime(currentDate.Year, 10, 1);
    }
    
    /// <summary>
    /// Получить дату окончания квартала.
    /// </summary>
    /// <param name="currentDate">Дата.</param>
    /// <returns>Дата окончания квартала.</returns>
    [Public]
    public static DateTime EndOfQuarter(DateTime currentDate)
    {
      if (currentDate.Month < 4)
        return new DateTime(currentDate.Year, 3, 31);
      if (currentDate.Month > 3 && currentDate.Month < 7)
        return new DateTime(currentDate.Year, 6, 30);
      if (currentDate.Month > 6 && currentDate.Month < 10)
        return new DateTime(currentDate.Year, 9, 30);
      return currentDate.EndOfYear();
    }
    
    /// <summary>
    /// Сгенерировать титул покупателя.
    /// </summary>
    /// <param name="sellerTitle">Параметры титула для генерации.</param>
    [Remote, Public]
    public virtual void GenerateSellerTitle(Structures.AccountingDocumentBase.ISellerTitle sellerTitle)
    {
      FinancialArchive.PublicFunctions.Module.Remote.GenerateSellerTitle(_obj, sellerTitle);

      // Поставить документ в очередь на генерацию pdf.
      if (_obj.SellerTitleId.HasValue)
      {
        var sellerVersion = _obj.Versions.Single(v => v.Id == _obj.SellerTitleId);

        if (sellerVersion.PublicBody.Size == 0)
        {
          var previousVersion = _obj.Versions.Where(v => v.Id != _obj.SellerTitleId).OrderBy(v => v.Number).LastOrDefault();
          if (previousVersion != null)
          {
            sellerVersion.PublicBody.Write(previousVersion.PublicBody.Read());
            sellerVersion.AssociatedApplication = previousVersion.AssociatedApplication;
          }
        }
        
        Docflow.PublicFunctions.Module.GenerateTempPublicBodyForExchangeDocument(_obj, _obj.SellerTitleId.Value);
        Exchange.PublicFunctions.Module.EnqueueXmlToPdfBodyConverter(_obj, _obj.SellerTitleId.Value, _obj.ExchangeState);
      }
    }
    
    /// <summary>
    /// Сгенерировать титул покупателя.
    /// </summary>
    /// <param name="buyerTitle">Параметры титула для генерации.</param>
    /// <param name="isAgent">Признак вызова из фонового процесса.</param>
    [Remote, Public]
    public virtual void GenerateAnswer(Structures.AccountingDocumentBase.IBuyerTitle buyerTitle, bool isAgent)
    {
      Exchange.PublicFunctions.Module.GenerateBuyerTitle(_obj, buyerTitle);

      // Поставить документ в очередь на генерацию pdf.
      if (_obj.BuyerTitleId.HasValue)
      {
        var version = _obj.Versions.Single(v => v.Id == _obj.BuyerTitleId);
        var sellerVersion = _obj.Versions.Single(v => v.Id == _obj.SellerTitleId);
        version.PublicBody.Write(sellerVersion.PublicBody.Read());
        version.AssociatedApplication = sellerVersion.AssociatedApplication;
        if (isAgent)
        {
          Docflow.PublicFunctions.Module.GeneratePublicBodyForExchangeDocument(_obj, _obj.BuyerTitleId.Value, _obj.ExchangeState);
        }
        else
        {
          Docflow.PublicFunctions.Module.GenerateTempPublicBodyForExchangeDocument(_obj, _obj.BuyerTitleId.Value);
          Exchange.PublicFunctions.Module.EnqueueXmlToPdfBodyConverter(_obj, _obj.BuyerTitleId.Value, _obj.ExchangeState);
        }
      }
    }
    
    /// <summary>
    /// Сгенерировать титул покупателя в автоматическом режиме.
    /// </summary>
    /// <param name="signatory">Подписывающий.</param>
    /// <param name="isAgent">Признак вызова из фонового процесса.</param>
    [Remote, Public]
    public virtual void GenerateDefaultAnswer(Company.IEmployee signatory, bool isAgent)
    {
      IPowerOfAttorney signatoryPowerOfAttorney = null;
      IPowerOfAttorney consigneePowerOfAttorney = null;
      var signatoryOtherReason = string.Empty;
      
      var signaturesSettings = Functions.OfficialDocument.GetSignatureSettings(_obj, signatory);
      var signaturesSettingWithDuties = signaturesSettings.Where(o => Equals(o.Reason, Docflow.SignatureSetting.Reason.Duties)).FirstOrDefault();
      var signaturesSettingWithPowerOfAttorney = signaturesSettings.Where(o => Equals(o.Reason, Docflow.SignatureSetting.Reason.PowerOfAttorney)).FirstOrDefault();
      var signaturesSettingWithOtherDocument = signaturesSettings.Where(o => Equals(o.Reason, Docflow.SignatureSetting.Reason.Other)).FirstOrDefault();

      if (signaturesSettingWithDuties == null && _obj.FormalizedServiceType != FormalizedServiceType.Waybill)
      {
        if (signaturesSettingWithPowerOfAttorney != null)
          signatoryPowerOfAttorney = Docflow.PowerOfAttorneys.As(signaturesSettingWithPowerOfAttorney.Document);
        else if (signaturesSettingWithOtherDocument != null)
          signatoryOtherReason = signaturesSettingWithOtherDocument.DocumentInfo;
      }

      var errorlist = Functions.AccountingDocumentBase.TitleDialogValidationErrors(_obj, signatory, null, signatoryPowerOfAttorney,
                                                                                   consigneePowerOfAttorney, signatoryOtherReason, null);
      var validationText = string.Join(Environment.NewLine, errorlist.Select(l => l.Text));
      if (errorlist.Any())
        throw AppliedCodeException.Create(validationText);
      
      // У УКД доступен только вариант "ответственный за оформление".
      var authority = Docflow.AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_DealAndRegister;
      if (_obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.GeneralTransfer && _obj.IsAdjustment == true)
        authority = Docflow.AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register;
      
      var basis = SignatureSettings.Info.Properties.Reason.GetLocalizedValue(Docflow.SignatureSetting.Reason.Duties);
      var buyerTitle = Docflow.Structures.AccountingDocumentBase.BuyerTitle.Create();
      buyerTitle.ActOfDisagreement = string.Empty;
      buyerTitle.Signatory = signatory;
      buyerTitle.SignatoryPowersBase = basis;
      buyerTitle.Consignee = null;
      buyerTitle.ConsigneePowersBase = string.Empty;
      buyerTitle.SignResult = true;
      buyerTitle.SignatoryPowers = authority;
      buyerTitle.AcceptanceDate = Calendar.Now;
      buyerTitle.SignatoryPowerOfAttorney = signatoryPowerOfAttorney;
      buyerTitle.SignatoryOtherReason = signatoryOtherReason;
      buyerTitle.ConsigneePowerOfAttorney = consigneePowerOfAttorney;
      buyerTitle.ConsigneeOtherReason = null;

      this.GenerateAnswer(buyerTitle, isAgent);
    }

    /// <summary>
    /// Валидация диалога заполнения титула.
    /// </summary>
    /// <param name="signatory">Подписал.</param>
    /// <param name="consignee">Груз получил.</param>
    /// <param name="signatoryPowerOfAttorney">Доверенность подписывающего.</param>
    /// <param name="consigneePowerOfAttorney">Доверенность груз принявшего.</param>
    /// <param name="signatoryOtherReason">Документ подписывающего.</param>
    /// <param name="consigneeOtherReason">Документ груз принявшего.</param>
    /// <returns>Список ошибок.</returns>
    [Remote]
    public virtual List<Structures.AccountingDocumentBase.GenerateTitleError> TitleDialogValidationErrors(Company.IEmployee signatory,
                                                                                                          Company.IEmployee consignee,
                                                                                                          IPowerOfAttorney signatoryPowerOfAttorney,
                                                                                                          IPowerOfAttorney consigneePowerOfAttorney,
                                                                                                          string signatoryOtherReason,
                                                                                                          string consigneeOtherReason)
    {
      var errorlist = new List<Structures.AccountingDocumentBase.GenerateTitleError>();
      var signatoryType = Constants.AccountingDocumentBase.GenerateTitleTypes.Signatory;
      var consigneeType = Constants.AccountingDocumentBase.GenerateTitleTypes.Consignee;
      var signatoryPoAType = Constants.AccountingDocumentBase.GenerateTitleTypes.SignatoryPowerOfAttorney;
      var consigneePoAType = Constants.AccountingDocumentBase.GenerateTitleTypes.ConsigneePowerOfAttorney;
      
      if (string.IsNullOrEmpty(_obj.BusinessUnit.TIN))
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(null, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_TIN));
      
      if (signatory != null && signatory.JobTitle == null)
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(signatoryType, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_SignatoryJobTitle));
      
      if (consignee != null && consignee.JobTitle == null)
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(consigneeType, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_ConsigneeJobTitle));
      
      if (signatoryPowerOfAttorney != null && (signatoryPowerOfAttorney.RegistrationDate == null || string.IsNullOrWhiteSpace(signatoryPowerOfAttorney.RegistrationNumber)))
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(signatoryPoAType, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_AttorneyRegistration));
      
      if (signatoryPowerOfAttorney != null && signatoryPowerOfAttorney.OurSignatory.JobTitle == null)
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(signatoryPoAType, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_AttorneyJobTitle));
      
      if (consigneePowerOfAttorney != null && (consigneePowerOfAttorney.RegistrationDate == null || string.IsNullOrWhiteSpace(consigneePowerOfAttorney.RegistrationNumber)))
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(consigneePoAType, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_AttorneyRegistration));
      
      if (consigneePowerOfAttorney != null && consigneePowerOfAttorney.OurSignatory.JobTitle == null)
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(consigneePoAType, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_AttorneyJobTitle));
      
      if (_obj.FormalizedServiceType == FormalizedServiceType.Waybill && !string.IsNullOrWhiteSpace(consigneeOtherReason))
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(null, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_OtherDocument));
      
      if (_obj.FormalizedServiceType == FormalizedServiceType.Act && !string.IsNullOrWhiteSpace(signatoryOtherReason))
        errorlist.Add(Structures.AccountingDocumentBase.GenerateTitleError.Create(null, AccountingDocumentBases.Resources.PropertiesFillingDialog_Error_OtherDocument));
      
      return errorlist;
    }
    
    /// <summary>
    /// Сгенерировать титул продавца в автоматическом режиме.
    /// </summary>
    /// <param name="signatory">Подписывающий.</param>
    [Remote, Public]
    public virtual void GenerateDefaultSellerTitle(Sungero.Company.IEmployee signatory)
    {
      // Основание: Должностные обязанности.
      var powerBase = SignatureSettings.Info.Properties.Reason.GetLocalizedValue(Docflow.SignatureSetting.Reason.Duties);
      // Полномочия: Лицо, совершившее сделку и отв. за оформление.
      var power = Docflow.AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_DealAndRegister;
      // Для УКД: Лицо, ответственное за оформление свершившегося события.
      if (_obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.GeneralTransfer && _obj.IsAdjustment == true)
        power = Docflow.AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register;
      // Доверенность.
      IPowerOfAttorney signatoryPowerOfAttorney = null;
      // Другой документ.
      var signatoryOtherReason = string.Empty;
      
      var signaturesSettings = Functions.OfficialDocument.GetSignatureSettings(_obj, signatory);
      var signaturesSettingWithDuties = signaturesSettings.Where(o => Equals(o.Reason, Docflow.SignatureSetting.Reason.Duties)).FirstOrDefault();
      var signaturesSettingWithPowerOfAttorney = signaturesSettings.Where(o => Equals(o.Reason, Docflow.SignatureSetting.Reason.PowerOfAttorney)).FirstOrDefault();
      var signaturesSettingWithOtherDocument = signaturesSettings.Where(o => Equals(o.Reason, Docflow.SignatureSetting.Reason.Other)).FirstOrDefault();

      if (signaturesSettingWithDuties == null && _obj.FormalizedServiceType != FormalizedServiceType.Waybill)
      {
        if (signaturesSettingWithPowerOfAttorney != null)
          signatoryPowerOfAttorney = Docflow.PowerOfAttorneys.As(signaturesSettingWithPowerOfAttorney.Document);
        else if (signaturesSettingWithOtherDocument != null)
          signatoryOtherReason = signaturesSettingWithOtherDocument.DocumentInfo;
      }
      
      var errorlist = Functions.AccountingDocumentBase.TitleDialogValidationErrors(_obj, signatory, null,
                                                                                   signatoryPowerOfAttorney, null,
                                                                                   signatoryOtherReason, null);
      var validationText = string.Join(Environment.NewLine, errorlist.Select(l => l.Text));
      if (errorlist.Any())
        throw AppliedCodeException.Create(validationText);
      
      var sellerTitle = Docflow.Structures.AccountingDocumentBase.SellerTitle
        .Create(signatory, powerBase, power, signatoryPowerOfAttorney, signatoryOtherReason);

      Functions.AccountingDocumentBase.GenerateSellerTitle(_obj, sellerTitle);
    }
    
    [Remote]
    public static List<Company.IEmployee> GetEmployeesByIds(List<int> ids)
    {
      return Company.Employees.GetAll(x => ids.Contains(x.Id)).ToList();
    }
    
    [Remote]
    public static string GetTaxDocumentClassifier(IAccountingDocumentBase document)
    {
      if (document.SellerTitleId.HasValue)
      {
        var sellerVersion = document.Versions.Single(v => v.Id == document.SellerTitleId);
        return Exchange.PublicFunctions.Module.GetTaxDocumentClassifierByContent(sellerVersion.Body.Read()).TaxDocumentClassifierCode;
      }
      return string.Empty;
    }

  }
}