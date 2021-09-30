
// ==================================================================
// ProjectClassifier.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectClassifierFilterForDocumentKind<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
    where TSourceEntity : class, global::Sungero.Projects.IProjectClassifier
    where TRootEntity : class, global::Sungero.Projects.IProject
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Projects.ProjectClassifierDocumentKindPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ClassifierDocumentKindFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ProjectClassifierFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ProjectClassifierSearchFilterForDocumentKind<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Projects.ProjectClassifierDocumentKindSearchPropertyFilteringServerHandler<TQueryEntity>().ClassifierDocumentKindSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ProjectClassifierSearchFilterForDocumentKind(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ProjectClassifierFilterForFolder<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IFolder
    where TSourceEntity : class, global::Sungero.Projects.IProjectClassifier
    where TRootEntity : class, global::Sungero.Projects.IProject
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Projects.ProjectClassifierFolderPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ClassifierFolderFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ProjectClassifierFilterForFolder(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ProjectClassifierSearchFilterForFolder<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IFolder
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Projects.ProjectClassifierFolderSearchPropertyFilteringServerHandler<TQueryEntity>().ClassifierFolderSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ProjectClassifierSearchFilterForFolder(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Projects.Server.ProjectClassifierFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind, global::Sungero.Projects.IProjectClassifier, global::Sungero.Projects.IProject>), "DocumentKind")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Projects.Server.ProjectClassifierSearchFilterForDocumentKind<global::Sungero.Docflow.IDocumentKind>), "DocumentKind")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Projects.Server.ProjectClassifierFilterForFolder<global::Sungero.CoreEntities.IFolder, global::Sungero.Projects.IProjectClassifier, global::Sungero.Projects.IProject>), "Folder")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Projects.Server.ProjectClassifierSearchFilterForFolder<global::Sungero.CoreEntities.IFolder>), "Folder")]


  public class ProjectClassifier :
    global::Sungero.Domain.ChildEntity, global::Sungero.Projects.IProjectClassifier
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fa6cf309-21c1-4c6f-8221-6ad7d332ea33");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Server.ProjectClassifier.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectClassifier, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Projects.IProjectClassifierState State
    {
      get { return (global::Sungero.Projects.IProjectClassifierState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectClassifierState(this);
    }

    public new virtual global::Sungero.Projects.IProjectClassifierInfo Info
    {
      get { return (global::Sungero.Projects.IProjectClassifierInfo)base.Info; }
    }


    public global::Sungero.Projects.IProject Project { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.Project; }
      set { this.Project = (global::Sungero.Projects.IProject)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectClassifierSharedHandlers(this);
    }

    private global::System.String _FolderName;
    public virtual global::System.String FolderName
    {
      get
      {
        return this._FolderName;
      }

      set
      {
        this.SetPropertyValue("FolderName", this._FolderName, value, (propertyValue) => { this._FolderName = propertyValue; }, this.FolderNameChangedHandler);
      }
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
    private global::Sungero.CoreEntities.IFolder _Folder;
    public virtual global::Sungero.CoreEntities.IFolder Folder
    {
      get
      {
        return this._Folder;
      }

      set
      {
        this.SetPropertyValue("Folder", this._Folder, value, (propertyValue) => { this._Folder = propertyValue; }, this.FolderChangedHandler);
      }
    }




    #region Framework events

    protected void FolderNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.FolderName, this.FolderName, this);
     ((global::Sungero.Projects.ProjectClassifierSharedHandlers)this.SharedHandlers).ClassifierFolderNameChanged(args);
    }

    protected void DocumentKindChangedHandler()
    {
      var args = new global::Sungero.Projects.Shared.ProjectClassifierDocumentKindChangedEventArgs(this.State.Properties.DocumentKind, this.DocumentKind, this);
     ((global::Sungero.Projects.ProjectClassifierSharedHandlers)this.SharedHandlers).ClassifierDocumentKindChanged(args);
    }

    protected void FolderChangedHandler()
    {
      var args = new global::Sungero.Projects.Shared.ProjectClassifierFolderChangedEventArgs(this.State.Properties.Folder, this.Folder, this);
     ((global::Sungero.Projects.ProjectClassifierSharedHandlers)this.SharedHandlers).ClassifierFolderChanged(args);
    }



    #endregion


    public ProjectClassifier()
    {
    }

  }
}

// ==================================================================
// ProjectClassifierHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects
{
  public partial class ProjectClassifierDocumentKindPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    private global::Sungero.Projects.IProjectClassifier _obj
    {
      get { return (global::Sungero.Projects.IProjectClassifier)this.Entity; }
    }

    private global::Sungero.Projects.IProject _root
    {
      get { return (global::Sungero.Projects.IProject)this.Root; }
    }

    public ProjectClassifierDocumentKindPropertyFilteringServerHandler(global::Sungero.Projects.IProjectClassifier entity, global::Sungero.Projects.IProject root)
      : base(entity, root)
    {
    }
  }

  public partial class ProjectClassifierDocumentKindSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentKind
  {

    public virtual global::System.Linq.IQueryable<T> ClassifierDocumentKindSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ProjectClassifierDocumentKindSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class ProjectClassifierFolderPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IFolder
  {
    private global::Sungero.Projects.IProjectClassifier _obj
    {
      get { return (global::Sungero.Projects.IProjectClassifier)this.Entity; }
    }

    private global::Sungero.Projects.IProject _root
    {
      get { return (global::Sungero.Projects.IProject)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ClassifierFolderFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ProjectClassifierFolderPropertyFilteringServerHandler(global::Sungero.Projects.IProjectClassifier entity, global::Sungero.Projects.IProject root)
      : base(entity, root)
    {
    }
  }

  public partial class ProjectClassifierFolderSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IFolder
  {

    public virtual global::System.Linq.IQueryable<T> ClassifierFolderSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ProjectClassifierFolderSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ProjectClassifierEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
}
