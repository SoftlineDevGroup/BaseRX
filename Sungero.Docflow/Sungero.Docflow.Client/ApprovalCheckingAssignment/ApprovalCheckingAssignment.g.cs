
// ==================================================================
// ApprovalCheckingAssignment.g.cs
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
  public class ApprovalCheckingAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.Docflow.IApprovalCheckingAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c09f0ae4-c959-4a57-9895-ae9aaf1f1855");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalCheckingAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalCheckingAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IApprovalCheckingAssignmentState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalCheckingAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentState(this);
    }

    public new global::Sungero.Docflow.IApprovalCheckingAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalCheckingAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _StageSubject;

        public virtual global::System.String StageSubject
        {
          get { return this._StageSubject.Value; }
          set { this._StageSubject.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _StageNumber;

        public virtual global::System.Int32? StageNumber
        {
          get { return this._StageNumber.Value; }
          set { this._StageNumber.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.Docflow.ApprovalCheckingAssignment.Result),
          typeof(global::Sungero.Docflow.Client.ApprovalCheckingAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalCheckingAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalCheckingAssignment.ResultItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _ReworkPerformer;

              public virtual global::Sungero.Company.IEmployee ReworkPerformer
              {
              get
              {
                return this._ReworkPerformer.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._ReworkPerformer as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalCheckingAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void StageSubjectChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.StageSubject, this.StageSubject, this);
     ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).StageSubjectChanged(args);
    }

    protected void StageNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.StageNumber, this.StageNumber, this);
     ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).StageNumberChanged(args);
    }

    protected void ReworkPerformerChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentReworkPerformerChangedEventArgs(this.State.Properties.ReworkPerformer, this.ReworkPerformer, this);
     ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).ReworkPerformerChanged(args);
    }



  protected global::System.String StageSubjectValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.StageSubject, value, this, this.Info.Properties.StageSubject);
    ((global::Sungero.Docflow.ApprovalCheckingAssignmentClientHandlers)this.Handlers).StageSubjectValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? StageNumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.StageNumber, value, this, this.Info.Properties.StageNumber);
    ((global::Sungero.Docflow.ApprovalCheckingAssignmentClientHandlers)this.Handlers).StageNumberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee ReworkPerformerValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentReworkPerformerValueInputEventArgs(this.ReworkPerformer, value, this, this.Info.Properties.ReworkPerformer);
    ((global::Sungero.Docflow.ApprovalCheckingAssignmentClientHandlers)this.Handlers).ReworkPerformerValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








              protected virtual void InitReworkPerformerNavigationProperty()
              {
                this._ReworkPerformer = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("ReworkPerformer", this);
                this._ReworkPerformer.ValueChanged += (sender, e) => { this.ReworkPerformerChangedHandler(); };
                this.AddProperty(this._ReworkPerformer as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalCheckingAssignment()
    {
            this._StageSubject = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("StageSubject", this);
            this._StageSubject.ValueChanged += (sender, e) => { this.StageSubjectChangedHandler(); };
            this.AddProperty(this._StageSubject);

            this._StageNumber = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("StageNumber", this);
            this._StageNumber.ValueChanged += (sender, e) => { this.StageNumberChangedHandler(); };
            this.AddProperty(this._StageNumber);

            this.InitReworkPerformerNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IApprovalCheckingAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalCheckingAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IApprovalCheckingAssignmentDocumentGroupAttachments DocumentGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.ApprovalCheckingAssignmentDocumentGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentGroup")
      {
        ((global::Sungero.Docflow.ApprovalCheckingAssignmentSharedHandlers)this.SharedHandlers).DocumentGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// ApprovalCheckingAssignmentPresenter.g.cs
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
  public class ApprovalCheckingAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalCheckingAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _AcceptCommand;

          public global::System.Windows.Input.ICommand AcceptCommand
          {
            get
            {
              if (this._AcceptCommand == null)
                  this._AcceptCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Accept", this, this.Accept, this.CanAccept) { IsEmptyParameterAllowed = true };
              return this._AcceptCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForReworkCommand;

          public global::System.Windows.Input.ICommand ForReworkCommand
          {
            get
            {
              if (this._ForReworkCommand == null)
                  this._ForReworkCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("ForRework", this, this.ForRework, this.CanForRework) { IsEmptyParameterAllowed = true };
              return this._ForReworkCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ExtendDeadlineCommand;

          public global::System.Windows.Input.ICommand ExtendDeadlineCommand
          {
            get
            {
              if (this._ExtendDeadlineCommand == null)
                  this._ExtendDeadlineCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ExtendDeadline", this, this.ExtendDeadline, this.CanExtendDeadline) { IsEmptyParameterAllowed = true };
              return this._ExtendDeadlineCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanAccept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.ApprovalCheckingAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalCheckingAssignment).ActionsHandlers).CanAccept(args);
              }

              private void Accept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Accept);
                ((Sungero.Docflow.Client.ApprovalCheckingAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalCheckingAssignment).ActionsHandlers).Accept(args);
              }

              private bool CanForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.ApprovalCheckingAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalCheckingAssignment).ActionsHandlers).CanForRework(args);
              }

              private void ForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRework);
                ((Sungero.Docflow.Client.ApprovalCheckingAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalCheckingAssignment).ActionsHandlers).ForRework(args);
              }

              private bool CanExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.ApprovalCheckingAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalCheckingAssignment).ActionsHandlers).CanExtendDeadline(args);
              }

              private void ExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ExtendDeadline);
                ((Sungero.Docflow.Client.ApprovalCheckingAssignmentActions)(entity as Sungero.Docflow.Client.ApprovalCheckingAssignment).ActionsHandlers).ExtendDeadline(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ReworkPerformerCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter ReworkPerformerCollectionPresenter
              {
          get { return this._ReworkPerformerCollectionPresenter; }
        }



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

                  this._ReworkPerformerCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("fc2ff06a-725c-451a-a3c6-a9b3397af672"));
              this._ReworkPerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.Company.IEmployee>(() => this.Entity, typeof(T), "ReworkPerformer");


    }

    public ApprovalCheckingAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalCheckingAssignmentCollectionPresenter.g.cs
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
  public class ApprovalCheckingAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalCheckingAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalCheckingAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalCheckingAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalCheckingAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalCheckingAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalCheckingAssignmentRepositoryImplementer.g.cs
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
  public class ApprovalCheckingAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalCheckingAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalCheckingAssignment
    {
       public new global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalCheckingAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalCheckingAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalCheckingAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalCheckingAssignmentAccessRights.g.cs
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
  public class ApprovalCheckingAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.Docflow.IApprovalCheckingAssignmentAccessRights
  {

    public ApprovalCheckingAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalCheckingAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.Docflow.IApprovalCheckingAssignmentAccessRights
  {

    public ApprovalCheckingAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
