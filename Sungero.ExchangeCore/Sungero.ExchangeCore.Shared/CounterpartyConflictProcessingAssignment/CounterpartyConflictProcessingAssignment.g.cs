
// ==================================================================
// CounterpartyConflictProcessingAssignmentState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class CounterpartyConflictProcessingAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentState
  {
    public CounterpartyConflictProcessingAssignmentState(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment entity) : base(entity) { }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentPropertyStates(entity);
    }


    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentControlStates Controls
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentControlStates(entity);
    }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPageStates Pages
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAttachmentStates Attachments { get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new CounterpartyConflictProcessingAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class CounterpartyConflictProcessingAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentAttachmentStates
    {

      protected internal CounterpartyConflictProcessingAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class CounterpartyConflictProcessingAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentControlStates
  {

    protected internal CounterpartyConflictProcessingAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CounterpartyConflictProcessingAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPageStates
  {

    protected internal CounterpartyConflictProcessingAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CounterpartyConflictProcessingAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPropertyStates
  {

    protected internal CounterpartyConflictProcessingAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CounterpartyConflictProcessingAssignmentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{  
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class CounterpartyConflictProcessingAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentInfo
  {
    public CounterpartyConflictProcessingAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignmentActionsInfo(entityType);
    }
  }

  public class CounterpartyConflictProcessingAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentPropertiesInfo
  {

    protected internal CounterpartyConflictProcessingAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class CounterpartyConflictProcessingAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Complete 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Complete")); }
        }


    protected internal CounterpartyConflictProcessingAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore
{
  public partial class CounterpartyConflictProcessingAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment)this.Entity; }
    }

    #region Workflow attachments extention


    #endregion

    public CounterpartyConflictProcessingAssignmentSharedHandlers(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyConflictProcessingAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignment
{
  /// <summary>
  /// Represents CounterpartyConflictProcessingAssignment resources.
  /// </summary>
  public class CounterpartyConflictProcessingAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.ExchangeCore.CounterpartyConflictProcessingAssignment.ICounterpartyConflictProcessingAssignmentResources
  {
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Shared
{
  public partial class CounterpartyConflictProcessingAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment)this.Entity; }
    }

    public CounterpartyConflictProcessingAssignmentFunctions(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Functions
{
  internal static class CounterpartyConflictProcessingAssignment
  {
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignment
{

  public class CounterpartyConflictProcessingAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterInfo
  {
  }

  public class CounterpartyConflictProcessingAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterState
  {



    public new Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.ExchangeCore.Shared.CounterpartyConflictProcessingAssignment.CounterpartyConflictProcessingAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
  public class CounterpartyConflictProcessingAssignmentSharedPublicFunctions : global::Sungero.ExchangeCore.Shared.ICounterpartyConflictProcessingAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentAttachmentGroups.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Shared
{
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.CounterpartyConflictProcessingAssignment
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
          global::System.Guid.Parse("03a51b42-a322-4574-90bb-212ea03ed71e"));
      }
    }

}
