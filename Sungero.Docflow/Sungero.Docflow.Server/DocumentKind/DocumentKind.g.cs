
// ==================================================================
// DocumentKind.g.cs
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
    public class DocumentKindFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Docflow.IDocumentKind
    {
      protected new global::Sungero.Docflow.IDocumentKindFilterState Filter { get; private set; }

      private global::Sungero.Docflow.IDocumentKindFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public DocumentKindFilter(global::Sungero.Docflow.IDocumentKindFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected DocumentKindFilter()
      {
      }
    }
      public class DocumentKindUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Docflow.IDocumentKind
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class DocumentKindSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Note { get; protected set; }
                  public virtual global::System.Boolean? GenerateDocumentName { get; protected set; }
                  public virtual global::System.Boolean? AutoNumbering { get; protected set; }
                  public virtual global::System.Boolean? ProjectsAccounting { get; protected set; }
                  public virtual global::System.Boolean? GrantRightsToProject { get; protected set; }
                  public virtual global::System.String Code { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> DocumentFlow { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> NumberingType { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentType> DocumentType { get; protected set; }


                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public DocumentKindAvailableActionsModel AvailableActions { get; protected set; }

        }


      public class DocumentKindAvailableActionsModel : global::Sungero.Domain.CollectionPropertySearchDialogModel
          {
            public override global::System.Int32? Id { get; protected set; }


         }



  public class DocumentKindFilterForDocumentType<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentType
    where TSourceEntity : class, global::Sungero.Docflow.IDocumentKind
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.DocumentKindDocumentTypePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).DocumentTypeFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentKindFilterForDocumentType(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class DocumentKindSearchFilterForDocumentType<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentType
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.DocumentKindDocumentTypeSearchPropertyFilteringServerHandler<TQueryEntity>().DocumentTypeSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentKindSearchFilterForDocumentType(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.DocumentKindFilter<global::Sungero.Docflow.IDocumentKind>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.DocumentKindUiFilter<global::Sungero.Docflow.IDocumentKind>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentKindFilterForDocumentType<global::Sungero.Docflow.IDocumentType, global::Sungero.Docflow.IDocumentKind>), "DocumentType")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentKindSearchFilterForDocumentType<global::Sungero.Docflow.IDocumentType>), "DocumentType")]


  public class DocumentKind :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Docflow.IDocumentKind
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentKind.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentKind, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IDocumentKindState State
    {
      get { return (global::Sungero.Docflow.IDocumentKindState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentKindState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentKindInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentKindInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IDocumentKindAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IDocumentKindAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.DocumentKindAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.DocumentKindFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentKindFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentKindServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentKindSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.String _Note;
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }
    private global::System.Int32? _DeadlineInDays;
    public virtual global::System.Int32? DeadlineInDays
    {
      get
      {
        return this._DeadlineInDays;
      }

      set
      {
        this.SetPropertyValue("DeadlineInDays", this._DeadlineInDays, value, (propertyValue) => { this._DeadlineInDays = propertyValue; }, this.DeadlineInDaysChangedHandler);
      }
    }
    private global::System.String _ShortName;
    public virtual global::System.String ShortName
    {
      get
      {
        return this._ShortName;
      }

      set
      {
        this.SetPropertyValue("ShortName", this._ShortName, value, (propertyValue) => { this._ShortName = propertyValue; }, this.ShortNameChangedHandler);
      }
    }
    private global::System.Int32? _DeadlineInHours;
    public virtual global::System.Int32? DeadlineInHours
    {
      get
      {
        return this._DeadlineInHours;
      }

      set
      {
        this.SetPropertyValue("DeadlineInHours", this._DeadlineInHours, value, (propertyValue) => { this._DeadlineInHours = propertyValue; }, this.DeadlineInHoursChangedHandler);
      }
    }
    private global::System.Boolean? _GenerateDocumentName;
    public virtual global::System.Boolean? GenerateDocumentName
    {
      get
      {
        return this._GenerateDocumentName;
      }

      set
      {
        this.SetPropertyValue("GenerateDocumentName", this._GenerateDocumentName, value, (propertyValue) => { this._GenerateDocumentName = propertyValue; }, this.GenerateDocumentNameChangedHandler);
      }
    }
    private global::System.Boolean? _AutoNumbering;
    public virtual global::System.Boolean? AutoNumbering
    {
      get
      {
        return this._AutoNumbering;
      }

      set
      {
        this.SetPropertyValue("AutoNumbering", this._AutoNumbering, value, (propertyValue) => { this._AutoNumbering = propertyValue; }, this.AutoNumberingChangedHandler);
      }
    }
    private global::System.Boolean? _ProjectsAccounting;
    public virtual global::System.Boolean? ProjectsAccounting
    {
      get
      {
        return this._ProjectsAccounting;
      }

      set
      {
        this.SetPropertyValue("ProjectsAccounting", this._ProjectsAccounting, value, (propertyValue) => { this._ProjectsAccounting = propertyValue; }, this.ProjectsAccountingChangedHandler);
      }
    }
    private global::System.Boolean? _GrantRightsToProject;
    public virtual global::System.Boolean? GrantRightsToProject
    {
      get
      {
        return this._GrantRightsToProject;
      }

      set
      {
        this.SetPropertyValue("GrantRightsToProject", this._GrantRightsToProject, value, (propertyValue) => { this._GrantRightsToProject = propertyValue; }, this.GrantRightsToProjectChangedHandler);
      }
    }
    private global::System.Boolean? _IsDefault;
    public virtual global::System.Boolean? IsDefault
    {
      get
      {
        return this._IsDefault;
      }

      set
      {
        this.SetPropertyValue("IsDefault", this._IsDefault, value, (propertyValue) => { this._IsDefault = propertyValue; }, this.IsDefaultChangedHandler);
      }
    }
    private global::System.String _Code;
    public virtual global::System.String Code
    {
      get
      {
        return this._Code;
      }

      set
      {
        this.SetPropertyValue("Code", this._Code, value, (propertyValue) => { this._Code = propertyValue; }, this.CodeChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _DocumentFlowItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.DocumentKind.DocumentFlow),
      typeof(global::Sungero.Docflow.Server.DocumentKind),
      "DocumentFlow");

    public static global::Sungero.Domain.Shared.EnumerationItems DocumentFlowItems
    {
      get { return global::Sungero.Docflow.Server.DocumentKind._DocumentFlowItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems DocumentFlowAllowedItems
    {
      get { return global::Sungero.Docflow.Server.DocumentKind.DocumentFlowItems; }
    }

    private global::Sungero.Core.Enumeration? _DocumentFlow;

    public virtual global::Sungero.Core.Enumeration? DocumentFlow
    {
      get { return this._DocumentFlow; }
      set { this.SetEnumPropertyValue("DocumentFlow", this._DocumentFlow, value, (propertyValue) => { this._DocumentFlow = propertyValue; }, this.DocumentFlowChangedHandler, this.DocumentFlowAllowedItems); }
    }
    private static global::Sungero.Domain.Shared.EnumerationItems _NumberingTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.DocumentKind.NumberingType),
      typeof(global::Sungero.Docflow.Server.DocumentKind),
      "NumberingType");

    public static global::Sungero.Domain.Shared.EnumerationItems NumberingTypeItems
    {
      get { return global::Sungero.Docflow.Server.DocumentKind._NumberingTypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems NumberingTypeAllowedItems
    {
      get { return global::Sungero.Docflow.Server.DocumentKind.NumberingTypeItems; }
    }

    private global::Sungero.Core.Enumeration? _NumberingType;

    public virtual global::Sungero.Core.Enumeration? NumberingType
    {
      get { return this._NumberingType; }
      set { this.SetEnumPropertyValue("NumberingType", this._NumberingType, value, (propertyValue) => { this._NumberingType = propertyValue; }, this.NumberingTypeChangedHandler, this.NumberingTypeAllowedItems); }
    }


    private global::Sungero.Docflow.IDocumentType _DocumentType;
    public virtual global::Sungero.Docflow.IDocumentType DocumentType
    {
      get
      {
        return this._DocumentType;
      }

      set
      {
        this.SetPropertyValue("DocumentType", this._DocumentType, value, (propertyValue) => { this._DocumentType = propertyValue; }, this.DocumentTypeChangedHandler);
      }
    }


    protected global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IDocumentKindAvailableActions> _AvailableActions;

    public virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IDocumentKindAvailableActions> AvailableActions
    {
      get
      {
        if (this._AvailableActions == null)
        {
          this._AvailableActions = this.CreateAvailableActionsCollection();
          this.SetAvailableActionsEventHandlers();
        }
        return this._AvailableActions;
      }

      set
      {
        if (this._AvailableActions != null)
          this.UnsetChildCollectionEventHandlers(this._AvailableActions);

        this._AvailableActions = value;
        this.SetAvailableActionsEventHandlers();
      }
    }

    protected virtual global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IDocumentKindAvailableActions> CreateAvailableActionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IDocumentKindAvailableActions>() { RootEntity = this };
    }

    private void SetAvailableActionsEventHandlers()
    {
      this.SetChildCollectionEventHandlers(this._AvailableActions, "AvailableActions");

      var changeNotifier = (global::Sungero.Domain.Shared.INotifyChildEntityCollectionChanged)this._AvailableActions;
      changeNotifier.Added += this.AvailableActionsAddedHandler;
      changeNotifier.Deleted += this.AvailableActionsDeletedHandler;
      changeNotifier.Added += this.AvailableActionsCollectionUpdateEventHandler;
      changeNotifier.Deleted += this.AvailableActionsCollectionUpdateEventHandler;
      changeNotifier.Updated += this.AvailableActionsCollectionUpdateEventHandler;
    }

    private void AvailableActionsCollectionUpdateEventHandler(object sender, global::Sungero.Domain.Shared.BaseChildEntityEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      if (this.IsPropertyChangedHandlerEnabled)
        this.AvailableActionsChangedHandler();
    }



    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      return new global::Sungero.Docflow.DocumentKindCreatingFromServerHandler((global::Sungero.Docflow.IDocumentKind)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DocumentFlowChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.DocumentFlow, this.DocumentFlow, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).DocumentFlowChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void DeadlineInDaysChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DeadlineInDays, this.DeadlineInDays, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).DeadlineInDaysChanged(args);
    }

    protected void ShortNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ShortName, this.ShortName, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).ShortNameChanged(args);
    }

    protected void DeadlineInHoursChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DeadlineInHours, this.DeadlineInHours, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).DeadlineInHoursChanged(args);
    }

    protected void NumberingTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.NumberingType, this.NumberingType, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).NumberingTypeChanged(args);
    }

    protected void GenerateDocumentNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.GenerateDocumentName, this.GenerateDocumentName, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).GenerateDocumentNameChanged(args);
    }

    protected void AutoNumberingChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AutoNumbering, this.AutoNumbering, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).AutoNumberingChanged(args);
    }

    protected void DocumentTypeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentKindDocumentTypeChangedEventArgs(this.State.Properties.DocumentType, this.DocumentType, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).DocumentTypeChanged(args);
    }

    protected void AvailableActionsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).AvailableActionsChanged(args);
    }

    protected void ProjectsAccountingChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.ProjectsAccounting, this.ProjectsAccounting, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).ProjectsAccountingChanged(args);
    }

    protected void GrantRightsToProjectChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.GrantRightsToProject, this.GrantRightsToProject, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).GrantRightsToProjectChanged(args);
    }

    protected void IsDefaultChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsDefault, this.IsDefault, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).IsDefaultChanged(args);
    }

    protected void CodeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Code, this.Code, this);
     ((global::Sungero.Docflow.DocumentKindSharedHandlers)this.SharedHandlers).CodeChanged(args);
    }



    protected virtual global::Sungero.Docflow.DocumentKindAvailableActionsSharedCollectionHandlers CreateAvailableActionsAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.DocumentKindAvailableActionsSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.Docflow.DocumentKindAvailableActionsSharedCollectionHandlers CreateAvailableActionsDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.Docflow.DocumentKindAvailableActionsSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void AvailableActionsAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {  
      var collectionHandlers = this.CreateAvailableActionsAddedHandler(e);
      if (collectionHandlers != null)
      {
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        collectionHandlers.AvailableActionsAdded(args);
      }
    }

    protected virtual void AvailableActionsDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {  
      var collectionHandlers = this.CreateAvailableActionsDeletedHandler(e);
      if (collectionHandlers != null)
      {
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        collectionHandlers.AvailableActionsDeleted(args);
      }
    }


    #endregion


    public DocumentKind()
    {
    }

  }
}

// ==================================================================
// DocumentKindHandlers.g.cs
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
  public partial class DocumentKindDocumentTypePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentType
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    public DocumentKindDocumentTypePropertyFilteringServerHandler(global::Sungero.Docflow.IDocumentKind entity)
      : base(entity)
    {
    }
  }

  public partial class DocumentKindDocumentTypeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentType
  {

    public virtual global::System.Linq.IQueryable<T> DocumentTypeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public DocumentKindDocumentTypeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class DocumentKindFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Docflow.IDocumentKindFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDocumentKindFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentKindFilteringServerHandler(global::Sungero.Docflow.IDocumentKindFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentKindFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class DocumentKindUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IDocumentKind
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class DocumentKindSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.DocumentKindSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.DocumentKindSearchDialogModel)this.Dialog;
       }
     }

     public DocumentKindSearchDialogServerHandler(global::Sungero.Docflow.Server.DocumentKindSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class DocumentKindServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    public DocumentKindServerHandlers(global::Sungero.Docflow.IDocumentKind entity)
      : base(entity)
    {
    }
  }

  public partial class DocumentKindCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IDocumentKind _source
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Source; }
    }

    private global::Sungero.Docflow.IDocumentKindInfo _info
    {
      get { return (global::Sungero.Docflow.IDocumentKindInfo)this._Info; }
    }

    public DocumentKindCreatingFromServerHandler(global::Sungero.Docflow.IDocumentKind source, global::Sungero.Docflow.IDocumentKindInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// DocumentKindEventArgs.g.cs
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

// ==================================================================
// DocumentKindAccessRights.g.cs
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
  public class DocumentKindAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Docflow.IDocumentKindAccessRights
  {

    public DocumentKindAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentKindTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Docflow.IDocumentKindAccessRights
  {

    public DocumentKindTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DocumentKindRepositoryImplementer.g.cs
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
    public class DocumentKindRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentKindRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentKind 
    {
       public new global::Sungero.Docflow.IDocumentKindAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentKindAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentKindInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentKindInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.DocumentKindTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentKindPanelNavigationFilters.g.cs
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

// ==================================================================
// DocumentKindServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class DocumentKindFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    public DocumentKindFunctions(global::Sungero.Docflow.IDocumentKind entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentKindFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class DocumentKind
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAvailableDocumentKinds(global::Sungero.Docflow.IOfficialDocument document)
    {
      return global::Sungero.Docflow.Server.DocumentKindFunctions.GetAvailableDocumentKinds(document);
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
    internal static  global::Sungero.Docflow.IDocumentKind GetNativeDocumentKind(global::System.Guid externalLink)
    {
      return global::Sungero.Docflow.Server.DocumentKindFunctions.GetNativeDocumentKind(externalLink);
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Docflow.IDocumentKind GetNativeDocumentKindRemote(global::System.Guid externalLink)
    {
      return global::Sungero.Docflow.Server.DocumentKindFunctions.GetNativeDocumentKindRemote(externalLink);
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
    internal static  global::System.Boolean IsExchangeNativeDocumentKind(global::Sungero.Docflow.IDocumentKind documentKind)
    {
      var functions = (global::Sungero.Docflow.Server.DocumentKindFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)documentKind).FunctionsContainer.ServerFunctions;
      return functions.IsExchangeNativeDocumentKind();
    }
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetDocumentKinds()
    {
      return global::Sungero.Docflow.Server.DocumentKindFunctions.GetDocumentKinds();
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Nullable<global::System.DateTime> GetConsiderationDate(global::Sungero.Docflow.IDocumentKind documentKind, global::Sungero.CoreEntities.IUser user)
    {
      return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetConsiderationDate(documentKind, user);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAvailableDocumentKinds(System.Type documentType)
    {
      return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetAvailableDocumentKinds(documentType);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.String> GetDocumentGuids(System.Type documentType)
    {
      return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetDocumentGuids(documentType);
    }

  }
}

// ==================================================================
// DocumentKindServerPublicFunctions.g.cs
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
  public class DocumentKindServerPublicFunctions : global::Sungero.Docflow.Server.IDocumentKindServerPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAvailableDocumentKinds(global::Sungero.Docflow.IOfficialDocument document)
    {
      return global::Sungero.Docflow.Functions.DocumentKind.GetAvailableDocumentKinds(document);
    }
    public global::Sungero.Docflow.IDocumentKind GetNativeDocumentKind(global::System.Guid externalLink)
    {
      return global::Sungero.Docflow.Functions.DocumentKind.GetNativeDocumentKind(externalLink);
    }
  }
}

// ==================================================================
// DocumentKindQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class DocumentKind
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.DocumentKind.DocumentKindQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
