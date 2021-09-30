
// ==================================================================
// DeadlineExtensionAssignment.g.cs
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
  public class DeadlineExtensionAssignment :
    global::Sungero.Workflow.Client.Assignment, global::Sungero.RecordManagement.IDeadlineExtensionAssignment
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8a5b9f7b-0c69-455f-95b2-8b525b4e7bb1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.DeadlineExtensionAssignment.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDeadlineExtensionAssignment, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentState(this);
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _NewDeadline;

        public virtual global::System.DateTime? NewDeadline
        {
          get { return this._NewDeadline.Value; }
          set { this._NewDeadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _ScheduledDate;

        public virtual global::System.DateTime? ScheduledDate
        {
          get { return this._ScheduledDate.Value; }
          set { this._ScheduledDate.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _ResultItems = new global::Sungero.Domain.Shared.EnumerationItems(
          global::Sungero.Workflow.Client.Assignment.ResultItems,
          typeof(global::Sungero.RecordManagement.DeadlineExtensionAssignment.Result),
          typeof(global::Sungero.RecordManagement.Client.DeadlineExtensionAssignment),
          "Result");

        public static new global::Sungero.Domain.Shared.EnumerationItems ResultItems
        {
          get { return global::Sungero.RecordManagement.Client.DeadlineExtensionAssignment._ResultItems; }
        }

        public override global::Sungero.Domain.Shared.EnumerationItems ResultAllowedItems
        {
          get { return global::Sungero.RecordManagement.Client.DeadlineExtensionAssignment.ResultItems; }
        }








      protected global::Sungero.Domain.Client.TextProperty _Reason;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Reason
      {
        get { return this._Reason.Value; }
        set { this._Reason.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.DeadlineExtensionAssignmentClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void ScheduledDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.ScheduledDate, this.ScheduledDate, this);
     ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).ScheduledDateChanged(args);
    }

    protected void ReasonChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Reason, this.Reason, this);
     ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).ReasonChanged(args);
    }



  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentClientHandlers)this.Handlers).NewDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? ScheduledDateValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.ScheduledDate, value, this, this.Info.Properties.ScheduledDate);
    ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentClientHandlers)this.Handlers).ScheduledDateValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ReasonValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Reason, value, this, this.Info.Properties.Reason);
    ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentClientHandlers)this.Handlers).ReasonValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors








    public DeadlineExtensionAssignment()
    {
            this._NewDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("NewDeadline", this);
            this._NewDeadline.ValueChanged += (sender, e) => { this.NewDeadlineChangedHandler(); };
            this.AddProperty(this._NewDeadline);

            this._ScheduledDate = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("ScheduledDate", this);
            this._ScheduledDate.ValueChanged += (sender, e) => { this.ScheduledDateChangedHandler(); };
            this.AddProperty(this._ScheduledDate);



            this._Reason = new global::Sungero.Domain.Client.TextProperty("Reason", this);
            this._Reason.ValueChanged += (sender, e) => { this.ReasonChangedHandler(); };
            this.AddProperty(this._Reason);






      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionAssignmentOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionAssignmentDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionAssignmentDocumentsGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionAssignmentSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// DeadlineExtensionAssignmentPresenter.g.cs
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
  public class DeadlineExtensionAssignmentPresenter<T> :
    global::Sungero.Workflow.Client.AssignmentPresenter<T>
    where T : class, global::Sungero.RecordManagement.IDeadlineExtensionAssignment
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




    #endregion

    #region Methods

              private bool CanAccept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.RecordManagement.Client.DeadlineExtensionAssignment).ActionsHandlers).CanAccept(args);
              }

              private void Accept(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.Accept);
                ((Sungero.RecordManagement.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.RecordManagement.Client.DeadlineExtensionAssignment).ActionsHandlers).Accept(args);
              }

              private bool CanForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.CanExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity);
                return ((Sungero.RecordManagement.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.RecordManagement.Client.DeadlineExtensionAssignment).ActionsHandlers).CanForRework(args);
              }

              private void ForRework(T entity)
              {
                var args = new global::Sungero.Workflow.Client.ExecuteResultActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, entity.Info.Actions.ForRework);
                ((Sungero.RecordManagement.Client.DeadlineExtensionAssignmentActions)(entity as Sungero.RecordManagement.Client.DeadlineExtensionAssignment).ActionsHandlers).ForRework(args);
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

    public DeadlineExtensionAssignmentPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DeadlineExtensionAssignmentCollectionPresenter.g.cs
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
  public class DeadlineExtensionAssignmentCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.AssignmentCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IDeadlineExtensionAssignment
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DeadlineExtensionAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DeadlineExtensionAssignmentCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DeadlineExtensionAssignmentCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DeadlineExtensionAssignmentCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DeadlineExtensionAssignmentRepositoryImplementer.g.cs
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
  public class DeadlineExtensionAssignmentRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.AssignmentRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IDeadlineExtensionAssignmentRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IDeadlineExtensionAssignment
    {
       public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IDeadlineExtensionAssignmentInfo Info
       {
          get { return (global::Sungero.RecordManagement.IDeadlineExtensionAssignmentInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.DeadlineExtensionAssignmentTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DeadlineExtensionAssignmentAccessRights.g.cs
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
  public class DeadlineExtensionAssignmentAccessRights : 
    Sungero.Workflow.Client.AssignmentAccessRights, Sungero.RecordManagement.IDeadlineExtensionAssignmentAccessRights
  {

    public DeadlineExtensionAssignmentAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineExtensionAssignmentTypeAccessRights : 
    Sungero.Workflow.Client.AssignmentTypeAccessRights, Sungero.RecordManagement.IDeadlineExtensionAssignmentAccessRights
  {

    public DeadlineExtensionAssignmentTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}