
// ==================================================================
// ApprovalRule.g.cs
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
  public class ApprovalRule :
    global::Sungero.Docflow.Client.ApprovalRuleBase, global::Sungero.Docflow.IApprovalRule
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a8dc61a5-862e-4c8a-a0e0-a5735ec3c3b3");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRule.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRule, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IApprovalRuleState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleState(this);
    }

    public new global::Sungero.Docflow.IApprovalRuleInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalRuleAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleAnyChildEntityCollectionActions();
    }

    protected override object CreateConditionsActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleConditionsActions();
    }

    protected override object CreateConditionsCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleConditionsCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalRuleFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRuleSharedHandlers(this);
    }

    #endregion

    #region Framework events












    #endregion

    #region Constructors





            protected override void InitDocumentKindsCollectionProperty()
            {
              this._DocumentKinds = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleDocumentKinds>("DocumentKinds", this);
              this._DocumentKinds.ValueChanged += (sender, e) => { this.DocumentKindsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._DocumentKinds);
              this.SetDocumentKindsEventHandlers();
            }

            protected override void InitConditionsCollectionProperty()
            {
              this._Conditions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleConditions>("Conditions", this);
              this._Conditions.ValueChanged += (sender, e) => { this.ConditionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Conditions);
              this.SetConditionsEventHandlers();
            }

            protected override void InitTransitionsCollectionProperty()
            {
              this._Transitions = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleTransitions>("Transitions", this);
              this._Transitions.ValueChanged += (sender, e) => { this.TransitionsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Transitions);
              this.SetTransitionsEventHandlers();
            }

            protected override void InitDepartmentsCollectionProperty()
            {
              this._Departments = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleDepartments>("Departments", this);
              this._Departments.ValueChanged += (sender, e) => { this.DepartmentsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Departments);
              this.SetDepartmentsEventHandlers();
            }

            protected override void InitStagesCollectionProperty()
            {
              this._Stages = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleStages>("Stages", this);
              this._Stages.ValueChanged += (sender, e) => { this.StagesChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Stages);
              this.SetStagesEventHandlers();
            }

            protected override void InitBusinessUnitsCollectionProperty()
            {
              this._BusinessUnits = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleBusinessUnits>("BusinessUnits", this);
              this._BusinessUnits.ValueChanged += (sender, e) => { this.BusinessUnitsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._BusinessUnits);
              this.SetBusinessUnitsEventHandlers();
            }

            protected override void InitDocumentGroupsCollectionProperty()
            {
              this._DocumentGroups = new global::Sungero.Domain.Client.ListProperty<global::Sungero.Docflow.IApprovalRuleDocumentGroups>("DocumentGroups", this);
              this._DocumentGroups.ValueChanged += (sender, e) => { this.DocumentGroupsChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._DocumentGroups);
              this.SetDocumentGroupsEventHandlers();
            }


    public ApprovalRule()
    {








    }

    #endregion

  }
}

// ==================================================================
// ApprovalRulePresenter.g.cs
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
  public class ApprovalRulePresenter<T> :
    global::Sungero.Docflow.Client.ApprovalRuleBasePresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalRule
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
              this._ParentRuleCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IApprovalRuleBase>(() => this.Entity.Id, typeof(T), "ParentRule");

              this._ReworkPerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(T), "ReworkPerformer");

              this._ReworkApprovalRoleCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Docflow.IApprovalRoleBase>(() => this.Entity, typeof(T), "ReworkApprovalRole");


                        this._DocumentKindsDocumentKindCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForChildNavigationProperty<global::Sungero.Docflow.IDocumentKind>(
                          () => this.ChildEntityCollectionPresenters.GetPresenter<global::Sungero.Docflow.IApprovalRuleDocumentKinds>().FocusedEntity,
                          typeof(Sungero.Docflow.IApprovalRuleDocumentKinds),
                          () => this.Entity,
                          "DocumentKind");


                          this._ConditionsConditionCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Docflow.ICondition>(global::System.Guid.Parse("63c932c6-2d61-4463-a828-219c94b6bc2c"));
                        this._ConditionsConditionCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.ICondition>(() => this.Entity.Id, typeof(Sungero.Docflow.IApprovalRuleConditions), "Condition");

                        this._DepartmentsDepartmentCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IDepartment>(() => this.Entity.Id, typeof(Sungero.Docflow.IApprovalRuleDepartments), "Department");


                        this._StagesStageCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Docflow.IApprovalStage>(() => this.Entity.Id, typeof(Sungero.Docflow.IApprovalRuleStages), "Stage");


                        this._BusinessUnitsBusinessUnitCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IBusinessUnit>(() => this.Entity.Id, typeof(Sungero.Docflow.IApprovalRuleBusinessUnits), "BusinessUnit");


                        this._DocumentGroupsDocumentGroupCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForChildNavigationProperty<global::Sungero.Docflow.IDocumentGroupBase>(
                          () => this.ChildEntityCollectionPresenters.GetPresenter<global::Sungero.Docflow.IApprovalRuleDocumentGroups>().FocusedEntity,
                          typeof(Sungero.Docflow.IApprovalRuleDocumentGroups),
                          () => this.Entity,
                          "DocumentGroup");



    }

    public ApprovalRulePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalRuleCollectionPresenter.g.cs
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
  public class ApprovalRuleCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ApprovalRuleBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalRule
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalRuleCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalRuleCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalRuleCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalRuleCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalRuleRepositoryImplementer.g.cs
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
  public class ApprovalRuleRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ApprovalRuleBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalRuleRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalRule
    {
       public new global::Sungero.Docflow.IApprovalRuleAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalRuleAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalRuleInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalRuleInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalRuleTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalRuleAccessRights.g.cs
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
  public class ApprovalRuleAccessRights : 
    Sungero.Docflow.Client.ApprovalRuleBaseAccessRights, Sungero.Docflow.IApprovalRuleAccessRights
  {

    public ApprovalRuleAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalRuleTypeAccessRights : 
    Sungero.Docflow.Client.ApprovalRuleBaseTypeAccessRights, Sungero.Docflow.IApprovalRuleAccessRights
  {

    public ApprovalRuleTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
