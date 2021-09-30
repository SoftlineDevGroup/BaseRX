
// ==================================================================
// CounterpartyConflictProcessingAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("d4870243-705a-483a-bcc2-89e53b80073f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Subject; }
        set { this.Subject = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Subject"; }
      }


    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentState State
    {
      get
      {
        return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentState(this);
    }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentAccessRights(this);
    }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.ExchangeCore.CounterpartyConflictProcessingAssignment.Result),
          typeof(global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignment.ResultItems; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.ExchangeCore.CounterpartyConflictProcessingAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.ExchangeCore.CounterpartyConflictProcessingAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors








    public CounterpartyConflictProcessingAssignment()
    {








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments

    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
    }
    #endregion

  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _CompleteCommand;

          public global::System.Windows.Input.ICommand CompleteCommand
          {
            get
            {
              if (this._CompleteCommand == null)
                  this._CompleteCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Complete", this, this.Complete, this.CanComplete) { IsEmptyParameterAllowed = true };
              return this._CompleteCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanComplete(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentActions)(entity as Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignment).ActionsHandlers).CanComplete(args);
              }

              private void Complete(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Complete);
                ((Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentActions)(entity as Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignment).ActionsHandlers).Complete(args);
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
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._PerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Performer");

              this._TaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "Task");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

              this._CompletedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "CompletedBy");


    }

    public CounterpartyConflictProcessingAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public CounterpartyConflictProcessingAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public CounterpartyConflictProcessingAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public CounterpartyConflictProcessingAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public CounterpartyConflictProcessingAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{ 
  public class CounterpartyConflictProcessingAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentRepositoryImplementer<T>
      where T : global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment
    {
       public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentInfo Info
       {
          get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.ExchangeCore.Client.CounterpartyConflictProcessingAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAccessRights
  {

    public CounterpartyConflictProcessingAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class CounterpartyConflictProcessingAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAccessRights
  {

    public CounterpartyConflictProcessingAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
