namespace Sungero.Parties.Structures.Counterparty
{
  public partial class SendInvitation : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static SendInvitation Create()
    {
      return new SendInvitation();
    }

    public static SendInvitation Create(global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox> boxes, global::Sungero.ExchangeCore.IBusinessUnitBox defaultBox, global::System.Boolean haveAllowedBoxes, global::System.Boolean haveAnyBoxes, global::System.Boolean haveDoubleCounterparty, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IExchangeService> services, global::System.Boolean canSendInivtationFromAnyService, global::System.Boolean canDoAction)
    {
      return new SendInvitation
      {
        Boxes = boxes,
        DefaultBox = defaultBox,
        HaveAllowedBoxes = haveAllowedBoxes,
        HaveAnyBoxes = haveAnyBoxes,
        HaveDoubleCounterparty = haveDoubleCounterparty,
        Services = services,
        CanSendInivtationFromAnyService = canSendInivtationFromAnyService,
        CanDoAction = canDoAction
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Boxes != null ? this.Boxes.GetHashCode() : 0) * 199) ^ ((this.DefaultBox != null ? this.DefaultBox.GetHashCode() : 0) * 199) ^ (this.HaveAllowedBoxes.GetHashCode() * 199) ^ (this.HaveAnyBoxes.GetHashCode() * 199) ^ (this.HaveDoubleCounterparty.GetHashCode() * 199) ^ ((this.Services != null ? this.Services.GetHashCode() : 0) * 199) ^ (this.CanSendInivtationFromAnyService.GetHashCode() * 199) ^ (this.CanDoAction.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SendInvitation)obj);
    }

    public static bool operator ==(SendInvitation left, SendInvitation right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SendInvitation left, SendInvitation right)
    {
      return !(left == right);
    }

    protected bool Equals(SendInvitation other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Boxes, other.Boxes)
             && object.Equals(this.DefaultBox, other.DefaultBox)
             && this.HaveAllowedBoxes == other.HaveAllowedBoxes
             && this.HaveAnyBoxes == other.HaveAnyBoxes
             && this.HaveDoubleCounterparty == other.HaveDoubleCounterparty
             && global::System.Linq.Enumerable.SequenceEqual(this.Services, other.Services)
             && this.CanSendInivtationFromAnyService == other.CanSendInivtationFromAnyService
             && this.CanDoAction == other.CanDoAction;
    }
  }

  public partial class AllowedBoxes : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static AllowedBoxes Create()
    {
      return new AllowedBoxes();
    }

    public static AllowedBoxes Create(global::Sungero.ExchangeCore.IBusinessUnitBox box, global::System.Collections.Generic.List<global::System.String> organizationIds)
    {
      return new AllowedBoxes
      {
        Box = box,
        OrganizationIds = organizationIds
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Box != null ? this.Box.GetHashCode() : 0) * 199) ^ ((this.OrganizationIds != null ? this.OrganizationIds.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AllowedBoxes)obj);
    }

    public static bool operator ==(AllowedBoxes left, AllowedBoxes right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AllowedBoxes left, AllowedBoxes right)
    {
      return !(left == right);
    }

    protected bool Equals(AllowedBoxes other)
    {
      return object.Equals(this.Box, other.Box)
             && global::System.Linq.Enumerable.SequenceEqual(this.OrganizationIds, other.OrganizationIds);
    }
  }
}