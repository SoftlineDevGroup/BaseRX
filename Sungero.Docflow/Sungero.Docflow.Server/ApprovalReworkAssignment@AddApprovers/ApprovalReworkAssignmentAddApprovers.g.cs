
// ==================================================================
// ApprovalReworkAssignmentAddApprovers.g.cs
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
  public class ApprovalReworkAssignmentAddApproversFilterForApprover<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.Docflow.IApprovalReworkAssignmentAddApprovers
    where TRootEntity : class, global::Sungero.Docflow.IApprovalReworkAssignment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.ApprovalReworkAssignmentAddApproversApproverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).AddApproversApproverFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalReworkAssignmentAddApproversFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ApprovalReworkAssignmentAddApproversSearchFilterForApprover<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.ApprovalReworkAssignmentAddApproversApproverSearchPropertyFilteringServerHandler<TQueryEntity>().AddApproversApproverSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ApprovalReworkAssignmentAddApproversSearchFilterForApprover(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentAddApproversFilterForApprover<global::Sungero.Company.IEmployee, global::Sungero.Docflow.IApprovalReworkAssignmentAddApprovers, global::Sungero.Docflow.IApprovalReworkAssignment>), "Approver")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ApprovalReworkAssignmentAddApproversSearchFilterForApprover<global::Sungero.CoreEntities.IRecipient>), "Approver")]


  public class ApprovalReworkAssignmentAddApprovers :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IApprovalReworkAssignmentAddApprovers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c97a3040-e94f-48af-97dd-471d94525691");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalReworkAssignmentAddApprovers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalReworkAssignmentAddApprovers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalReworkAssignmentAddApproversState State
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentAddApproversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentAddApproversState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalReworkAssignmentAddApproversInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentAddApproversInfo)base.Info; }
    }


    public global::Sungero.Docflow.IApprovalReworkAssignment ApprovalReworkAssignment { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalReworkAssignment; }
      set { this.ApprovalReworkAssignment = (global::Sungero.Docflow.IApprovalReworkAssignment)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalReworkAssignmentAddApproversSharedHandlers(this);
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
      var args = new global::Sungero.Docflow.Shared.ApprovalReworkAssignmentAddApproversApproverChangedEventArgs(this.State.Properties.Approver, this.Approver, this);
     ((global::Sungero.Docflow.ApprovalReworkAssignmentAddApproversSharedHandlers)this.SharedHandlers).AddApproversApproverChanged(args);
    }



    #endregion


    public ApprovalReworkAssignmentAddApprovers()
    {
    }

  }
}

// ==================================================================
// ApprovalReworkAssignmentAddApproversHandlers.g.cs
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
  public partial class ApprovalReworkAssignmentAddApproversApproverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.Docflow.IApprovalReworkAssignmentAddApprovers _obj
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignmentAddApprovers)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalReworkAssignment _root
    {
      get { return (global::Sungero.Docflow.IApprovalReworkAssignment)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> AddApproversApproverFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalReworkAssignmentAddApproversApproverPropertyFilteringServerHandler(global::Sungero.Docflow.IApprovalReworkAssignmentAddApprovers entity, global::Sungero.Docflow.IApprovalReworkAssignment root)
      : base(entity, root)
    {
    }
  }

  public partial class ApprovalReworkAssignmentAddApproversApproverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> AddApproversApproverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ApprovalReworkAssignmentAddApproversApproverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ApprovalReworkAssignmentAddApproversEventArgs.g.cs
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