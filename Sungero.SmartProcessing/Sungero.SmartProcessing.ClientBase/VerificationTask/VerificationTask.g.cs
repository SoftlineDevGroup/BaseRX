
// ==================================================================
// VerificationTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{ 
  public class VerificationTaskAssigneeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public VerificationTaskAssigneeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class VerificationTaskAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public VerificationTaskAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// VerificationTaskHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{

  public partial class VerificationTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.SmartProcessing.IVerificationTaskFilterState Filter { get; private set; }

    private global::Sungero.SmartProcessing.IVerificationTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public VerificationTaskFilteringClientHandler(global::Sungero.SmartProcessing.IVerificationTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected VerificationTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class VerificationTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.SmartProcessing.IVerificationTask _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationTask)this.Entity; }
    }

    public virtual void AssigneeValueInput(global::Sungero.SmartProcessing.Client.VerificationTaskAssigneeValueInputEventArgs e) { }


    public virtual void DeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void AddresseeValueInput(global::Sungero.SmartProcessing.Client.VerificationTaskAddresseeValueInputEventArgs e) { }


    public virtual void LeadingDocumentNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public VerificationTaskClientHandlers(global::Sungero.SmartProcessing.IVerificationTask entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// VerificationTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Client
{
  public partial class VerificationTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.SmartProcessing.IVerificationTask _obj
    {
      get { return (global::Sungero.SmartProcessing.IVerificationTask)this.Entity; }
    }

    public VerificationTaskFunctions(global::Sungero.SmartProcessing.IVerificationTask entity) : base(entity) { }
  }
}

// ==================================================================
// VerificationTaskFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class VerificationTask
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.VerificationTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.SmartProcessing.IVerificationTask verificationTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("999a5ae0-17ec-4735-bc90-d85c7fe08dd3"),
          "GetStateView(global::Sungero.SmartProcessing.IVerificationTask)"
          , verificationTask);
      }

    }
  }
}

// ==================================================================
// VerificationTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class VerificationTaskClientPublicFunctions : global::Sungero.SmartProcessing.Client.IVerificationTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// VerificationTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public partial class VerificationTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.SmartProcessing.IVerificationTask _obj { get { return (global::Sungero.SmartProcessing.IVerificationTask)this.Entity; } }
    public VerificationTaskActions(global::Sungero.SmartProcessing.IVerificationTask entity) : base(entity) { }
  }

  public partial class VerificationTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.SmartProcessing.IVerificationTask> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.SmartProcessing.IVerificationTask>(this.Entities); }
    }
  }

  public partial class VerificationTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class VerificationTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }

}
