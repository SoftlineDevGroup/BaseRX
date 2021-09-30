
// ==================================================================
// ApprovalReworkAssignmentApprovers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ApprovalReworkAssignmentApproversFilterForApprover<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalReworkAssignmentApprovers
    where TRootEntity : class, global::Sungero.Docflow.IApprovalReworkAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.ApprovalReworkAssignmentApproversApproverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ApproversApproverFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalReworkAssignmentApproversFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalReworkAssignmentApproversSearchFilterForApprover<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.ApprovalReworkAssignmentApproversApproverSearchPropertyFilteringServerHandler<TQueryEntity>().ApproversApproverSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalReworkAssignmentApproversSearchFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentApproversFilterForApprover<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IApprovalReworkAssignmentApprovers, global::Sungero.Docflow.IApprovalReworkAssignment>), "Approver")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentApproversSearchFilterForApprover<global::Sungero.CoreEntities.IRecipient>), "Approver")]


  public class ApprovalReworkAssignmentApprovers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalReworkAssignmentApprovers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ad3d2bfd-0bcd-4d74-8a13-1368666d7963");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalReworkAssignmentApprovers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalReworkAssignmentApproversState State
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentApproversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentApproversState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalReworkAssignmentApproversInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentApproversInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalReworkAssignment ApprovalReworkAssignment { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalReworkAssignment; }
      set { this.ApprovalReworkAssignment = (global::Sungero.Docflow.IApprovalReworkAssignment)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalReworkAssignmentApproversSharedHandlers(this);
    }

    private global::System.Boolean? _IsRequiredApprover;
    public virtual global::System.Boolean? IsRequiredApprover
    {
      get
      {
        return this._IsRequiredApprover;
      }

      set
      {
        this.SetPropertyValue("IsRequiredApprover", this._IsRequiredApprover, value, (propertyValue) => { this._IsRequiredApprover = propertyValue; }, this.IsRequiredApproverChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ApprovedItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.ApprovalReworkAssignmentApprovers.Approved),
      typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers),
      "Approved");

    public static global::Sungero.Domain.Shared.EnumerationItems ApprovedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers._ApprovedItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems ApprovedAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers.ApprovedItems; }
    }

    private global::Sungero.Core.Enumeration? _Approved;

    public virtual global::Sungero.Core.Enumeration? Approved
    {
      get { return this._Approved; }
      set { this.SetEnumPropertyValue("Approved", this._Approved, value, (propertyValue) => { this._Approved = propertyValue; }, this.ApprovedChangedHandler, this.ApprovedAllowedItems); }
    }
    private static global::Sungero.Domain.Shared.EnumerationItems _ActionItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.ApprovalReworkAssignmentApprovers.Action),
      typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers),
      "Action");

    public static global::Sungero.Domain.Shared.EnumerationItems ActionItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers._ActionItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems ActionAllowedItems
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentApprovers.ActionItems; }
    }

    private global::Sungero.Core.Enumeration? _Action;

    public virtual global::Sungero.Core.Enumeration? Action
    {
      get { return this._Action; }
      set { this.SetEnumPropertyValue("Action", this._Action, value, (propertyValue) => { this._Action = propertyValue; }, this.ActionChangedHandler, this.ActionAllowedItems); }
    }


    private global::Sungero.Company.IEmployee _Approver;
    public virtual global::Sungero.Company.IEmployee Approver
    {
      get
      {
        return this._Approver;
      }

      set
      {
        this.SetPropertyValue("Approver", this._Approver, value, (propertyValue) => { this._Approver = propertyValue; }, this.ApproverChangedHandler);
      }
    }




    #region Framework events

    protected void ApproverChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversApproverChanged(args);
    }

    protected void ApprovedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Approved, this.Approved, this);
     ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversApprovedChanged(args);
    }

    protected void ActionChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Action, this.Action, this);
     ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversActionChanged(args);
    }

    protected void IsRequiredApproverChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsRequiredApprover, this.IsRequiredApprover, this);
     ((global::Sungero.Docflow.ApprovalReworkAssignmentApproversSharedHandlers)this.SharedHandlers).ApproversIsRequiredApproverChanged(args);
    }



    #endregion


    public ApprovalReworkAssignmentApprovers()
    {
    }

  }
}

// ==================================================================
// ApprovalReworkAssignmentApproversHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class ApprovalReworkAssignmentApproversApproverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IApprovalReworkAssignmentApprovers _obj
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentApprovers)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalReworkAssignment _root
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignment)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ApproversApproverFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalReworkAssignmentApproversApproverPropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalReworkAssignmentApprovers entity, global::Sungero.Docflow.IApprovalReworkAssignment root)
      : base(entity, root)
    {
    }
  }

  public partial class ApprovalReworkAssignmentApproversApproverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ApproversApproverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalReworkAssignmentApproversApproverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ApprovalReworkAssignmentApproversEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}
