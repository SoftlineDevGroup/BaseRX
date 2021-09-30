
// ==================================================================
// StoragePolicyBaseDocumentKinds.g.cs
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
  public class StoragePolicyBaseDocumentKindsFilterForDocumentKind<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
    where TSourceEntity : class, global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds
    where TRootEntity : class, global::Sungero.Docflow.IStoragePolicyBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.StoragePolicyBaseDocumentKindsDocumentKindPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).DocumentKindsDocumentKindFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public StoragePolicyBaseDocumentKindsFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class StoragePolicyBaseDocumentKindsSearchFilterForDocumentKind<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.StoragePolicyBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<TQueryEntity>().DocumentKindsDocumentKindSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public StoragePolicyBaseDocumentKindsSearchFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.StoragePolicyBaseDocumentKindsFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind, global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds, global::Sungero.Docflow.IStoragePolicyBase>), "DocumentKind")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.StoragePolicyBaseDocumentKindsSearchFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind>), "DocumentKind")]


  public class StoragePolicyBaseDocumentKinds :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("112c0e12-b9ae-415d-9982-64a2df7cd193");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.StoragePolicyBaseDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IStoragePolicyBaseDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IStoragePolicyBaseDocumentKindsState State
    {
      get { return (global::Sungero.Docflow.IStoragePolicyBaseDocumentKindsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.StoragePolicyBaseDocumentKindsState(this);
    }

    public new virtual global::Sungero.Docflow.IStoragePolicyBaseDocumentKindsInfo Info
    {
      get { return (global::Sungero.Docflow.IStoragePolicyBaseDocumentKindsInfo)base.Info; }
    }


    public global::Sungero.Docflow.IStoragePolicyBase StoragePolicyBase { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.StoragePolicyBase; }
      set { this.StoragePolicyBase = (global::Sungero.Docflow.IStoragePolicyBase)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.StoragePolicyBaseDocumentKindsSharedHandlers(this);
    }







    private global::Sungero.Docflow.IDocumentKind _DocumentKind;
    public virtual global::Sungero.Docflow.IDocumentKind DocumentKind
    {
      get
      {
        return this._DocumentKind;
      }

      set
      {
        this.SetPropertyValue("DocumentKind", this._DocumentKind, value, (propertyValue) => { this._DocumentKind = propertyValue; }, this.DocumentKindChangedHandler);
      }
    }




    #region Framework events

    protected void DocumentKindChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.StoragePolicyBaseDocumentKindsDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Docflow.StoragePolicyBaseDocumentKindsSharedHandlers)this.SharedHandlers).DocumentKindsDocumentKindChanged(args);
    }



    #endregion


    public StoragePolicyBaseDocumentKinds()
    {
    }

  }
}

// ==================================================================
// StoragePolicyBaseDocumentKindsHandlers.g.cs
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
  public partial class StoragePolicyBaseDocumentKindsDocumentKindPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    private global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds)this.Entity; }
    }

    private global::Sungero.Docflow.IStoragePolicyBase _root
    {
      get { return (global::Sungero.Docflow.IStoragePolicyBase)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public StoragePolicyBaseDocumentKindsDocumentKindPropertyFilteringServerHandler(global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds entity, global::Sungero.Docflow.IStoragePolicyBase root)
      : base(entity, root)
    {
    }
  }

  public partial class StoragePolicyBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public StoragePolicyBaseDocumentKindsDocumentKindSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// StoragePolicyBaseDocumentKindsEventArgs.g.cs
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