
// ==================================================================
// ReviewClerkNotification.g.cs
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
  public class ReviewClerkNotification :
    global::Sungero.Workflow.Client.Notice, global::Sungero.RecordManagement.IReviewClerkNotification
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4ca82b63-1b51-4aef-a42b-57b7c97dab64");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ReviewClerkNotification.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewClerkNotification, Sungero.Domain.Interfaces"; }
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


    public new global::Sungero.RecordManagement.IReviewClerkNotificationState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewClerkNotificationState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationState(this);
    }

    public new global::Sungero.RecordManagement.IReviewClerkNotificationInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewClerkNotificationInfo)base.Info;
      }
    }

    public new global::Sungero.RecordManagement.IReviewClerkNotificationAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.RecordManagement.IReviewClerkNotificationAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewClerkNotificationClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public ReviewClerkNotification()
    {








      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #endregion

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewClerkNotificationResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationResolutionGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewClerkNotificationAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewClerkNotificationOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationOtherGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewClerkNotificationDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewClerkNotificationDocumentForReviewGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewClerkNotificationSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// ReviewClerkNotificationPresenter.g.cs
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
  public class ReviewClerkNotificationPresenter<T> :
    global::Sungero.Workflow.Client.NoticePresenter<T>
    where T : class, global::Sungero.RecordManagement.IReviewClerkNotification
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

    public ReviewClerkNotificationPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ReviewClerkNotificationCollectionPresenter.g.cs
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
  public class ReviewClerkNotificationCollectionPresenter<T> : 
    global::Sungero.Workflow.Client.NoticeCollectionPresenter<T>
    where T: class, global::Sungero.RecordManagement.IReviewClerkNotification
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ReviewClerkNotificationCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ReviewClerkNotificationCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ReviewClerkNotificationCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ReviewClerkNotificationCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ReviewClerkNotificationRepositoryImplementer.g.cs
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
  public class ReviewClerkNotificationRepositoryImplementer<T> : 
      global::Sungero.Workflow.Client.NoticeRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewClerkNotificationRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewClerkNotification
    {
       public new global::Sungero.RecordManagement.IReviewClerkNotificationAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewClerkNotificationAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewClerkNotificationInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewClerkNotificationInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Client.ReviewClerkNotificationTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewClerkNotificationAccessRights.g.cs
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
  public class ReviewClerkNotificationAccessRights : 
    Sungero.Workflow.Client.NoticeAccessRights, Sungero.RecordManagement.IReviewClerkNotificationAccessRights
  {

    public ReviewClerkNotificationAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewClerkNotificationTypeAccessRights : 
    Sungero.Workflow.Client.NoticeTypeAccessRights, Sungero.RecordManagement.IReviewClerkNotificationAccessRights
  {

    public ReviewClerkNotificationTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
