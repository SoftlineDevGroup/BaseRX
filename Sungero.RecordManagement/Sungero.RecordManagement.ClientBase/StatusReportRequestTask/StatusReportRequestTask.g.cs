
// ==================================================================
// StatusReportRequestTaskEventArgs.g.cs
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
  public class StatusReportRequestTaskAssigneeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public StatusReportRequestTaskAssigneeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// StatusReportRequestTaskHandlers.g.cs
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

  public partial class StatusReportRequestTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IStatusReportRequestTaskFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IStatusReportRequestTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public StatusReportRequestTaskFilteringClientHandler(global::Sungero.RecordManagement.IStatusReportRequestTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected StatusReportRequestTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class StatusReportRequestTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.RecordManagement.IStatusReportRequestTask _obj
    {
      get { return (global::Sungero.RecordManagement.IStatusReportRequestTask)this.Entity; }
    }

    public virtual void ReportValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void ActionItemValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void ReportNoteValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }



    public StatusReportRequestTaskClientHandlers(global::Sungero.RecordManagement.IStatusReportRequestTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// StatusReportRequestTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class StatusReportRequestTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.RecordManagement.IStatusReportRequestTask _obj
    {
      get { return (global::Sungero.RecordManagement.IStatusReportRequestTask)this.Entity; }
    }

    public StatusReportRequestTaskFunctions(global::Sungero.RecordManagement.IStatusReportRequestTask entity) : base(entity) { }
  }
}

// ==================================================================
// StatusReportRequestTaskFunctions.g.cs
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
  internal static class StatusReportRequestTask
  {
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.StatusReportRequestTaskFunctions" />
    internal static  global::System.String GetStatusReportRequestSubject(global::Sungero.RecordManagement.IStatusReportRequestTask task, CommonLibrary.LocalizedString beginningSubject)
    {
      return global::Sungero.RecordManagement.Shared.StatusReportRequestTaskFunctions.GetStatusReportRequestSubject(task, beginningSubject);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.StatusReportRequestTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IStatusReportRequestTask statusReportRequestTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("c8aed854-ad26-4ee3-88a3-080bc98c12e1"),
          "GetStateView(global::Sungero.RecordManagement.IStatusReportRequestTask)"
          , statusReportRequestTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.StatusReportRequestTaskFunctions" />
      internal static  global::Sungero.RecordManagement.IStatusReportRequestTask CreateStatusReportRequest(global::Sungero.RecordManagement.IActionItemExecutionTask task)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.RecordManagement.IStatusReportRequestTask>(
          global::System.Guid.Parse("c8aed854-ad26-4ee3-88a3-080bc98c12e1"),
          "CreateStatusReportRequest(global::Sungero.RecordManagement.IActionItemExecutionTask)"
      , task);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.StatusReportRequestTaskFunctions" />
      internal static  global::Sungero.RecordManagement.IStatusReportRequestTask CreateStatusReportRequest(global::Sungero.RecordManagement.IActionItemExecutionAssignment job)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.RecordManagement.IStatusReportRequestTask>(
          global::System.Guid.Parse("c8aed854-ad26-4ee3-88a3-080bc98c12e1"),
          "CreateStatusReportRequest(global::Sungero.RecordManagement.IActionItemExecutionAssignment)"
      , job);
      }

    }
  }
}

// ==================================================================
// StatusReportRequestTaskClientPublicFunctions.g.cs
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
  public class StatusReportRequestTaskClientPublicFunctions : global::Sungero.RecordManagement.Client.IStatusReportRequestTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// StatusReportRequestTaskActions.g.cs
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
  public partial class StatusReportRequestTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.RecordManagement.IStatusReportRequestTask _obj { get { return (global::Sungero.RecordManagement.IStatusReportRequestTask)this.Entity; } }
    public StatusReportRequestTaskActions(global::Sungero.RecordManagement.IStatusReportRequestTask entity) : base(entity) { }
  }

  public partial class StatusReportRequestTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IStatusReportRequestTask> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IStatusReportRequestTask>(this.Entities); }
    }
  }

  public partial class StatusReportRequestTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class StatusReportRequestTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }

}
