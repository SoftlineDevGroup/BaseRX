
// ==================================================================
// ApprovalReworkAssignmentRegApprovers.g.cs
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
  public class ApprovalReworkAssignmentRegApproversFilterForApprover<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers
    where TRootEntity : class, global::Sungero.Docflow.IApprovalReworkAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversApproverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).RegApproversApproverFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalReworkAssignmentRegApproversFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalReworkAssignmentRegApproversSearchFilterForApprover<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversApproverSearchPropertyFilteringServerHandler<TQueryEntity>().RegApproversApproverSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalReworkAssignmentRegApproversSearchFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentRegApproversFilterForApprover<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers, global::Sungero.Docflow.IApprovalReworkAssignment>), "Approver")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentRegApproversSearchFilterForApprover<global::Sungero.CoreEntities.IRecipient>), "Approver")]


  public class ApprovalReworkAssignmentRegApprovers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("d534f771-4e5b-4846-81cf-9b8fd4ad754d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentRegApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalReworkAssignmentRegApprovers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversState State
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentRegApproversState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentRegApproversInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalReworkAssignment ApprovalReworkAssignment { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalReworkAssignment; }
      set { this.ApprovalReworkAssignment = (global::Sungero.Docflow.IApprovalReworkAssignment)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversSharedHandlers(this);
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
      var args = new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentRegApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.ApprovalReworkAssignmentRegApproversSharedHandlers)this.SharedHandlers).RegApproversApproverChanged(args);
    }



    #endregion


    public ApprovalReworkAssignmentRegApprovers()
    {
    }

  }
}

// ==================================================================
// ApprovalReworkAssignmentRegApproversHandlers.g.cs
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
  public partial class ApprovalReworkAssignmentRegApproversApproverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers _obj
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalReworkAssignment _root
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignment)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> RegApproversApproverFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalReworkAssignmentRegApproversApproverPropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalReworkAssignmentRegApprovers entity, global::Sungero.Docflow.IApprovalReworkAssignment root)
      : base(entity, root)
    {
    }
  }

  public partial class ApprovalReworkAssignmentRegApproversApproverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> RegApproversApproverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalReworkAssignmentRegApproversApproverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ApprovalReworkAssignmentRegApproversEventArgs.g.cs
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