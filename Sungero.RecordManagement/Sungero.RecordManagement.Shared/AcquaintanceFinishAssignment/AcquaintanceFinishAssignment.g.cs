
// ==================================================================
// AcquaintanceFinishAssignmentState.g.cs
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
  public class AcquaintanceFinishAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentState
  {
    public AcquaintanceFinishAssignmentState(global::Sungero.RecordManagement.IAcquaintanceFinishAssignment entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceFinishAssignmentPropertyStates(entity);
    }


    public new global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentControlStates Controls
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceFinishAssignmentControlStates(entity);
    }

    public new global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPageStates Pages
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceFinishAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentAttachmentStates Attachments { get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new AcquaintanceFinishAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class AcquaintanceFinishAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("a9f0df39-6287-42dd-a325-849fe22412af"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("fb96c0c8-6657-40ee-ac6e-2442bf14bbce"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("19c1e8c9-e896-4d93-a1e8-4e22b932c1ce"));
        }
      }


      protected internal AcquaintanceFinishAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class AcquaintanceFinishAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentControlStates
  {

    protected internal AcquaintanceFinishAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class AcquaintanceFinishAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPageStates
  {

    protected internal AcquaintanceFinishAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class AcquaintanceFinishAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Description 
            {
              get { return this.GetPropertyState<global::System.String>("Description"); }
            }


    protected internal AcquaintanceFinishAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// AcquaintanceFinishAssignmentEventArgs.g.cs
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
// AcquaintanceFinishAssignmentInfo.g.cs
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
  public class AcquaintanceFinishAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentInfo
  {
    public AcquaintanceFinishAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceFinishAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceFinishAssignmentActionsInfo(entityType);
    }
  }

  public class AcquaintanceFinishAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Description 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Description");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal AcquaintanceFinishAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class AcquaintanceFinishAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ShowAcquaintanceReport 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ShowAcquaintanceReport")); }
        }


    protected internal AcquaintanceFinishAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// AcquaintanceFinishAssignmentHandlers.g.cs
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
  public partial class AcquaintanceFinishAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceFinishAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignment)this.Entity; }
    }
    public virtual void DescriptionChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public AcquaintanceFinishAssignmentSharedHandlers(global::Sungero.RecordManagement.IAcquaintanceFinishAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceFinishAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared.AcquaintanceFinishAssignment
{
  /// <summary>
  /// Represents AcquaintanceFinishAssignment resources.
  /// </summary>
  public class AcquaintanceFinishAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.RecordManagement.AcquaintanceFinishAssignment.IAcquaintanceFinishAssignmentResources
  {
  }
}

// ==================================================================
// AcquaintanceFinishAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared
{
  public partial class AcquaintanceFinishAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.RecordManagement.IAcquaintanceFinishAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignment)this.Entity; }
    }

    public AcquaintanceFinishAssignmentFunctions(global::Sungero.RecordManagement.IAcquaintanceFinishAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// AcquaintanceFinishAssignmentFunctions.g.cs
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
  internal static class AcquaintanceFinishAssignment
  {
  }
}

// ==================================================================
// AcquaintanceFinishAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Shared.AcquaintanceFinishAssignment
{

  public class AcquaintanceFinishAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterInfo
  {
  }

  public class AcquaintanceFinishAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterState
  {



    public new Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.RecordManagement.Shared.AcquaintanceFinishAssignment.AcquaintanceFinishAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// AcquaintanceFinishAssignmentSharedPublicFunctions.g.cs
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
  public class AcquaintanceFinishAssignmentSharedPublicFunctions : global::Sungero.RecordManagement.Shared.IAcquaintanceFinishAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceFinishAssignmentAttachmentGroups.g.cs
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

  public class AcquaintanceFinishAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public AcquaintanceFinishAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "a9f0df39-6287-42dd-a325-849fe22412af") { }
  }

  public class AcquaintanceFinishAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentOtherGroupAttachments
  {

    public AcquaintanceFinishAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "fb96c0c8-6657-40ee-ac6e-2442bf14bbce") { }
  }

  public class AcquaintanceFinishAssignmentDocumentGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentDocumentGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public AcquaintanceFinishAssignmentDocumentGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "19c1e8c9-e896-4d93-a1e8-4e22b932c1ce") { }
  }

}

// ==================================================================
// AcquaintanceFinishAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.AcquaintanceFinishAssignment
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
          global::System.Guid.Parse("2d53959b-2cee-41f7-83c2-98ae1dbbd538"));
      }
    }

}
