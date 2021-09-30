
// ==================================================================
// ContractCondition.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractCondition :
    global::Sungero.Docflow.Client.ConditionBase, global::Sungero.Contracts.IContractCondition
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0523387b-a689-41e5-bed3-95892df6922c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ContractCondition.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractCondition, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Contracts.IContractConditionState State
    {
      get
      {
        return (global::Sungero.Contracts.IContractConditionState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractConditionState(this);
    }

    public new global::Sungero.Contracts.IContractConditionInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IContractConditionInfo)base.Info;
      }
    }

    public new global::Sungero.Contracts.IContractConditionAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Contracts.IContractConditionAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Client.ContractConditionAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _ConditionTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Docflow.Client.ConditionBase.ConditionTypeItems,
          typeof(global::Sungero.Contracts.ContractCondition.ConditionType),
          typeof(global::Sungero.Contracts.Client.ContractCondition),
          "ConditionType");

        public static new global::Sungero.Domain.Shared.EnumerationItems ConditionTypeItems
        {
          get { return global::Sungero.Contracts.Client.ContractCondition._ConditionTypeItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ConditionTypeAllowedItems
        {
          get { return global::Sungero.Contracts.Client.ContractCondition.ConditionTypeItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ContractConditionActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ContractConditionCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ContractConditionAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.ContractConditionAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Contracts.Client.ContractConditionFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.ContractConditionFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ContractConditionClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ContractConditionSharedHandlers(this);
    }

    #endregion

    #region Framework events









    #endregion

    #region Constructors






            protected override void InitCurrenciesCollectionProperty()
            {
              this._Currencies = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractConditionCurrencies>("Currencies", this);
              this._Currencies.ValueChanged += (sender, e) => { this.CurrenciesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Currencies);
              this.SetCurrenciesEventHandlers();
            }

            protected override void InitDocumentKindsCollectionProperty()
            {
              this._DocumentKinds = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractConditionDocumentKinds>("DocumentKinds", this);
              this._DocumentKinds.ValueChanged += (sender, e) => { this.DocumentKindsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._DocumentKinds);
              this.SetDocumentKindsEventHandlers();
            }

            protected override void InitConditionDocumentKindsCollectionProperty()
            {
              this._ConditionDocumentKinds = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractConditionConditionDocumentKinds>("ConditionDocumentKinds", this);
              this._ConditionDocumentKinds.ValueChanged += (sender, e) => { this.ConditionDocumentKindsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._ConditionDocumentKinds);
              this.SetConditionDocumentKindsEventHandlers();
            }

            protected override void InitDeliveryMethodsCollectionProperty()
            {
              this._DeliveryMethods = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.IContractConditionDeliveryMethods>("DeliveryMethods", this);
              this._DeliveryMethods.ValueChanged += (sender, e) => { this.DeliveryMethodsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._DeliveryMethods);
              this.SetDeliveryMethodsEventHandlers();
            }


    public ContractCondition()
    {








    }

    #endregion

  }
}

// ==================================================================
// ContractConditionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractConditionPresenter<T> :
    global::Sungero.Docflow.Client.ConditionBasePresenter<T>
    where T : class, global::Sungero.Contracts.IContractCondition
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



    #region Constructors

    private void Init()
    {
              this._ApprovalRoleCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IApprovalRoleBase>(() => this.Entity, typeof(T), "ApprovalRole");

              this._ApprovalRoleForComparisonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IApprovalRoleBase>(() => this.Entity, typeof(T), "ApprovalRoleForComparison");

              this._RecipientForComparisonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(T), "RecipientForComparison");

              this._AddendaDocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IDocumentKind>(() => this.Entity.Id, typeof(T), "AddendaDocumentKind");


                        this._CurrenciesCurrencyCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.ICurrency>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractConditionCurrencies), "Currency");

                        this._DocumentKindsDocumentKindCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IDocumentKind>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractConditionDocumentKinds), "DocumentKind");


                        this._ConditionDocumentKindsDocumentKindCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForChildNavigationProperty<global::Sungero.Docflow.IDocumentKind>(
                          () => this.ChildEntityCollectionPresenters.GetPresenter<global::Sungero.Contracts.IContractConditionConditionDocumentKinds>().FocusedEntity,
                          typeof(Sungero.Contracts.IContractConditionConditionDocumentKinds),
                          () => this.Entity,
                          "DocumentKind");


                        this._DeliveryMethodsDeliveryMethodCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(Sungero.Contracts.IContractConditionDeliveryMethods), "DeliveryMethod");



    }

    public ContractConditionPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ContractConditionCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractConditionCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ConditionBaseCollectionPresenter<T>
    where T: class, global::Sungero.Contracts.IContractCondition
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ContractConditionCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ContractConditionCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ContractConditionCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ContractConditionCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ContractConditionRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{ 
  public class ContractConditionRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ConditionBaseRepositoryImplementer<T>,
      global::Sungero.Contracts.IContractConditionRepositoryImplementer<T>
      where T : global::Sungero.Contracts.IContractCondition
    {
       public new global::Sungero.Contracts.IContractConditionAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.IContractConditionAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.IContractConditionInfo Info
       {
          get { return (global::Sungero.Contracts.IContractConditionInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Client.ContractConditionTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContractConditionAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractConditionAccessRights : 
    Sungero.Docflow.Client.ConditionBaseAccessRights, Sungero.Contracts.IContractConditionAccessRights
  {

    public ContractConditionAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContractConditionTypeAccessRights : 
    Sungero.Docflow.Client.ConditionBaseTypeAccessRights, Sungero.Contracts.IContractConditionAccessRights
  {

    public ContractConditionTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}