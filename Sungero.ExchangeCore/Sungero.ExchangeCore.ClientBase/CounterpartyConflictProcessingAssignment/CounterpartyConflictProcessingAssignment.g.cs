
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

namespace Sungero.ExchangeCore.Client
{ 
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

  public partial class CounterpartyConflictProcessingAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterState Filter { get; private set; }

    private global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CounterpartyConflictProcessingAssignmentFilteringClientHandler(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CounterpartyConflictProcessingAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class CounterpartyConflictProcessingAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment _obj
    {
      get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment)this.Entity; }
    }

    public CounterpartyConflictProcessingAssignmentClientHandlers(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyConflictProcessingAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.ExchangeCore.Client
{
  public partial class CounterpartyConflictProcessingAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
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
// CounterpartyConflictProcessingAssignmentClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class CounterpartyConflictProcessingAssignmentClientPublicFunctions : global::Sungero.ExchangeCore.Client.ICounterpartyConflictProcessingAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// CounterpartyConflictProcessingAssignmentActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public partial class CounterpartyConflictProcessingAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment _obj { get { return (global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment)this.Entity; } }
    public CounterpartyConflictProcessingAssignmentActions(global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment entity) : base(entity) { }
  }

  public partial class CounterpartyConflictProcessingAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.ExchangeCore.ICounterpartyConflictProcessingAssignment>(this.Entities); }
    }
  }

  public partial class CounterpartyConflictProcessingAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class CounterpartyConflictProcessingAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }

}
