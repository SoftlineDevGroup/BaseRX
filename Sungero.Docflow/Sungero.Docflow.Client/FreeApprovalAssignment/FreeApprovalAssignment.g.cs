
// ==================================================================
// FreeApprovalAssignment.g.cs
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
  public class FreeApprovalAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("01be6c28-8785-4f74-9877-e3270704452e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.FreeApprovalAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IFreeApprovalAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.Docflow.IFreeApprovalAssignmentState State
    {
      get
      {
        return (global::Sungero.Docflow.IFreeApprovalAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentState(this);
    }

    public new global::Sungero.Docflow.IFreeApprovalAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IFreeApprovalAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _AddresseeDeadline;

        public virtual global::System.DateTime? AddresseeDeadline
        {
          get { return this._AddresseeDeadline.Value; }
          set { this._AddresseeDeadline.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.Docflow.FreeApprovalAssignment.Result),
          typeof(global::Sungero.Docflow.Client.FreeApprovalAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.Docflow.Client.FreeApprovalAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.Docflow.Client.FreeApprovalAssignment.ResultItems; }
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
      return new global::Sungero.Docflow.Client.FreeApprovalAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.FreeApprovalAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.FreeApprovalAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.FreeApprovalAssignmentAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void AddresseeDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.AddresseeDeadline, this.AddresseeDeadline, this);
     ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddresseeDeadlineChanged(args);
    }



  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Docflow.Client.FreeApprovalAssignmentAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.Docflow.FreeApprovalAssignmentClientHandlers)this.Handlers).AddresseeValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? AddresseeDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.AddresseeDeadline, value, this, this.Info.Properties.AddresseeDeadline);
    ((global::Sungero.Docflow.FreeApprovalAssignmentClientHandlers)this.Handlers).AddresseeDeadlineValueInput(args);
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




    public FreeApprovalAssignment()
    {
            this._AddresseeDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("AddresseeDeadline", this);
            this._AddresseeDeadline.ValueChanged += (sender, e) => { this.AddresseeDeadlineChangedHandler(); };
            this.AddProperty(this._AddresseeDeadline);

            this.InitAddresseeNavigationProperty();








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.Docflow.IFreeApprovalAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.Docflow.IFreeApprovalAssignmentForApprovalGroupAttachments ForApprovalGroup
    {
      get
      {
        return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentForApprovalGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ForApprovalGroup")
      {
        ((global::Sungero.Docflow.FreeApprovalAssignmentSharedHandlers)this.SharedHandlers).ForApprovalGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// FreeApprovalAssignmentPresenter.g.cs
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
  public class FreeApprovalAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    #region Fields and properties

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
          private global::System.Windows.Input.ICommand _ApprovedCommand;

          public global::System.Windows.Input.ICommand ApprovedCommand
          {
            get
            {
              if (this._ApprovedCommand == null)
                  this._ApprovedCommand = new global::Sungero.Workflow.Client.SingleAssignmentCommand<T>("Approved", this, this.Approved, this.CanApproved) { IsEmptyParameterAllowed = true };
              return this._ApprovedCommand;
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
          private global::System.Windows.Input.ICommand _AddApproverCommand;

          public global::System.Windows.Input.ICommand AddApproverCommand
          {
            get
            {
              if (this._AddApproverCommand == null)
                  this._AddApproverCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("AddApprover", this, this.AddApprover, this.CanAddApprover) { IsEmptyParameterAllowed = true };
              return this._AddApproverCommand;
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

              private bool CanForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).CanForRework(args);
              }

              private void ForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRework);
                ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).ForRework(args);
              }

              private bool CanApproved(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).CanApproved(args);
              }

              private void Approved(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Approved);
                ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).Approved(args);
              }

              private bool CanExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).CanExtendDeadline(args);
              }

              private void ExtendDeadline(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ExtendDeadline);
                ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).ExtendDeadline(args);
              }

              private bool CanAddApprover(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).CanAddApprover(args);
              }

              private void AddApprover(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.AddApprover);
                ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).AddApprover(args);
              }

              private bool CanForward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).CanForward(args);
              }

              private void Forward(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Forward);
                ((Sungero.Docflow.Client.FreeApprovalAssignmentActions)(entity as Sungero.Docflow.Client.FreeApprovalAssignment).ActionsHandlers).Forward(args);
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

                  this._AddresseeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("d3139a94-afe5-4516-8211-615daa9cc008"));
              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");


    }

    public FreeApprovalAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// FreeApprovalAssignmentCollectionPresenter.g.cs
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
  public class FreeApprovalAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IFreeApprovalAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public FreeApprovalAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public FreeApprovalAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public FreeApprovalAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public FreeApprovalAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// FreeApprovalAssignmentRepositoryImplementer.g.cs
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
  public class FreeApprovalAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.Docflow.IFreeApprovalAssignmentRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IFreeApprovalAssignment
    {
       public new global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IFreeApprovalAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IFreeApprovalAssignmentInfo Info
       {
          get { return (global::Sungero.Docflow.IFreeApprovalAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.FreeApprovalAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// FreeApprovalAssignmentAccessRights.g.cs
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
  public class FreeApprovalAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.Docflow.IFreeApprovalAssignmentAccessRights
  {

    public FreeApprovalAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class FreeApprovalAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.Docflow.IFreeApprovalAssignmentAccessRights
  {

    public FreeApprovalAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
