
// ==================================================================
// Bank.g.cs
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
  public class Bank :
    global::Sungero.Parties.Client.CompanyBase, global::Sungero.Parties.IBank
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("80c4e311-e95f-449b-984d-1fd540b8f0af");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Client.Bank.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.IBank, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Parties.IBankState State
    {
      get
      {
        return (global::Sungero.Parties.IBankState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.BankState(this);
    }

    public new global::Sungero.Parties.IBankInfo Info
    {
      get
      {
        return (global::Sungero.Parties.IBankInfo)base.Info;
      }
    }

    public new global::Sungero.Parties.IBankAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Parties.IBankAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Parties.Client.BankAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _BIC;

        public virtual global::System.String BIC
        {
          get { return this._BIC.Value; }
          set { this._BIC.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _CorrespondentAccount;

        public virtual global::System.String CorrespondentAccount
        {
          get { return this._CorrespondentAccount.Value; }
          set { this._CorrespondentAccount.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsSystem;

        public virtual global::System.Boolean? IsSystem
        {
          get { return this._IsSystem.Value; }
          set { this._IsSystem.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Parties.Client.BankActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Parties.Client.BankCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Parties.Client.BankAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Parties.Client.BankAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Parties.Client.BankFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Parties.Shared.BankFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Parties.BankClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Parties.BankSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void BICChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.BIC, this.BIC, this);
     ((global::Sungero.Parties.BankSharedHandlers)this.SharedHandlers).BICChanged(args);
    }

    protected void CorrespondentAccountChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.CorrespondentAccount, this.CorrespondentAccount, this);
     ((global::Sungero.Parties.BankSharedHandlers)this.SharedHandlers).CorrespondentAccountChanged(args);
    }

    protected void IsSystemChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsSystem, this.IsSystem, this);
     ((global::Sungero.Parties.BankSharedHandlers)this.SharedHandlers).IsSystemChanged(args);
    }





  protected global::System.String BICValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.BIC, value, this, this.Info.Properties.BIC);
    ((global::Sungero.Parties.BankClientHandlers)this.Handlers).BICValueInput(args);
    return args.NewValue;
  }

  protected global::System.String CorrespondentAccountValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.CorrespondentAccount, value, this, this.Info.Properties.CorrespondentAccount);
    ((global::Sungero.Parties.BankClientHandlers)this.Handlers).CorrespondentAccountValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsSystemValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsSystem, value, this, this.Info.Properties.IsSystem);
    ((global::Sungero.Parties.BankClientHandlers)this.Handlers).IsSystemValueInput(args);
    return args.NewValue;
  }




    #endregion

    #region Constructors







            protected override void InitExchangeBoxesCollectionProperty()
            {
              this._ExchangeBoxes = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Parties.IBankExchangeBoxes>("ExchangeBoxes", this);
              this._ExchangeBoxes.ValueChanged += (sender, e) => { this.ExchangeBoxesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._ExchangeBoxes);
              this.SetExchangeBoxesEventHandlers();
            }


    public Bank()
    {
            this._BIC = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("BIC", this);
            this._BIC.ValueChanged += (sender, e) => { this.BICChangedHandler(); };
            this.AddProperty(this._BIC);

            this._CorrespondentAccount = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("CorrespondentAccount", this);
            this._CorrespondentAccount.ValueChanged += (sender, e) => { this.CorrespondentAccountChangedHandler(); };
            this.AddProperty(this._CorrespondentAccount);

            this._IsSystem = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsSystem", this);
            this._IsSystem.ValueChanged += (sender, e) => { this.IsSystemChangedHandler(); };
            this.AddProperty(this._IsSystem);








    }

    #endregion

  }
}

// ==================================================================
// BankPresenter.g.cs
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
  public class BankPresenter<T> :
    global::Sungero.Parties.Client.CompanyBasePresenter<T>
    where T : class, global::Sungero.Parties.IBank
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
              this._ResponsibleCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Responsible");

              this._RegionCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.IRegion>(() => this.Entity.Id, typeof(T), "Region");

              this._CityCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Commons.ICity>(() => this.Entity, typeof(T), "City");

              this._BankCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.IBank>(() => this.Entity.Id, typeof(T), "Bank");

              this._HeadCompanyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.ICompany>(() => this.Entity, typeof(T), "HeadCompany");


                        this._ExchangeBoxesBoxCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.ExchangeCore.IBusinessUnitBox>(() => this.Entity.Id, typeof(Sungero.Parties.IBankExchangeBoxes), "Box");



    }

    public BankPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// BankCollectionPresenter.g.cs
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
  public class BankCollectionPresenter<T> : 
    global::Sungero.Parties.Client.CompanyBaseCollectionPresenter<T>
    where T: class, global::Sungero.Parties.IBank
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public BankCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public BankCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public BankCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public BankCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// BankRepositoryImplementer.g.cs
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
  public class BankRepositoryImplementer<T> : 
      global::Sungero.Parties.Client.CompanyBaseRepositoryImplementer<T>,
      global::Sungero.Parties.IBankRepositoryImplementer<T>
      where T : global::Sungero.Parties.IBank
    {
       public new global::Sungero.Parties.IBankAccessRights AccessRights
       {
          get { return (global::Sungero.Parties.IBankAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Parties.IBankInfo Info
       {
          get { return (global::Sungero.Parties.IBankInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Parties.Client.BankTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// BankAccessRights.g.cs
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
  public class BankAccessRights : 
    Sungero.Parties.Client.CompanyBaseAccessRights, Sungero.Parties.IBankAccessRights
  {

    public BankAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class BankTypeAccessRights : 
    Sungero.Parties.Client.CompanyBaseTypeAccessRights, Sungero.Parties.IBankAccessRights
  {

    public BankTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
