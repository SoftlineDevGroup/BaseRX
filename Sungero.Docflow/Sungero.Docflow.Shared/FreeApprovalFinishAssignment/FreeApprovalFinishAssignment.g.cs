
// ==================================================================
// FreeApprovalFinishAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class FreeApprovalFinishAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.IFreeApprovalFinishAssignmentState
  {
    public FreeApprovalFinishAssignmentState(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.IFreeApprovalFinishAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new FreeApprovalFinishAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class FreeApprovalFinishAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.IFreeApprovalFinishAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("fe0d933f-02f8-4733-b110-1e49467a9cf8"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("698df64c-b849-4786-ae93-19a1f086a2a8"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState ForApprovalGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("cd77936e-884e-44bb-b869-9a60f9f5f2b4"));
        }
      }


      protected internal FreeApprovalFinishAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class FreeApprovalFinishAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.IFreeApprovalFinishAssignmentControlStates
  {

    protected internal FreeApprovalFinishAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class FreeApprovalFinishAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.IFreeApprovalFinishAssignmentPageStates
  {

    protected internal FreeApprovalFinishAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class FreeApprovalFinishAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.IFreeApprovalFinishAssignmentPropertyStates
  {

    protected internal FreeApprovalFinishAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// FreeApprovalFinishAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{  
}

// ==================================================================
// FreeApprovalFinishAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class FreeApprovalFinishAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.IFreeApprovalFinishAssignmentInfo
  {
    public FreeApprovalFinishAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IFreeApprovalFinishAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalFinishAssignmentActionsInfo(entityType);
    }
  }

  public class FreeApprovalFinishAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.IFreeApprovalFinishAssignmentPropertiesInfo
  {

    protected internal FreeApprovalFinishAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class FreeApprovalFinishAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.IFreeApprovalFinishAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }


    protected internal FreeApprovalFinishAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class FreeApprovalFinishAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; }
    }

    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void ForApprovalGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void ForApprovalGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void ForApprovalGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public FreeApprovalFinishAssignmentSharedHandlers(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FreeApprovalFinishAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.FreeApprovalFinishAssignment
{
  /// <summary>
  /// Represents FreeApprovalFinishAssignment resources.
  /// </summary>
  public class FreeApprovalFinishAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.FreeApprovalFinishAssignment.IFreeApprovalFinishAssignmentResources
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class FreeApprovalFinishAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalFinishAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalFinishAssignment)this.Entity; }
    }

    public FreeApprovalFinishAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalFinishAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class FreeApprovalFinishAssignment
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.FreeApprovalFinishAssignment
{

  public class FreeApprovalFinishAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterInfo
  {
  }

  public class FreeApprovalFinishAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.IFreeApprovalFinishAssignmentFilterState
  {



    public new Sungero.Docflow.IFreeApprovalFinishAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IFreeApprovalFinishAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.FreeApprovalFinishAssignment.FreeApprovalFinishAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// FreeApprovalFinishAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class FreeApprovalFinishAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.IFreeApprovalFinishAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalFinishAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{

  public class FreeApprovalFinishAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalFinishAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Content.IElectronicDocument> ElectronicDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Content.IElectronicDocument>();
        } 
      }


    public FreeApprovalFinishAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "fe0d933f-02f8-4733-b110-1e49467a9cf8") { }
  }

  public class FreeApprovalFinishAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalFinishAssignmentOtherGroupAttachments
  {

    public FreeApprovalFinishAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "698df64c-b849-4786-ae93-19a1f086a2a8") { }
  }

  public class FreeApprovalFinishAssignmentForApprovalGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalFinishAssignmentForApprovalGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Content.IElectronicDocument> ElectronicDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Content.IElectronicDocument>();
        } 
      }


    public FreeApprovalFinishAssignmentForApprovalGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "cd77936e-884e-44bb-b869-9a60f9f5f2b4") { }
  }

}

// ==================================================================
// FreeApprovalFinishAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.FreeApprovalFinishAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V2 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(2, global::System.Guid.Parse("7ce6852c-2346-4ea5-86d4-bdac0b1902d0"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V3 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(3, global::System.Guid.Parse("b87fbd2e-278a-439c-a10a-716de8bd84bf"));
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
          global::System.Guid.Parse("77f43035-9f23-4a19-9882-5a6a2cd5c9c7"));
      }
    }

}
