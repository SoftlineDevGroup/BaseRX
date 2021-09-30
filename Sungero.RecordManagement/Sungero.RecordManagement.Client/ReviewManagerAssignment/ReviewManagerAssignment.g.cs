
// ==================================================================
// ReviewManagerAssignment.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ReviewManagerAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.RecordManagement.IReviewManagerAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("69ac657a-0e74-46be-acba-f6bbbbd2bc73");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ReviewManagerAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewManagerAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IReviewManagerAssignmentState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewManagerAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentState(this);
    }

    public new global::Sungero.RecordManagement.IReviewManagerAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewManagerAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IReviewManagerAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewManagerAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _ReworkDeadline;

        public virtual global::System.DateTime? ReworkDeadline
        {
          get { return this._ReworkDeadline.Value; }
          set { this._ReworkDeadline.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.RecordManagement.ReviewManagerAssignment.Result),
          typeof(global::Sungero.RecordManagement.Client.ReviewManagerAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.RecordManagement.Client.ReviewManagerAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.RecordManagement.Client.ReviewManagerAssignment.ResultItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Addressee;

              public virtual global::Sungero.Company.IEmployee Addressee
              {
              get
              {
                return this._Addressee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Addressee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewManagerAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ReworkDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ReworkDeadline, this.ReworkDeadline, this);
     ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).ReworkDeadlineChanged(args);
    }

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }



  protected global::System.DateTime? ReworkDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.ReworkDeadline, value, this, this.Info.Properties.ReworkDeadline);
    ((global::Sungero.RecordManagement.ReviewManagerAssignmentClientHandlers)this.Handlers).ReworkDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.RecordManagement.ReviewManagerAssignmentClientHandlers)this.Handlers).AddresseeValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








              protected virtual void InitAddresseeNavigationProperty()
              {
                this._Addressee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Addressee", this);
                this._Addressee.ValueChanged += (sender, e) => { this.AddresseeChangedHandler(); };
                this.AddProperty(this._Addressee as global::Sungero.Domain.Client.IProperty);
              }




    public ReviewManagerAssignment()
    {
            this._ReworkDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("ReworkDeadline", this);
            this._ReworkDeadline.ValueChanged += (sender, e) => { this.ReworkDeadlineChangedHandler(); };
            this.AddProperty(this._ReworkDeadline);

            this.InitAddresseeNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewManagerAssignmentResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentResolutionGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewManagerAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewManagerAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewManagerAssignmentDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewManagerAssignmentDocumentForReviewGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewManagerAssignmentSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// ReviewManagerAssignmentPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ReviewManagerAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.RecordManagement.IReviewManagerAssignment
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _AddAssignmentCommand;

          public global::System.Windows.Input.ICommand AddAssignmentCommand
          {
            get
            {
              if (this._AddAssignmentCommand == null)
                  this._AddAssignmentCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("AddAssignment", this, this.AddAssignment, this.CanAddAssignment) { IsEmptyParameterAllowed = true };
              return this._AddAssignmentCommand;
            }
          }
          private global::System.Windows.Input.ICommand _AddResolutionCommand;

          public global::System.Windows.Input.ICommand AddResolutionCommand
          {
            get
            {
              if (this._AddResolutionCommand == null)
                  this._AddResolutionCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("AddResolution", this, this.AddResolution, this.CanAddResolution) { IsEmptyParameterAllowed = true };
              return this._AddResolutionCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ExploredCommand;

          public global::System.Windows.Input.ICommand ExploredCommand
          {
            get
            {
              if (this._ExploredCommand == null)
                  this._ExploredCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Explored", this, this.Explored, this.CanExplored) { IsEmptyParameterAllowed = true };
              return this._ExploredCommand;
            }
          }
          private global::System.Windows.Input.ICommand _CreateActionItemCommand;

          public global::System.Windows.Input.ICommand CreateActionItemCommand
          {
            get
            {
              if (this._CreateActionItemCommand == null)
                  this._CreateActionItemCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("CreateActionItem", this, this.CreateActionItem, this.CanCreateActionItem) { IsEmptyParameterAllowed = true };
              return this._CreateActionItemCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ForwardCommand;

          public global::System.Windows.Input.ICommand ForwardCommand
          {
            get
            {
              if (this._ForwardCommand == null)
                  this._ForwardCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Forward", this, this.Forward, this.CanForward) { IsEmptyParameterAllowed = true };
              return this._ForwardCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanAddAssignment(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).CanAddAssignment(args);
              }

              private void AddAssignment(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.AddAssignment);
                ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).AddAssignment(args);
              }

              private bool CanAddResolution(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).CanAddResolution(args);
              }

              private void AddResolution(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.AddResolution);
                ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).AddResolution(args);
              }

              private bool CanExplored(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).CanExplored(args);
              }

              private void Explored(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Explored);
                ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).Explored(args);
              }

              private bool CanCreateActionItem(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).CanCreateActionItem(args);
              }

              private void CreateActionItem(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.CreateActionItem);
                ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).CreateActionItem(args);
              }

              private bool CanForward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).CanForward(args);
              }

              private void Forward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Forward);
                ((Sungero.RecordManagement.Client.ReviewManagerAssignmentActions)(entity as Sungero.RecordManagement.Client.ReviewManagerAssignment).ActionsHandlers).Forward(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _AddresseeCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter AddresseeCollectionPresenter
              {
          get { return this._AddresseeCollectionPresenter; }
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

                  this._AddresseeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("1e3bfaa2-6022-40d2-bfaf-e6554f42667c"));
              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");


    }

    public ReviewManagerAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ReviewManagerAssignmentCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ReviewManagerAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IReviewManagerAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ReviewManagerAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ReviewManagerAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ReviewManagerAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ReviewManagerAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ReviewManagerAssignmentRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
  public class ReviewManagerAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewManagerAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewManagerAssignment
    {
       public new global::Sungero.RecordManagement.IReviewManagerAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewManagerAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewManagerAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewManagerAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.ReviewManagerAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewManagerAssignmentAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ReviewManagerAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.RecordManagement.IReviewManagerAssignmentAccessRights
  {

    public ReviewManagerAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewManagerAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.RecordManagement.IReviewManagerAssignmentAccessRights
  {

    public ReviewManagerAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}