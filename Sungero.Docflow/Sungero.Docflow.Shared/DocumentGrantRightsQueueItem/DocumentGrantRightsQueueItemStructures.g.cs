namespace Sungero.Docflow.Structures.DocumentGrantRightsQueueItem
{
  [global::System.Serializable]
  public partial class ProxyQueueItem : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ProxyQueueItem Create()
    {
      return new ProxyQueueItem();
    }

    public static ProxyQueueItem Create(global::System.Int32 id, global::System.Guid discriminator, global::System.Int32 documentIdDocflowSungero, global::System.Int32 accessRightsDocflowSungero, global::System.String changedTypeDocflowSungero)
    {
      return new ProxyQueueItem
      {
        Id = id,
        Discriminator = discriminator,
        DocumentId_Docflow_Sungero = documentIdDocflowSungero,
        AccessRights_Docflow_Sungero = accessRightsDocflowSungero,
        ChangedType_Docflow_Sungero = changedTypeDocflowSungero
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Discriminator != null ? this.Discriminator.GetHashCode() : 0) * 199) ^ (this.DocumentId_Docflow_Sungero.GetHashCode() * 199) ^ (this.AccessRights_Docflow_Sungero.GetHashCode() * 199) ^ ((this.ChangedType_Docflow_Sungero != null ? this.ChangedType_Docflow_Sungero.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ProxyQueueItem)obj);
    }

    public static bool operator ==(ProxyQueueItem left, ProxyQueueItem right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ProxyQueueItem left, ProxyQueueItem right)
    {
      return !(left == right);
    }

    protected bool Equals(ProxyQueueItem other)
    {
      return this.Id == other.Id
             && object.Equals(this.Discriminator, other.Discriminator)
             && this.DocumentId_Docflow_Sungero == other.DocumentId_Docflow_Sungero
             && this.AccessRights_Docflow_Sungero == other.AccessRights_Docflow_Sungero
             && object.Equals(this.ChangedType_Docflow_Sungero, other.ChangedType_Docflow_Sungero);
    }
  }
}