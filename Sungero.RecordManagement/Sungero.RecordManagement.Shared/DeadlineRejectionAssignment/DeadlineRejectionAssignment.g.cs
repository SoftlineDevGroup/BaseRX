
// ==================================================================
// DeadlineRejectionAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DeadlineRejectionAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentState
  {
    public DeadlineRejectionAssignmentState(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new DeadlineRejectionAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class DeadlineRejectionAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("40dc1024-52c0-4a37-bd51-eb03d9b963e3"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("016ebd36-1503-4a7a-ab6e-4b4bbd2a94a7"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentsGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("431d8004-a022-415b-b622-917af0d570bb"));
        }
      }


      protected internal DeadlineRejectionAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class DeadlineRejectionAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("99fe3c5b-b080-4a34-9bce-85c94a6f4f51")); }
        }


    protected internal DeadlineRejectionAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DeadlineRejectionAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState State
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("State"); }
        }


    protected internal DeadlineRejectionAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DeadlineRejectionAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NewDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NewDeadline"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> CurrentDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("CurrentDeadline"); }
            }


    protected internal DeadlineRejectionAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DeadlineRejectionAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{  
}

// ==================================================================
// DeadlineRejectionAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DeadlineRejectionAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentInfo
  {
    public DeadlineRejectionAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IDeadlineRejectionAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DeadlineRejectionAssignmentActionsInfo(entityType);
    }
  }

  public class DeadlineRejectionAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo NewDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("NewDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo CurrentDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("CurrentDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }


    protected internal DeadlineRejectionAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class DeadlineRejectionAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IDeadlineRejectionAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Accept 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Accept")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ForRework 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForRework")); }
        }


    protected internal DeadlineRejectionAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentHandlers.g.cs
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
  public partial class DeadlineRejectionAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Entity; }
    }
    public virtual void NewDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void CurrentDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentsGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentsGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentsGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public DeadlineRejectionAssignmentSharedHandlers(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineRejectionAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.DeadlineRejectionAssignment
{
  /// <summary>
  /// Represents DeadlineRejectionAssignment resources.
  /// </summary>
  public class DeadlineRejectionAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.DeadlineRejectionAssignment.IDeadlineRejectionAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString RequestCommentNotFilled
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineRejectionAssignment) , "RequestCommentNotFilled");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RequestCommentNotFilledFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineRejectionAssignment), "RequestCommentNotFilled", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString RequestedRepeatedly
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineRejectionAssignment) , "RequestedRepeatedly");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RequestedRepeatedlyFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineRejectionAssignment), "RequestedRepeatedly", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString RequestedAccepted
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineRejectionAssignment) , "RequestedAccepted");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RequestedAcceptedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IDeadlineRejectionAssignment), "RequestedAccepted", false, args);
    }

  }
}

// ==================================================================
// DeadlineRejectionAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class DeadlineRejectionAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Entity; }
    }

    public DeadlineRejectionAssignmentFunctions(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentFunctions.g.cs
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
  internal static class DeadlineRejectionAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DeadlineRejectionAssignmentFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDeadlineRejectionAssignment deadlineRejectionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("dea721dd-12f9-498a-93e9-451a1fbfad67"),
          "GetStateView(global::Sungero.RecordManagement.IDeadlineRejectionAssignment)"
          , deadlineRejectionAssignment);
      }

    }
  }
}

// ==================================================================
// DeadlineRejectionAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.DeadlineRejectionAssignment
{

  public class DeadlineRejectionAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterInfo
  {
  }

  public class DeadlineRejectionAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState
  {



    public new Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.DeadlineRejectionAssignment.DeadlineRejectionAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// DeadlineRejectionAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DeadlineRejectionAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IDeadlineRejectionAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineRejectionAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{

  public class DeadlineRejectionAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineRejectionAssignmentAddendaGroupAttachments
  {

    public DeadlineRejectionAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "40dc1024-52c0-4a37-bd51-eb03d9b963e3") { }
  }

  public class DeadlineRejectionAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineRejectionAssignmentOtherGroupAttachments
  {

    public DeadlineRejectionAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "016ebd36-1503-4a7a-ab6e-4b4bbd2a94a7") { }
  }

  public class DeadlineRejectionAssignmentDocumentsGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IDeadlineRejectionAssignmentDocumentsGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public DeadlineRejectionAssignmentDocumentsGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "431d8004-a022-415b-b622-917af0d570bb") { }
  }

}

// ==================================================================
// DeadlineRejectionAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.DeadlineRejectionAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
}

    public static class TaskExtensions
    {
      /// <summary>
      /// Получить версию схемы запущенной задачи.
      /// </summary>
      /// <param name="task">Задача.</param>
      /// <returns>Версия схемы запущенной задачи.</returns>
      public static global::Sungero.Workflow.Shared.ExtendedSchemeVersion GetStartedSchemeVersion(this global::Sungero.Workflow.ITask task)
      {
        return global::Sungero.Workflow.Shared.OverriddenTaskHelper.FindLayerSchemeVersionForTask(task,
          global::System.Guid.Parse("67b46acc-07a9-43ed-86dc-8f9dc3ccf12f"));
      }
    }

}
