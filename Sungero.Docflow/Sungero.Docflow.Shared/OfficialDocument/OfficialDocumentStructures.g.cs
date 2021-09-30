namespace Sungero.Docflow.Structures.OfficialDocument
{
  public partial class DialogResult : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DialogResult Create()
    {
      return new DialogResult();
    }

    public static DialogResult Create(global::Sungero.Docflow.IDocumentRegister register, global::System.DateTime date, global::System.String number)
    {
      return new DialogResult
      {
        Register = register,
        Date = date,
        Number = number
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Register != null ? this.Register.GetHashCode() : 0) * 199) ^ ((this.Date != null ? this.Date.GetHashCode() : 0) * 199) ^ ((this.Number != null ? this.Number.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DialogResult)obj);
    }

    public static bool operator ==(DialogResult left, DialogResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DialogResult left, DialogResult right)
    {
      return !(left == right);
    }

    protected bool Equals(DialogResult other)
    {
      return object.Equals(this.Register, other.Register)
             && object.Equals(this.Date, other.Date)
             && object.Equals(this.Number, other.Number);
    }
  }

  public partial class DialogParams : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static DialogParams Create()
    {
      return new DialogParams();
    }

    public static DialogParams Create(global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentRegister> registers, global::Sungero.Core.Enumeration operation, global::Sungero.Docflow.IDocumentRegister defaultRegister, global::System.String currentRegistrationNumber, global::System.Nullable<global::System.DateTime> currentRegistrationDate, global::System.String nextNumber, global::System.Int32 leadId, global::System.String leadNumber, global::System.Boolean isNumberValidationDisabled, global::System.Int32 departmentId, global::System.String departmentCode, global::System.String businessUnitCode, global::System.Int32 businessUnitId, global::System.String caseFileIndex, global::System.String docKindCode, global::System.String counterpartyCode, global::System.Boolean isClerk)
    {
      return new DialogParams
      {
        Registers = registers,
        Operation = operation,
        DefaultRegister = defaultRegister,
        CurrentRegistrationNumber = currentRegistrationNumber,
        CurrentRegistrationDate = currentRegistrationDate,
        NextNumber = nextNumber,
        LeadId = leadId,
        LeadNumber = leadNumber,
        IsNumberValidationDisabled = isNumberValidationDisabled,
        DepartmentId = departmentId,
        DepartmentCode = departmentCode,
        BusinessUnitCode = businessUnitCode,
        BusinessUnitId = businessUnitId,
        CaseFileIndex = caseFileIndex,
        DocKindCode = docKindCode,
        CounterpartyCode = counterpartyCode,
        IsClerk = isClerk
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Registers != null ? this.Registers.GetHashCode() : 0) * 199) ^ ((this.Operation != null ? this.Operation.GetHashCode() : 0) * 199) ^ ((this.DefaultRegister != null ? this.DefaultRegister.GetHashCode() : 0) * 199) ^ ((this.CurrentRegistrationNumber != null ? this.CurrentRegistrationNumber.GetHashCode() : 0) * 199) ^ ((this.CurrentRegistrationDate != null ? this.CurrentRegistrationDate.GetHashCode() : 0) * 199) ^ ((this.NextNumber != null ? this.NextNumber.GetHashCode() : 0) * 199) ^ (this.LeadId.GetHashCode() * 199) ^ ((this.LeadNumber != null ? this.LeadNumber.GetHashCode() : 0) * 199) ^ (this.IsNumberValidationDisabled.GetHashCode() * 199) ^ (this.DepartmentId.GetHashCode() * 199) ^ ((this.DepartmentCode != null ? this.DepartmentCode.GetHashCode() : 0) * 199) ^ ((this.BusinessUnitCode != null ? this.BusinessUnitCode.GetHashCode() : 0) * 199) ^ (this.BusinessUnitId.GetHashCode() * 199) ^ ((this.CaseFileIndex != null ? this.CaseFileIndex.GetHashCode() : 0) * 199) ^ ((this.DocKindCode != null ? this.DocKindCode.GetHashCode() : 0) * 199) ^ ((this.CounterpartyCode != null ? this.CounterpartyCode.GetHashCode() : 0) * 199) ^ (this.IsClerk.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DialogParams)obj);
    }

    public static bool operator ==(DialogParams left, DialogParams right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DialogParams left, DialogParams right)
    {
      return !(left == right);
    }

    protected bool Equals(DialogParams other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Registers, other.Registers)
             && object.Equals(this.Operation, other.Operation)
             && object.Equals(this.DefaultRegister, other.DefaultRegister)
             && object.Equals(this.CurrentRegistrationNumber, other.CurrentRegistrationNumber)
             && object.Equals(this.CurrentRegistrationDate, other.CurrentRegistrationDate)
             && object.Equals(this.NextNumber, other.NextNumber)
             && this.LeadId == other.LeadId
             && object.Equals(this.LeadNumber, other.LeadNumber)
             && this.IsNumberValidationDisabled == other.IsNumberValidationDisabled
             && this.DepartmentId == other.DepartmentId
             && object.Equals(this.DepartmentCode, other.DepartmentCode)
             && object.Equals(this.BusinessUnitCode, other.BusinessUnitCode)
             && this.BusinessUnitId == other.BusinessUnitId
             && object.Equals(this.CaseFileIndex, other.CaseFileIndex)
             && object.Equals(this.DocKindCode, other.DocKindCode)
             && object.Equals(this.CounterpartyCode, other.CounterpartyCode)
             && this.IsClerk == other.IsClerk;
    }
  }

  [global::System.Serializable]
  public partial class СonversionToPdfResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static СonversionToPdfResult Create()
    {
      return new СonversionToPdfResult();
    }

    public static СonversionToPdfResult Create(global::System.Boolean isFastConvertion, global::System.Boolean isOnConvertion, global::System.Boolean hasErrors, global::System.Boolean hasConvertionError, global::System.Boolean hasLockError, global::System.String errorTitle, global::System.String errorMessage)
    {
      return new СonversionToPdfResult
      {
        IsFastConvertion = isFastConvertion,
        IsOnConvertion = isOnConvertion,
        HasErrors = hasErrors,
        HasConvertionError = hasConvertionError,
        HasLockError = hasLockError,
        ErrorTitle = errorTitle,
        ErrorMessage = errorMessage
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.IsFastConvertion.GetHashCode() * 199) ^ (this.IsOnConvertion.GetHashCode() * 199) ^ (this.HasErrors.GetHashCode() * 199) ^ (this.HasConvertionError.GetHashCode() * 199) ^ (this.HasLockError.GetHashCode() * 199) ^ ((this.ErrorTitle != null ? this.ErrorTitle.GetHashCode() : 0) * 199) ^ ((this.ErrorMessage != null ? this.ErrorMessage.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((СonversionToPdfResult)obj);
    }

    public static bool operator ==(СonversionToPdfResult left, СonversionToPdfResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(СonversionToPdfResult left, СonversionToPdfResult right)
    {
      return !(left == right);
    }

    protected bool Equals(СonversionToPdfResult other)
    {
      return this.IsFastConvertion == other.IsFastConvertion
             && this.IsOnConvertion == other.IsOnConvertion
             && this.HasErrors == other.HasErrors
             && this.HasConvertionError == other.HasConvertionError
             && this.HasLockError == other.HasLockError
             && object.Equals(this.ErrorTitle, other.ErrorTitle)
             && object.Equals(this.ErrorMessage, other.ErrorMessage);
    }
  }

  [global::System.Serializable]
  public partial class RecognizedProperty : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RecognizedProperty Create()
    {
      return new RecognizedProperty();
    }

    public static RecognizedProperty Create(global::System.String name, global::System.Nullable<global::System.Double> probability, global::System.String position)
    {
      return new RecognizedProperty
      {
        Name = name,
        Probability = probability,
        Position = position
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ ((this.Probability != null ? this.Probability.GetHashCode() : 0) * 199) ^ ((this.Position != null ? this.Position.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RecognizedProperty)obj);
    }

    public static bool operator ==(RecognizedProperty left, RecognizedProperty right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RecognizedProperty left, RecognizedProperty right)
    {
      return !(left == right);
    }

    protected bool Equals(RecognizedProperty other)
    {
      return object.Equals(this.Name, other.Name)
             && object.Equals(this.Probability, other.Probability)
             && object.Equals(this.Position, other.Position);
    }
  }
}