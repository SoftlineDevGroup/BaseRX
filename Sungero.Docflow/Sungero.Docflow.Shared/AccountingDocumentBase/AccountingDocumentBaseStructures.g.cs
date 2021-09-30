namespace Sungero.Docflow.Structures.AccountingDocumentBase
{
  [global::System.Serializable]
  public partial class ExportReport : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportReport Create()
    {
      return new ExportReport();
    }

    public static ExportReport Create(global::System.String reportSessionId, global::System.String document, global::System.String hyperlink, global::System.Int32 id, global::System.String exported, global::System.String note, global::System.String iOHyperlink, global::System.Int32 orderId)
    {
      return new ExportReport
      {
        ReportSessionId = reportSessionId,
        Document = document,
        Hyperlink = hyperlink,
        Id = id,
        Exported = exported,
        Note = note,
        IOHyperlink = iOHyperlink,
        OrderId = orderId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ ((this.Document != null ? this.Document.GetHashCode() : 0) * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.Exported != null ? this.Exported.GetHashCode() : 0) * 199) ^ ((this.Note != null ? this.Note.GetHashCode() : 0) * 199) ^ ((this.IOHyperlink != null ? this.IOHyperlink.GetHashCode() : 0) * 199) ^ (this.OrderId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportReport)obj);
    }

    public static bool operator ==(ExportReport left, ExportReport right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportReport left, ExportReport right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportReport other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId)
             && object.Equals(this.Document, other.Document)
             && object.Equals(this.Hyperlink, other.Hyperlink)
             && this.Id == other.Id
             && object.Equals(this.Exported, other.Exported)
             && object.Equals(this.Note, other.Note)
             && object.Equals(this.IOHyperlink, other.IOHyperlink)
             && this.OrderId == other.OrderId;
    }
  }

  [global::System.Serializable]
  public partial class ExportDialogParams : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportDialogParams Create()
    {
      return new ExportDialogParams();
    }

    public static ExportDialogParams Create(global::System.Boolean groupCounterparty, global::System.Boolean groupDocumentType, global::System.Boolean forPrint)
    {
      return new ExportDialogParams
      {
        GroupCounterparty = groupCounterparty,
        GroupDocumentType = groupDocumentType,
        ForPrint = forPrint
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.GroupCounterparty.GetHashCode() * 199) ^ (this.GroupDocumentType.GetHashCode() * 199) ^ (this.ForPrint.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportDialogParams)obj);
    }

    public static bool operator ==(ExportDialogParams left, ExportDialogParams right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportDialogParams left, ExportDialogParams right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportDialogParams other)
    {
      return this.GroupCounterparty == other.GroupCounterparty
             && this.GroupDocumentType == other.GroupDocumentType
             && this.ForPrint == other.ForPrint;
    }
  }

  [global::System.Serializable]
  public partial class AfterExportDialog : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AfterExportDialog Create()
    {
      return new AfterExportDialog();
    }

    public static AfterExportDialog Create(global::System.String rootFolder, global::System.String pathToRoot, global::System.Nullable<global::System.DateTime> dateTime, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.ExportedDocument> documents)
    {
      return new AfterExportDialog
      {
        RootFolder = rootFolder,
        PathToRoot = pathToRoot,
        DateTime = dateTime,
        Documents = documents
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.RootFolder != null ? this.RootFolder.GetHashCode() : 0) * 199) ^ ((this.PathToRoot != null ? this.PathToRoot.GetHashCode() : 0) * 199) ^ ((this.DateTime != null ? this.DateTime.GetHashCode() : 0) * 199) ^ ((this.Documents != null ? this.Documents.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AfterExportDialog)obj);
    }

    public static bool operator ==(AfterExportDialog left, AfterExportDialog right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AfterExportDialog left, AfterExportDialog right)
    {
      return !(left == right);
    }

    protected bool Equals(AfterExportDialog other)
    {
      return object.Equals(this.RootFolder, other.RootFolder)
             && object.Equals(this.PathToRoot, other.PathToRoot)
             && object.Equals(this.DateTime, other.DateTime)
             && global::System.Linq.Enumerable.SequenceEqual(this.Documents, other.Documents);
    }
  }

  [global::System.Serializable]
  public partial class ExportedDocument : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportedDocument Create()
    {
      return new ExportedDocument();
    }

    public static ExportedDocument Create(global::System.Int32 id, global::System.Boolean isFormalized, global::System.Boolean isAddendum, global::System.String parentShortName, global::System.Boolean isFaulted, global::System.Boolean isPrint, global::System.String error, global::Sungero.Docflow.Structures.AccountingDocumentBase.ExportedFolder folder, global::System.String name, global::System.Nullable<global::System.Int32> leadDocumentId)
    {
      return new ExportedDocument
      {
        Id = id,
        IsFormalized = isFormalized,
        IsAddendum = isAddendum,
        ParentShortName = parentShortName,
        IsFaulted = isFaulted,
        IsPrint = isPrint,
        Error = error,
        Folder = folder,
        Name = name,
        LeadDocumentId = leadDocumentId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ (this.IsFormalized.GetHashCode() * 199) ^ (this.IsAddendum.GetHashCode() * 199) ^ ((this.ParentShortName != null ? this.ParentShortName.GetHashCode() : 0) * 199) ^ (this.IsFaulted.GetHashCode() * 199) ^ (this.IsPrint.GetHashCode() * 199) ^ ((this.Error != null ? this.Error.GetHashCode() : 0) * 199) ^ ((this.Folder != null ? this.Folder.GetHashCode() : 0) * 199) ^ ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ ((this.LeadDocumentId != null ? this.LeadDocumentId.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportedDocument)obj);
    }

    public static bool operator ==(ExportedDocument left, ExportedDocument right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportedDocument left, ExportedDocument right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportedDocument other)
    {
      return this.Id == other.Id
             && this.IsFormalized == other.IsFormalized
             && this.IsAddendum == other.IsAddendum
             && object.Equals(this.ParentShortName, other.ParentShortName)
             && this.IsFaulted == other.IsFaulted
             && this.IsPrint == other.IsPrint
             && object.Equals(this.Error, other.Error)
             && object.Equals(this.Folder, other.Folder)
             && object.Equals(this.Name, other.Name)
             && object.Equals(this.LeadDocumentId, other.LeadDocumentId);
    }
  }

  [global::System.Serializable]
  public partial class ExportResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportResult Create()
    {
      return new ExportResult();
    }

    public static ExportResult Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.ExportedDocument> exportedDocuments, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.ZipModel> zipModels)
    {
      return new ExportResult
      {
        ExportedDocuments = exportedDocuments,
        ZipModels = zipModels
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ExportedDocuments != null ? this.ExportedDocuments.GetHashCode() : 0) * 199) ^ ((this.ZipModels != null ? this.ZipModels.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportResult)obj);
    }

    public static bool operator ==(ExportResult left, ExportResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportResult left, ExportResult right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportResult other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.ExportedDocuments, other.ExportedDocuments)
             && global::System.Linq.Enumerable.SequenceEqual(this.ZipModels, other.ZipModels);
    }
  }

  [global::System.Serializable]
  public partial class ExportedFolder : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportedFolder Create()
    {
      return new ExportedFolder();
    }

    public static ExportedFolder Create(global::System.String folderName, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.ExportedFile> files, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.AccountingDocumentBase.ExportedFolder> folders, global::System.String parentRelativePath)
    {
      return new ExportedFolder
      {
        FolderName = folderName,
        Files = files,
        Folders = folders,
        ParentRelativePath = parentRelativePath
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.FolderName != null ? this.FolderName.GetHashCode() : 0) * 199) ^ ((this.Files != null ? this.Files.GetHashCode() : 0) * 199) ^ ((this.Folders != null ? this.Folders.GetHashCode() : 0) * 199) ^ ((this.ParentRelativePath != null ? this.ParentRelativePath.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportedFolder)obj);
    }

    public static bool operator ==(ExportedFolder left, ExportedFolder right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportedFolder left, ExportedFolder right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportedFolder other)
    {
      return object.Equals(this.FolderName, other.FolderName)
             && global::System.Linq.Enumerable.SequenceEqual(this.Files, other.Files)
             && global::System.Linq.Enumerable.SequenceEqual(this.Folders, other.Folders)
             && object.Equals(this.ParentRelativePath, other.ParentRelativePath);
    }
  }

  [global::System.Serializable]
  public partial class ExportedFile : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExportedFile Create()
    {
      return new ExportedFile();
    }

    public static ExportedFile Create(global::System.Int32 id, global::System.String fileName, global::System.Byte[] body, global::System.String servicePath, global::System.String token)
    {
      return new ExportedFile
      {
        Id = id,
        FileName = fileName,
        Body = body,
        ServicePath = servicePath,
        Token = token
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.FileName != null ? this.FileName.GetHashCode() : 0) * 199) ^ (this.Body.GetHashCode() * 199) ^ ((this.ServicePath != null ? this.ServicePath.GetHashCode() : 0) * 199) ^ ((this.Token != null ? this.Token.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExportedFile)obj);
    }

    public static bool operator ==(ExportedFile left, ExportedFile right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExportedFile left, ExportedFile right)
    {
      return !(left == right);
    }

    protected bool Equals(ExportedFile other)
    {
      return this.Id == other.Id
             && object.Equals(this.FileName, other.FileName)
             && this.Body == other.Body
             && object.Equals(this.ServicePath, other.ServicePath)
             && object.Equals(this.Token, other.Token);
    }
  }

  [global::System.Serializable]
  public partial class ZipModel : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ZipModel Create()
    {
      return new ZipModel();
    }

    public static ZipModel Create(global::System.Int32 documentId, global::System.Int32 versionId, global::System.Boolean isPublicBody, global::System.String fileName, global::System.Collections.Generic.List<global::System.String> folderRelativePath, global::System.Nullable<global::System.Int32> signatureId, global::System.Int64 size)
    {
      return new ZipModel
      {
        DocumentId = documentId,
        VersionId = versionId,
        IsPublicBody = isPublicBody,
        FileName = fileName,
        FolderRelativePath = folderRelativePath,
        SignatureId = signatureId,
        Size = size
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.DocumentId.GetHashCode() * 199) ^ (this.VersionId.GetHashCode() * 199) ^ (this.IsPublicBody.GetHashCode() * 199) ^ ((this.FileName != null ? this.FileName.GetHashCode() : 0) * 199) ^ ((this.FolderRelativePath != null ? this.FolderRelativePath.GetHashCode() : 0) * 199) ^ ((this.SignatureId != null ? this.SignatureId.GetHashCode() : 0) * 199) ^ (this.Size.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ZipModel)obj);
    }

    public static bool operator ==(ZipModel left, ZipModel right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ZipModel left, ZipModel right)
    {
      return !(left == right);
    }

    protected bool Equals(ZipModel other)
    {
      return this.DocumentId == other.DocumentId
             && this.VersionId == other.VersionId
             && this.IsPublicBody == other.IsPublicBody
             && object.Equals(this.FileName, other.FileName)
             && global::System.Linq.Enumerable.SequenceEqual(this.FolderRelativePath, other.FolderRelativePath)
             && object.Equals(this.SignatureId, other.SignatureId)
             && this.Size == other.Size;
    }
  }

  [global::System.Serializable]
  public partial class GenerateTitleError : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static GenerateTitleError Create()
    {
      return new GenerateTitleError();
    }

    public static GenerateTitleError Create(global::System.String type, global::System.String text)
    {
      return new GenerateTitleError
      {
        Type = type,
        Text = text
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Type != null ? this.Type.GetHashCode() : 0) * 199) ^ ((this.Text != null ? this.Text.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((GenerateTitleError)obj);
    }

    public static bool operator ==(GenerateTitleError left, GenerateTitleError right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(GenerateTitleError left, GenerateTitleError right)
    {
      return !(left == right);
    }

    protected bool Equals(GenerateTitleError other)
    {
      return object.Equals(this.Type, other.Type)
             && object.Equals(this.Text, other.Text);
    }
  }
}