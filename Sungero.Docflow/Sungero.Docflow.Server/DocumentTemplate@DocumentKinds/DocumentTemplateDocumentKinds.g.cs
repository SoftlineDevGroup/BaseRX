
// ==================================================================
// DocumentTemplateDocumentKinds.g.cs
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
  public class DocumentTemplateDocumentKindsFilterForDocumentKind<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
    where TSourceEntity : class, global::Sungero.Docflow.IDocumentTemplateDocumentKinds
    where TRootEntity : class, global::Sungero.Docflow.IDocumentTemplate
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.DocumentTemplateDocumentKindsDocumentKindPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).DocumentKindsDocumentKindFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentTemplateDocumentKindsFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class DocumentTemplateDocumentKindsSearchFilterForDocumentKind<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.DocumentTemplateDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<TQueryEntity>().DocumentKindsDocumentKindSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentTemplateDocumentKindsSearchFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentTemplateDocumentKindsFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind, global::Sungero.Docflow.IDocumentTemplateDocumentKinds, global::Sungero.Docflow.IDocumentTemplate>), "DocumentKind")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentTemplateDocumentKindsSearchFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind>), "DocumentKind")]


  public class DocumentTemplateDocumentKinds :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IDocumentTemplateDocumentKinds
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("95086795-1b7c-4fc3-83a4-393f5d6520eb");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentTemplateDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentTemplateDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IDocumentTemplateDocumentKindsState State
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateDocumentKindsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentTemplateDocumentKindsState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentTemplateDocumentKindsInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateDocumentKindsInfo)base.Info; }
    }


    public global::Sungero.Docflow.IDocumentTemplate DocumentTemplate { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.DocumentTemplate; }
      set { this.DocumentTemplate = (global::Sungero.Docflow.IDocumentTemplate)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentTemplateDocumentKindsSharedHandlers(this);
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
      var args = new global::Sungero.Docflow.Shared.DocumentTemplateDocumentKindsDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Docflow.DocumentTemplateDocumentKindsSharedHandlers)this.SharedHandlers).DocumentKindsDocumentKindChanged(args);
    }



    #endregion


    public DocumentTemplateDocumentKinds()
    {
    }

  }
}

// ==================================================================
// DocumentTemplateDocumentKindsHandlers.g.cs
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
  public partial class DocumentTemplateDocumentKindsDocumentKindPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    private global::Sungero.Docflow.IDocumentTemplateDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateDocumentKinds)this.Entity; }
    }

    private global::Sungero.Docflow.IDocumentTemplate _root
    {
      get { return (global::Sungero.Docflow.IDocumentTemplate)this.Root; }
    }

    public DocumentTemplateDocumentKindsDocumentKindPropertyFilteringServerHandler(global::Sungero.Docflow.IDocumentTemplateDocumentKinds entity, global::Sungero.Docflow.IDocumentTemplate root)
      : base(entity, root)
    {
    }
  }

  public partial class DocumentTemplateDocumentKindsDocumentKindSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {

    public virtual global::System.Linq.IQueryable<T> DocumentKindsDocumentKindSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public DocumentTemplateDocumentKindsDocumentKindSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// DocumentTemplateDocumentKindsEventArgs.g.cs
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