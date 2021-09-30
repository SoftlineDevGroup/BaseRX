using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.ClientExtensions;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.AccountingDocumentBase;
using Sungero.Domain.Shared.Validation;

namespace Sungero.Docflow.Client
{
  partial class AccountingDocumentBaseFunctions
  {
    /// <summary>
    /// Запустить выгрузку документов с поиском документов.
    /// </summary>
    [Public]
    public static void ExportFinancialDocumentDialogWithSearch()
    {
      if (ClientApplication.ApplicationType == ApplicationType.Desktop)
        ExportFinancialDocumentDialogWithSearch(null, false);
      else
        ExportFinancialDocumentDialogWithSearchInWeb(null, false);
    }
    
    /// <summary>
    /// Запустить поиск документов в финархиве.
    /// </summary>
    /// <returns>Ленивый запрос на отображение документов.</returns>
    [Public]
    public static IQueryable<IOfficialDocument> FinancialDocumentDialogSearch()
    {
      if (ClientApplication.ApplicationType == ApplicationType.Desktop)
        return ExportFinancialDocumentDialogWithSearch(null, true);
      else
        return ExportFinancialDocumentDialogWithSearchInWeb(null, true);
    }
    
    /// <summary>
    /// Запустить выгрузку документов из явно указанных.
    /// </summary>
    /// <param name="documents">Документы, которые надо выгрузить.</param>
    [Public]
    public static void ExportFinancialDocumentDialog(List<IOfficialDocument> documents)
    {
      if (ClientApplication.ApplicationType == ApplicationType.Desktop)
        ExportFinancialDocumentDialogWithSearch(documents, false);
      else
        ExportFinancialDocumentDialogWithSearchInWeb(documents, false);
    }
    
    private static IQueryable<IOfficialDocument> ExportFinancialDocumentDialogWithSearch(List<IOfficialDocument> documentList, bool onlySearch)
    {
      Docflow.Structures.AccountingDocumentBase.IExportDialogSearch filter = null;
      var documents = documentList != null ? documentList.AsQueryable() : null;
      var documentCount = documents != null ? documents.Count() : 0;
      var canSearch = documents == null;
      IQueryable<IOfficialDocument> returned = null;
      var reportData = Structures.AccountingDocumentBase.AfterExportDialog.Create();
      reportData.Documents = new List<Structures.AccountingDocumentBase.ExportedDocument>();
      var documentsToPrepare = new List<int>();
      
      // Проверить, приобретена ли лицензия на модуль Финансовый архив.
      var moduleGuid = Constants.AccountingDocumentBase.FinancialArchiveUIGuid;
      if (!Sungero.Docflow.PublicFunctions.Module.Remote.IsModuleAvailableByLicense(moduleGuid))
      {
        Dialogs.NotifyMessage(AccountingDocumentBases.Resources.NoFinancialArchiveLicense);
        return returned;
      }

      var rootFolder = IO.GetMyDocumentsFolder();
      var personalSettings = Docflow.PublicFunctions.PersonalSetting.GetPersonalSettings(null);
      if (personalSettings != null && !string.IsNullOrWhiteSpace(personalSettings.FinArchiveExportPath) &&
          IO.ExistsDirectory(personalSettings.FinArchiveExportPath))
      {
        rootFolder = personalSettings.FinArchiveExportPath;
      }
      
      var search = canSearch;
      var start = !canSearch;
      var progress = false;
      var end = false;
      var step = 1;

      var dialog = Dialogs.CreateInputDialog(onlySearch ?
                                             AccountingDocumentBases.Resources.ExportDialog_Search_Title :
                                             AccountingDocumentBases.Resources.ExportDialog_Title);
      // Размеры подобраны на глаз.
      dialog.Height = canSearch ? (onlySearch ? 0 : 242) : 200;
      dialog.HelpCode = onlySearch ? Constants.AccountingDocumentBase.HelpCodes.Search : Constants.AccountingDocumentBase.HelpCodes.Export;
      var type = dialog.AddSelect(AccountingDocumentBases.Resources.ExportDialog_Format, true, AccountingDocumentBases.Resources.ExportDialog_Format_Formalized)
        .From(AccountingDocumentBases.Resources.ExportDialog_Format_Formalized, AccountingDocumentBases.Resources.ExportDialog_Format_Print);
      var group = dialog.AddSelect(AccountingDocumentBases.Resources.ExportDialog_Group, true, AccountingDocumentBases.Resources.ExportDialog_Group_None)
        .From(AccountingDocumentBases.Resources.ExportDialog_Group_None,
              AccountingDocumentBases.Resources.ExportDialog_Group_Counterparty,
              AccountingDocumentBases.Resources.ExportDialog_Group_DocumentType);
      var path = dialog.AddString(AccountingDocumentBases.Resources.ExportDialog_Path, false, rootFolder);
      path.IsEnabled = false;
      var changePath = dialog.AddHyperlink(AccountingDocumentBases.Resources.ExportDialog_Hyperlink_ChangePath);
      var exported = dialog.AddString(AccountingDocumentBases.Resources.ExportDialog_Exported_Name, false, AccountingDocumentBases.Resources.ExportDialog_Exported_Default);
      exported.IsEnabled = false;
      var errorInExport = dialog.AddString(AccountingDocumentBases.Resources.ExportDialog_Exported_Error, false);
      errorInExport.IsEnabled = false;
      
      var properties = AccountingDocumentBases.Info.Properties;
      var unit = dialog.AddSelect(properties.BusinessUnit.LocalizedName, !onlySearch, Company.BusinessUnits.Null);
      var counterparty = dialog.AddSelect(properties.Counterparty.LocalizedName, false, Parties.Counterparties.Null);
      
      var contract = dialog.AddSelect(AccountingDocumentBases.Resources.ExportDialog_Search_Contract, false, Contracts.ContractualDocuments.Null)
        .Where(c => (unit.Value == null || Equals(c.BusinessUnit, unit.Value)) && (counterparty.Value == null || Equals(c.Counterparty, counterparty.Value)));

      var allowedKinds = new List<IDocumentKind>();
      
      var allowedAccountingDocumentKinds = Functions.DocumentKind.GetAvailableDocumentKinds(typeof(IAccountingDocumentBase))
        .Where(k => !Equals(k.DocumentType.DocumentTypeGuid, Constants.AccountingDocumentBase.IncomingInvoiceGuid));
      allowedKinds.AddRange(allowedAccountingDocumentKinds);
      
      var allowedContractualDocumentKinds = Functions.DocumentKind.GetAvailableDocumentKinds(typeof(IContractualDocumentBase));
      allowedKinds.AddRange(allowedContractualDocumentKinds);
      allowedKinds = allowedKinds.OrderBy(k => k.Name).ToList();
      
      var kinds = dialog.AddSelectMany(AccountingDocumentBases.Resources.ExportDialog_Search_DocumentKinds, false, Docflow.DocumentKinds.Null)
        .From(allowedKinds);
      var dateFrom = dialog.AddDate(AccountingDocumentBases.Resources.ExportDialog_Search_DateFrom, false);
      var dateTo = dialog.AddDate(AccountingDocumentBases.Resources.ExportDialog_Search_DateTo, false);
      
      var showDocs = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_Search_Show);
      var back = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_Back);
      back.IsVisible = canSearch;
      var next = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_StartExport);
      var cancel = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_Close);
      
      Action showAllDocuments = () => documents.Show();
      
      // Фильтрация договоров по НОР и контрагентам.
      unit.SetOnValueChanged(u =>
                             {
                               if (u.NewValue != null && contract.Value != null && !Equals(contract.Value.BusinessUnit, u.NewValue))
                                 contract.Value = null;
                             });
      counterparty.SetOnValueChanged(cp =>
                                     {
                                       if (cp.NewValue != null && contract.Value != null && !Equals(contract.Value.Counterparty, cp.NewValue))
                                         contract.Value = null;
                                     });
      contract.SetOnValueChanged(c =>
                                 {
                                   if (c.NewValue != null)
                                   {
                                     unit.Value = c.NewValue.BusinessUnit;
                                     counterparty.Value = c.NewValue.Counterparty;
                                   }
                                 });

      changePath.SetOnExecute(() =>
                              {
                                var newPath = WinApiDialogs.SelectFolder(path.Value);
                                if (newPath != path.Value)
                                {
                                  path.Value = newPath;
                                  if (personalSettings != null)
                                  {
                                    personalSettings.FinArchiveExportPath = newPath;
                                    personalSettings.Save();
                                  }
                                }
                              });
      
      System.Threading.CancellationTokenSource cancelationTokenSource = null;
      var resultFolder = string.Empty;
      var errorInInitialize = false;
      
      Action<CommonLibrary.InputDialogRefreshEventArgs> refresh = (r) =>
      {
        if (!onlySearch)
        {
          if (search)
          {
            dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_SearchFormat(step);
            dialog.Text += Environment.NewLine;
          }
          else if (start)
          {
            dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_ConfigFormat(step);
            dialog.Text += Environment.NewLine + Environment.NewLine;
            
            // Приложения будут выгружаться если выбраны договорные виды или явно переданы договорные документы.
            if (kinds.Value.Where(k => allowedContractualDocumentKinds.Contains(k)).Any() ||
                (documentList != null && documentList.Any(d => Contracts.ContractualDocuments.Is(d))))
            {
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_OpenDocumentsWithAddendumsFormat(documentCount);
            }
            else
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_OpenDocumentsFormat(documentCount);
          }
          else if (progress)
          {
            dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_ProcessFormat(step);
            dialog.Text += Environment.NewLine;
          }
          else if (end)
          {
            dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_EndFormat(step);
            dialog.Text += Environment.NewLine + Environment.NewLine;
            if (reportData.Documents.Any(d => !d.IsFaulted))
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_CompletedFormat(resultFolder);
            else if (reportData.Documents.Any(d => d.IsFaulted))
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_CompletedNotExported;
            else if (errorInInitialize)
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_Error_Client_NoReason;
            else
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_CompletedNotFound;
            
            dialog.Text += Environment.NewLine + Environment.NewLine;
            dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_AllDocsFormat(reportData.Documents.Count(d => !d.IsAddendum));
            dialog.Text += Environment.NewLine;
            dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_FormalizedDocsFormat(reportData.Documents.Count(d => !d.IsAddendum && !d.IsFaulted && d.IsFormalized));
            dialog.Text += Environment.NewLine;
            dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NonformalizedDocsFormat(reportData.Documents.Count(d => !d.IsAddendum && !d.IsFaulted && !d.IsFormalized));
            if (reportData.Documents.Any(d => !d.IsAddendum && d.IsFaulted))
            {
              dialog.Text += Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NotExportedDocsFormat(reportData.Documents.Count(d => !d.IsAddendum && d.IsFaulted));
            }
            
            if (reportData.Documents.Any(d => d.IsAddendum))
            {
              dialog.Text += Environment.NewLine + Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_AllAddendumsFormat(reportData.Documents.Count(d => d.IsAddendum));
              dialog.Text += Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_FormalizedDocsFormat(reportData.Documents.Count(d => d.IsAddendum && !d.IsFaulted && d.IsFormalized));
              dialog.Text += Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NonformalizedDocsFormat(reportData.Documents.Count(d => d.IsAddendum && !d.IsFaulted && !d.IsFormalized));
              if (reportData.Documents.Any(d => d.IsAddendum && d.IsFaulted))
              {
                dialog.Text += Environment.NewLine;
                dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NotExportedDocsFormat(reportData.Documents.Count(d => d.IsAddendum && d.IsFaulted));
              }
            }
          }
        }
        
        exported.IsVisible = progress;
        errorInExport.IsVisible = progress && reportData.Documents.Any(d => d.IsFaulted);
        
        group.IsVisible = start;
        type.IsVisible = start;
        path.IsVisible = start;
        changePath.IsVisible = start;
        
        unit.IsVisible = search;
        counterparty.IsVisible = search;
        dateFrom.IsVisible = search;
        dateTo.IsVisible = search;
        kinds.IsVisible = search;
        contract.IsVisible = search;
        showDocs.IsVisible = search && onlySearch || start || end;
        showDocs.IsEnabled = start ? documentCount != 0 : (end ? !errorInInitialize : true);
        
        next.IsVisible = !progress && !onlySearch;
        back.IsVisible = start && canSearch || progress;
        next.IsEnabled = start ? documentCount != 0 : (end ? reportData.Documents.Any(d => !d.IsFaulted) : true);
        cancel.IsVisible = !progress;
        
        back.Name = progress ? AccountingDocumentBases.Resources.ExportDialog_Abort : AccountingDocumentBases.Resources.ExportDialog_Back;
        next.Name = end ? AccountingDocumentBases.Resources.ExportDialog_OpenExplorer :
          (search ? AccountingDocumentBases.Resources.ExportDialog_ConfigExport : AccountingDocumentBases.Resources.ExportDialog_StartExport);
        cancel.Name = end ? AccountingDocumentBases.Resources.ExportDialog_Close : AccountingDocumentBases.Resources.ExportDialog_Cancel;
        showDocs.Name = search ? AccountingDocumentBases.Resources.ExportDialog_Search_OnlySearch :
          (start ? AccountingDocumentBases.Resources.ExportDialog_Search_Show : AccountingDocumentBases.Resources.ExportDialog_End_Report);
      };
      dialog.SetOnRefresh(refresh);
      
      dialog.SetOnButtonClick(
        (h) =>
        {
          if (h.Button == next || h.Button == back || (h.Button == showDocs && !onlySearch))
            h.CloseAfterExecute = false;
          
          #region Экран с результатами выгрузки

          if (end)
          {
            if (h.Button == next)
            {
              if (!string.IsNullOrWhiteSpace(resultFolder))
                System.Diagnostics.Process.Start(resultFolder);
            }
            
            if (h.Button == showDocs)
            {
              var generated = FinancialArchive.Reports.GetFinArchiveExportReport();
              generated.CurrentTime = reportData.DateTime ?? Calendar.UserNow;
              generated.Exported = reportData.Documents.Count(d => !d.IsFaulted);
              generated.NotExported = reportData.Documents.Count(d => d.IsFaulted);
              generated.ReportSessionId = Functions.AccountingDocumentBase.Remote.GenerateFinArchiveExportReport(reportData.Documents, reportData.PathToRoot);
              generated.Open();
            }
          }
          
          #endregion

          #region Экран выгрузки

          if (progress && h.Button == back && cancelationTokenSource != null && !cancelationTokenSource.IsCancellationRequested)
          {
            back.IsEnabled = false;
            cancelationTokenSource.Cancel(false);
            h.CloseAfterExecute = false;
          }

          #endregion
          
          #region Экран параметров выгрузки
          
          if (start)
          {
            if (h.Button == next && h.IsValid)
            {
              cancelationTokenSource = new System.Threading.CancellationTokenSource();
              var dispather = System.Windows.Threading.Dispatcher.CurrentDispatcher;
              var task = System.Threading.Tasks.Task.Run(
                () =>
                {
                  var parameters = Structures.AccountingDocumentBase.ExportDialogParams
                    .Create(group.Value == AccountingDocumentBases.Resources.ExportDialog_Group_Counterparty,
                            group.Value == AccountingDocumentBases.Resources.ExportDialog_Group_DocumentType,
                            type.Value == AccountingDocumentBases.Resources.ExportDialog_Format_Print);
                  var partSize = parameters.ForPrint ? 3 : 5;
                  var initialize = Structures.AccountingDocumentBase.AfterExportDialog
                    .Create(string.Empty, string.Empty, Calendar.UserNow, new List<Structures.AccountingDocumentBase.ExportedDocument>());
                  try
                  {
                    initialize = filter != null ?
                      Functions.AccountingDocumentBase.Remote.PrepareExportFinancialDocumentDialogDocuments(documentsToPrepare, parameters) :
                      Functions.AccountingDocumentBase.Remote.PrepareExportFinancialDocumentDialogDocuments(documentList.Select(x => x.Id).ToList(), parameters);
                  }
                  catch (Exception ex)
                  {
                    errorInInitialize = true;
                    Logger.Error("Не удалось подготовить данные для выгрузки", ex);
                  }
                  documentCount = initialize.Documents.Count;
                  for (int i = 0; i < documentCount; i = i + partSize)
                  {
                    var docsAddedToResult = false;
                    List<Structures.AccountingDocumentBase.ExportedDocument> part = null;
                    List<Structures.AccountingDocumentBase.ExportedDocument> result = null;
                    try
                    {
                      if (cancelationTokenSource.IsCancellationRequested)
                      {
                        // При отмене указываем причину для отчёта
                        foreach (var document in initialize.Documents.Skip(i))
                        {
                          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_Canceled;
                          document.IsFaulted = true;
                          reportData.Documents.Add(document);
                          Logger.DebugFormat("Document export with id {0} has been canceled", document.Id);
                        }
                        break;
                      }
                      
                      part = initialize.Documents.Skip(i).Take(partSize).ToList();
                      result = Functions.AccountingDocumentBase.Remote.AfterExportFinancialDocumentDialog(part, parameters);
                      if (result.Any())
                      {
                        var faultedDocuments = reportData.Documents.Where(d => d.IsFaulted).Select(d => d.Id);
                        var addendumsFaulted = result.Where(d => !d.IsFaulted && d.IsAddendum && d.LeadDocumentId != null && faultedDocuments.Contains(d.LeadDocumentId.Value));
                        foreach (var addendum in addendumsFaulted)
                        {
                          addendum.IsFaulted = true;
                          addendum.Error = AccountingDocumentBases.Resources.ExportDialog_Error_LeadDocumentNoVersion;
                        }
                        if (string.IsNullOrWhiteSpace(resultFolder))
                        {
                          resultFolder = IO.CreateDirectory(IO.Combine(path.Value, initialize.RootFolder));
                          reportData.PathToRoot = resultFolder;
                          reportData.DateTime = initialize.DateTime;
                        }
                        foreach (var doc in result.Where(d => !d.IsFaulted))
                        {
                          if (!result.Any(r => Equals(r.Id, doc.LeadDocumentId) && r.IsFaulted))
                            ExtractDocument(doc, resultFolder);
                          else
                          {
                            doc.IsFaulted = true;
                            doc.Error = AccountingDocumentBases.Resources.ExportDialog_Error_LeadDocumentNoVersion;
                          }
                        }
                        reportData.Documents.AddRange(result);
                        docsAddedToResult = true;
                      }
                    }
                    catch (Exception ex)
                    {
                      Logger.Debug(ex.ToString());
                      if (!docsAddedToResult)
                      {
                        foreach (var document in part)
                        {
                          document.Error = AccountingDocumentBases.Resources.ExportDialog_Error_ClientFormat(ex.Message.TrimEnd('.'));
                          document.IsFaulted = true;
                          reportData.Documents.Add(document);
                        }
                      }
                    }
                    
                    dispather.Invoke(() =>
                                     {
                                       errorInExport.IsVisible = reportData.Documents.Any(d => d.IsFaulted);
                                       
                                       var exportedCount = Math.Min(i + partSize, documentCount);
                                       exported.Value = AccountingDocumentBases.Resources.ExportDialog_Exported_TextFormat(exportedCount, documentCount);
                                       errorInExport.Value = reportData.Documents.Count(d => d.IsFaulted).ToString();
                                     });
                  }
                  IO.DeleteFileAndEmptyDirectory(string.Empty, resultFolder);
                  back.IsEnabled = true;
                  progress = false;
                  end = true;
                  step += 1;
                  dispather.Invoke(() => refresh.Invoke(null));
                }, cancelationTokenSource.Token);
              start = false;
              progress = true;
              step += 1;
              refresh.Invoke(null);
            }
            
            if (h.Button == back)
            {
              search = true;
              start = false;
              step -= 1;
              refresh.Invoke(null);
            }
            
            if (h.Button == showDocs)
            {
              showAllDocuments();
            }
          }
          
          #endregion
          
          #region Экран поиска
          
          if (search)
          {
            filter = Docflow.Structures.AccountingDocumentBase.ExportDialogSearch
              .Create(unit.Value, counterparty.Value, contract.Value, dateFrom.Value, dateTo.Value, kinds.Value.ToList());
            if (h.Button == showDocs)
            {
              returned = Functions.AccountingDocumentBase.Remote.SearchByRequisites(filter);
            }
            
            if (h.Button == cancel)
            {
              unit.IsRequired = false;
            }
            
            if (h.Button == next)
            {
              if (h.IsValid)
              {
                var newDocuments = Functions.AccountingDocumentBase.Remote.SearchByRequisites(filter);
                documents = newDocuments;
                documentsToPrepare = newDocuments.Select(x => x.Id).ToList();
                documentCount = documents.Count();
                search = false;
                start = true;
                step += 1;
                refresh.Invoke(null);
              }
            }
          }
          
          #endregion
        });
      dialog.Show();
      
      return returned;
    }
    
    private static IQueryable<IOfficialDocument> ExportFinancialDocumentDialogWithSearchInWeb(List<IOfficialDocument> documentList, bool onlySearch)
    {
      int zipModelFilesCount = 0;
      long zipModelFilesSumSize = 0;
      bool zipModelFilesExportError = false;
      string addErrorMessage = string.Empty;
      var totalForDownloadDialogText = string.Empty;
      var typeValueChanged = false;
      Docflow.Structures.AccountingDocumentBase.IExportDialogSearch filter = null;
      Structures.AccountingDocumentBase.ExportResult exportRezult = null;
      var documents = documentList != null ? documentList.AsQueryable() : null;
      var documentCount = documents != null ? documents.Count() : 0;
      var canSearch = documents == null;
      IQueryable<IOfficialDocument> returned = null;
      var reportData = Structures.AccountingDocumentBase.AfterExportDialog.Create();
      reportData.PathToRoot = ".";
      reportData.Documents = new List<Structures.AccountingDocumentBase.ExportedDocument>();
      var documentsToPrepare = new List<int>();
      
      // Проверить, приобретена ли лицензия на модуль Финансовый архив.
      var moduleGuid = Constants.AccountingDocumentBase.FinancialArchiveUIGuid;
      if (!Sungero.Docflow.PublicFunctions.Module.Remote.IsModuleAvailableByLicense(moduleGuid))
      {
        Dialogs.NotifyMessage(AccountingDocumentBases.Resources.NoFinancialArchiveLicense);
        return returned;
      }

      var search = canSearch;
      var start = !canSearch;
      var end = false;
      var step = 1;

      var dialog = Dialogs.CreateInputDialog(onlySearch ?
                                             AccountingDocumentBases.Resources.ExportDialog_Search_Title :
                                             AccountingDocumentBases.Resources.ExportDialog_Title);
      // Размеры подобраны на глаз.
      dialog.Height = canSearch ? (onlySearch ? 0 : 220) : 160;
      
      // Принудительно увеличиваем ширину диалога для корректного отображения кнопок.
      var fakeControl = dialog.AddString("123456789012345", false);
      fakeControl.IsVisible = false;
      
      dialog.HelpCode = onlySearch ? Constants.AccountingDocumentBase.HelpCodes.Search : Constants.AccountingDocumentBase.HelpCodes.Export;
      var type = dialog.AddSelect(AccountingDocumentBases.Resources.ExportDialog_Format, true, AccountingDocumentBases.Resources.ExportDialog_Format_Formalized)
        .From(AccountingDocumentBases.Resources.ExportDialog_Format_Formalized, AccountingDocumentBases.Resources.ExportDialog_Format_Print);
      var group = dialog.AddSelect(AccountingDocumentBases.Resources.ExportDialog_Group, true, AccountingDocumentBases.Resources.ExportDialog_Group_None)
        .From(AccountingDocumentBases.Resources.ExportDialog_Group_None,
              AccountingDocumentBases.Resources.ExportDialog_Group_Counterparty,
              AccountingDocumentBases.Resources.ExportDialog_Group_DocumentType);
      
      var properties = AccountingDocumentBases.Info.Properties;
      var unit = dialog.AddSelect(properties.BusinessUnit.LocalizedName, !onlySearch, Company.BusinessUnits.Null);
      var counterparty = dialog.AddSelect(properties.Counterparty.LocalizedName, false, Parties.Counterparties.Null);
      
      var contract = dialog.AddSelect(AccountingDocumentBases.Resources.ExportDialog_Search_Contract, false, Contracts.ContractualDocuments.Null)
        .Where(c => (unit.Value == null || Equals(c.BusinessUnit, unit.Value)) && (counterparty.Value == null || Equals(c.Counterparty, counterparty.Value)));

      var allowedKinds = new List<IDocumentKind>();
      
      var allowedAccountingDocumentKinds = Functions.DocumentKind.GetAvailableDocumentKinds(typeof(IAccountingDocumentBase))
        .Where(k => !Equals(k.DocumentType.DocumentTypeGuid, Constants.AccountingDocumentBase.IncomingInvoiceGuid));
      allowedKinds.AddRange(allowedAccountingDocumentKinds);
      
      var allowedContractualDocumentKinds = Functions.DocumentKind.GetAvailableDocumentKinds(typeof(IContractualDocumentBase));
      allowedKinds.AddRange(allowedContractualDocumentKinds);
      allowedKinds = allowedKinds.OrderBy(k => k.Name).ToList();
      
      var kinds = dialog.AddSelectMany(AccountingDocumentBases.Resources.ExportDialog_Search_DocumentKinds, false, Docflow.DocumentKinds.Null)
        .From(allowedKinds);
      var dateFrom = dialog.AddDate(AccountingDocumentBases.Resources.ExportDialog_Search_DateFrom, false);
      var dateTo = dialog.AddDate(AccountingDocumentBases.Resources.ExportDialog_Search_DateTo, false);
      
      var showDocs = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_Search_Show);
      var back = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_Back);
      back.IsVisible = canSearch;
      var next = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_StartExport);
      var cancel = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.ExportDialog_Close);
      
      Action showAllDocuments = () => documents.Show();
      
      // Фильтрация договоров по НОР и контрагентам.
      unit.SetOnValueChanged(u =>
                             {
                               if (u.NewValue != null && contract.Value != null && !Equals(contract.Value.BusinessUnit, u.NewValue))
                                 contract.Value = null;
                             });
      counterparty.SetOnValueChanged(cp =>
                                     {
                                       if (cp.NewValue != null && contract.Value != null && !Equals(contract.Value.Counterparty, cp.NewValue))
                                         contract.Value = null;
                                     });
      contract.SetOnValueChanged(c =>
                                 {
                                   if (c.NewValue != null)
                                   {
                                     unit.Value = c.NewValue.BusinessUnit;
                                     counterparty.Value = c.NewValue.Counterparty;
                                   }
                                 });
      
      type.SetOnValueChanged(t =>
                             {
                               totalForDownloadDialogText = string.Empty;
                               typeValueChanged = true;
                             });
      
      #region Refresh
      
      Action<CommonLibrary.InputDialogRefreshEventArgs> refresh = (r) =>
      {
        if (!onlySearch)
        {
          if (search)
          {
            dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_SearchFormat(step);
            dialog.Text += Environment.NewLine;
          }
          else if (start)
          {
            dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_Config_WebFormat(step);
            dialog.Text += Environment.NewLine + Environment.NewLine;
            
            // Приложения будут выгружаться если выбраны договорные виды или явно переданы договорные документы.
            if (kinds.Value.Where(k => allowedContractualDocumentKinds.Contains(k)).Any() ||
                (documentList != null && documentList.Any(d => Contracts.ContractualDocuments.Is(d))))
            {
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_OpenDocumentsWithAddendumsFormat(documentCount);
            }
            else
            {
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_OpenDocumentsFormat(documentCount);
            }
            
            dialog.Text += totalForDownloadDialogText;
            
            if (documentCount > Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit && start && step == 1)
            {
              r.AddError(AccountingDocumentBases.Resources.ExportDialog_Error_DocumentCountLimitFormat(Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit));
            }
          }
          else if (end)
          {
            if (reportData.Documents.Any(d => !d.IsFaulted))
            {
              dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_End_WebFormat(step);
              dialog.Text += Environment.NewLine + Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_DocumentsSuccessfullyPreparedForDownload;
            }
            else if (reportData.Documents.Any(d => d.IsFaulted))
            {
              dialog.Text = AccountingDocumentBases.Resources.ExportDialog_Step_End_Report_WebFormat(step);
              dialog.Text += Environment.NewLine + Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_CompletedNotExported;
            }
            
            dialog.Text += Environment.NewLine + Environment.NewLine;
            dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_AllDocs_WebFormat(reportData.Documents.Count(d => !d.IsAddendum));
            dialog.Text += Environment.NewLine;
            dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_FormalizedDocsFormat(reportData.Documents.Count(d => !d.IsAddendum && !d.IsFaulted && d.IsFormalized));
            dialog.Text += Environment.NewLine;
            dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NonformalizedDocsFormat(reportData.Documents.Count(d => !d.IsAddendum && !d.IsFaulted && !d.IsFormalized));
            if (reportData.Documents.Any(d => !d.IsAddendum && d.IsFaulted))
            {
              dialog.Text += Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NotExportedDocs_WebFormat(reportData.Documents.Count(d => !d.IsAddendum && d.IsFaulted));
            }
            
            if (reportData.Documents.Any(d => d.IsAddendum))
            {
              dialog.Text += Environment.NewLine + Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_AllAddendumsFormat(reportData.Documents.Count(d => d.IsAddendum));
              dialog.Text += Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_FormalizedDocsFormat(reportData.Documents.Count(d => d.IsAddendum && !d.IsFaulted && d.IsFormalized));
              dialog.Text += Environment.NewLine;
              dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NonformalizedDocsFormat(reportData.Documents.Count(d => d.IsAddendum && !d.IsFaulted && !d.IsFormalized));
              if (reportData.Documents.Any(d => d.IsAddendum && d.IsFaulted))
              {
                dialog.Text += Environment.NewLine;
                dialog.Text += AccountingDocumentBases.Resources.ExportDialog_End_NotExportedDocs_WebFormat(reportData.Documents.Count(d => d.IsAddendum && d.IsFaulted));
              }
            }
          }
        }
        
        group.IsVisible = start;
        type.IsVisible = start;
        group.IsEnabled = documentCount != 0 && documentCount <= Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit;
        type.IsEnabled = documentCount != 0 && documentCount <= Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit;
        
        unit.IsVisible = search;
        counterparty.IsVisible = search;
        dateFrom.IsVisible = search;
        dateTo.IsVisible = search;
        kinds.IsVisible = search;
        contract.IsVisible = search;
        showDocs.IsVisible = search && onlySearch || start;
        showDocs.IsEnabled = start ? documentCount != 0 : !end;
        
        next.IsVisible = !onlySearch;
        back.IsVisible = start && canSearch || end && reportData.Documents.All(d => d.IsFaulted);
        next.IsEnabled = start
          ? (documentCount != 0 && documentCount <= Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit && (!zipModelFilesExportError || typeValueChanged))
          : (end ? reportData.Documents.Any(d => !d.IsFaulted) : true);
        
        back.Name = end ? AccountingDocumentBases.Resources.ExportDialog_End_Report : AccountingDocumentBases.Resources.ExportDialog_Back;
        next.Name = end ? AccountingDocumentBases.Resources.ExportDialog_StartExport :
          AccountingDocumentBases.Resources.ExportDialog_ConfigExport;
        cancel.Name = end ? AccountingDocumentBases.Resources.ExportDialog_Close : AccountingDocumentBases.Resources.ExportDialog_Cancel;
        showDocs.Name = search ? AccountingDocumentBases.Resources.ExportDialog_Search_OnlySearch :
          (start ? AccountingDocumentBases.Resources.ExportDialog_Search_Show : AccountingDocumentBases.Resources.ExportDialog_End_Report);
      };
      
      dialog.SetOnRefresh(refresh);
      
      #endregion
      
      IZip zip = null;
      dialog.SetOnButtonClick(
        (h) =>
        {
          if (h.Button == next || h.Button == back || (h.Button == showDocs && !onlySearch))
            h.CloseAfterExecute = false;
          
          #region Экран с результатами выгрузки

          if (end && h.Button == next)
          {
            zip.Export();
          }
          else if (end && h.Button == back)
          {
            var now = Calendar.UserNow;
            var report = Functions.AccountingDocumentBase.GetFinArchiveExportReport(exportRezult.ExportedDocuments, now);
            report.Open();
          }
          
          #endregion

          #region Экран параметров выгрузки
          
          if (start)
          {
            if (h.Button == next && h.IsValid)
            {
              typeValueChanged = false;
              var parameters = Structures.AccountingDocumentBase.ExportDialogParams
                .Create(group.Value == AccountingDocumentBases.Resources.ExportDialog_Group_Counterparty,
                        group.Value == AccountingDocumentBases.Resources.ExportDialog_Group_DocumentType,
                        type.Value == AccountingDocumentBases.Resources.ExportDialog_Format_Print);
              var initialize = Structures.AccountingDocumentBase.AfterExportDialog
                .Create(string.Empty, string.Empty, Calendar.UserNow, new List<Structures.AccountingDocumentBase.ExportedDocument>());
              try
              {
                initialize = filter != null ?
                  Functions.AccountingDocumentBase.Remote.PrepareExportFinancialDocumentDialogDocuments(documentsToPrepare, parameters) :
                  Functions.AccountingDocumentBase.Remote.PrepareExportFinancialDocumentDialogDocuments(documentList.Select(x => x.Id).ToList(), parameters);
              }
              catch (Exception ex)
              {
                Logger.Error("Не удалось подготовить данные для выгрузки", ex);
                addErrorMessage = AccountingDocumentBases.Resources.ExportDialog_Error_Client_NoReason_Web;
                h.AddError(addErrorMessage);
                return;
              }
              
              exportRezult = Functions.AccountingDocumentBase.Remote.AfterExportFinancialDocumentDialogToWeb(initialize.Documents, parameters, initialize.RootFolder);
              
              zipModelFilesCount = exportRezult.ZipModels.Count;
              zipModelFilesSumSize = exportRezult.ZipModels.Sum(m => m.Size);
              
              if (zipModelFilesCount != 0)
              {
                var filesSumSize = (double)zipModelFilesSumSize / Constants.AccountingDocumentBase.ConvertMb;
                if (filesSumSize < 0.1)
                  filesSumSize = 0.1;

                totalForDownloadDialogText = Environment.NewLine + Environment.NewLine +
                  AccountingDocumentBases.Resources.ExportDialog_TotalForDownloadFormat(zipModelFilesCount, filesSumSize.ToString("0.#"));
              }
              
              if (zipModelFilesCount > Constants.AccountingDocumentBase.ExportedFilesCountMaxLimit)
              {
                addErrorMessage = AccountingDocumentBases.Resources.ExportDialog_Error_ExportedFilesLimitFormat(Constants.AccountingDocumentBase.ExportedFilesCountMaxLimit);
                h.AddError(addErrorMessage);
                zipModelFilesExportError = true;
                return;
              }
              else if (zipModelFilesSumSize > Constants.AccountingDocumentBase.ExportedFilesSizeMaxLimitMb * Constants.AccountingDocumentBase.ConvertMb)
              {
                addErrorMessage = Sungero.Docflow.AccountingDocumentBases.Resources.ExportDialog_Error_ExportedSizeLimitFormat(Constants.AccountingDocumentBase.ExportedFilesSizeMaxLimitMb);
                h.AddError(addErrorMessage);
                zipModelFilesExportError = true;
                return;
              }
              
              if (exportRezult.ZipModels != null && exportRezult.ZipModels.Any() && exportRezult.ExportedDocuments != null && exportRezult.ExportedDocuments.Any())
              {
                try
                {
                  zip = Functions.AccountingDocumentBase.Remote.CreateZipFromZipModel(exportRezult.ZipModels, exportRezult.ExportedDocuments, initialize.RootFolder);
                }
                catch (Exception ex)
                {
                  Logger.Error("Не удалось подготовить zip-архив для выгрузки", ex);
                  addErrorMessage = AccountingDocumentBases.Resources.ExportDialog_Error_Client_NoReason_Web;
                  h.AddError(addErrorMessage);
                  zipModelFilesExportError = true;
                  return;
                }
              }
              
              var result = exportRezult.ExportedDocuments;
              if (result.Any())
              {
                var faultedDocuments = reportData.Documents.Where(d => d.IsFaulted).Select(d => d.Id);
                var addendumsFaulted = result.Where(d => !d.IsFaulted && d.IsAddendum && d.LeadDocumentId != null && faultedDocuments.Contains(d.LeadDocumentId.Value));
                foreach (var addendum in addendumsFaulted)
                {
                  addendum.IsFaulted = true;
                  addendum.Error = AccountingDocumentBases.Resources.ExportDialog_Error_LeadDocumentNoVersion;
                }
                reportData.Documents.AddRange(result);
              }
              
              back.IsEnabled = true;
              end = true;
              step += 1;
              start = false;
              refresh.Invoke(null);
            }
            
            if (h.Button == back)
            {
              search = true;
              start = false;
              step -= 1;
              zipModelFilesCount = 0;
              zipModelFilesExportError = false;
              typeValueChanged = false;
              addErrorMessage = string.Empty;
              totalForDownloadDialogText = string.Empty;
              refresh.Invoke(null);
            }
            
            if (h.Button == showDocs)
            {
              if (!string.IsNullOrEmpty(addErrorMessage))
                h.AddError(addErrorMessage);
              
              showAllDocuments();
            }
          }
          
          #endregion
          
          #region Экран поиска
          
          if (search)
          {
            filter = Docflow.Structures.AccountingDocumentBase.ExportDialogSearch
              .Create(unit.Value, counterparty.Value, contract.Value, dateFrom.Value, dateTo.Value, kinds.Value.ToList());
            if (h.Button == showDocs)
              returned = Functions.AccountingDocumentBase.Remote.SearchByRequisites(filter);
            
            if (h.Button == cancel)
              unit.IsRequired = false;
            
            if (h.Button == next)
            {
              if (h.IsValid)
              {
                var newDocuments = Functions.AccountingDocumentBase.Remote.SearchByRequisites(filter);
                documents = newDocuments;
                documentCount = documents.Count();
                documentsToPrepare = newDocuments.Select(x => x.Id).ToList();
                search = false;
                start = true;
                step += 1;
                if (documentCount > Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit)
                {
                  addErrorMessage = AccountingDocumentBases.Resources.ExportDialog_Error_DocumentCountLimitFormat(Constants.AccountingDocumentBase.ExportedDocumentsCountMaxLimit);
                  h.AddError(addErrorMessage);
                }
                refresh.Invoke(null);
              }
            }
          }
          
          #endregion
          
        });
      dialog.Show();
      
      return returned;
    }
    
    /// <summary>
    /// Распаковать документ в папку.
    /// </summary>
    /// <param name="document">Документ с сервера.</param>
    /// <param name="systemfolder">Путь к папке на жестком диске.</param>
    private static void ExtractDocument(Structures.AccountingDocumentBase.ExportedDocument document, string systemfolder)
    {
      var folder = document.Folder;
      try
      {
        ExtractFolder(folder, systemfolder, document.Id);
      }
      catch (Exception ex)
      {
        document.IsFaulted = true;
        document.Error = ex.Message;
      }
    }
    
    /// <summary>
    /// Распаковать папку.
    /// </summary>
    /// <param name="folder">Папка с сервера.</param>
    /// <param name="systemfolder">Путь к папке на жестком диске.</param>
    /// <param name="id">ИД выгружаемого документа (для игнорирования приложений).</param>
    private static void ExtractFolder(Structures.AccountingDocumentBase.ExportedFolder folder, string systemfolder, int id)
    {
      if (folder.Files.Any())
      {
        try
        {
          foreach (var file in folder.Files.Where(f => f.Id <= 0 || f.Id == id))
          {
            var folderInfo = IO.CreateDirectory(systemfolder);
            var filePath = IO.Combine(folderInfo, file.FileName);
            if (file.Body != null)
              IO.WriteAllBytes(filePath, file.Body);
            else
            {
              #warning Нелегал на сервис хранилищ, см 62340
              var tokenRefresherConstructor = Type.GetType("Sungero.StorageServices.Shared.TokenRefresher, Sungero.StorageServices.Shared")
                .GetConstructors().Single(c => c.GetParameters().Length == 2);
              var tokenRefresher = tokenRefresherConstructor.Invoke(new[] { file.Token, null });
               
              var storageServiceReadStreamConstructor = Type.GetType("Sungero.StorageServices.Shared.StorageServiceReadStream, Sungero.StorageServices.Shared")
                .GetConstructors().Single(c => c.GetParameters().Length == 2);
             
              using (var storageStream = (System.IO.Stream)storageServiceReadStreamConstructor.Invoke(new[] { file.ServicePath, tokenRefresher }))
              {
                using (var fileStream = System.IO.File.Create(filePath))
                {
                  storageStream.CopyTo(fileStream);
                }
              }
            }
            Logger.DebugFormat("File containing document with id {0} has been extracted to folder", file.Id);
          }
        }
        catch
        {
          foreach (var file in folder.Files.Where(f => f.Id <= 0 || f.Id == id))
          {
            var filePath = IO.Combine(systemfolder, file.FileName);
            IO.DeleteFileAndEmptyDirectory(filePath, systemfolder);
          }
          throw;
        }
      }
      
      if (folder.Folders.Any())
      {
        foreach (var subFolder in folder.Folders)
        {
          var subFolderPath = IO.Combine(systemfolder, subFolder.FolderName);
          ExtractFolder(subFolder, subFolderPath, id);
        }
      }
    }
    
    /// <summary>
    /// Диалог заполнения информации о продавце.
    /// </summary>
    public virtual void SellerTitlePropertiesFillingDialog()
    {
      var isDpt = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.GoodsTransfer;
      var isDprr = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.WorksTransfer;
      var isUtdAny = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.GeneralTransfer;
      var isUtdCorrection = isUtdAny && _obj.IsAdjustment == true;
      var isUtdNotCorrection = isUtdAny && _obj.IsAdjustment != true;
      
      if (!isDpt && !isDprr && !isUtdAny)
        return;
      
      var dialog = Dialogs.CreateInputDialog(AccountingDocumentBases.Resources.PropertiesFillingDialog_SellerTitle);

      if (isDpt)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.SellerGoodsTransfer;
      else if (isDprr)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.SellerWorksTransfer;
      else if (isUtdNotCorrection)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.SellerUniversalTransfer;
      else if (isUtdCorrection)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.SellerUniversalCorrectionTransfer;

      Action<CommonLibrary.InputDialogRefreshEventArgs> refresh = null;
      var signatories = Functions.OfficialDocument.Remote.GetSignatories(_obj);
      
      dialog.Text = AccountingDocumentBases.Resources.PropertiesFillingDialog_Text_SellerTitle;
      
      var defaultSignatory = Company.Employees.Null;
      if (signatories.Any(s => _obj.OurSignatory != null && Equals(s.EmployeeId, _obj.OurSignatory.Id)))
        defaultSignatory = _obj.OurSignatory;
      else if (signatories.Any(s => Company.Employees.Current != null && Equals(s.EmployeeId, Company.Employees.Current.Id)))
        defaultSignatory = Company.Employees.Current;
      else if (signatories.Select(s => s.EmployeeId).Distinct().Count() == 1)
        defaultSignatory = Functions.AccountingDocumentBase.Remote.GetEmployeesByIds(signatories.Select(s => s.EmployeeId).ToList()).FirstOrDefault();
      
      // Поле Подписал.
      var defaultEmployees = Functions.AccountingDocumentBase.Remote.GetEmployeesByIds(signatories.Select(s => s.EmployeeId).ToList());
      var signedBy = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_SignedBy, true, Company.Employees.Null)
        .From(defaultEmployees.Distinct());
      
      // Поле Полномочия.
      CommonLibrary.IDropDownDialogValue hasAuthority = null;
      if (isDpt || isDprr)
        hasAuthority = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority, true, 0)
          .From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_DealAndRegister,
                AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register);
      else if (isUtdAny && _obj.IsAdjustment != true)
        hasAuthority = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority, true, 0)
          .From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_DealAndRegisterAndInvoiceSignatory,
                AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_RegisterAndInvoiceSignatory);
      else if (isUtdAny && _obj.IsAdjustment == true)
      {
        hasAuthority = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority, true, 0)
          .From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_RegisterAndInvoiceSignatory);
        hasAuthority.IsEnabled = false;
      }

      // Поле Основание и связанные с ним Доверенность/Документ.
      CommonLibrary.IDropDownDialogValue basis = null;
      INavigationDialogValue<IPowerOfAttorney> attorney = null;
      CommonLibrary.IDropDownDialogValue basisDocument = null;
      basis = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Basis, true, 0);
      attorney = dialog.AddSelect(PowerOfAttorneys.Info.LocalizedName, false, PowerOfAttorneys.Null);
      basisDocument = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Document, false, null);

      CommonLibrary.CustomDialogButton saveAndSignButton = null;
      if (signatories.Any(s => Users.Current != null && Equals(s.EmployeeId, Users.Current.Id)))
        saveAndSignButton = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.PropertiesFillingDialog_SaveAndSign);
      
      var saveButton = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.PropertiesFillingDialog_Save);
      dialog.Buttons.Default = saveAndSignButton ?? saveButton;
      var cancelButton = dialog.Buttons.AddCancel();
      
      string[] basisValues = null;
      IPowerOfAttorney[] attorneyValues = null;
      string[] basisDocumentValues = null;
      List<ISignatureSetting> settings = null;

      if (basis != null)
        basis.SetOnValueChanged(bv => FillBasisDocuments(bv.NewValue, attorney, basisDocument, attorneyValues, basisDocumentValues));
      
      signedBy.SetOnValueChanged(
        (sc) =>
        {
          settings = Functions.OfficialDocument.Remote.GetSignatureSettings(_obj, sc.NewValue);
          if (basis != null)
          {
            basisValues = settings.Select(s => s.Reason).Distinct()
              .OrderBy(r => r != SignatureSetting.Reason.Duties)
              .ThenBy(r => r != SignatureSetting.Reason.PowerOfAttorney)
              .Select(r => SignatureSettings.Info.Properties.Reason.GetLocalizedValue(r)).ToArray();
            basis.From(basisValues);
            basis.IsEnabled = sc.NewValue != null;
            basis.IsRequired = sc.NewValue != null;
          }
          if (attorney != null)
          {
            attorneyValues = settings.Where(s => s.Reason == SignatureSetting.Reason.PowerOfAttorney)
              .Select(s => s.Document).OfType<IPowerOfAttorney>().Where(d => d.AccessRights.CanRead(Users.Current)).ToArray();
            attorney.From(attorneyValues);
          }
          if (basisDocument != null)
          {
            basisDocumentValues = settings.Where(s => s.Reason == SignatureSetting.Reason.Other).Select(s => s.DocumentInfo).ToArray();
            basisDocument.From(basisDocumentValues);
          }
          if (basis != null)
          {
            basis.Value = basisValues.FirstOrDefault();
            FillBasisDocuments(basis.Value, attorney, basisDocument, attorneyValues, basisDocumentValues);
          }
        });
      signedBy.Value = defaultSignatory;
      
      dialog.SetOnRefresh(refresh);
      dialog.SetOnButtonClick(
        (b) =>
        {
          if (b.Button == saveAndSignButton || b.Button == saveButton)
          {
            if (!b.IsValid)
              return;
          }
          var signatoryAttorneyValue = attorney != null ? attorney.Value : null;
          var signatoryOtherReasonValue = basisDocument != null ? basisDocument.Value : null;
          
          var errorlist = Functions.AccountingDocumentBase.Remote
            .TitleDialogValidationErrors(_obj, signedBy.Value, null,
                                         signatoryAttorneyValue, null,
                                         signatoryOtherReasonValue, null);
          foreach (var errors in errorlist.GroupBy(e => e.Text))
          {
            var controls = new List<CommonLibrary.IDialogControl>();
            foreach (var error in errors)
            {
              if (error.Type == Constants.AccountingDocumentBase.GenerateTitleTypes.Signatory)
                controls.Add(signedBy);
              if (error.Type == Constants.AccountingDocumentBase.GenerateTitleTypes.SignatoryPowerOfAttorney)
                controls.Add(attorney);
            }
            b.AddError(errors.Key, controls.ToArray());
          }
          
          if (b.IsValid)
          {
            var basisValue = basis != null ? basis.Value : string.Empty;
            var hasAuthorityValue = hasAuthority != null ? hasAuthority.Value : string.Empty;
            var signatoryAttorney = Structures.AccountingDocumentBase.Attorney.Create(signatoryAttorneyValue, signatoryOtherReasonValue);
            var title = Structures.AccountingDocumentBase.SellerTitle.Create(signedBy.Value, basisValue, hasAuthorityValue,
                                                                             signatoryAttorney.Document, signatoryAttorney.OtherReason);
            
            try
            {
              Functions.AccountingDocumentBase.Remote.GenerateSellerTitle(_obj, title);
            }
            catch (AppliedCodeException ex)
            {
              b.AddError(ex.Message);
              return;
            }
            catch (ValidationException ex)
            {
              b.AddError(ex.Message);
              return;
            }
            catch (Exception ex)
            {
              Logger.ErrorFormat("Error generation title: ", ex);
              b.AddError(Sungero.Docflow.AccountingDocumentBases.Resources.ErrorSellerTitlePropertiesFilling);
              return;
            }

            if (b.Button == saveAndSignButton)
            {
              try
              {
                Functions.Module.ApproveWithAddenda(_obj, null, null, null, false, true, string.Empty);
              }
              catch (Exception ex)
              {
                b.AddError(ex.Message);
              }
            }
          }
        });
      
      dialog.Show();
    }

    /// <summary>
    /// Диалог заполнения информации о покупателе.
    /// </summary>
    public virtual void BuyerTitlePropertiesFillingDialog()
    {
      var taxDocumentClassifier = Functions.AccountingDocumentBase.Remote.GetTaxDocumentClassifier(_obj);
      var isAct = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.Act;
      var isTorg12 = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.Waybill;
      var isDpt = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.GoodsTransfer &&
        taxDocumentClassifier == Exchange.PublicConstants.Module.TaxDocumentClassifier.GoodsTransferSeller;
      var isDprr = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.WorksTransfer &&
        taxDocumentClassifier == Exchange.PublicConstants.Module.TaxDocumentClassifier.WorksTransferSeller;
      var isUtdAny = _obj.FormalizedServiceType == Docflow.AccountingDocumentBase.FormalizedServiceType.GeneralTransfer;
      var isUtdCorrection = isUtdAny && _obj.IsAdjustment == true;
      var isOldUtdCorrection = isUtdCorrection && (taxDocumentClassifier == Exchange.PublicConstants.Module.TaxDocumentClassifier.UniversalCorrectionDocumentSeller);
      var isUtdNotCorrection = isUtdAny && _obj.IsAdjustment != true;
      var isWaybill = isTorg12 || isDpt;
      var isContractStatment = isAct || isDprr;
      var exchangeProvider = _obj.BusinessUnitBox.ExchangeService.ExchangeProvider;
      
      if (!isUtdAny && !isWaybill && !isContractStatment)
        return;
      
      var dialog = Dialogs.CreateInputDialog(AccountingDocumentBases.Resources.PropertiesFillingDialog_Title);

      if (isTorg12)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.Waybill;
      else if (isAct)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.ContractStatement;
      else if (isDpt)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.GoodsTransfer;
      else if (isDprr)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.WorksTransfer;
      else if (isUtdNotCorrection)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.UniversalTransfer;
      else if (isUtdCorrection)
        dialog.HelpCode = Constants.AccountingDocumentBase.HelpCodes.UniversalCorrectionTransfer;

      Action<CommonLibrary.InputDialogRefreshEventArgs> refresh = null;
      var signatories = Functions.OfficialDocument.Remote.GetSignatories(_obj);
      
      var dialogText = string.Empty;
      
      if (isUtdNotCorrection)
        dialogText = AccountingDocumentBases.Resources.PropertiesFillingDialog_Text_Universal;

      if (isUtdCorrection)
        dialogText = AccountingDocumentBases.Resources.PropertiesFillingDialog_Text_UniversalCorrection;

      if (isWaybill)
        dialogText = AccountingDocumentBases.Resources.PropertiesFillingDialog_Text_Waybill;

      if (isContractStatment)
        dialogText = AccountingDocumentBases.Resources.PropertiesFillingDialog_Text_Act;
      
      dialog.Text = dialogText;
      
      var defaultSignatory = Company.Employees.Null;
      if (signatories.Any(s => _obj.OurSignatory != null && Equals(s.EmployeeId, _obj.OurSignatory.Id)))
        defaultSignatory = _obj.OurSignatory;
      else if (signatories.Any(s => Company.Employees.Current != null && Equals(s.EmployeeId, Company.Employees.Current.Id)))
        defaultSignatory = Company.Employees.Current;
      else if (signatories.Select(s => s.EmployeeId).Distinct().Count() == 1)
        defaultSignatory = Functions.AccountingDocumentBase.Remote.GetEmployeesByIds(signatories.Select(s => s.EmployeeId).ToList()).FirstOrDefault();
      
      // Поле Подписал.
      var defaultEmployees = Functions.AccountingDocumentBase.Remote.GetEmployeesByIds(signatories.Select(s => s.EmployeeId).ToList());
      var signatory = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_SignedBy, true, Company.Employees.Null)
        .From(defaultEmployees.Distinct());
      
      // Поле Полномочия.
      CommonLibrary.IDropDownDialogValue hasAuthority = null;
      if (!isAct && !isTorg12)
      {
        hasAuthority = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority, true, 0);
        if (isOldUtdCorrection)
        {
          hasAuthority.From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register);
          hasAuthority.IsEnabled = false;
        }
        else if (isUtdCorrection && exchangeProvider == ExchangeCore.ExchangeService.ExchangeProvider.Synerdocs)
        {
          hasAuthority.From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register);
          hasAuthority.IsEnabled = false;
        }
        else if (isUtdCorrection)
          hasAuthority.From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register,
                            AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_SignSchf,
                            Sungero.Docflow.AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_SignSchfAndRegister,
                            Sungero.Docflow.AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Other);
        else
          hasAuthority.From(AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Register,
                            AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_Deal,
                            AccountingDocumentBases.Resources.PropertiesFillingDialog_HasAuthority_DealAndRegister);

      }

      // Поле Основание и связанные с ним Доверенность/Документ.
      CommonLibrary.IDropDownDialogValue basis = null;
      INavigationDialogValue<IPowerOfAttorney> powerOfAttorney = null;
      CommonLibrary.IDropDownDialogValue basisDocument = null;
      if (!isTorg12)
      {
        basis = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Basis, true, 0);
        powerOfAttorney = dialog.AddSelect(PowerOfAttorneys.Info.LocalizedName, false, PowerOfAttorneys.Null);

        if (!isAct)
          basisDocument = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Document, false, null);
      }

      // Дата подписания (Дата согласования, если УКД).
      var signingLable = isUtdCorrection ?
        AccountingDocumentBases.Resources.PropertiesFillingDialog_DateApproving :
        AccountingDocumentBases.Resources.PropertiesFillingDialog_SigningDate;
      var signingDate = dialog.AddDate(signingLable, true, Calendar.UserToday);
      
      // Результат и Разногласия.
      CommonLibrary.IDropDownDialogValue result = null;
      CommonLibrary.IMultilineStringDialogValue disagreement = null;
      if (!isUtdCorrection && !isContractStatment)
      {
        result = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Result, true, 0)
          .From(AccountingDocumentBases.Resources.PropertiesFillingDialog_Result_Accepted,
                AccountingDocumentBases.Resources.PropertiesFillingDialog_Result_AcceptedWithDisagreement);
        disagreement = dialog.AddMultilineString(AccountingDocumentBases.Resources.PropertiesFillingDialog_Disagreement, false);
      }
      
      // Поле Результат для УКД.
      CommonLibrary.IDropDownDialogValue adjustmentResult = null;
      if (isUtdCorrection)
      {
        adjustmentResult = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Result, true, 0)
          .From(AccountingDocumentBases.Resources.PropertiesFillingDialog_AdjustmentResult_AgreedChanges);
        adjustmentResult.IsEnabled = false;
      }
      
      // Груз принял получатель груза.
      CommonLibrary.IBooleanDialogValue isSameConsignee = null;
      INavigationDialogValue<Company.IEmployee> consignee = null;
      CommonLibrary.IDropDownDialogValue consigneeBasis = null;
      INavigationDialogValue<IPowerOfAttorney> consigneeAttorney = null;
      CommonLibrary.IStringDialogValue consigneeDocument = null;
      if (isWaybill || isUtdNotCorrection)
      {
        isSameConsignee = dialog.AddBoolean(AccountingDocumentBases.Resources.PropertiesFillingDialog_SameConsignee, true);
        consignee = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_Consignee, false, Company.Employees.Null)
          .Where(x => Equals(x.Status, CoreEntities.DatabookEntry.Status.Active));
        consigneeBasis = dialog.AddSelect(AccountingDocumentBases.Resources.PropertiesFillingDialog_ConsigneeBasis, false, 0);
        consigneeAttorney = dialog.AddSelect(PowerOfAttorneys.Info.LocalizedName, false, PowerOfAttorneys.Null);
        consigneeDocument = dialog.AddString(AccountingDocumentBases.Resources.PropertiesFillingDialog_Document, false);
      }

      CommonLibrary.CustomDialogButton saveAndSignButton = null;
      if (signatories.Any(s => Users.Current != null && Equals(s.EmployeeId, Users.Current.Id)))
        saveAndSignButton = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.PropertiesFillingDialog_SaveAndSign);
      
      var saveButton = dialog.Buttons.AddCustom(AccountingDocumentBases.Resources.PropertiesFillingDialog_Save);
      dialog.Buttons.Default = saveAndSignButton ?? saveButton;
      var cancelButton = dialog.Buttons.AddCancel();
      
      string[] basisValues = null;
      IPowerOfAttorney[] powerOfAttorneyValues = null;
      string[] basisDocumentValues = null;
      List<ISignatureSetting> settings = null;
      IPowerOfAttorney[] consigneePowerOfAttorneyValues = null;

      if (basis != null)
        basis.SetOnValueChanged(bv => FillBasisDocuments(bv.NewValue, powerOfAttorney, basisDocument, powerOfAttorneyValues, basisDocumentValues));
      
      signatory.SetOnValueChanged(
        (sc) =>
        {
          settings = Functions.OfficialDocument.Remote.GetSignatureSettings(_obj, sc.NewValue);
          if (basis != null)
          {
            basisValues = settings.Select(s => s.Reason).Distinct()
              .Where(r => !isAct || r != SignatureSetting.Reason.Other)
              .OrderBy(r => r != SignatureSetting.Reason.Duties)
              .ThenBy(r => r != SignatureSetting.Reason.PowerOfAttorney)
              .Select(r => SignatureSettings.Info.Properties.Reason.GetLocalizedValue(r)).ToArray();
            basis.From(basisValues);
            basis.IsEnabled = sc.NewValue != null;
            basis.IsRequired = sc.NewValue != null;
          }
          if (powerOfAttorney != null)
          {
            powerOfAttorneyValues = settings.Where(s => s.Reason == SignatureSetting.Reason.PowerOfAttorney)
              .Select(s => s.Document).OfType<IPowerOfAttorney>().Where(d => d.AccessRights.CanRead(Users.Current)).ToArray();
            powerOfAttorney.From(powerOfAttorneyValues);
          }
          if (basisDocument != null)
          {
            basisDocumentValues = settings.Where(s => s.Reason == SignatureSetting.Reason.Other).Select(s => s.DocumentInfo).ToArray();
            basisDocument.From(basisDocumentValues);
          }
          if (basis != null)
          {
            basis.Value = basisValues.FirstOrDefault();
            FillBasisDocuments(basis.Value, powerOfAttorney, basisDocument, powerOfAttorneyValues, basisDocumentValues);
          }
        });
      signatory.Value = defaultSignatory;
      
      Action<CommonLibrary.InputDialogValueChangedEventArgs<string>> consigneeBasisChanged =
        cb =>
      {
        var basisIsDuties = cb.NewValue == SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.Duties);
        var basisIsAttorney = cb.NewValue == SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.PowerOfAttorney);
        var basisIsOther = cb.NewValue == SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.Other);
        
        if (consigneeAttorney != null)
        {
          consigneeAttorney.IsVisible = !basisIsOther;
          consigneeAttorney.IsRequired = basisIsAttorney;
          consigneeAttorney.IsEnabled = basisIsAttorney;
          if (!consigneeAttorney.IsEnabled)
            consigneeAttorney.Value = null;
          else
            consigneeAttorney.Value = consigneePowerOfAttorneyValues.Length == 1 ? consigneePowerOfAttorneyValues.SingleOrDefault() : null;
        }
        
        if (consigneeDocument != null)
        {
          consigneeDocument.IsVisible = basisIsOther;
          consigneeDocument.IsRequired = basisIsOther;
          if (!consigneeDocument.IsVisible)
            consigneeDocument.Value = null;
        }
      };
      
      if (consignee != null)
        consignee.SetOnValueChanged(
          ce =>
          {
            var cbValues = new List<string>();
            if (ce.NewValue != null)
            {
              cbValues.Add(SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.Duties));
              cbValues.Add(SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.PowerOfAttorney));
              if (!isTorg12)
                cbValues.Add(SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.Other));

              consigneePowerOfAttorneyValues = Functions.PowerOfAttorney.Remote.GetActivePowerOfAttorneys(ce.NewValue, signingDate.Value).ToArray();
            }
            else
              consigneePowerOfAttorneyValues = new IPowerOfAttorney[0];
            
            consigneeBasis.From(cbValues.ToArray());
            consigneeAttorney.From(consigneePowerOfAttorneyValues);

            consigneeBasis.Value = cbValues.OrderBy(v => v != consigneeBasis.Value).FirstOrDefault();
            consigneeBasisChanged.Invoke(new CommonLibrary.InputDialogValueChangedEventArgs<string>(null, consigneeBasis.Value));
          });
      
      if (consigneeBasis != null)
        consigneeBasis.SetOnValueChanged(consigneeBasisChanged);
      
      signingDate.SetOnValueChanged(
        sd =>
        {
          if (consigneeAttorney != null)
          {
            if (sd.NewValue.HasValue && consignee.Value != null)
              consigneePowerOfAttorneyValues = Functions.PowerOfAttorney.Remote.GetActivePowerOfAttorneys(consignee.Value, signingDate.Value).ToArray();
            else
              consigneePowerOfAttorneyValues = new IPowerOfAttorney[0];

            consigneeAttorney.From(consigneePowerOfAttorneyValues);
            consigneeBasisChanged.Invoke(new CommonLibrary.InputDialogValueChangedEventArgs<string>(null, consigneeBasis.Value));
          }
        });
      
      refresh = (r) =>
      {
        if (disagreement != null)
          disagreement.IsEnabled = result.Value == AccountingDocumentBases.Resources.PropertiesFillingDialog_Result_AcceptedWithDisagreement;

        if (isSameConsignee != null)
        {
          var needConsignee = !isSameConsignee.Value.Value;
          consignee.IsEnabled = needConsignee;
          consignee.IsRequired = needConsignee;
          consigneeBasis.IsEnabled = needConsignee && consignee.Value != null;
          consigneeBasis.IsRequired = needConsignee && consignee.Value != null;

          if (!needConsignee)
          {
            consignee.Value = Company.Employees.Null;
            consigneeBasis.Value = string.Empty;
          }
        }
      };
      
      dialog.SetOnRefresh(refresh);
      dialog.SetOnButtonClick(
        (b) =>
        {
          if (b.Button == saveAndSignButton || b.Button == saveButton)
          {
            if (!b.IsValid)
              return;
            
            var consigneeValue = isSameConsignee != null ? (isSameConsignee.Value == true ? signatory.Value : consignee.Value) : null;
            var signatoryPowerOfAttorneyValue = powerOfAttorney != null ? powerOfAttorney.Value : null;
            var signatoryOtherReasonValue = basisDocument != null ? basisDocument.Value : null;
            var consigneePowerOfAttorneyValue = consigneeAttorney != null ? consigneeAttorney.Value : null;
            var consigneeOtherReasonValue = consigneeDocument != null ? consigneeDocument.Value : null;
            var errorlist = Functions.AccountingDocumentBase.Remote
              .TitleDialogValidationErrors(_obj, signatory.Value, consignee != null ? consignee.Value : null,
                                           signatoryPowerOfAttorneyValue, consigneePowerOfAttorneyValue,
                                           signatoryOtherReasonValue, consigneeOtherReasonValue);
            foreach (var errors in errorlist.GroupBy(e => e.Text))
            {
              var controls = new List<CommonLibrary.IDialogControl>();
              foreach (var error in errors)
              {
                if (error.Type == Constants.AccountingDocumentBase.GenerateTitleTypes.Signatory)
                  controls.Add(signatory);
                if (error.Type == Constants.AccountingDocumentBase.GenerateTitleTypes.Consignee)
                  controls.Add(consignee);
                if (error.Type == Constants.AccountingDocumentBase.GenerateTitleTypes.SignatoryPowerOfAttorney)
                  controls.Add(powerOfAttorney);
                if (error.Type == Constants.AccountingDocumentBase.GenerateTitleTypes.ConsigneePowerOfAttorney)
                  controls.Add(consigneeAttorney);
              }
              b.AddError(errors.Key, controls.ToArray());
            }
            
            if (b.IsValid)
            {
              var signed = (result != null && result.IsVisible) ?
                result.Value != AccountingDocumentBases.Resources.PropertiesFillingDialog_Result_AcceptedWithDisagreement :
                true;
              var consigneeBasisValue = isSameConsignee != null && basis != null ? (isSameConsignee.Value == true ? basis.Value : consigneeBasis.Value) : string.Empty;
              var disagreementValue = disagreement != null ? disagreement.Value : string.Empty;
              var basisValue = basis != null ? basis.Value : string.Empty;
              var hasAuthorityValue = hasAuthority != null ? hasAuthority.Value : string.Empty;
              var signatoryPowerOfAttorney = Structures.AccountingDocumentBase.Attorney.Create(signatoryPowerOfAttorneyValue, signatoryOtherReasonValue);
              var consigneePowerOfAttorney = Structures.AccountingDocumentBase.Attorney.Create(consigneePowerOfAttorneyValue, consigneeOtherReasonValue);
              var title = Structures.AccountingDocumentBase.BuyerTitle.Create();
              title.ActOfDisagreement = disagreementValue;
              title.Signatory = signatory.Value;
              title.SignatoryPowersBase = basisValue;
              title.Consignee = consigneeValue;
              title.ConsigneePowersBase = consigneeBasisValue;
              title.SignResult = signed;
              title.SignatoryPowers = hasAuthorityValue;
              title.AcceptanceDate = signingDate.Value;
              title.SignatoryPowerOfAttorney = signatoryPowerOfAttorney.Document;
              title.SignatoryOtherReason = signatoryPowerOfAttorney.OtherReason;
              title.ConsigneePowerOfAttorney = consigneePowerOfAttorney.Document;
              title.ConsigneeOtherReason = consigneePowerOfAttorney.OtherReason;
              
              try
              {
                Functions.AccountingDocumentBase.Remote.GenerateAnswer(_obj, title, false);
              }
              catch (AppliedCodeException ex)
              {
                b.AddError(ex.Message);
                return;
              }
              catch (ValidationException ex)
              {
                b.AddError(ex.Message);
                return;
              }
              catch (Exception ex)
              {
                Logger.ErrorFormat("Error generation title: ", ex);
                b.AddError(Sungero.Docflow.AccountingDocumentBases.Resources.ErrorBuyerTitlePropertiesFilling);
                return;
              }

              if (b.Button == saveAndSignButton)
              {
                try
                {
                  Functions.Module.ApproveWithAddenda(_obj, null, null, null, false, true, string.Empty);
                }
                catch (Exception ex)
                {
                  b.AddError(ex.Message);
                }
              }
            }
          }
        });
      dialog.Show();
    }
    
    /// <summary>
    /// Заполнение значений доверенности и документа с основанием "Другой документ".
    /// </summary>
    /// <param name="newValue">Основание.</param>
    /// <param name="powerOfAttorney">Доверенность.</param>
    /// <param name="basisDocument">Документ основания.</param>
    /// <param name="powerOfAttorneyValues">Список доверенностей.</param>
    /// <param name="basisDocumentValues">Список документов основания.</param>
    private static void FillBasisDocuments(string newValue,
                                           INavigationDialogValue<IPowerOfAttorney> powerOfAttorney,
                                           CommonLibrary.IDropDownDialogValue basisDocument,
                                           IPowerOfAttorney[] powerOfAttorneyValues,
                                           string[] basisDocumentValues)
    {
      var basisIsAttorney = newValue == SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.PowerOfAttorney);
      var basisIsOther = newValue == SignatureSettings.Info.Properties.Reason.GetLocalizedValue(SignatureSetting.Reason.Other);
      
      if (powerOfAttorney != null)
      {
        powerOfAttorney.IsVisible = !basisIsOther;
        powerOfAttorney.IsRequired = basisIsAttorney;
        powerOfAttorney.IsEnabled = basisIsAttorney;
        if (!powerOfAttorney.IsEnabled)
          powerOfAttorney.Value = null;
        else
          powerOfAttorney.Value = powerOfAttorneyValues.Length == 1 ? powerOfAttorneyValues.Single() : null;
      }
      if (basisDocument != null)
      {
        basisDocument.IsVisible = basisIsOther;
        basisDocument.IsRequired = basisIsOther;
        if (!basisDocument.IsVisible)
          basisDocument.Value = null;
        else
          basisDocument.Value = basisDocumentValues.Length == 1 ? basisDocumentValues.Single() : null;
      }
    }
    
    /// <summary>
    /// Генерировать титул покупателя в автоматическом режиме.
    /// </summary>
    public virtual void GenerateDefaultBuyerTitle()
    {
      if (_obj.ExchangeState == OfficialDocument.ExchangeState.SignRequired && _obj.BuyerTitleId == null)
      {
        Docflow.PublicFunctions.AccountingDocumentBase.Remote.GenerateDefaultAnswer(_obj, Company.Employees.Current, false);
      }
    }
    
    /// <summary>
    /// Генерировать титул продавца в автоматическом режиме.
    /// </summary>
    public virtual void GenerateDefaultSellerTitle()
    {
      if (_obj.IsFormalized == true && _obj.SellerTitleId != null && !FinancialArchive.PublicFunctions.Module.Remote.HasSellerSignatoryInfo(_obj))
      {
        Docflow.PublicFunctions.AccountingDocumentBase.Remote.GenerateDefaultSellerTitle(_obj, Sungero.Company.Employees.Current);
      }
    }
  }
}