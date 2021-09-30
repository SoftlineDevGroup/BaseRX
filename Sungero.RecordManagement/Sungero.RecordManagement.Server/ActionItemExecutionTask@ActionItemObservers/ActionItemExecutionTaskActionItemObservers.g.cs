
// ==================================================================
// ActionItemExecutionTaskActionItemObservers.g.cs
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
  public class ActionItemExecutionTaskActionItemObserversFilterForObserver<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers
    where TRootEntity : class, global::Sungero.RecordManagement.IActionItemExecutionTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversObserverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ActionItemObserversObserverFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ActionItemExecutionTaskActionItemObserversFilterForObserver(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ActionItemExecutionTaskActionItemObserversSearchFilterForObserver<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversObserverSearchPropertyFilteringServerHandler<TQueryEntity>().ActionItemObserversObserverSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ActionItemExecutionTaskActionItemObserversSearchFilterForObserver(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemObserversFilterForObserver<global::Sungero.CoreEntities.IRecipient, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers, global::Sungero.RecordManagement.IActionItemExecutionTask>), "Observer")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemObserversSearchFilterForObserver<global::Sungero.CoreEntities.IRecipient>), "Observer")]


  public class ActionItemExecutionTaskActionItemObservers :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("5bb73a81-d4cb-4a63-a00d-fffb8cf91956");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ActionItemExecutionTaskActionItemObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversState State
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemObserversState(this);
    }

    public new virtual global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversInfo Info
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObserversInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemExecutionTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ActionItemExecutionTask; }
      set { this.ActionItemExecutionTask = (global::Sungero.RecordManagement.IActionItemExecutionTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Observer;
    public virtual global::Sungero.CoreEntities.IRecipient Observer
    {
      get
      {
        return this._Observer;
      }

      set
      {
        this.SetPropertyValue("Observer", this._Observer, value, (propertyValue) => { this._Observer = propertyValue; }, this.ObserverChangedHandler);
      }
    }




    #region Framework events

    protected void ObserverChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemObserversObserverChangedEventArgs(this.State.Properties.Observer, this.Observer, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemObserversSharedHandlers)this.SharedHandlers).ActionItemObserversObserverChanged(args);
    }



    #endregion


    public ActionItemExecutionTaskActionItemObservers()
    {
    }

  }
}

// ==================================================================
// ActionItemExecutionTaskActionItemObserversHandlers.g.cs
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
  public partial class ActionItemExecutionTaskActionItemObserversObserverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers)this.Entity; }
    }

    private global::Sungero.RecordManagement.IActionItemExecutionTask _root
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTask)this.Root; }
    }

    public ActionItemExecutionTaskActionItemObserversObserverPropertyFilteringServerHandler(global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemObservers entity, global::Sungero.RecordManagement.IActionItemExecutionTask root)
      : base(entity, root)
    {
    }
  }

  public partial class ActionItemExecutionTaskActionItemObserversObserverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ActionItemObserversObserverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ActionItemExecutionTaskActionItemObserversObserverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ActionItemExecutionTaskActionItemObserversEventArgs.g.cs
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