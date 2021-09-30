
// ==================================================================
// ApprovalRuleBaseEventArgs.g.cs
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
  public class ApprovalRuleBaseParentRuleValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IApprovalRuleBase>
  {
    public ApprovalRuleBaseParentRuleValueInputEventArgs(global::Sungero.Docflow.IApprovalRuleBase oldValue, global::Sungero.Docflow.IApprovalRuleBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class ApprovalRuleBaseReworkPerformerValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.CoreEntities.IRecipient>
  {
    public ApprovalRuleBaseReworkPerformerValueInputEventArgs(global::Sungero.CoreEntities.IRecipient oldValue, global::Sungero.CoreEntities.IRecipient newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


  public class ApprovalRuleBaseReworkApprovalRoleValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IApprovalRoleBase>
  {
    public ApprovalRuleBaseReworkApprovalRoleValueInputEventArgs(global::Sungero.Docflow.IApprovalRoleBase oldValue, global::Sungero.Docflow.IApprovalRoleBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ApprovalRuleBaseHandlers.g.cs
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

  public partial class ApprovalRuleBaseFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IApprovalRuleBaseFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IApprovalRuleBaseFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ApprovalRuleBaseFilteringClientHandler(global::Sungero.Docflow.IApprovalRuleBaseFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ApprovalRuleBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ApprovalRuleBaseClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBase)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }





    public virtual void PriorityValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }




    public virtual void DocumentFlowValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void IsDefaultRuleValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }




    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void ParentRuleValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseParentRuleValueInputEventArgs e) { }


    public virtual void VersionNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void IsSmallApprovalAllowedValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void ReworkPerformerTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void ReworkPerformerValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseReworkPerformerValueInputEventArgs e) { }



    public virtual void ReworkApprovalRoleValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseReworkApprovalRoleValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DocumentFlowFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }









    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> ReworkPerformerTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }





    public ApprovalRuleBaseClientHandlers(global::Sungero.Docflow.IApprovalRuleBase entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseDocumentKindsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseDocumentKinds)this.Entity; }
    }
    public virtual void DocumentKindsDocumentKindValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseDocumentKindsDocumentKindValueInputEventArgs e) { }


    public ApprovalRuleBaseDocumentKindsClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseDocumentKinds entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseDepartmentsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseDepartments _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseDepartments)this.Entity; }
    }
    public virtual void DepartmentsDepartmentValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseDepartmentsDepartmentValueInputEventArgs e) { }


    public ApprovalRuleBaseDepartmentsClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseDepartments entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseStagesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseStages _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseStages)this.Entity; }
    }
    public virtual void StagesStageValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseStagesStageValueInputEventArgs e) { }


    public virtual void StagesNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void StagesStageTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> StagesStageTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public ApprovalRuleBaseStagesClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseStages entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseBusinessUnitsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseBusinessUnits _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseBusinessUnits)this.Entity; }
    }
    public virtual void BusinessUnitsBusinessUnitValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseBusinessUnitsBusinessUnitValueInputEventArgs e) { }


    public ApprovalRuleBaseBusinessUnitsClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseBusinessUnits entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseDocumentGroupsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups)this.Entity; }
    }
    public virtual void DocumentGroupsDocumentGroupValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseDocumentGroupsDocumentGroupValueInputEventArgs e) { }


    public ApprovalRuleBaseDocumentGroupsClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseDocumentGroups entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseTransitionsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseTransitions _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseTransitions)this.Entity; }
    }
    public virtual void TransitionsSourceStageValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void TransitionsTargetStageValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void TransitionsConditionValueValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public ApprovalRuleBaseTransitionsClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseTransitions entity) : base(entity)
    {
    }
  }

  public partial class ApprovalRuleBaseConditionsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IApprovalRuleBaseConditions _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBaseConditions)this.Entity; }
    }
    public virtual void ConditionsNumberValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void ConditionsConditionValueInput(global::Sungero.Docflow.Client.ApprovalRuleBaseConditionsConditionValueInputEventArgs e) { }


    public ApprovalRuleBaseConditionsClientHandlers(global::Sungero.Docflow.IApprovalRuleBaseConditions entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalRuleBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ApprovalRuleBaseFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IApprovalRuleBase _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBase)this.Entity; }
    }

    public ApprovalRuleBaseFunctions(global::Sungero.Docflow.IApprovalRuleBase entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalRuleBaseFunctions.g.cs
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
  internal static class ApprovalRuleBase
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalRuleBaseFunctions" />
    internal static  global::System.String GetPlaceHolder(global::Sungero.Docflow.IApprovalRuleBaseStages stage)
    {
      return global::Sungero.Docflow.Client.ApprovalRuleBaseFunctions.GetPlaceHolder(stage);
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ApprovalRuleBaseFunctions" />
    internal static  global::Sungero.Core.IIconInfo GetStageIcon(global::Sungero.Docflow.IApprovalRuleBaseStages stage)
    {
      return global::Sungero.Docflow.Client.ApprovalRuleBaseFunctions.GetStageIcon(stage);
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.Int32 GetNextNumber(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.GetNextNumber();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBaseConditions> GetConditions(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.GetConditions(document, task);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::Sungero.Docflow.Structures.ApprovalRuleBase.NextStageNumber GetNextStageNumber(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Docflow.IOfficialDocument document, global::System.Nullable<global::System.Int32> currentStageNumber, global::Sungero.Docflow.IApprovalTask task)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.GetNextStageNumber(document, currentStageNumber, task);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.String GetIncompatibleDocumentGroupsExcludedHint(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.GetIncompatibleDocumentGroupsExcludedHint();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentGroupBase> GetAvailableDocumentGroups(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.GetAvailableDocumentGroups();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.Boolean HasApprovalStage(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Core.Enumeration stage, global::Sungero.Docflow.IOfficialDocument document, global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> stages)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.HasApprovalStage(stage, document, stages);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.Boolean HasApprovalCondition(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task, global::Sungero.Core.Enumeration condition)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.HasApprovalCondition(document, task, condition);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  void CreateAutoTransitions(global::Sungero.Docflow.IApprovalRuleBase rule)
    {
    global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions.CreateAutoTransitions(rule);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  void AddDocumentKindToCondition(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Docflow.IConditionBase condition)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
    functions.AddDocumentKindToCondition(condition);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IDocumentKind> GetAvaliableDocumentKinds(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
      return functions.GetAvaliableDocumentKinds();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalRuleBaseFunctions" />
    internal static  void SetStateProperties(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalRuleBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalRuleBase).FunctionsContainer.SharedFunctions;
    functions.SetStateProperties();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::System.Int32 CanRegisterAndHasTaskInProcess(global::Sungero.Docflow.IApprovalRuleBase rule)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Int32>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "CanRegisterAndHasTaskInProcess(global::Sungero.Docflow.IApprovalRuleBase)"
      , rule);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase> GetDoubleRules(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase>>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetDoubleRules(global::Sungero.Docflow.IApprovalRuleBase)"
          , approvalRuleBase);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalTask> GetTasksInProcess(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalTask>>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetTasksInProcess(global::Sungero.Docflow.IApprovalRuleBase)"
          , approvalRuleBase);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::Sungero.Docflow.IApprovalRuleBase GetOrCreateNextVersion(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IApprovalRuleBase>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetOrCreateNextVersion(global::Sungero.Docflow.IApprovalRuleBase)"
          , approvalRuleBase);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalRuleBase> GetAvailableRulesByDocument(global::Sungero.Docflow.IOfficialDocument document)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalRuleBase>>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetAvailableRulesByDocument(global::Sungero.Docflow.IOfficialDocument)"
      , document);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::Sungero.Company.IEmployee GetEmployeeByAssignee(global::Sungero.CoreEntities.IRecipient assignee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IEmployee>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetEmployeeByAssignee(global::Sungero.CoreEntities.IRecipient)"
      , assignee);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalStage> ChartSelectStage(global::System.Nullable<global::Sungero.Core.Enumeration> stageType)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IApprovalStage>>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "ChartSelectStage(global::System.Nullable<global::Sungero.Core.Enumeration>)"
      , stageType);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase> GetAllRuleVersions(global::Sungero.Docflow.IApprovalRuleBase rule)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase>>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetAllRuleVersions(global::Sungero.Docflow.IApprovalRuleBase)"
      , rule);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::Sungero.Docflow.IApprovalRuleBase GetPreviousActiveRule(global::Sungero.Docflow.IApprovalRuleBase rule)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IApprovalRuleBase>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetPreviousActiveRule(global::Sungero.Docflow.IApprovalRuleBase)"
      , rule);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::Sungero.Docflow.IApprovalRuleBase GetNextVersion(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IApprovalRuleBase>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetNextVersion(global::Sungero.Docflow.IApprovalRuleBase)"
          , approvalRuleBase);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::Sungero.Docflow.Structures.Module.DefinedApprovalStages GetStages(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.IApprovalTask task)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.Module.DefinedApprovalStages>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetStages(global::Sungero.Docflow.IApprovalRuleBase,global::Sungero.Docflow.IOfficialDocument,global::Sungero.Docflow.IApprovalTask)"
          , approvalRuleBase, document, task);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalRuleBaseFunctions" />
      internal static  global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite GetNextStage(global::Sungero.Docflow.IApprovalRuleBase approvalRuleBase, global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite currentStage, global::Sungero.Docflow.IApprovalTask task)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite>(
          global::System.Guid.Parse("42a6a084-6828-47d9-95bb-50b0538a6037"),
          "GetNextStage(global::Sungero.Docflow.IApprovalRuleBase,global::Sungero.Docflow.IOfficialDocument,global::Sungero.Docflow.Structures.Module.DefinedApprovalStageLite,global::Sungero.Docflow.IApprovalTask)"
          , approvalRuleBase, document, currentStage, task);
      }

    }
  }
}

// ==================================================================
// ApprovalRuleBaseClientPublicFunctions.g.cs
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
  public class ApprovalRuleBaseClientPublicFunctions : global::Sungero.Docflow.Client.IApprovalRuleBaseClientPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalRuleBaseActions.g.cs
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
  public partial class ApprovalRuleBaseActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.IApprovalRuleBase _obj { get { return (global::Sungero.Docflow.IApprovalRuleBase)this.Entity; } }
    public ApprovalRuleBaseActions(global::Sungero.Docflow.IApprovalRuleBase entity) : base(entity) { }
  }

  public partial class ApprovalRuleBaseCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalRuleBase> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalRuleBase>(this.Entities); }
    }
  }

  public partial class ApprovalRuleBaseAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class ApprovalRuleBaseAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }

  public partial class ApprovalRuleBaseStagesActions : global::Sungero.Domain.Client.ChildEntityActions
  {
    private global::Sungero.Docflow.IApprovalRuleBaseStages _obj { get { return (global::Sungero.Docflow.IApprovalRuleBaseStages)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseStages> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseStages>)this.AllEntities; }
    }
  }

  public partial class ApprovalRuleBaseStagesCollectionActions : global::Sungero.Domain.Client.ChildEntityCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalRuleBaseStages> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalRuleBaseStages>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseStages> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseStages>)this.AllEntities; }
    }
  }
  public partial class ApprovalRuleBaseConditionsActions : global::Sungero.Domain.Client.ChildEntityActions
  {
    private global::Sungero.Docflow.IApprovalRuleBaseConditions _obj { get { return (global::Sungero.Docflow.IApprovalRuleBaseConditions)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseConditions> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseConditions>)this.AllEntities; }
    }
  }

  public partial class ApprovalRuleBaseConditionsCollectionActions : global::Sungero.Domain.Client.ChildEntityCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IApprovalRuleBaseConditions> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IApprovalRuleBaseConditions>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseConditions> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IApprovalRuleBaseConditions>)this.AllEntities; }
    }
  }

}