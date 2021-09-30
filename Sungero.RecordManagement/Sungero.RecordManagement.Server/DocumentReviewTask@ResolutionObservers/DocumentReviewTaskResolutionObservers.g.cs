
// ==================================================================
// DocumentReviewTaskResolutionObservers.g.cs
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
  public class DocumentReviewTaskResolutionObserversFilterForObserver<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers
    where TRootEntity : class, global::Sungero.RecordManagement.IDocumentReviewTask
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversObserverPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ResolutionObserversObserverFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentReviewTaskResolutionObserversFilterForObserver(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class DocumentReviewTaskResolutionObserversSearchFilterForObserver<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversObserverSearchPropertyFilteringServerHandler<TQueryEntity>().ResolutionObserversObserverSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentReviewTaskResolutionObserversSearchFilterForObserver(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.DocumentReviewTaskResolutionObserversFilterForObserver<global::Sungero.CoreEntities.IRecipient, global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers, global::Sungero.RecordManagement.IDocumentReviewTask>), "Observer")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.DocumentReviewTaskResolutionObserversSearchFilterForObserver<global::Sungero.CoreEntities.IRecipient>), "Observer")]


  public class DocumentReviewTaskResolutionObservers :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("67733707-1758-4d72-bc40-0acecb8e9fd8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.DocumentReviewTaskResolutionObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObserversState State
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObserversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskResolutionObserversState(this);
    }

    public new virtual global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObserversInfo Info
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObserversInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IDocumentReviewTask DocumentReviewTask { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.DocumentReviewTask; }
      set { this.DocumentReviewTask = (global::Sungero.RecordManagement.IDocumentReviewTask)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversSharedHandlers(this);
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
      var args = new global::Sungero.RecordManagement.Shared.DocumentReviewTaskResolutionObserversObserverChangedEventArgs(this.State.Properties.Observer, this.Observer, this);
     ((global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversSharedHandlers)this.SharedHandlers).ResolutionObserversObserverChanged(args);
    }



    #endregion


    public DocumentReviewTaskResolutionObservers()
    {
    }

  }
}

// ==================================================================
// DocumentReviewTaskResolutionObserversHandlers.g.cs
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
  public partial class DocumentReviewTaskResolutionObserversObserverPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers)this.Entity; }
    }

    private global::Sungero.RecordManagement.IDocumentReviewTask _root
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Root; }
    }

    public DocumentReviewTaskResolutionObserversObserverPropertyFilteringServerHandler(global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers entity, global::Sungero.RecordManagement.IDocumentReviewTask root)
      : base(entity, root)
    {
    }
  }

  public partial class DocumentReviewTaskResolutionObserversObserverSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ResolutionObserversObserverSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public DocumentReviewTaskResolutionObserversObserverSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// DocumentReviewTaskResolutionObserversEventArgs.g.cs
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
