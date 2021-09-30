
// ==================================================================
// CompanyBase.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class CompanyBase :
    global::Sungero.Parties.Client.Counterparty, global::Sungero.Parties.ICompanyBase
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("78278dd7-f0d2-4e35-b543-13d0bd462cd6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Client.CompanyBase.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.ICompanyBase, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Parties.ICompanyBaseState State
    {
      get
      {
        return (global::Sungero.Parties.ICompanyBaseState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.CompanyBaseState(this);
    }

    public new global::Sungero.Parties.ICompanyBaseInfo Info
    {
      get
      {
        return (global::Sungero.Parties.ICompanyBaseInfo)base.Info;
      }
    }

    public new global::Sungero.Parties.ICompanyBaseAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Parties.ICompanyBaseAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Parties.Client.CompanyBaseAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _TRRC;

        public virtual global::System.String TRRC
        {
          get { return this._TRRC.Value; }
          set { this._TRRC.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsCardReadOnly;

        public virtual global::System.Boolean? IsCardReadOnly
        {
          get { return this._IsCardReadOnly.Value; }
          set { this._IsCardReadOnly.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _LegalName;

        public virtual global::System.String LegalName
        {
          get { return this._LegalName.Value; }
          set { this._LegalName.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.ICompany> _HeadCompany;

              public virtual global::Sungero.Parties.ICompany HeadCompany
              {
              get
              {
                return this._HeadCompany.Value as global::Sungero.Parties.ICompany;
              }

              set
              {
                (this._HeadCompany as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Parties.Client.CompanyBaseFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Parties.Shared.CompanyBaseFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Parties.CompanyBaseClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Parties.CompanyBaseSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void HeadCompanyChangedHandler()
    {
      var args = new global::Sungero.Parties.Shared.CompanyBaseHeadCompanyChangedEventArgs(this.State.Properties.HeadCompany, this.HeadCompany, this);
     ((global::Sungero.Parties.CompanyBaseSharedHandlers)this.SharedHandlers).HeadCompanyChanged(args);
    }

    protected void TRRCChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.TRRC, this.TRRC, this);
     ((global::Sungero.Parties.CompanyBaseSharedHandlers)this.SharedHandlers).TRRCChanged(args);
    }

    protected void IsCardReadOnlyChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsCardReadOnly, this.IsCardReadOnly, this);
     ((global::Sungero.Parties.CompanyBaseSharedHandlers)this.SharedHandlers).IsCardReadOnlyChanged(args);
    }

    protected void LegalNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.LegalName, this.LegalName, this);
     ((global::Sungero.Parties.CompanyBaseSharedHandlers)this.SharedHandlers).LegalNameChanged(args);
    }





  protected global::Sungero.Parties.ICompany HeadCompanyValueInputHandler(global::Sungero.Parties.ICompany value)
  {
    var args = new global::Sungero.Parties.Client.CompanyBaseHeadCompanyValueInputEventArgs(this.HeadCompany, value, this, this.Info.Properties.HeadCompany);
    ((global::Sungero.Parties.CompanyBaseClientHandlers)this.Handlers).HeadCompanyValueInput(args);
    return args.NewValue;
  }

  protected global::System.String TRRCValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.TRRC, value, this, this.Info.Properties.TRRC);
    ((global::Sungero.Parties.CompanyBaseClientHandlers)this.Handlers).TRRCValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsCardReadOnlyValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsCardReadOnly, value, this, this.Info.Properties.IsCardReadOnly);
    ((global::Sungero.Parties.CompanyBaseClientHandlers)this.Handlers).IsCardReadOnlyValueInput(args);
    return args.NewValue;
  }

  protected global::System.String LegalNameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.LegalName, value, this, this.Info.Properties.LegalName);
    ((global::Sungero.Parties.CompanyBaseClientHandlers)this.Handlers).LegalNameValueInput(args);
    return args.NewValue;
  }




    #endregion

    #region Constructors







              protected virtual void InitHeadCompanyNavigationProperty()
              {
                this._HeadCompany = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICompany>("HeadCompany", this);
                this._HeadCompany.ValueChanged += (sender, e) => { this.HeadCompanyChangedHandler(); };
                this.AddProperty(this._HeadCompany as global::Sungero.Domain.Client.IProperty);
              }



            protected override void InitExchangeBoxesCollectionProperty()
            {
              this._ExchangeBoxes = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Parties.ICompanyBaseExchangeBoxes>("ExchangeBoxes", this);
              this._ExchangeBoxes.ValueChanged += (sender, e) => { this.ExchangeBoxesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._ExchangeBoxes);
              this.SetExchangeBoxesEventHandlers();
            }


    public CompanyBase()
    {
            this._TRRC = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("TRRC", this);
            this._TRRC.ValueChanged += (sender, e) => { this.TRRCChangedHandler(); };
            this.AddProperty(this._TRRC);

            this._IsCardReadOnly = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsCardReadOnly", this);
            this._IsCardReadOnly.ValueChanged += (sender, e) => { this.IsCardReadOnlyChangedHandler(); };
            this.AddProperty(this._IsCardReadOnly);

            this._LegalName = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("LegalName", this);
            this._LegalName.ValueChanged += (sender, e) => { this.LegalNameChangedHandler(); };
            this.AddProperty(this._LegalName);

            this.InitHeadCompanyNavigationProperty();








    }

    #endregion

  }
}

// ==================================================================
// CompanyBasePresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class CompanyBasePresenter<T> :
    global::Sungero.Parties.Client.CounterpartyPresenter<T>
    where T : class, global::Sungero.Parties.ICompanyBase
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _OpenContactsCommand;

          public global::System.Windows.Input.ICommand OpenContactsCommand
          {
            get
            {
              if (this._OpenContactsCommand == null)
                  this._OpenContactsCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("OpenContacts", this, this.OpenContacts, this.CanOpenContacts) { IsEmptyParameterAllowed = true };
              return this._OpenContactsCommand;
            }
          }
          private global::System.Windows.Input.ICommand _FillFromServiceCommand;

          public global::System.Windows.Input.ICommand FillFromServiceCommand
          {
            get
            {
              if (this._FillFromServiceCommand == null)
                  this._FillFromServiceCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("FillFromService", this, this.FillFromService, this.CanFillFromService) { IsEmptyParameterAllowed = true };
              return this._FillFromServiceCommand;
            }
          }
          private global::System.Windows.Input.ICommand _OpenOnDueDiligenceWebsiteCommand;

          public global::System.Windows.Input.ICommand OpenOnDueDiligenceWebsiteCommand
          {
            get
            {
              if (this._OpenOnDueDiligenceWebsiteCommand == null)
                  this._OpenOnDueDiligenceWebsiteCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("OpenOnDueDiligenceWebsite", this, this.OpenOnDueDiligenceWebsite, this.CanOpenOnDueDiligenceWebsite) { IsEmptyParameterAllowed = true };
              return this._OpenOnDueDiligenceWebsiteCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanOpenContacts(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).CanOpenContacts(args);
              }

              private void OpenContacts(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.OpenContacts);
                ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).OpenContacts(args);
              }

              private bool CanFillFromService(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).CanFillFromService(args);
              }

              private void FillFromService(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.FillFromService);
                ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).FillFromService(args);
              }

              private bool CanOpenOnDueDiligenceWebsite(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).CanOpenOnDueDiligenceWebsite(args);
              }

              private void OpenOnDueDiligenceWebsite(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.OpenOnDueDiligenceWebsite);
                ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).OpenOnDueDiligenceWebsite(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _HeadCompanyCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter HeadCompanyCollectionPresenter
              {
          get { return this._HeadCompanyCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
              this._ResponsibleCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Responsible");

              this._RegionCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.IRegion>(() => this.Entity.Id, typeof(T), "Region");

              this._BankCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.IBank>(() => this.Entity.Id, typeof(T), "Bank");

              this._CityCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Commons.ICity>(() => this.Entity, typeof(T), "City");

                  this._HeadCompanyCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.ICompany>(global::System.Guid.Parse("8e14d1b1-02b8-466c-aed8-a69a4d95c0fa"));
              this._HeadCompanyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.ICompany>(() => this.Entity, typeof(T), "HeadCompany");


                        this._ExchangeBoxesBoxCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(Sungero.Parties.ICompanyBaseExchangeBoxes), "Box");



    }

    public CompanyBasePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// CompanyBaseCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class CompanyBaseCollectionPresenter<T> : 
    global::Sungero.Parties.Client.CounterpartyCollectionPresenter<T>
    where T: class, global::Sungero.Parties.ICompanyBase
  {
    #region Actions

          private global::System.Windows.Input.ICommand _OpenContactsCommand;  

          public global::System.Windows.Input.ICommand OpenContactsCommand 
          { 
            get
            { 
              if (this._OpenContactsCommand == null)
                this._OpenContactsCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("OpenContacts", this, this.OpenContacts, this.CanOpenContacts) { IsEmptyParameterAllowed = true };
              return this._OpenContactsCommand; 
            }
          }



    #endregion

    #region Methods

        private bool CanOpenContacts(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this);
          return ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).CanOpenContacts(args);
        }

        private void OpenContacts(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this, entity.Info.Actions.OpenContacts);
          ((Sungero.Parties.Client.CompanyBaseActions)(entity as Sungero.Parties.Client.CompanyBase).ActionsHandlers).OpenContacts(args);
        }



    #endregion

    public CompanyBaseCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public CompanyBaseCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public CompanyBaseCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public CompanyBaseCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// CompanyBaseRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{ 
  public class CompanyBaseRepositoryImplementer<T> : 
      global::Sungero.Parties.Client.CounterpartyRepositoryImplementer<T>,
      global::Sungero.Parties.ICompanyBaseRepositoryImplementer<T>
      where T : global::Sungero.Parties.ICompanyBase
    {
       public new global::Sungero.Parties.ICompanyBaseAccessRights AccessRights
       {
          get { return (global::Sungero.Parties.ICompanyBaseAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Parties.ICompanyBaseInfo Info
       {
          get { return (global::Sungero.Parties.ICompanyBaseInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Parties.Client.CompanyBaseTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CompanyBaseAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class CompanyBaseAccessRights : 
    Sungero.Parties.Client.CounterpartyAccessRights, Sungero.Parties.ICompanyBaseAccessRights
  {

    public CompanyBaseAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CompanyBaseTypeAccessRights : 
    Sungero.Parties.Client.CounterpartyTypeAccessRights, Sungero.Parties.ICompanyBaseAccessRights
  {

    public CompanyBaseTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
