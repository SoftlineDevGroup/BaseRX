using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Docflow.Structures.AccountingDocumentBase
{
  partial class ExportReport
  {
    public string ReportSessionId { get; set; }
    
    public string Document { get; set; }
    
    public string Hyperlink { get; set; }
    
    public int Id { get; set; }
    
    public string Exported { get; set; }
    
    public string Note { get; set; }
    
    public string IOHyperlink { get; set; }
    
    public int OrderId { get; set; }
  }
  
  [Public]
  partial class ExportDialogSearch
  {
    public Company.IBusinessUnit BusinessUnit { get; set; }
    
    public Parties.ICounterparty Counterparty { get; set; }
    
    public Contracts.IContractualDocument Contract { get; set; }
    
    public DateTime? From { get; set; }
    
    public DateTime? To { get; set; }
    
    public List<Docflow.IDocumentKind> DocumentKinds { get; set; }
  }
  
  partial class ExportDialogParams
  {
    public bool GroupCounterparty { get; set; }
    
    public bool GroupDocumentType { get; set; }
    
    public bool ForPrint { get; set; }
  }
  
  partial class AfterExportDialog
  {
    public string RootFolder { get; set; }
    
    public string PathToRoot { get; set; }
    
    public DateTime? DateTime { get; set; }
    
    public List<Sungero.Docflow.Structures.AccountingDocumentBase.ExportedDocument> Documents { get; set; }
  }
  
  partial class ExportedDocument
  {
    public int Id { get; set; }
    
    public bool IsFormalized { get; set; }
    
    public bool IsAddendum { get; set; }
    
    public string ParentShortName { get; set; }
    
    public bool IsFaulted { get; set; }
    
    public bool IsPrint { get; set; }
    
    public string Error { get; set; }
    
    // Папка самого документа всегда с пустым именем, это фактически корень общий для всех.
    public Sungero.Docflow.Structures.AccountingDocumentBase.ExportedFolder Folder { get; set; }
    
    public string Name { get; set; }
    
    public int? LeadDocumentId { get; set; }
  }
  
  partial class ExportResult
  {
    public List<Sungero.Docflow.Structures.AccountingDocumentBase.ExportedDocument> ExportedDocuments { get; set; }
    
    public List<Sungero.Docflow.Structures.AccountingDocumentBase.ZipModel> ZipModels { get; set; }
  }
  
  partial class ExportedFolder
  {
    public string FolderName { get; set; }
    
    public List<Sungero.Docflow.Structures.AccountingDocumentBase.ExportedFile> Files { get; set; }
    
    public List<Sungero.Docflow.Structures.AccountingDocumentBase.ExportedFolder> Folders { get; set; }
    
    public string ParentRelativePath { get; set; }
  }
  
  partial class ExportedFile
  {
    public int Id { get; set; }
    
    public string FileName { get; set; }
    
    public byte[] Body { get; set; }
    
    public string ServicePath { get; set; }
    
    public string Token { get; set; }
  }
  
  partial class ZipModel
  {
    public int DocumentId { get; set; }
    
    public int VersionId { get; set; }
    
    public bool IsPublicBody { get; set; }
    
    public string FileName { get; set; }
    
    public List<string> FolderRelativePath { get; set; }
    
    public int? SignatureId { get; set; }
    
    public long Size { get; set; }
  }
  
  [PublicAttribute]
  partial class BuyerTitle
  {
    public DateTime? AcceptanceDate { get; set; }
    
    /// <summary>
    /// Результат подписания - с разногласиями или без.
    /// </summary>
    public bool SignResult { get; set; }

    /// <summary>
    /// Акт разногласий.
    /// </summary>
    public string ActOfDisagreement { get; set; }

    /// <summary>
    /// Подписывающий.
    /// </summary>
    public Company.IEmployee Signatory { get; set; }

    /// <summary>
    /// Основание полномочий подписывающего.
    /// </summary>
    public string SignatoryPowersBase { get; set; }

    /// <summary>
    /// Сотрудник, принявший груз.
    /// </summary>
    public Company.IEmployee Consignee { get; set; }

    /// <summary>
    /// Основание полномочий принявшего груз.
    /// </summary>
    public string ConsigneePowersBase { get; set; }
    
    /// <summary>
    /// Область полномочий (оформление, подписание, оформление и подписание).
    /// </summary>
    public string SignatoryPowers { get; set; }
    
    /// <summary>
    /// Доверенность.
    /// </summary>
    public IPowerOfAttorney SignatoryPowerOfAttorney { get; set; }
    
    /// <summary>
    /// Другой документ.
    /// </summary>
    public string SignatoryOtherReason { get; set; }
    
    /// <summary>
    /// Доверенность.
    /// </summary>
    public IPowerOfAttorney ConsigneePowerOfAttorney { get; set; }
    
    /// <summary>
    /// Другой документ.
    /// </summary>
    public string ConsigneeOtherReason { get; set; }
    
    /* TODO Ждёт баги 44693
    
    /// <summary>
    /// Доверенность подписывающего.
    /// </summary>
    public Sungero.Docflow.Structures.AccountingDocumentBase.IAttorney Attorney { get; set; }

    /// <summary>
    /// Доверенность принявшего груз.
    /// </summary>
    public Sungero.Docflow.Structures.AccountingDocumentBase.IAttorney ConsigneeAttorney { get; set; }
    
     */

  }
  
  [PublicAttribute]
  partial class SellerTitle
  {
    /// <summary>
    /// Подписывающий.
    /// </summary>
    public Company.IEmployee Signatory { get; set; }

    /// <summary>
    /// Основание полномочий подписывающего.
    /// </summary>
    public string SignatoryPowersBase { get; set; }
    
    /// <summary>
    /// Область полномочий (оформление, подписание, оформление и подписание).
    /// </summary>
    public string SignatoryPowers { get; set; }
    
    /// <summary>
    /// Доверенность.
    /// </summary>
    public IPowerOfAttorney SignatoryPowerOfAttorney { get; set; }
    
    /// <summary>
    /// Другая причина.
    /// </summary>
    public string SignatoryOtherReason { get; set; }
  }
  
  [Public]
  partial class Attorney
  {
    /// <summary>
    /// Доверенность.
    /// </summary>
    public IPowerOfAttorney Document { get; set; }
    
    /// <summary>
    /// Другая причина.
    /// </summary>
    public string OtherReason { get; set; }
  }
  
  partial class GenerateTitleError
  {
    public string Type { get; set; }
    
    public string Text { get; set; }
  }
}