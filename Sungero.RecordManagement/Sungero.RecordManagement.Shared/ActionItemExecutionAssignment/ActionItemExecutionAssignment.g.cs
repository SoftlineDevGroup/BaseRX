
// ==================================================================
// ActionItemExecutionAssignmentState.g.cs
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
  public class ActionItemExecutionAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IActionItemExecutionAssignmentState
  {
    public ActionItemExecutionAssignmentState(global::Sungero.RecordManagement.IActionItemExecutionAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IActionItemExecutionAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IActionItemExecutionAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IActionItemExecutionAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ActionItemExecutionAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ActionItemExecutionAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IActionItemExecutionAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("d44a8df5-3fe9-4a1b-a5a0-e8aaa65820da"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("13a98dcd-c5ec-4fd0-a682-424613f615d4"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ResultGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("6977b087-9b93-4527-9d0f-24d0e8b7ce88"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentsGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("804f50fe-f3da-411b-bb2e-e5373936e029"));
        }
      }


      protected internal ActionItemExecutionAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ActionItemExecutionAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IActionItemExecutionAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState Description
        {
        get { return this.GetControlState(global::System.Guid.Parse("1132e4e0-f0dd-4452-bc4c-2384b1935a7e")); }
        }
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("ce4c80d1-ba1a-4785-aaca-125e6dbdc213")); }
        }


    protected internal ActionItemExecutionAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ActionItemExecutionAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IActionItemExecutionAssignmentPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState State
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("State"); }
        }


    protected internal ActionItemExecutionAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ActionItemExecutionAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IActionItemExecutionAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ActionItem 
            {
              get { return this.GetPropertyState<global::System.String>("ActionItem"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> AssignedBy 
            {
              get { return this.InternalAssignedBy; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAssignedBy
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("AssignedBy"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> ScheduledDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("ScheduledDate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> NeedAbortChildActionItems 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("NeedAbortChildActionItems"); }
            }


    protected internal ActionItemExecutionAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ActionItemExecutionAssignmentEventArgs.g.cs
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
    public class ActionItemExecutionAssignmentAssignedByChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public ActionItemExecutionAssignmentAssignedByChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }



}

// ==================================================================
// ActionItemExecutionAssignmentInfo.g.cs
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
  public class ActionItemExecutionAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IActionItemExecutionAssignmentInfo
  {
    public ActionItemExecutionAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IActionItemExecutionAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionAssignmentActionsInfo(entityType);
    }
  }

  public class ActionItemExecutionAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IActionItemExecutionAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo ActionItem 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ActionItem");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> AssignedBy 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("AssignedBy");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo ScheduledDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("ScheduledDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo NeedAbortChildActionItems 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("NeedAbortChildActionItems");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }


    protected internal ActionItemExecutionAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ActionItemExecutionAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IActionItemExecutionAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Done 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Done")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo CreateChildActionItem 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateChildActionItem")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo RequireReport 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("RequireReport")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo CreateReplyLetter 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateReplyLetter")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo PrintActionItem 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("PrintActionItem")); }
        }


    protected internal ActionItemExecutionAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ActionItemExecutionAssignmentHandlers.g.cs
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
  public partial class ActionItemExecutionAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IActionItemExecutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignment)this.Entity; }
    }
    public virtual void ActionItemChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void AssignedByChanged(global::Sungero.RecordManagement.Shared.ActionItemExecutionAssignmentAssignedByChangedEventArgs e) { }


    public virtual void ScheduledDateChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void NeedAbortChildActionItemsChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void ResultGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void ResultGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void ResultGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentsGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentsGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentsGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ActionItemExecutionAssignmentSharedHandlers(global::Sungero.RecordManagement.IActionItemExecutionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ActionItemExecutionAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.ActionItemExecutionAssignment
{
  /// <summary>
  /// Represents ActionItemExecutionAssignment resources.
  /// </summary>
  public class ActionItemExecutionAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.ActionItemExecutionAssignment.IActionItemExecutionAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString ReportIsNotFilled
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment) , "ReportIsNotFilled");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ReportIsNotFilledFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment), "ReportIsNotFilled", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString JobExecuted
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment) , "JobExecuted");
      }
    }

    public virtual global::CommonLibrary.LocalizedString JobExecutedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment), "JobExecuted", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Abort
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment) , "Abort");
      }
    }

    public virtual global::CommonLibrary.LocalizedString AbortFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment), "Abort", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString NotAbort
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment) , "NotAbort");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NotAbortFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment), "NotAbort", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString AssignmentsNotCreated
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment) , "AssignmentsNotCreated");
      }
    }

    public virtual global::CommonLibrary.LocalizedString AssignmentsNotCreatedFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.RecordManagement.IActionItemExecutionAssignment), "AssignmentsNotCreated", false, args);
    }

  }
}

// ==================================================================
// ActionItemExecutionAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class ActionItemExecutionAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IActionItemExecutionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionAssignment)this.Entity; }
    }

    public ActionItemExecutionAssignmentFunctions(global::Sungero.RecordManagement.IActionItemExecutionAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ActionItemExecutionAssignmentFunctions.g.cs
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
  internal static class ActionItemExecutionAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemExecutionAssignmentFunctions" />
      internal static global::System.String  GetActionItemExecutionAssignmentStateView(global::Sungero.RecordManagement.IActionItemExecutionAssignment assignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("d238ef51-607e-46a5-b86a-ede4482f7f19"),
          "GetActionItemExecutionAssignmentStateView(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , assignment);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemExecutionAssignmentFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IActionItemExecutionAssignment actionItemExecutionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("d238ef51-607e-46a5-b86a-ede4482f7f19"),
          "GetStateView(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
          , actionItemExecutionAssignment);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemExecutionAssignmentFunctions" />
      internal static  global::System.Boolean IsCoAssigneeAssignamentCreated(global::Sungero.RecordManagement.IActionItemExecutionAssignment actionItemExecutionAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("d238ef51-607e-46a5-b86a-ede4482f7f19"),
          "IsCoAssigneeAssignamentCreated(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
          , actionItemExecutionAssignment);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemExecutionAssignmentFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.RecordManagement.IActionItemExecutionAssignment> GetActionItems(global::Sungero.RecordManagement.IActionItemExecutionAssignment entity)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.RecordManagement.IActionItemExecutionAssignment>>(
          global::System.Guid.Parse("d238ef51-607e-46a5-b86a-ede4482f7f19"),
          "GetActionItems(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , entity);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemExecutionAssignmentFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.CoreEntities.IUser> GetActionItemsAssignees(global::Sungero.RecordManagement.IActionItemExecutionAssignment entity)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.CoreEntities.IUser>>(
          global::System.Guid.Parse("d238ef51-607e-46a5-b86a-ede4482f7f19"),
          "GetActionItemsAssignees(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , entity);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemExecutionAssignmentFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask> GetSubActionItemExecution(global::Sungero.RecordManagement.IActionItemExecutionAssignment entity)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask>>(
          global::System.Guid.Parse("d238ef51-607e-46a5-b86a-ede4482f7f19"),
          "GetSubActionItemExecution(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , entity);
      }

    }
  }
}

// ==================================================================
// ActionItemExecutionAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.ActionItemExecutionAssignment
{

  public class ActionItemExecutionAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IActionItemExecutionAssignmentFilterInfo
  {
  }

  public class ActionItemExecutionAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IActionItemExecutionAssignmentFilterState
  {



    public new Sungero.RecordManagement.IActionItemExecutionAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IActionItemExecutionAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.ActionItemExecutionAssignment.ActionItemExecutionAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ActionItemExecutionAssignmentSharedPublicFunctions.g.cs
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
  public class ActionItemExecutionAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IActionItemExecutionAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ActionItemExecutionAssignmentAttachmentGroups.g.cs
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

  public class ActionItemExecutionAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemExecutionAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ActionItemExecutionAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "d44a8df5-3fe9-4a1b-a5a0-e8aaa65820da") { }
  }

  public class ActionItemExecutionAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemExecutionAssignmentOtherGroupAttachments
  {

    public ActionItemExecutionAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "13a98dcd-c5ec-4fd0-a682-424613f615d4") { }
  }

  public class ActionItemExecutionAssignmentResultGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemExecutionAssignmentResultGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ActionItemExecutionAssignmentResultGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "6977b087-9b93-4527-9d0f-24d0e8b7ce88") { }
  }

  public class ActionItemExecutionAssignmentDocumentsGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IActionItemExecutionAssignmentDocumentsGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ActionItemExecutionAssignmentDocumentsGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "804f50fe-f3da-411b-bb2e-e5373936e029") { }
  }

}

// ==================================================================
// ActionItemExecutionAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.ActionItemExecutionAssignment
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
          global::System.Guid.Parse("c290b098-12c7-487d-bb38-73e2c98f9789"));
      }
    }

}
