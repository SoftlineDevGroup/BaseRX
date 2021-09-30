
// ==================================================================
// DeadlineExtensionNotification.g.cs
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
  public class DeadlineExtensionNotification :
    global::Sungero.Workflow.Client.Notice, global::Sungero.RecordManagement.IDeadlineExtensionNotification
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("db855988-d42a-4cc5-a610-afff7ffb9560");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.DeadlineExtensionNotification.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDeadlineExtensionNotification, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IDeadlineExtensionNotificationState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionNotificationState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionNotificationState(this);
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionNotificationInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionNotificationInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IDeadlineExtensionNotificationAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IDeadlineExtensionNotificationAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _NewDeadline;

        public virtual global::System.DateTime? NewDeadline
        {
          get { return this._NewDeadline.Value; }
          set { this._NewDeadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _PreviousDeadline;

        public virtual global::System.DateTime? PreviousDeadline
        {
          get { return this._PreviousDeadline.Value; }
          set { this._PreviousDeadline.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineExtensionNotificationFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.DeadlineExtensionNotificationClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NewDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.NewDeadline, this.NewDeadline, this);
     ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).NewDeadlineChanged(args);
    }

    protected void PreviousDeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.PreviousDeadline, this.PreviousDeadline, this);
     ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).PreviousDeadlineChanged(args);
    }



  protected global::System.DateTime? NewDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.NewDeadline, value, this, this.Info.Properties.NewDeadline);
    ((global::Sungero.RecordManagement.DeadlineExtensionNotificationClientHandlers)this.Handlers).NewDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? PreviousDeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.PreviousDeadline, value, this, this.Info.Properties.PreviousDeadline);
    ((global::Sungero.RecordManagement.DeadlineExtensionNotificationClientHandlers)this.Handlers).PreviousDeadlineValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors







    public DeadlineExtensionNotification()
    {
            this._NewDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("NewDeadline", this);
            this._NewDeadline.ValueChanged += (sender, e) => { this.NewDeadlineChangedHandler(); };
            this.AddProperty(this._NewDeadline);

            this._PreviousDeadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("PreviousDeadline", this);
            this._PreviousDeadline.ValueChanged += (sender, e) => { this.PreviousDeadlineChangedHandler(); };
            this.AddProperty(this._PreviousDeadline);








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionNotificationDocumentsGroupAttachments DocumentsGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionNotificationDocumentsGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionNotificationAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionNotificationAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IDeadlineExtensionNotificationOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.DeadlineExtensionNotificationOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).DocumentsGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).DocumentsGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentsGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).DocumentsGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.DeadlineExtensionNotificationSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// DeadlineExtensionNotificationPresenter.g.cs
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
  public class DeadlineExtensionNotificationPresenter<T> :
    global::Sungero.Workflow.Client.NoticePresenter<T>
    where T : class, global::Sungero.RecordManagement.IDeadlineExtensionNotification
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
              this._AuthorCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Author");

              this._PerformerCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.CoreEntities.IUser>(() => this.Entity.Id, typeof(T), "Performer");

              this._TaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "Task");

              this._MainTaskCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Workflow.ITask>(() => this.Entity.Id, typeof(T), "MainTask");


    }

    public DeadlineExtensionNotificationPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// DeadlineExtensionNotificationCollectionPresenter.g.cs
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
  public class DeadlineExtensionNotificationCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.NoticeCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IDeadlineExtensionNotification
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public DeadlineExtensionNotificationCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public DeadlineExtensionNotificationCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public DeadlineExtensionNotificationCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public DeadlineExtensionNotificationCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// DeadlineExtensionNotificationRepositoryImplementer.g.cs
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
  public class DeadlineExtensionNotificationRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.NoticeRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IDeadlineExtensionNotificationRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IDeadlineExtensionNotification
    {
       public new global::Sungero.RecordManagement.IDeadlineExtensionNotificationAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IDeadlineExtensionNotificationAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IDeadlineExtensionNotificationInfo Info
       {
          get { return (global::Sungero.RecordManagement.IDeadlineExtensionNotificationInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.DeadlineExtensionNotificationTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DeadlineExtensionNotificationAccessRights.g.cs
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
  public class DeadlineExtensionNotificationAccessRights : 
    Sungero.Workflow.Client.NoticeAccessRights, Sungero.RecordManagement.IDeadlineExtensionNotificationAccessRights
  {

    public DeadlineExtensionNotificationAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DeadlineExtensionNotificationTypeAccessRights : 
    Sungero.Workflow.Client.NoticeTypeAccessRights, Sungero.RecordManagement.IDeadlineExtensionNotificationAccessRights
  {

    public DeadlineExtensionNotificationTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}