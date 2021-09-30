
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

namespace Sungero.RecordManagement.Client
{ 
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

  public partial class DeadlineRejectionAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineRejectionAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IDeadlineRejectionAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DeadlineRejectionAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DeadlineRejectionAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Entity; }
    }

    public virtual void CurrentDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public DeadlineRejectionAssignmentClientHandlers(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineRejectionAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class DeadlineRejectionAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
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
// DeadlineRejectionAssignmentClientPublicFunctions.g.cs
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
  public class DeadlineRejectionAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IDeadlineRejectionAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineRejectionAssignmentActions.g.cs
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
  public partial class DeadlineRejectionAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IDeadlineRejectionAssignment _obj { get { return (global::Sungero.RecordManagement.IDeadlineRejectionAssignment)this.Entity; } }
    public DeadlineRejectionAssignmentActions(global::Sungero.RecordManagement.IDeadlineRejectionAssignment entity) : base(entity) { }
  }

  public partial class DeadlineRejectionAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IDeadlineRejectionAssignment> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IDeadlineRejectionAssignment>(this.Entities); }
    }
  }

  public partial class DeadlineRejectionAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class DeadlineRejectionAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }

}