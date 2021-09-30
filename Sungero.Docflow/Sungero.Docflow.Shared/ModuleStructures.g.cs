namespace Sungero.Docflow.Structures.Module
{
  [global::System.Serializable]
  public partial class MailSendingResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static MailSendingResult Create()
    {
      return new MailSendingResult();
    }

    public static MailSendingResult Create(global::System.Boolean isSuccess, global::System.Boolean anyMailSended)
    {
      return new MailSendingResult
      {
        IsSuccess = isSuccess,
        AnyMailSended = anyMailSended
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.IsSuccess.GetHashCode() * 199) ^ (this.AnyMailSended.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((MailSendingResult)obj);
    }

    public static bool operator ==(MailSendingResult left, MailSendingResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(MailSendingResult left, MailSendingResult right)
    {
      return !(left == right);
    }

    protected bool Equals(MailSendingResult other)
    {
      return this.IsSuccess == other.IsSuccess
             && this.AnyMailSended == other.AnyMailSended;
    }
  }

  [global::System.Serializable]
  public partial class EnvelopeReportTableLine : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static EnvelopeReportTableLine Create()
    {
      return new EnvelopeReportTableLine();
    }

    public static EnvelopeReportTableLine Create(global::System.String reportSessionId, global::System.Int32 id, global::System.String toName, global::System.String fromName, global::System.String toZipCode, global::System.String fromZipCode, global::System.String toPlace, global::System.String fromPlace)
    {
      return new EnvelopeReportTableLine
      {
        ReportSessionId = reportSessionId,
        Id = id,
        ToName = toName,
        FromName = fromName,
        ToZipCode = toZipCode,
        FromZipCode = fromZipCode,
        ToPlace = toPlace,
        FromPlace = fromPlace
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199) ^ (this.Id.GetHashCode() * 199) ^ ((this.ToName != null ? this.ToName.GetHashCode() : 0) * 199) ^ ((this.FromName != null ? this.FromName.GetHashCode() : 0) * 199) ^ ((this.ToZipCode != null ? this.ToZipCode.GetHashCode() : 0) * 199) ^ ((this.FromZipCode != null ? this.FromZipCode.GetHashCode() : 0) * 199) ^ ((this.ToPlace != null ? this.ToPlace.GetHashCode() : 0) * 199) ^ ((this.FromPlace != null ? this.FromPlace.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((EnvelopeReportTableLine)obj);
    }

    public static bool operator ==(EnvelopeReportTableLine left, EnvelopeReportTableLine right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(EnvelopeReportTableLine left, EnvelopeReportTableLine right)
    {
      return !(left == right);
    }

    protected bool Equals(EnvelopeReportTableLine other)
    {
      return object.Equals(this.ReportSessionId, other.ReportSessionId)
             && this.Id == other.Id
             && object.Equals(this.ToName, other.ToName)
             && object.Equals(this.FromName, other.FromName)
             && object.Equals(this.ToZipCode, other.ToZipCode)
             && object.Equals(this.FromZipCode, other.FromZipCode)
             && object.Equals(this.ToPlace, other.ToPlace)
             && object.Equals(this.FromPlace, other.FromPlace);
    }
  }

  [global::System.Serializable]
  public partial class DefinedApprovalStages : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DefinedApprovalStages Create()
    {
      return new DefinedApprovalStages();
    }

    public static DefinedApprovalStages Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages, global::System.Boolean isConditionsDefined, global::System.String errorMessage)
    {
      return new DefinedApprovalStages
      {
        Stages = stages,
        IsConditionsDefined = isConditionsDefined,
        ErrorMessage = errorMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Stages != null ? this.Stages.GetHashCode() : 0) * 199) ^ (this.IsConditionsDefined.GetHashCode() * 199) ^ ((this.ErrorMessage != null ? this.ErrorMessage.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DefinedApprovalStages)obj);
    }

    public static bool operator ==(DefinedApprovalStages left, DefinedApprovalStages right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DefinedApprovalStages left, DefinedApprovalStages right)
    {
      return !(left == right);
    }

    protected bool Equals(DefinedApprovalStages other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Stages, other.Stages)
             && this.IsConditionsDefined == other.IsConditionsDefined
             && object.Equals(this.ErrorMessage, other.ErrorMessage);
    }
  }

  public partial class DefinedApprovalStageLite : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DefinedApprovalStageLite Create()
    {
      return new DefinedApprovalStageLite();
    }

    public static DefinedApprovalStageLite Create(global::Sungero.Docflow.IApprovalStage stage, global::System.Nullable<global::System.Int32> number, global::System.Nullable<global::Sungero.Core.Enumeration> stageType)
    {
      return new DefinedApprovalStageLite
      {
        Stage = stage,
        Number = number,
        StageType = stageType
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Stage != null ? this.Stage.GetHashCode() : 0) * 199) ^ ((this.Number != null ? this.Number.GetHashCode() : 0) * 199) ^ ((this.StageType != null ? this.StageType.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DefinedApprovalStageLite)obj);
    }

    public static bool operator ==(DefinedApprovalStageLite left, DefinedApprovalStageLite right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DefinedApprovalStageLite left, DefinedApprovalStageLite right)
    {
      return !(left == right);
    }

    protected bool Equals(DefinedApprovalStageLite other)
    {
      return object.Equals(this.Stage, other.Stage)
             && object.Equals(this.Number, other.Number)
             && object.Equals(this.StageType, other.StageType);
    }
  }

  public partial class AddresseeAndSender : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static AddresseeAndSender Create()
    {
      return new AddresseeAndSender();
    }

    public static AddresseeAndSender Create(global::Sungero.Parties.ICounterparty addresse, global::Sungero.Company.IBusinessUnit sender)
    {
      return new AddresseeAndSender
      {
        Addresse = addresse,
        Sender = sender
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Addresse != null ? this.Addresse.GetHashCode() : 0) * 199) ^ ((this.Sender != null ? this.Sender.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AddresseeAndSender)obj);
    }

    public static bool operator ==(AddresseeAndSender left, AddresseeAndSender right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AddresseeAndSender left, AddresseeAndSender right)
    {
      return !(left == right);
    }

    protected bool Equals(AddresseeAndSender other)
    {
      return object.Equals(this.Addresse, other.Addresse)
             && object.Equals(this.Sender, other.Sender);
    }
  }

  [global::System.Serializable]
  public partial class ZipCodeAndAddress : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ZipCodeAndAddress Create()
    {
      return new ZipCodeAndAddress();
    }

    public static ZipCodeAndAddress Create(global::System.String zipCode, global::System.String address)
    {
      return new ZipCodeAndAddress
      {
        ZipCode = zipCode,
        Address = address
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ZipCode != null ? this.ZipCode.GetHashCode() : 0) * 199) ^ ((this.Address != null ? this.Address.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ZipCodeAndAddress)obj);
    }

    public static bool operator ==(ZipCodeAndAddress left, ZipCodeAndAddress right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ZipCodeAndAddress left, ZipCodeAndAddress right)
    {
      return !(left == right);
    }

    protected bool Equals(ZipCodeAndAddress other)
    {
      return object.Equals(this.ZipCode, other.ZipCode)
             && object.Equals(this.Address, other.Address);
    }
  }

  [global::System.Serializable]
  public partial class TaskIterations : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static TaskIterations Create()
    {
      return new TaskIterations();
    }

    public static TaskIterations Create(global::System.DateTime date, global::System.Boolean isRework, global::System.Boolean isRestart)
    {
      return new TaskIterations
      {
        Date = date,
        IsRework = isRework,
        IsRestart = isRestart
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ (this.IsRework.GetHashCode() * 199) ^ (this.IsRestart.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TaskIterations)obj);
    }

    public static bool operator ==(TaskIterations left, TaskIterations right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(TaskIterations left, TaskIterations right)
    {
      return !(left == right);
    }

    protected bool Equals(TaskIterations other)
    {
      return object.Equals(this.Date, other.Date)
             && this.IsRework == other.IsRework
             && this.IsRestart == other.IsRestart;
    }
  }

  [global::System.Serializable]
  public partial class IssuerSubject : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static IssuerSubject Create()
    {
      return new IssuerSubject();
    }

    public static IssuerSubject Create(global::System.String name)
    {
      return new IssuerSubject
      {
        Name = name
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Name != null ? this.Name.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((IssuerSubject)obj);
    }

    public static bool operator ==(IssuerSubject left, IssuerSubject right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(IssuerSubject left, IssuerSubject right)
    {
      return !(left == right);
    }

    protected bool Equals(IssuerSubject other)
    {
      return object.Equals(this.Name, other.Name);
    }
  }

  [global::System.Serializable]
  public partial class DocumentToSetStorage : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static DocumentToSetStorage Create()
    {
      return new DocumentToSetStorage();
    }

    public static DocumentToSetStorage Create(global::System.Int32 documentId, global::System.Int32 storageId)
    {
      return new DocumentToSetStorage
      {
        DocumentId = documentId,
        StorageId = storageId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.DocumentId.GetHashCode() * 199) ^ (this.StorageId.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentToSetStorage)obj);
    }

    public static bool operator ==(DocumentToSetStorage left, DocumentToSetStorage right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentToSetStorage left, DocumentToSetStorage right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentToSetStorage other)
    {
      return this.DocumentId == other.DocumentId
             && this.StorageId == other.StorageId;
    }
  }
}