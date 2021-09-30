
// ==================================================================
// ReviewObserverNotification.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
    public class ReviewObserverNotificationFilter<T> :
      global::Sungero.Workflow.Server.NoticeFilter<T>
      where T : class, global::Sungero.RecordManagement.IReviewObserverNotification
    {
      protected new global::Sungero.RecordManagement.IReviewObserverNotificationFilterState Filter { get; private set; }

      private global::Sungero.RecordManagement.IReviewObserverNotificationFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ReviewObserverNotificationFilter(global::Sungero.RecordManagement.IReviewObserverNotificationFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ReviewObserverNotificationFilter()
      {
      }
    }
    public class ReviewObserverNotificationSearchDialogModel : global::Sungero.Workflow.Server.NoticeSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Performer { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Importance { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Deadline { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }




        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.RecordManagement.Server.ReviewObserverNotificationFilter<global::Sungero.RecordManagement.IReviewObserverNotification>))]

  public class ReviewObserverNotification :
    global::Sungero.Workflow.Server.Notice, global::Sungero.RecordManagement.IReviewObserverNotification, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("75d6c458-7725-4133-8ff4-848e16ec5bd3");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.ReviewObserverNotification.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IReviewObserverNotification, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Subject; }
      set { this.Subject = value; }
    }

    public new virtual global::Sungero.RecordManagement.IReviewObserverNotificationState State
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotificationState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewObserverNotificationState(this);
    }

    public new virtual global::Sungero.RecordManagement.IReviewObserverNotificationInfo Info
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotificationInfo)base.Info; }
    }

    public new virtual global::Sungero.RecordManagement.IReviewObserverNotificationAccessRights AccessRights
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotificationAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.RecordManagement.Server.ReviewObserverNotificationAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.RecordManagement.Server.ReviewObserverNotificationFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.RecordManagement.Shared.ReviewObserverNotificationFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ReviewObserverNotificationServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers(this);
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      return new global::Sungero.RecordManagement.ReviewObserverNotificationCreatingFromServerHandler((global::Sungero.RecordManagement.IReviewObserverNotification)entitySource, this.Info);
    }

    #region Framework events



    #endregion


    public ReviewObserverNotification()
    {
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentCreated += this.AttachmentCreatedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentAdded += this.AttachmentAddedHandler;
      ((global::Sungero.Workflow.Interfaces.IWorkflowEntity)this).AttachmentDeleted += this.AttachmentDeletedHandler;


    }

    #region Workflow attachments
    public virtual global::Sungero.RecordManagement.IReviewObserverNotificationResolutionGroupAttachments ResolutionGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewObserverNotificationResolutionGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewObserverNotificationAddendaGroupAttachments AddendaGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewObserverNotificationAddendaGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewObserverNotificationDocumentForReviewGroupAttachments DocumentForReviewGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewObserverNotificationDocumentForReviewGroupAttachments(this);
      }
    }
    public virtual global::Sungero.RecordManagement.IReviewObserverNotificationOtherGroupAttachments OtherGroup
    {
      get
      {
        return new global::Sungero.RecordManagement.Shared.ReviewObserverNotificationOtherGroupAttachments(this);
      }
    }


    private void AttachmentCreatedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).ResolutionGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).AddendaGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).DocumentForReviewGroupCreated(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).OtherGroupCreated(e);
        return;
      }

    }

    private void AttachmentAddedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).ResolutionGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).AddendaGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).DocumentForReviewGroupAdded(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).OtherGroupAdded(e);
        return;
      }

    }

    private void AttachmentDeletedHandler(object sender, global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e)
    {
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "ResolutionGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).ResolutionGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "AddendaGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).AddendaGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "DocumentForReviewGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).DocumentForReviewGroupDeleted(e);
        return;
      }
      if (((global::Sungero.Workflow.Interfaces.IInternalAttachmentEventArgs)e).GroupName == "OtherGroup")
      {
        ((global::Sungero.RecordManagement.ReviewObserverNotificationSharedHandlers)this.SharedHandlers).OtherGroupDeleted(e);
        return;
      }

    }
    #endregion

  }
}

// ==================================================================
// ReviewObserverNotificationHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

  public partial class ReviewObserverNotificationFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.RecordManagement.IReviewObserverNotification
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.RecordManagement.IReviewObserverNotificationFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IReviewObserverNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ReviewObserverNotificationFilteringServerHandler(global::Sungero.RecordManagement.IReviewObserverNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ReviewObserverNotificationFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ReviewObserverNotificationSearchDialogServerHandler : global::Sungero.Workflow.NoticeSearchDialogServerHandler
   {
     private global::Sungero.RecordManagement.Server.ReviewObserverNotificationSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.RecordManagement.Server.ReviewObserverNotificationSearchDialogModel)this.Dialog;
       }
     }

     public ReviewObserverNotificationSearchDialogServerHandler(global::Sungero.RecordManagement.Server.ReviewObserverNotificationSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ReviewObserverNotificationServerHandlers : global::Sungero.Workflow.NoticeServerHandlers
  {
    private global::Sungero.RecordManagement.IReviewObserverNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotification)this.Entity; }
    }

    public ReviewObserverNotificationServerHandlers(global::Sungero.RecordManagement.IReviewObserverNotification entity)
      : base(entity)
    {
    }
  }

  public partial class ReviewObserverNotificationCreatingFromServerHandler : global::Sungero.Workflow.NoticeCreatingFromServerHandler
  {
    private global::Sungero.RecordManagement.IReviewObserverNotification _source
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotification)this.Source; }
    }

    private global::Sungero.RecordManagement.IReviewObserverNotificationInfo _info
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotificationInfo)this._Info; }
    }

    public ReviewObserverNotificationCreatingFromServerHandler(global::Sungero.RecordManagement.IReviewObserverNotification source, global::Sungero.RecordManagement.IReviewObserverNotificationInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ReviewObserverNotificationEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}

// ==================================================================
// ReviewObserverNotificationAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class ReviewObserverNotificationAccessRights : 
    Sungero.Workflow.Server.NoticeAccessRights, Sungero.RecordManagement.IReviewObserverNotificationAccessRights
  {

    public ReviewObserverNotificationAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ReviewObserverNotificationTypeAccessRights : 
    Sungero.Workflow.Server.NoticeTypeAccessRights, Sungero.RecordManagement.IReviewObserverNotificationAccessRights
  {

    public ReviewObserverNotificationTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ReviewObserverNotificationRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
    public class ReviewObserverNotificationRepositoryImplementer<T> : 
      global::Sungero.Workflow.Server.NoticeRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IReviewObserverNotificationRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IReviewObserverNotification 
    {
       public new global::Sungero.RecordManagement.IReviewObserverNotificationAccessRights AccessRights
       {
          get { return (global::Sungero.RecordManagement.IReviewObserverNotificationAccessRights)base.AccessRights; }
       }

       public new global::Sungero.RecordManagement.IReviewObserverNotificationInfo Info
       {
          get { return (global::Sungero.RecordManagement.IReviewObserverNotificationInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.RecordManagement.Server.ReviewObserverNotificationTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ReviewObserverNotificationPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}

// ==================================================================
// ReviewObserverNotificationServerFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Server
{
  public partial class ReviewObserverNotificationFunctions : global::Sungero.Workflow.Server.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IReviewObserverNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IReviewObserverNotification)this.Entity; }
    }

    public ReviewObserverNotificationFunctions(global::Sungero.RecordManagement.IReviewObserverNotification entity) : base(entity) { }
  }
}

// ==================================================================
// ReviewObserverNotificationFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class ReviewObserverNotification
  {
  }
}

// ==================================================================
// ReviewObserverNotificationServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class ReviewObserverNotificationServerPublicFunctions : global::Sungero.RecordManagement.Server.IReviewObserverNotificationServerPublicFunctions
  {
  }
}

// ==================================================================
// ReviewObserverNotificationQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Queries
{
  public class ReviewObserverNotification
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.ReviewObserverNotification.ReviewObserverNotificationQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// ReviewObserverNotificationBlock.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class ReviewObserverNotificationArguments: global::Sungero.Workflow.Server.Route.NoticeStartEventArguments<ReviewObserverNotificationBlock, global::Sungero.Workflow.NoticeBlock>
  {
    public ReviewObserverNotificationArguments(ReviewObserverNotificationBlock block) : base(block) { }
  }

  public class ReviewObserverNotificationEndBlockEventArguments: global::Sungero.Workflow.Server.Route.NoticeEndBlockEventArguments<ReviewObserverNotificationBlock, global::Sungero.Workflow.NoticeBlock, Sungero.RecordManagement.IReviewObserverNotification> 
  {
    public ReviewObserverNotificationEndBlockEventArguments(ReviewObserverNotificationBlock block) : base(block) { }
  }

  public partial class ReviewObserverNotificationBlock : global::Sungero.Workflow.Blocks.NoticeBlockWrapper<global::Sungero.Workflow.NoticeBlock>    
  {



    public ReviewObserverNotificationBlock(global::Sungero.Workflow.NoticeBlock block) : base(block) { }
  }
}

// ==================================================================
// ReviewObserverNotificationChildWrappers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}
