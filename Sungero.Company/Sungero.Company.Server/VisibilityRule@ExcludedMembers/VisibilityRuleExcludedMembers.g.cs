
// ==================================================================
// VisibilityRuleExcludedMembers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
  public class VisibilityRuleExcludedMembersFilterForRecipient<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Company.IVisibilityRuleExcludedMembers
    where TRootEntity : class, global::Sungero.Company.IVisibilityRule
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Company.VisibilityRuleExcludedMembersRecipientPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ExcludedMembersRecipientFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VisibilityRuleExcludedMembersFilterForRecipient(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class VisibilityRuleExcludedMembersSearchFilterForRecipient<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Company.VisibilityRuleExcludedMembersRecipientSearchPropertyFilteringServerHandler<TQueryEntity>().ExcludedMembersRecipientSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VisibilityRuleExcludedMembersSearchFilterForRecipient(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Company.Server.VisibilityRuleExcludedMembersFilterForRecipient<global::Sungero.CoreEntities.IRecipient, global::Sungero.Company.IVisibilityRuleExcludedMembers, global::Sungero.Company.IVisibilityRule>), "Recipient")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Company.Server.VisibilityRuleExcludedMembersSearchFilterForRecipient<global::Sungero.CoreEntities.IRecipient>), "Recipient")]


  public class VisibilityRuleExcludedMembers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Company.IVisibilityRuleExcludedMembers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("b7dd2935-25a9-4dd2-802b-711cf4549df2");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Server.VisibilityRuleExcludedMembers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IVisibilityRuleExcludedMembers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Company.IVisibilityRuleExcludedMembersState State
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembersState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.VisibilityRuleExcludedMembersState(this);
    }

    public new virtual global::Sungero.Company.IVisibilityRuleExcludedMembersInfo Info
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembersInfo)base.Info; }
    }


    public global::Sungero.Company.IVisibilityRule VisibilityRule { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.VisibilityRule; }
      set { this.VisibilityRule = (global::Sungero.Company.IVisibilityRule)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Company.VisibilityRuleExcludedMembersSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Recipient;
    public virtual global::Sungero.CoreEntities.IRecipient Recipient
    {
      get
      {
        return this._Recipient;
      }

      set
      {
        this.SetPropertyValue("Recipient", this._Recipient, value, (propertyValue) => { this._Recipient = propertyValue; }, this.RecipientChangedHandler);
      }
    }




    #region Framework events

    protected void RecipientChangedHandler()
    {
      var args = new global::Sungero.Company.Shared.VisibilityRuleExcludedMembersRecipientChangedEventArgs(this.State.Properties.Recipient, this.Recipient, this);
     ((global::Sungero.Company.VisibilityRuleExcludedMembersSharedHandlers)this.SharedHandlers).ExcludedMembersRecipientChanged(args);
    }



    #endregion


    public VisibilityRuleExcludedMembers()
    {
    }

  }
}

// ==================================================================
// VisibilityRuleExcludedMembersHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{
  public partial class VisibilityRuleExcludedMembersRecipientPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Company.IVisibilityRuleExcludedMembers _obj
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembers)this.Entity; }
    }

    private global::Sungero.Company.IVisibilityRule _root
    {
      get { return (global::Sungero.Company.IVisibilityRule)this.Root; }
    }

    public VisibilityRuleExcludedMembersRecipientPropertyFilteringServerHandler(global::Sungero.Company.IVisibilityRuleExcludedMembers entity, global::Sungero.Company.IVisibilityRule root)
      : base(entity, root)
    {
    }
  }

  public partial class VisibilityRuleExcludedMembersRecipientSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ExcludedMembersRecipientSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public VisibilityRuleExcludedMembersRecipientSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// VisibilityRuleExcludedMembersEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
}