
// ==================================================================
// DocumentReviewTaskEventArgs.g.cs
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
  public class DocumentReviewTaskAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public DocumentReviewTaskAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }





}

// ==================================================================
// DocumentReviewTaskHandlers.g.cs
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

  public partial class DocumentReviewTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IDocumentReviewTaskFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IDocumentReviewTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentReviewTaskFilteringClientHandler(global::Sungero.RecordManagement.IDocumentReviewTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentReviewTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DocumentReviewTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTask _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Entity; }
    }

    public virtual void ResolutionTextValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }



    public virtual void NeedDeleteActionItemsValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public DocumentReviewTaskClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTask entity) : base(entity)
    {
    }
  }

  public partial class DocumentReviewTaskResolutionObserversClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers)this.Entity; }
    }
    public virtual void ResolutionObserversObserverValueInput(global::Sungero.RecordManagement.Client.DocumentReviewTaskResolutionObserversObserverValueInputEventArgs e) { }


    public DocumentReviewTaskResolutionObserversClientHandlers(global::Sungero.RecordManagement.IDocumentReviewTaskResolutionObservers entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DocumentReviewTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class DocumentReviewTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.RecordManagement.IDocumentReviewTask _obj
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Entity; }
    }

    public DocumentReviewTaskFunctions(global::Sungero.RecordManagement.IDocumentReviewTask entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentReviewTaskFunctions.g.cs
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
  internal static class DocumentReviewTask
  {
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  global::Sungero.RecordManagement.IActionItemExecutionTask CreateActionItemExecution(global::Sungero.Workflow.IAssignment parentAssignment, global::Sungero.RecordManagement.IDocumentReviewTask mainTask, global::System.String resolutionText)
    {
      return global::Sungero.RecordManagement.Client.DocumentReviewTaskFunctions.CreateActionItemExecution(parentAssignment, mainTask, resolutionText);
    }
    /// <redirect project="Sungero.RecordManagement.Client" type="Sungero.RecordManagement.Client.DocumentReviewTaskFunctions" />
    internal static  void CheckOverdueActionItemExecutionTasks(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var functions = (global::Sungero.RecordManagement.Client.DocumentReviewTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.ClientFunctions;
    functions.CheckOverdueActionItemExecutionTasks(e);
    }

    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.Structures.DocumentReviewTask.StartValidationMessage> GetStartValidationMessages(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var functions = (global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      return functions.GetStartValidationMessages();
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean ValidateDocumentReviewTaskStart(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, Sungero.Core.IValidationArgs e)
    {
      var functions = (global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      return functions.ValidateDocumentReviewTaskStart(e);
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Boolean IncomingDocumentRegistered(global::Sungero.Docflow.IOfficialDocument document)
    {
      return global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions.IncomingDocumentRegistered(document);
    }
    /// <redirect project="Sungero.RecordManagement.Shared" type="Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.RecordManagement.IActionItemExecutionTask> GetDraftOverdueActionItemExecutionTasks(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
    {
      var functions = (global::Sungero.RecordManagement.Shared.DocumentReviewTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)documentReviewTask).FunctionsContainer.SharedFunctions;
      return functions.GetDraftOverdueActionItemExecutionTasks();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static  global::System.String GetStateViewXml(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "GetStateViewXml(global::Sungero.RecordManagement.IDocumentReviewTask)"
          , documentReviewTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "GetStateView(global::Sungero.RecordManagement.IDocumentReviewTask)"
          , documentReviewTask);
      }
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DocumentReviewTaskFunctions" />
      internal static  void StartActionItemsForDraftResolution(global::Sungero.RecordManagement.IDocumentReviewTask documentReviewTask, global::Sungero.Workflow.IAssignment parentAssignment)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("4ef03457-8b42-4239-a3c5-d4d05e61f0b6"),
          "StartActionItemsForDraftResolution(global::Sungero.RecordManagement.IDocumentReviewTask,global::Sungero.Workflow.IAssignment)"
          , documentReviewTask, parentAssignment);
      }

    }
  }
}

// ==================================================================
// DocumentReviewTaskClientPublicFunctions.g.cs
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
  public class DocumentReviewTaskClientPublicFunctions : global::Sungero.RecordManagement.Client.IDocumentReviewTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// DocumentReviewTaskActions.g.cs
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
  public partial class DocumentReviewTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.RecordManagement.IDocumentReviewTask _obj { get { return (global::Sungero.RecordManagement.IDocumentReviewTask)this.Entity; } }
    public DocumentReviewTaskActions(global::Sungero.RecordManagement.IDocumentReviewTask entity) : base(entity) { }
  }

  public partial class DocumentReviewTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IDocumentReviewTask> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IDocumentReviewTask>(this.Entities); }
    }
  }

  public partial class DocumentReviewTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class DocumentReviewTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }

}
