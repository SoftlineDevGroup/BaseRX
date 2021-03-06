
// ==================================================================
// ActionItemExecutionTaskActionItemParts.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class ActionItemExecutionTaskActionItemPartsFilterForAssignee<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IEmployee
    where TSourceEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts
    where TRootEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsAssigneePropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ActionItemPartsAssigneeFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ActionItemExecutionTaskActionItemPartsFilterForAssignee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ActionItemExecutionTaskActionItemPartsSearchFilterForAssignee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsAssigneeSearchPropertyFilteringServerHandler<TQueryEntity>().ActionItemPartsAssigneeSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ActionItemExecutionTaskActionItemPartsSearchFilterForAssignee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ActionItemExecutionTaskActionItemPartsFilterForActionItemPartExecutionTask<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTask
    where TSourceEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts
    where TRootEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ActionItemPartsActionItemPartExecutionTaskFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ActionItemExecutionTaskActionItemPartsFilterForActionItemPartExecutionTask(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ActionItemExecutionTaskActionItemPartsSearchFilterForActionItemPartExecutionTask<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskSearchPropertyFilteringServerHandler<TQueryEntity>().ActionItemPartsActionItemPartExecutionTaskSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ActionItemExecutionTaskActionItemPartsSearchFilterForActionItemPartExecutionTask(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemPartsFilterForAssignee<global::Sungero.Company.IEmployee, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts, global::Sungero.RecordManagement.IActionItemExecutionTask>), "Assignee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemPartsSearchFilterForAssignee<global::Sungero.CoreEntities.IRecipient>), "Assignee")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemPartsFilterForActionItemPartExecutionTask<global::Sungero.RecordManagement.IActionItemExecutionTask, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts, global::Sungero.RecordManagement.IActionItemExecutionTask>), "ActionItemPartExecutionTask")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemPartsSearchFilterForActionItemPartExecutionTask<global::Sungero.RecordManagement.IActionItemExecutionTask>), "ActionItemPartExecutionTask")]


  public class ActionItemExecutionTaskActionItemParts :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e2e199fe-7c2e-403f-8986-7a6801f86191");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemParts.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsState State
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsState(this);
    }

    public new virtual global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsInfo Info
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemExecutionTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ActionItemExecutionTask; }
      set { this.ActionItemExecutionTask = (global::Sungero.RecordManagement.IActionItemExecutionTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers(this);
    }

    private global::System.DateTime? _Deadline;
    public virtual global::System.DateTime? Deadline
    {
      get
      {
        return this._Deadline;
      }

      set
      {
        this.SetPropertyValue("Deadline", this._Deadline, value, (propertyValue) => { this._Deadline = propertyValue; }, this.DeadlineChangedHandler);
      }
    }
    private global::System.Int32? _Number;
    public virtual global::System.Int32? Number
    {
      get
      {
        return this._Number;
      }

      set
      {
        this.SetPropertyValue("Number", this._Number, value, (propertyValue) => { this._Number = propertyValue; }, this.NumberChangedHandler);
      }
    }
    private global::System.Boolean? _AssignmentCreated;
    public virtual global::System.Boolean? AssignmentCreated
    {
      get
      {
        return this._AssignmentCreated;
      }

      set
      {
        this.SetPropertyValue("AssignmentCreated", this._AssignmentCreated, value, (propertyValue) => { this._AssignmentCreated = propertyValue; }, this.AssignmentCreatedChangedHandler);
      }
    }



    private global::System.String _ActionItemPart;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.String ActionItemPart
    {
      get
      {
        return this._ActionItemPart;
      }

      set
      {
        this.SetPropertyValue("ActionItemPart", this._ActionItemPart, value, (propertyValue) => { this._ActionItemPart = propertyValue; }, this.ActionItemPartChangedHandler);
      }
    }





    private global::Sungero.Company.IEmployee _Assignee;
    public virtual global::Sungero.Company.IEmployee Assignee
    {
      get
      {
        return this._Assignee;
      }

      set
      {
        this.SetPropertyValue("Assignee", this._Assignee, value, (propertyValue) => { this._Assignee = propertyValue; }, this.AssigneeChangedHandler);
      }
    }
    private global::Sungero.RecordManagement.IActionItemExecutionTask _ActionItemPartExecutionTask;
    public virtual global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemPartExecutionTask
    {
      get
      {
        return this._ActionItemPartExecutionTask;
      }

      set
      {
        this.SetPropertyValue("ActionItemPartExecutionTask", this._ActionItemPartExecutionTask, value, (propertyValue) => { this._ActionItemPartExecutionTask = propertyValue; }, this.ActionItemPartExecutionTaskChangedHandler);
      }
    }




    #region Framework events

    protected void ActionItemPartChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ActionItemPart, this.ActionItemPart, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsActionItemPartChanged(args);
    }

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsAssigneeChanged(args);
    }

    protected void DeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Deadline, this.Deadline, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsDeadlineChanged(args);
    }

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsNumberChanged(args);
    }

    protected void ActionItemPartExecutionTaskChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskChangedEventArgs(this.State.Properties.ActionItemPartExecutionTask, this.ActionItemPartExecutionTask, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsActionItemPartExecutionTaskChanged(args);
    }

    protected void AssignmentCreatedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AssignmentCreated, this.AssignmentCreated, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsAssignmentCreatedChanged(args);
    }



    #endregion


    public ActionItemExecutionTaskActionItemParts()
    {
    }

  }
}

// ==================================================================
// ActionItemExecutionTaskActionItemPartsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{
  public partial class ActionItemExecutionTaskActionItemPartsAssigneePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IEmployee
  {
    private global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts)this.Entity; }
    }

    private global::Sungero.RecordManagement.IActionItemExecutionTask _root
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTask)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ActionItemPartsAssigneeFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ActionItemExecutionTaskActionItemPartsAssigneePropertyFilteringServerHandler(global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts entity, global::Sungero.RecordManagement.IActionItemExecutionTask root)
      : base(entity, root)
    {
    }
  }

  public partial class ActionItemExecutionTaskActionItemPartsAssigneeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ActionItemPartsAssigneeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ActionItemExecutionTaskActionItemPartsAssigneeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.RecordManagement.IActionItemExecutionTask
  {
    private global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts)this.Entity; }
    }

    private global::Sungero.RecordManagement.IActionItemExecutionTask _root
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTask)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ActionItemPartsActionItemPartExecutionTaskFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskPropertyFilteringServerHandler(global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts entity, global::Sungero.RecordManagement.IActionItemExecutionTask root)
      : base(entity, root)
    {
    }
  }

  public partial class ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.RecordManagement.IActionItemExecutionTask
  {

    public virtual global::System.Linq.IQueryable<T> ActionItemPartsActionItemPartExecutionTaskSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ActionItemExecutionTaskActionItemPartsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}
