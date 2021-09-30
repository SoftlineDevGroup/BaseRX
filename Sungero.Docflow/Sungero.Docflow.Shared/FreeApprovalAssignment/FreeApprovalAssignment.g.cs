
// ==================================================================
// FreeApprovalAssignmentState.g.cs
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
  public class FreeApprovalAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.IFreeApprovalAssignmentState
  {
    public FreeApprovalAssignmentState(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.IFreeApprovalAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IFreeApprovalAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.IFreeApprovalAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.IFreeApprovalAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.IFreeApprovalAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new FreeApprovalAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class FreeApprovalAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.IFreeApprovalAssignmentAttachmentStates
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


      protected internal FreeApprovalAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class FreeApprovalAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.IFreeApprovalAssignmentControlStates
  {

    protected internal FreeApprovalAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class FreeApprovalAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.IFreeApprovalAssignmentPageStates
  {

    protected internal FreeApprovalAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class FreeApprovalAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.IFreeApprovalAssignmentPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> AddresseeDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("AddresseeDeadline"); }
            }


    protected internal FreeApprovalAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// FreeApprovalAssignmentEventArgs.g.cs
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
    public class FreeApprovalAssignmentAddresseeChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public FreeApprovalAssignmentAddresseeChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }


}

// ==================================================================
// FreeApprovalAssignmentInfo.g.cs
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
  public class FreeApprovalAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.IFreeApprovalAssignmentInfo
  {
    public FreeApprovalAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IFreeApprovalAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IFreeApprovalAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.FreeApprovalAssignmentActionsInfo(entityType);
    }
  }

  public class FreeApprovalAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.IFreeApprovalAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo AddresseeDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("AddresseeDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }


    protected internal FreeApprovalAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class FreeApprovalAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.IFreeApprovalAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo ForRework 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForRework")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Approved 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Approved")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo AddApprover 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("AddApprover")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo Forward 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Forward")); }
        }


    protected internal FreeApprovalAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// FreeApprovalAssignmentHandlers.g.cs
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
  public partial class FreeApprovalAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }
    public virtual void AddresseeDeadlineChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }



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

    public FreeApprovalAssignmentSharedHandlers(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FreeApprovalAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.FreeApprovalAssignment
{
  /// <summary>
  /// Represents FreeApprovalAssignment resources.
  /// </summary>
  public class FreeApprovalAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.FreeApprovalAssignment.IFreeApprovalAssignmentResources
  {
    public virtual global::CommonLibrary.LocalizedString ApproverAlreadyExists
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalAssignment) , "ApproverAlreadyExists");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ApproverAlreadyExistsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalAssignment), "ApproverAlreadyExists", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Enum_Operation_AddApprover
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalAssignment) , "Enum_Operation_AddApprover");
      }
    }

    public virtual global::CommonLibrary.LocalizedString Enum_Operation_AddApproverFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalAssignment), "Enum_Operation_AddApprover", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString ApprovalConfirmationMessage
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalAssignment) , "ApprovalConfirmationMessage");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ApprovalConfirmationMessageFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IFreeApprovalAssignment), "ApprovalConfirmationMessage", false, args);
    }

  }
}

// ==================================================================
// FreeApprovalAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class FreeApprovalAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.IFreeApprovalAssignment _obj
    {
      get { return (global::Sungero.Docflow.IFreeApprovalAssignment)this.Entity; }
    }

    public FreeApprovalAssignmentFunctions(global::Sungero.Docflow.IFreeApprovalAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// FreeApprovalAssignmentFunctions.g.cs
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
  internal static class FreeApprovalAssignment
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.FreeApprovalAssignmentFunctions" />
      internal static  global::System.Boolean CanForwardTo(global::Sungero.Docflow.IFreeApprovalAssignment freeApprovalAssignment, global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("01be6c28-8785-4f74-9877-e3270704452e"),
          "CanForwardTo(global::Sungero.Docflow.IFreeApprovalAssignment,global::Sungero.Company.IEmployee)"
          , freeApprovalAssignment, employee);
      }

    }
  }
}

// ==================================================================
// FreeApprovalAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.FreeApprovalAssignment
{

  public class FreeApprovalAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.IFreeApprovalAssignmentFilterInfo
  {
  }

  public class FreeApprovalAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.IFreeApprovalAssignmentFilterState
  {



    public new Sungero.Docflow.IFreeApprovalAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IFreeApprovalAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.FreeApprovalAssignment.FreeApprovalAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// FreeApprovalAssignmentSharedPublicFunctions.g.cs
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
  public class FreeApprovalAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.IFreeApprovalAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// FreeApprovalAssignmentAttachmentGroups.g.cs
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

  public class FreeApprovalAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Content.IElectronicDocument> ElectronicDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Content.IElectronicDocument>();
        } 
      }


    public FreeApprovalAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "fe0d933f-02f8-4733-b110-1e49467a9cf8") { }
  }

  public class FreeApprovalAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalAssignmentOtherGroupAttachments
  {

    public FreeApprovalAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "698df64c-b849-4786-ae93-19a1f086a2a8") { }
  }

  public class FreeApprovalAssignmentForApprovalGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IFreeApprovalAssignmentForApprovalGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Content.IElectronicDocument> ElectronicDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Content.IElectronicDocument>();
        } 
      }


    public FreeApprovalAssignmentForApprovalGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "cd77936e-884e-44bb-b869-9a60f9f5f2b4") { }
  }

}

// ==================================================================
// FreeApprovalAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.FreeApprovalAssignment
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