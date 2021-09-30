
// ==================================================================
// ApprovalTaskEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class ApprovalTaskSignatoryValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalTaskSignatoryValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ApprovalTaskApprovalRuleValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IApprovalRuleBase>
  {
    public ApprovalTaskApprovalRuleValueInputEventArgs(global::Sungero.Docflow.IApprovalRuleBase oldValue, global::Sungero.Docflow.IApprovalRuleBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class ApprovalTaskAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalTaskAddresseeValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



  public class ApprovalTaskDeliveryMethodValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IMailDeliveryMethod>
  {
    public ApprovalTaskDeliveryMethodValueInputEventArgs(global::Sungero.Docflow.IMailDeliveryMethod oldValue, global::Sungero.Docflow.IMailDeliveryMethod newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ApprovalTaskExchangeServiceValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IExchangeService>
  {
    public ApprovalTaskExchangeServiceValueInputEventArgs(global::Sungero.ExchangeCore.IExchangeService oldValue, global::Sungero.ExchangeCore.IExchangeService newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class ApprovalTaskReworkPerformerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public ApprovalTaskReworkPerformerValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ApprovalTaskHandlers.g.cs
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

  public partial class ApprovalTaskFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IApprovalTaskFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalTaskFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalTaskFilteringClientHandler(global::Sungero.Docflow.IApprovalTaskFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalTaskFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ApprovalTaskClientHandlers : global::Sungero.Workflow.TaskClientHandlers
  {
    private global::Sungero.Docflow.IApprovalTask _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTask)this.Entity; }
    }

    public virtual void StageNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }



    public virtual void ControlReturnStartDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void IterationValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void AbortingReasonValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }



    public virtual void ResolutionTextValueInput(global::Sungero.Presentation.TextValueInputEventArgs e) { }


    public virtual void ReworkReasonValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void ExchangeServiceValueInput(global::Sungero.Docflow.Client.ApprovalTaskExchangeServiceValueInputEventArgs e) { }



    public virtual void IsStageAssigneeNotFoundValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void DocumentExternalApprovalStateValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void ReworkPerformerValueInput(global::Sungero.Docflow.Client.ApprovalTaskReworkPerformerValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DocumentExternalApprovalStateFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }



    public ApprovalTaskClientHandlers(global::Sungero.Docflow.IApprovalTask entity) : base(entity)
    {
    }
  }

  public partial class ApprovalTaskReqApproversClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalTaskReqApprovers _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTaskReqApprovers)this.Entity; }
    }
    public virtual void ReqApproversApproverValueInput(global::Sungero.Docflow.Client.ApprovalTaskReqApproversApproverValueInputEventArgs e) { }


    public ApprovalTaskReqApproversClientHandlers(global::Sungero.Docflow.IApprovalTaskReqApprovers entity) : base(entity)
    {
    }
  }

  public partial class ApprovalTaskAddApproversClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalTaskAddApprovers _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddApprovers)this.Entity; }
    }
    public virtual void AddApproversApproverValueInput(global::Sungero.Docflow.Client.ApprovalTaskAddApproversApproverValueInputEventArgs e) { }


    public ApprovalTaskAddApproversClientHandlers(global::Sungero.Docflow.IApprovalTaskAddApprovers entity) : base(entity)
    {
    }
  }

  public partial class ApprovalTaskAddApproversExpandedClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalTaskAddApproversExpanded _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddApproversExpanded)this.Entity; }
    }
    public virtual void AddApproversExpandedApproverValueInput(global::Sungero.Docflow.Client.ApprovalTaskAddApproversExpandedApproverValueInputEventArgs e) { }


    public ApprovalTaskAddApproversExpandedClientHandlers(global::Sungero.Docflow.IApprovalTaskAddApproversExpanded entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalTaskClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalTaskFunctions : global::Sungero.Workflow.Client.TaskFunctions
  {
    private global::Sungero.Docflow.IApprovalTask _obj
    {
      get { return (global::Sungero.Docflow.IApprovalTask)this.Entity; }
    }

    public ApprovalTaskFunctions(global::Sungero.Docflow.IApprovalTask entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalTaskFunctions.g.cs
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
  internal static class ApprovalTask
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean ConfirmCompleteAssignment(global::Sungero.Docflow.IOfficialDocument attachedDocument, global::System.String confirmationMessage, global::System.String dialogId, global::System.Boolean isSigning)
    {
      return global::Sungero.Docflow.Client.ApprovalTaskFunctions.ConfirmCompleteAssignment(attachedDocument, confirmationMessage, dialogId, isSigning);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean ConfirmCompleteAssignment(global::System.Boolean documentBodyChanged, global::System.Boolean documentViewed, global::System.String confirmationMessage, global::System.String dialogId, global::System.Boolean isSigning)
    {
      return global::Sungero.Docflow.Client.ApprovalTaskFunctions.ConfirmCompleteAssignment(documentBodyChanged, documentViewed, confirmationMessage, dialogId, isSigning);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  void ShowStrongSignErrorHint(global::Sungero.Workflow.IAssignment assignment, Sungero.Domain.Client.ExecuteActionArgs e)
    {
    global::Sungero.Docflow.Client.ApprovalTaskFunctions.ShowStrongSignErrorHint(assignment, e);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean ValidateBeforeRework(global::Sungero.Workflow.IAssignment assignment, global::System.String errorMessage, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      return global::Sungero.Docflow.Client.ApprovalTaskFunctions.ValidateBeforeRework(assignment, errorMessage, eventArgs);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean NeedHideCoverLetterAction(global::Sungero.Docflow.IApprovalTask approvalTask, global::System.Collections.Generic.List<global::System.Nullable<global::Sungero.Core.Enumeration>> collapsedStageTypes)
    {
      var functions = (global::Sungero.Docflow.Client.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.ClientFunctions;
      return functions.NeedHideCoverLetterAction(collapsedStageTypes);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean GetReasonBeforeAbort(global::Sungero.Docflow.IApprovalTask approvalTask, global::System.String activeText)
    {
      var functions = (global::Sungero.Docflow.Client.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.ClientFunctions;
      return functions.GetReasonBeforeAbort(activeText);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean EnableCreateCoverLetter(global::Sungero.Docflow.IOfficialDocument document)
    {
      return global::Sungero.Docflow.Client.ApprovalTaskFunctions.EnableCreateCoverLetter(document);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  void ShowExchangeHint(global::Sungero.Docflow.IApprovalTask approvalTask, Domain.Shared.IPropertyState state, Domain.Shared.IPropertyInfo info, global::Sungero.Docflow.IMailDeliveryMethod deliveryMethod, Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IMailDeliveryMethod> e)
    {
      var functions = (global::Sungero.Docflow.Client.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.ClientFunctions;
    functions.ShowExchangeHint(state, info, deliveryMethod, e);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  void ShowExchangeHint(global::Sungero.Docflow.IApprovalTask approvalTask, Domain.Shared.IPropertyState state, Domain.Shared.IPropertyInfo info, global::Sungero.Docflow.IMailDeliveryMethod deliveryMethod, Sungero.Domain.Shared.BaseEntityValidationEventArgs e)
    {
      var functions = (global::Sungero.Docflow.Client.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.ClientFunctions;
    functions.ShowExchangeHint(state, info, deliveryMethod, e);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Boolean NeedShowExchangeHint(global::Sungero.Docflow.IApprovalTask approvalTask, Domain.Shared.IPropertyState state, Domain.Shared.IPropertyInfo info, global::Sungero.Docflow.IMailDeliveryMethod deliveryMethod, Domain.Shared.ParamsDictionary param)
    {
      var functions = (global::Sungero.Docflow.Client.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.ClientFunctions;
      return functions.NeedShowExchangeHint(state, info, deliveryMethod, param);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  global::System.Nullable<global::System.DateTime> GetNewDeadline(global::System.Nullable<global::System.DateTime> oldDeadline)
    {
      return global::Sungero.Docflow.Client.ApprovalTaskFunctions.GetNewDeadline(oldDeadline);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalTaskFunctions" />
    internal static  void ShowReworkConfirmationDialog(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Workflow.IAssignmentBase assignment, global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> attachments, global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> additionalAssignees, global::Sungero.Company.IEmployee reworkPerformer, Sungero.Workflow.Client.ExecuteResultActionArgs e, global::System.String dialogId)
    {
      var functions = (global::Sungero.Docflow.Client.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.ClientFunctions;
    functions.ShowReworkConfirmationDialog(assignment, attachments, additionalAssignees, reworkPerformer, e, dialogId);
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  global::System.Nullable<global::System.Int32> GetNextStageNumber(global::Sungero.Docflow.IApprovalTask task)
    {
      return global::Sungero.Docflow.Shared.ApprovalTaskFunctions.GetNextStageNumber(task);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters refreshParameters)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
    functions.SetRequiredProperties(refreshParameters);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  void SetVisibleProperties(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters refreshParameters)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
    functions.SetVisibleProperties(refreshParameters);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  void SetEnabledProperties(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters refreshParameters)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
    functions.SetEnabledProperties(refreshParameters);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  global::System.String GetDeliveryMethodDescription(global::Sungero.Docflow.IMailDeliveryMethod method, global::Sungero.ExchangeCore.IExchangeService service, global::System.Boolean isManyAddressees)
    {
      return global::Sungero.Docflow.Shared.ApprovalTaskFunctions.GetDeliveryMethodDescription(method, service, isManyAddressees);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  void RefreshApprovalTaskForm(global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
    functions.RefreshApprovalTaskForm();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  void RefreshApprovalTaskForm(global::Sungero.Docflow.IApprovalTask approvalTask, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
    functions.RefreshApprovalTaskForm(stages);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  void RefreshProperties(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters refreshParameters)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
    functions.RefreshProperties(refreshParameters);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  global::System.Boolean SchemeVersionSupportsRework(global::Sungero.Docflow.IApprovalTask approvalTask)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
      return functions.SchemeVersionSupportsRework();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalTaskFunctions" />
    internal static  global::System.Boolean ValidateApprovalTaskStart(global::Sungero.Docflow.IApprovalTask approvalTask, Sungero.Core.IValidationArgs e)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalTaskFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalTask).FunctionsContainer.SharedFunctions;
      return functions.ValidateApprovalTaskStart(e);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Workflow.IAssignment> GetTaskAssigments(global::Sungero.Workflow.ITask task)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Workflow.IAssignment>>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetTaskAssigments(global::Sungero.Workflow.ITask)"
      , task);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetStateView(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean DocumentHasBodyUpdateAfterLastView(global::Sungero.Content.IElectronicDocument document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "DocumentHasBodyUpdateAfterLastView(global::Sungero.Content.IElectronicDocument)"
      , document);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean DocumenHasBeenViewed(global::Sungero.Content.IElectronicDocument document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "DocumenHasBeenViewed(global::Sungero.Content.IElectronicDocument)"
      , document);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean CurrentStageCollapsedWithSpecificStage(global::Sungero.Docflow.IApprovalTask task, global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite currentStage, global::Sungero.Core.Enumeration specificStageType)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "CurrentStageCollapsedWithSpecificStage(global::Sungero.Docflow.IApprovalTask,global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite,global::Sungero.Core.Enumeration)"
      , task, currentStage, specificStageType);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean CurrentStageCollapsedWithSpecificStage(global::Sungero.Docflow.IApprovalTask task, global::System.Nullable<global::System.Int32> currentStageNumber, global::Sungero.Core.Enumeration specificStageType)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "CurrentStageCollapsedWithSpecificStage(global::Sungero.Docflow.IApprovalTask,global::System.Nullable<global::System.Int32>,global::Sungero.Core.Enumeration)"
      , task, currentStageNumber, specificStageType);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean CheckSequenceOfCoupleStages(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Core.Enumeration firstStageType, global::Sungero.Core.Enumeration secondStageType, global::System.Boolean allowAdditionalApprovers)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "CheckSequenceOfCoupleStages(global::Sungero.Docflow.IApprovalTask,global::Sungero.Core.Enumeration,global::Sungero.Core.Enumeration,global::System.Boolean)"
          , approvalTask, firstStageType, secondStageType, allowAdditionalApprovers);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean CheckSignatory(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Company.IEmployee signatory, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "CheckSignatory(global::Sungero.Docflow.IApprovalTask,global::Sungero.Company.IEmployee,global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite>)"
          , approvalTask, signatory, stages);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.ApprovalTask.ApprovalStatus AuthorMustApproveDocument(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.CoreEntities.IUser assignee, global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient> approvers)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.ApprovalTask.ApprovalStatus>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "AuthorMustApproveDocument(global::Sungero.Docflow.IApprovalTask,global::Sungero.CoreEntities.IUser,global::System.Collections.Generic.List<global::Sungero.CoreEntities.IRecipient>)"
          , approvalTask, assignee, approvers);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  void ApprovalRuleChanged(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.IApprovalRuleBase rule, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "ApprovalRuleChanged(global::Sungero.Docflow.IApprovalTask,global::Sungero.Docflow.IApprovalRuleBase,global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite>)"
          , approvalTask, rule, stages);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  void ApprovalRuleChanged(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.IApprovalRuleBase rule)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "ApprovalRuleChanged(global::Sungero.Docflow.IApprovalTask,global::Sungero.Docflow.IApprovalRuleBase)"
          , approvalTask, rule);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  void UpdateReglamentApprovers(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.IApprovalRuleBase rule, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "UpdateReglamentApprovers(global::Sungero.Docflow.IApprovalTask,global::Sungero.Docflow.IApprovalRuleBase,global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite>)"
          , approvalTask, rule, stages);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  void UpdateReglamentApprovers(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Docflow.IApprovalRuleBase rule)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "UpdateReglamentApprovers(global::Sungero.Docflow.IApprovalTask,global::Sungero.Docflow.IApprovalRuleBase)"
          , approvalTask, rule);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.ApprovalTask.ExchangeServies GetExchangeServices(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.ApprovalTask.ExchangeServies>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetExchangeServices(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  void GrantRightsToAuthor(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GrantRightsToAuthor(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Boolean HasDocumentAndCanRead(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "HasDocumentAndCanRead(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Nullable<global::System.DateTime> GetExpectedDate(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Nullable<global::System.DateTime>>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetExpectedDate(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Nullable<global::System.DateTime> GetExpectedDate(global::Sungero.Docflow.IApprovalTask approvalTask, global::Sungero.Workflow.IAssignment currentAssignment, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Nullable<global::System.DateTime>>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetExpectedDate(global::Sungero.Docflow.IApprovalTask,global::Sungero.Workflow.IAssignment,global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite>)"
          , approvalTask, currentAssignment, stages);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.Module.DefinedApprovalStages GetStages(global::Sungero.Docflow.IApprovalTask task)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.Module.DefinedApprovalStages>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetStages(global::Sungero.Docflow.IApprovalTask)"
      , task);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters GetStagesInfoForRefresh(global::Sungero.Docflow.IApprovalTask task, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetStagesInfoForRefresh(global::Sungero.Docflow.IApprovalTask,global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite>)"
      , task, stages);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters GetStagesInfoForRefresh(global::Sungero.Docflow.IApprovalTask task)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.ApprovalTask.RefreshParameters>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetStagesInfoForRefresh(global::Sungero.Docflow.IApprovalTask)"
      , task);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetReworkPerformers(global::Sungero.Docflow.IApprovalTask approvalTask)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetReworkPerformers(global::Sungero.Docflow.IApprovalTask)"
          , approvalTask);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalTaskFunctions" />
      internal static  global::Sungero.Docflow.Structures.ApprovalTask.ReworkParameters GetReworkParameters(global::Sungero.Docflow.IApprovalTask approvalTask, global::System.Int32 stageNumber)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.ApprovalTask.ReworkParameters>(
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"),
          "GetReworkParameters(global::Sungero.Docflow.IApprovalTask,global::System.Int32)"
          , approvalTask, stageNumber);
      }

    }
  }
}

// ==================================================================
// ApprovalTaskClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalTaskClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalTaskClientPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalTaskActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class ApprovalTaskActions : global::Sungero.Workflow.Client.TaskActions
  {
    private global::Sungero.Docflow.IApprovalTask _obj { get { return (global::Sungero.Docflow.IApprovalTask)this.Entity; } }
    public ApprovalTaskActions(global::Sungero.Docflow.IApprovalTask entity) : base(entity) { }
  }

  public partial class ApprovalTaskCollectionActions : global::Sungero.Workflow.Client.TaskCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalTask> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalTask>(this.Entities); }
    }
  }

  public partial class ApprovalTaskAnyChildEntityActions : global::Sungero.Workflow.Client.TaskAnyChildEntityActions
  {
  }

  public partial class ApprovalTaskAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.TaskAnyChildEntityCollectionActions
  {
  }

}
