
// ==================================================================
// SupAgreement.g.cs
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
  public class SupAgreement :
    global::Sungero.Contracts.Client.ContractualDocument, global::Sungero.Contracts.ISupAgreement
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("265f2c57-6a8a-4a15-833b-ca00e8047fa5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.SupAgreement.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.ISupAgreement, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Contracts.ISupAgreementState State
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.SupAgreementState(this);
    }

    public new global::Sungero.Contracts.ISupAgreementInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementInfo)base.Info;
      }
    }

    public new global::Sungero.Contracts.ISupAgreementAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Contracts.Client.SupAgreementAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _LifeCycleStateItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Contracts.Client.ContractualDocument.LifeCycleStateItems,
          typeof(global::Sungero.Contracts.SupAgreement.LifeCycleState),
          typeof(global::Sungero.Contracts.Client.SupAgreement),
          "LifeCycleState");

        public static new global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateItems
        {
          get { return global::Sungero.Contracts.Client.SupAgreement._LifeCycleStateItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems LifeCycleStateAllowedItems
        {
          get { return global::Sungero.Contracts.Client.SupAgreement.LifeCycleStateItems; }
        }





              public new virtual global::Sungero.Contracts.IContractBase LeadingDocument
              {
              get
              {
                return this._LeadingDocument.Value as global::Sungero.Contracts.IContractBase;
              }

              set
              {
                (this._LeadingDocument as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.SupAgreementActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.SupAgreementCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.SupAgreementAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Contracts.Client.SupAgreementAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Contracts.Client.SupAgreementFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Contracts.Shared.SupAgreementFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.SupAgreementClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.SupAgreementSharedHandlers(this);
    }

    #endregion

    #region Framework events








    #endregion

    #region Constructors









              protected override void InitLeadingDocumentNavigationProperty()
              {
                this._LeadingDocument = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Contracts.IContractBase>("LeadingDocument", this);
                this._LeadingDocument.ValueChanged += (sender, e) => { this.LeadingDocumentChangedHandler(); };
                this.AddProperty(this._LeadingDocument as global::Sungero.Domain.Client.IProperty);
              }


































            protected override void InitVersionsCollectionProperty()
            {
              this._Versions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.ISupAgreementVersions>("Versions", this);
              this._Versions.ValueChanged += (sender, e) => { this.VersionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Versions);
              this.SetVersionsEventHandlers();
            }


            protected override void InitTrackingCollectionProperty()
            {
              this._Tracking = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.ISupAgreementTracking>("Tracking", this);
              this._Tracking.ValueChanged += (sender, e) => { this.TrackingChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Tracking);
              this.SetTrackingEventHandlers();
            }

            protected override void InitMilestonesCollectionProperty()
            {
              this._Milestones = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Contracts.ISupAgreementStages>("Milestones", this);
              this._Milestones.ValueChanged += (sender, e) => { this.MilestonesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Milestones);
              this.SetMilestonesEventHandlers();
            }


    public SupAgreement()
    {








    }

    #endregion

  }
}

// ==================================================================
// SupAgreementPresenter.g.cs
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
  public class SupAgreementPresenter<T> :
    global::Sungero.Contracts.Client.ContractualDocumentPresenter<T>
    where T : class, global::Sungero.Contracts.ISupAgreement
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _CreateContractStatementCommand;

          public global::System.Windows.Input.ICommand CreateContractStatementCommand
          {
            get
            {
              if (this._CreateContractStatementCommand == null)
                  this._CreateContractStatementCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateContractStatement", this, this.CreateContractStatement, this.CanCreateContractStatement) { IsEmptyParameterAllowed = true };
              return this._CreateContractStatementCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanCreateContractStatement(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Contracts.Client.SupAgreementActions)(entity as Sungero.Contracts.Client.SupAgreement).ActionsHandlers).CanCreateContractStatement(args);
              }

              private void CreateContractStatement(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.CreateContractStatement);
                ((Sungero.Contracts.Client.SupAgreementActions)(entity as Sungero.Contracts.Client.SupAgreement).ActionsHandlers).CreateContractStatement(args);
              }


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
              this._StorageCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IStorage>(() => this.Entity.Id, typeof(T), "Storage");

              this._AssigneeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Assignee");

              this._PreparedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "PreparedBy");

              this._ProjectCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IProjectBase>(() => this.Entity.Id, typeof(T), "Project");

              this._DepartmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(T), "Department");

              this._CurrencyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Commons.ICurrency>(() => this.Entity.Id, typeof(T), "Currency");

                  this._LeadingDocumentCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Contracts.IContractBase>(global::System.Guid.Parse("aae1f6ae-d090-4c5a-963e-44c8b79dc92b"));
              this._LeadingDocumentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Contracts.IContractBase>(() => this.Entity, typeof(T), "LeadingDocument");

              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._AssociatedApplicationCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(T), "AssociatedApplication");

              this._DocumentRegisterCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentRegister>(() => this.Entity, typeof(T), "DocumentRegister");

              this._DeliveryMethodCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IMailDeliveryMethod>(() => this.Entity.Id, typeof(T), "DeliveryMethod");

              this._CaseFileCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.ICaseFile>(() => this.Entity.Id, typeof(T), "CaseFile");

              this._DeliveredToCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "DeliveredTo");

              this._ResponsibleForReturnEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleForReturnEmployee");

              this._DocumentKindCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentKind>(() => this.Entity, typeof(T), "DocumentKind");

              this._BusinessUnitCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(T), "BusinessUnit");

              this._OurSignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "OurSignatory");

              this._DocumentGroupCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(() => this.Entity, typeof(T), "DocumentGroup");

              this._CounterpartyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICounterparty>(() => this.Entity.Id, typeof(T), "Counterparty");

              this._CounterpartySignatoryCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "CounterpartySignatory");

              this._ContactCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Parties.IContact>(() => this.Entity, typeof(T), "Contact");

              this._ResponsibleEmployeeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "ResponsibleEmployee");


                        this._VersionsAuthorCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementVersions), "Author");

                        this._VersionsModifiedByCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementVersions), "ModifiedBy");

                        this._VersionsAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementVersions), "AssociatedApplication");

                        this._VersionsBodyAssociatedApplicationCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Content.IAssociatedApplication>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementVersions), "BodyAssociatedApplication");


                        this._TrackingDeliveredToCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementTracking), "DeliveredTo");

                        this._TrackingReturnTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementTracking), "ReturnTask");


                        this._MilestonesPerformerCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementStages), "Performer");

                        this._MilestonesTaskCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ISimpleTask>(() => this.Entity.Id, typeof(Sungero.Contracts.ISupAgreementStages), "Task");



    }

    public SupAgreementPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// SupAgreementCollectionPresenter.g.cs
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
  public class SupAgreementCollectionPresenter<T> : 
    global::Sungero.Contracts.Client.ContractualDocumentCollectionPresenter<T>
    where T: class, global::Sungero.Contracts.ISupAgreement
  {
    #region Actions

          private global::System.Windows.Input.ICommand _CreateContractStatementCommand;  

          public global::System.Windows.Input.ICommand CreateContractStatementCommand 
          { 
            get
            { 
              if (this._CreateContractStatementCommand == null)
                this._CreateContractStatementCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateContractStatement", this, this.CreateContractStatement, this.CanCreateContractStatement) { IsEmptyParameterAllowed = true };
              return this._CreateContractStatementCommand; 
            }
          }



    #endregion

    #region Methods

        private bool CanCreateContractStatement(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this);
          return ((Sungero.Contracts.Client.SupAgreementActions)(entity as Sungero.Contracts.Client.SupAgreement).ActionsHandlers).CanCreateContractStatement(args);
        }

        private void CreateContractStatement(T entity)
        {
          var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Collection, entity, this, entity.Info.Actions.CreateContractStatement);
          ((Sungero.Contracts.Client.SupAgreementActions)(entity as Sungero.Contracts.Client.SupAgreement).ActionsHandlers).CreateContractStatement(args);
        }



    #endregion

    public SupAgreementCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public SupAgreementCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public SupAgreementCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public SupAgreementCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// SupAgreementRepositoryImplementer.g.cs
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
  public class SupAgreementRepositoryImplementer<T> : 
      global::Sungero.Contracts.Client.ContractualDocumentRepositoryImplementer<T>,
      global::Sungero.Contracts.ISupAgreementRepositoryImplementer<T>
      where T : global::Sungero.Contracts.ISupAgreement
    {
       public new global::Sungero.Contracts.ISupAgreementAccessRights AccessRights
       {
          get { return (global::Sungero.Contracts.ISupAgreementAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Contracts.ISupAgreementInfo Info
       {
          get { return (global::Sungero.Contracts.ISupAgreementInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Contracts.Client.SupAgreementTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// SupAgreementAccessRights.g.cs
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
  public class SupAgreementAccessRights : 
    Sungero.Contracts.Client.ContractualDocumentAccessRights, Sungero.Contracts.ISupAgreementAccessRights
  {

    public SupAgreementAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class SupAgreementTypeAccessRights : 
    Sungero.Contracts.Client.ContractualDocumentTypeAccessRights, Sungero.Contracts.ISupAgreementAccessRights
  {

    public SupAgreementTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
