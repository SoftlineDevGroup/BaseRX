
// ==================================================================
// DocumentReviewTask.g.cs
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
  public class DocumentReviewTask :
    global::Sungero.Workflow.Client.Task, global::Sungero.RecordManagement.IDocumentReviewTask
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.DocumentReviewTask.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDocumentReviewTask, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IDocumentReviewTaskState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IDocumentReviewTaskState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskState(this);
    }

    public new global::Sungero.RecordManagement.IDocumentReviewTaskInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IDocumentReviewTaskInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IDocumentReviewTaskAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IDocumentReviewTaskAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.DocumentReviewTaskAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _Deadline;

        public virtual global::System.DateTime? Deadline
        {
          get { return this._Deadline.Value; }
          set { this._Deadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _NeedDeleteActionItems;

        public virtual global::System.Boolean? NeedDeleteActionItems
        {
          get { return this._NeedDeleteActionItems.Value; }
          set { this._NeedDeleteActionItems.Value = value; }
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







          protected global::Sungero.Domain.Client.IListProperty<global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers> _ResolutionObservers;

          virtual public global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers> ResolutionObservers
          {
            get { return this._ResolutionObservers.Value; }
          }




      protected global::Sungero.Domain.Client.TextProperty _ResolutionText;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ResolutionText
      {
        get { return this._ResolutionText.Value; }
        set { this._ResolutionText.Value = value; }
      }



    private object _ResolutionObserversActionsHandlers;

    public object ResolutionObserversActionsHandlers
    {
      get
      {
        if (this._ResolutionObserversActionsHandlers == null)
          this._ResolutionObserversActionsHandlers = this.CreateResolutionObserversActionsHandlers();
        return this._ResolutionObserversActionsHandlers;
      }
    }

    private object _ResolutionObserversCollectionActionsHandlers;

    public object ResolutionObserversCollectionActionsHandlers
    {
      get
      {
        if (this._ResolutionObserversCollectionActionsHandlers == null)
          this._ResolutionObserversCollectionActionsHandlers = this.CreateResolutionObserversCollectionActionsHandlers();
        return this._ResolutionObserversCollectionActionsHandlers;
      }
    }

    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DocumentReviewTaskActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DocumentReviewTaskCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DocumentReviewTaskAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DocumentReviewTaskAnyChildEntityCollectionActions();
    }

    protected object CreateResolutionObserversActionsHandlers()
    {
      return null;
    }

    protected object CreateResolutionObserversCollectionActionsHandlers()
    {
      return null;
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.DocumentReviewTaskFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.DocumentReviewTaskClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.DocumentReviewTaskAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).AddresseeChanged(args);
    }

    protected void DeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Deadline, this.Deadline, this);
     ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).DeadlineChanged(args);
    }

    protected void ResolutionTextChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ResolutionText, this.ResolutionText, this);
     ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).ResolutionTextChanged(args);
    }

    protected void ResolutionObserversChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs(this);
     ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).ResolutionObserversChanged(args);
    }

    protected void NeedDeleteActionItemsChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.NeedDeleteActionItems, this.NeedDeleteActionItems, this);
     ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).NeedDeleteActionItemsChanged(args);
    }




    protected virtual global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversSharedCollectionHandlers CreateResolutionObserversAddedHandler(global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversSharedCollectionHandlers(this, e.Value, null, e.Source);
    }

    protected virtual global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversSharedCollectionHandlers CreateResolutionObserversDeletedHandler(global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {
      return new global::Sungero.RecordManagement.DocumentReviewTaskResolutionObserversSharedCollectionHandlers(this, null, e.Value, null);
    }

    protected virtual void ResolutionObserversAddedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityAddedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {  
      var collectionHandlers = this.CreateResolutionObserversAddedHandler(e);
      if (collectionHandlers != null)
      {
        var args = new global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs(this);
        collectionHandlers.ResolutionObserversAdded(args);
      }
    }

    protected virtual void ResolutionObserversDeletedHandler(object sender, global::Sungero.Domain.Shared.ChildEntityDeletedEventArgs<global::Sungero.Domain.Shared.IChildEntity> e)
    {  
      var collectionHandlers = this.CreateResolutionObserversDeletedHandler(e);
      if (collectionHandlers != null)
      {
        var args = new global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs(this);
        collectionHandlers.ResolutionObserversDeleted(args);
      }
    }


  protected global::Sungero.Company.IEmployee AddresseeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.DocumentReviewTaskAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.RecordManagement.DocumentReviewTaskClientHandlers)this.Handlers).AddresseeValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? DeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.Deadline, value, this, this.Info.Properties.Deadline);
    ((global::Sungero.RecordManagement.DocumentReviewTaskClientHandlers)this.Handlers).DeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ResolutionTextValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ResolutionText, value, this, this.Info.Properties.ResolutionText);
    ((global::Sungero.RecordManagement.DocumentReviewTaskClientHandlers)this.Handlers).ResolutionTextValueInput(args);
    return args.NewValue;
  }


  protected global::System.Boolean? NeedDeleteActionItemsValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.NeedDeleteActionItems, value, this, this.Info.Properties.NeedDeleteActionItems);
    ((global::Sungero.RecordManagement.DocumentReviewTaskClientHandlers)this.Handlers).NeedDeleteActionItemsValueInput(args);
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



            protected override void InitObserversCollectionProperty()
            {
              this._Observers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IDocumentReviewTaskObservers>("Observers", this);
              this._Observers.ValueChanged += (sender, e) => { this.ObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._Observers);
              this.SetObserversEventHandlers();
            }

            protected virtual void InitResolutionObserversCollectionProperty()
            {
              this._ResolutionObservers = new global::Sungero.Domain.Client.ListProperty<global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers>("ResolutionObservers", this);
              this._ResolutionObservers.ValueChanged += (sender, e) => { this.ResolutionObserversChangedHandler(); };
              this.AddProperty((global::Sungero.Domain.Client.IProperty)this._ResolutionObservers);
              this.SetResolutionObserversEventHandlers();
            }

            protected void SetResolutionObserversEventHandlers()
            {
              this._ResolutionObservers.ChildEntityAdded += this.ResolutionObserversAddedHandler;
              this._ResolutionObservers.ChildEntityDeleted += this.ResolutionObserversDeletedHandler;
            }


    public DocumentReviewTask()
    {
            this._Deadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("Deadline", this);
            this._Deadline.ValueChanged += (sender, e) => { this.DeadlineChangedHandler(); };
            this.AddProperty(this._Deadline);

            this._NeedDeleteActionItems = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("NeedDeleteActionItems", this);
            this._NeedDeleteActionItems.ValueChanged += (sender, e) => { this.NeedDeleteActionItemsChangedHandler(); };
            this.AddProperty(this._NeedDeleteActionItems);

            this.InitAddresseeNavigationProperty();


            this.InitResolutionObserversCollectionProperty();


            this._ResolutionText = new global::Sungero.Domain.Client.TextProperty("ResolutionText", this);
            this._ResolutionText.ValueChanged += (sender, e) => { this.ResolutionTextChangedHandler(); };
            this.AddProperty(this._ResolutionText);






      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IDocumentReviewTaskDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskDocumentForReviewGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDocumentReviewTaskAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDocumentReviewTaskOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDocumentReviewTaskResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskResolutionGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.DocumentReviewTaskSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// DocumentReviewTaskPresenter.g.cs
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
  public class DocumentReviewTaskPresenter<T> :
    global::Sungero.Workflow.Client.TaskPresenter<T>
    where T : class, global::Sungero.RecordManagement.IDocumentReviewTask
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _AddResolutionCommand;

          public global::System.Windows.Input.ICommand AddResolutionCommand
          {
            get
            {
              if (this._AddResolutionCommand == null)
                  this._AddResolutionCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("AddResolution", this, this.AddResolution, this.CanAddResolution) { IsEmptyParameterAllowed = true };
              return this._AddResolutionCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanAddResolution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.RecordManagement.Client.DocumentReviewTaskActions)(entity as Sungero.RecordManagement.Client.DocumentReviewTask).ActionsHandlers).CanAddResolution(args);
              }

              private void AddResolution(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.AddResolution);
                ((Sungero.RecordManagement.Client.DocumentReviewTaskActions)(entity as Sungero.RecordManagement.Client.DocumentReviewTask).ActionsHandlers).AddResolution(args);
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


                          protected global::Sungero.Domain.Client.IEntityCollectionPresenter _ResolutionObserversObserverCollectionPresenter;
                          public global::Sungero.Domain.Client.IEntityCollectionPresenter ResolutionObserversObserverCollectionPresenter
                          {
                  get { return this._ResolutionObserversObserverCollectionPresenter; }
                }



    #region Constructors

    private void Init()
    {
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationProperty<global::Sungero.CoreEntities.IUser>(() => this.Entity, typeof(T), "Author");

              this._StartedByCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "StartedBy");

              this._ParentTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "ParentTask");

              this._ParentAssignmentCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.IAssignmentBase>(() => this.Entity.Id, typeof(T), "ParentAssignment");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");

                  this._AddresseeCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Company.IEmployee>(global::System.Guid.Parse("d549a15d-9ca0-4128-9897-222ee4d3b056"));
              this._AddresseeCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Company.IEmployee>(() => this.Entity.Id, typeof(T), "Addressee");


                        this._ObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IDocumentReviewTaskObservers), "Observer");


                          this._ResolutionObserversObserverCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.CoreEntities.IRecipient>(global::System.Guid.Parse("7edb8486-b86f-4019-aea1-94d76e606a38"));
                        this._ResolutionObserversObserverCollectionPresenter
                        .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IRecipient>(() => this.Entity.Id, typeof(Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers), "Observer");


    }

    public DocumentReviewTaskPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DocumentReviewTaskCollectionPresenter.g.cs
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
  public class DocumentReviewTaskCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.TaskCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IDocumentReviewTask
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DocumentReviewTaskCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DocumentReviewTaskCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DocumentReviewTaskCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DocumentReviewTaskCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DocumentReviewTaskRepositoryImplementer.g.cs
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
  public class DocumentReviewTaskRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.TaskRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IDocumentReviewTaskRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IDocumentReviewTask
    {
       public new global::Sungero.RecordManagement.IDocumentReviewTaskAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IDocumentReviewTaskAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IDocumentReviewTaskInfo Info
       {
          get { return (global::Sungero.RecordManagement.IDocumentReviewTaskInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.DocumentReviewTaskTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentReviewTaskAccessRights.g.cs
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
  public class DocumentReviewTaskAccessRights : 
    Sungero.Workflow.Client.TaskAccessRights, Sungero.RecordManagement.IDocumentReviewTaskAccessRights
  {

    public DocumentReviewTaskAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentReviewTaskTypeAccessRights : 
    Sungero.Workflow.Client.TaskTypeAccessRights, Sungero.RecordManagement.IDocumentReviewTaskAccessRights
  {

    public DocumentReviewTaskTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}