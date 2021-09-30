
// ==================================================================
// DocumentGrantRightsQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class DocumentGrantRightsQueueItem :
    global::Sungero.ExchangeCore.Client.QueueItemBase, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("de73a02c-c1bf-4edf-bee4-bf2705d282b8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DocumentGrantRightsQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentGrantRightsQueueItem, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemState State
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentGrantRightsQueueItemState(this);
    }

    public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _DocumentId;

        public virtual global::System.Int32? DocumentId
        {
          get { return this._DocumentId.Value; }
          set { this._DocumentId.Value = value; }
        }
        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _ChangedEntityType;

        public virtual global::Sungero.Core.Enumeration? ChangedEntityType
        {
          get { return this._ChangedEntityType.Value; }
          set { this._ChangedEntityType.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ChangedEntityTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.DocumentGrantRightsQueueItem.ChangedEntityType),
          typeof(global::Sungero.Docflow.Client.DocumentGrantRightsQueueItem),
          "ChangedEntityType");

        public static global::Sungero.Domain.Shared.EnumerationItems ChangedEntityTypeItems
        {
          get { return global::Sungero.Docflow.Client.DocumentGrantRightsQueueItem._ChangedEntityTypeItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems ChangedEntityTypeAllowedItems
        {
          get { return global::Sungero.Docflow.Client.DocumentGrantRightsQueueItem.ChangedEntityTypeItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IAccessRightsRule> _AccessRightsRule;

              public virtual global::Sungero.Docflow.IAccessRightsRule AccessRightsRule
              {
              get
              {
                return this._AccessRightsRule.Value as global::Sungero.Docflow.IAccessRightsRule;
              }

              set
              {
                (this._AccessRightsRule as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentGrantRightsQueueItemFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentGrantRightsQueueItemClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }

    protected void AccessRightsRuleChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentGrantRightsQueueItemAccessRightsRuleChangedEventArgs(this.State.Properties.AccessRightsRule, this.AccessRightsRule, this);
     ((global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers)this.SharedHandlers).AccessRightsRuleChanged(args);
    }

    protected void ChangedEntityTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ChangedEntityType, this.ChangedEntityType, this);
     ((global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers)this.SharedHandlers).ChangedEntityTypeChanged(args);
    }



  protected global::System.Int32? DocumentIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.DocumentId, value, this, this.Info.Properties.DocumentId);
    ((global::Sungero.Docflow.DocumentGrantRightsQueueItemClientHandlers)this.Handlers).DocumentIdValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Docflow.IAccessRightsRule AccessRightsRuleValueInputHandler(global::Sungero.Docflow.IAccessRightsRule value)
  {
    var args = new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemAccessRightsRuleValueInputEventArgs(this.AccessRightsRule, value, this, this.Info.Properties.AccessRightsRule);
    ((global::Sungero.Docflow.DocumentGrantRightsQueueItemClientHandlers)this.Handlers).AccessRightsRuleValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? ChangedEntityTypeValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.ChangedEntityType, value, this, this.Info.Properties.ChangedEntityType);
    ((global::Sungero.Docflow.DocumentGrantRightsQueueItemClientHandlers)this.Handlers).ChangedEntityTypeValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ChangedEntityTypeFilteringHandler()
  {
    return ((global::Sungero.Docflow.DocumentGrantRightsQueueItemClientHandlers)this.Handlers).ChangedEntityTypeFiltering(this.ChangedEntityTypeAllowedItems);
  }


    #endregion

    #region Constructors





              protected virtual void InitAccessRightsRuleNavigationProperty()
              {
                this._AccessRightsRule = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IAccessRightsRule>("AccessRightsRule", this);
                this._AccessRightsRule.ValueChanged += (sender, e) => { this.AccessRightsRuleChangedHandler(); };
                this.AddProperty(this._AccessRightsRule as global::Sungero.Domain.Client.IProperty);
              }




    public DocumentGrantRightsQueueItem()
    {
            this._DocumentId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("DocumentId", this);
            this._DocumentId.ValueChanged += (sender, e) => { this.DocumentIdChangedHandler(); };
            this.AddProperty(this._DocumentId);

            this._ChangedEntityType = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("ChangedEntityType", this);
            this._ChangedEntityType.ValueChanged += (sender, e) => { this.ChangedEntityTypeChangedHandler(); };
            this.AddProperty(this._ChangedEntityType);

            this.InitAccessRightsRuleNavigationProperty();








    }

    #endregion

  }
}

// ==================================================================
// DocumentGrantRightsQueueItemPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class DocumentGrantRightsQueueItemPresenter<T> :
    global::Sungero.ExchangeCore.Client.QueueItemBasePresenter<T>
    where T : class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    #region Fields and properties




    #endregion

    #region Methods

    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AccessRightsRuleCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AccessRightsRuleCollectionPresenter
              {
          get { return this._AccessRightsRuleCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._BoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBoxBase>(() => this.Entity.Id, typeof(T), "Box");

              this._RootBoxCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(T), "RootBox");

                  this._AccessRightsRuleCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Docflow.IAccessRightsRule>(global::System.Guid.Parse("4032f8fe-5af6-4819-b8af-ed8ea1759532"));
              this._AccessRightsRuleCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IAccessRightsRule>(() => this.Entity.Id, typeof(T), "AccessRightsRule");


    }

    public DocumentGrantRightsQueueItemPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DocumentGrantRightsQueueItemCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class DocumentGrantRightsQueueItemCollectionPresenter<T> : 
    global::Sungero.ExchangeCore.Client.QueueItemBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DocumentGrantRightsQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DocumentGrantRightsQueueItemCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DocumentGrantRightsQueueItemCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DocumentGrantRightsQueueItemCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DocumentGrantRightsQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class DocumentGrantRightsQueueItemRepositoryImplementer<T> : 
      global::Sungero.ExchangeCore.Client.QueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentGrantRightsQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentGrantRightsQueueItem
    {
       public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.DocumentGrantRightsQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentGrantRightsQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class DocumentGrantRightsQueueItemAccessRights : 
    Sungero.ExchangeCore.Client.QueueItemBaseAccessRights, Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights
  {

    public DocumentGrantRightsQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentGrantRightsQueueItemTypeAccessRights : 
    Sungero.ExchangeCore.Client.QueueItemBaseTypeAccessRights, Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights
  {

    public DocumentGrantRightsQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}