
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

namespace Sungero.RecordManagement.Client
{ 
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

  public partial class AcquaintanceFinishAssignmentFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public AcquaintanceFinishAssignmentFilteringClientHandler(global::Sungero.RecordManagement.IAcquaintanceFinishAssignmentFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected AcquaintanceFinishAssignmentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class AcquaintanceFinishAssignmentClientHandlers : global::Sungero.Workflow.AssignmentClientHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceFinishAssignment _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignment)this.Entity; }
    }

    public virtual void DescriptionValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public AcquaintanceFinishAssignmentClientHandlers(global::Sungero.RecordManagement.IAcquaintanceFinishAssignment entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// AcquaintanceFinishAssignmentClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class AcquaintanceFinishAssignmentFunctions : global::Sungero.Workflow.Client.AssignmentFunctions
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
// AcquaintanceFinishAssignmentClientPublicFunctions.g.cs
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
  public class AcquaintanceFinishAssignmentClientPublicFunctions : global::Sungero.RecordManagement.Client.IAcquaintanceFinishAssignmentClientPublicFunctions
  {
  }
}

// ==================================================================
// AcquaintanceFinishAssignmentActions.g.cs
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
  public partial class AcquaintanceFinishAssignmentActions : global::Sungero.Workflow.Client.AssignmentActions
  {
    private global::Sungero.RecordManagement.IAcquaintanceFinishAssignment _obj { get { return (global::Sungero.RecordManagement.IAcquaintanceFinishAssignment)this.Entity; } }
    public AcquaintanceFinishAssignmentActions(global::Sungero.RecordManagement.IAcquaintanceFinishAssignment entity) : base(entity) { }
  }

  public partial class AcquaintanceFinishAssignmentCollectionActions : global::Sungero.Workflow.Client.AssignmentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IAcquaintanceFinishAssignment> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IAcquaintanceFinishAssignment>(this.Entities); }
    }
  }

  public partial class AcquaintanceFinishAssignmentAnyChildEntityActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityActions
  {
  }

  public partial class AcquaintanceFinishAssignmentAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.AssignmentAnyChildEntityCollectionActions
  {
  }

}