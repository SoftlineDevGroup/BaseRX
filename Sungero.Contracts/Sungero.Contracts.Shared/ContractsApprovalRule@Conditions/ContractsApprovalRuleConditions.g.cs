
// ==================================================================
// ContractsApprovalRuleConditionsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractsApprovalRuleConditionsState : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsState, global::Sungero.Contracts.IContractsApprovalRuleConditionsState
  {
    public ContractsApprovalRuleConditionsState(global::Sungero.Contracts.IContractsApprovalRuleConditions entity) : base(entity) { }

    public new global::Sungero.Contracts.IContractsApprovalRuleConditionsPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleConditionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleConditionsPropertyStates(entity);
    }


  }


  public class ContractsApprovalRuleConditionsPropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsPropertyStates, global::Sungero.Contracts.IContractsApprovalRuleConditionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractsApprovalRule> ApprovalRuleBase
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractsApprovalRule>)base.ApprovalRuleBase; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> InternalApprovalRuleBase
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.IContractsApprovalRule>("ApprovalRuleBase"); }
            }
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractCondition> Condition
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IContractCondition>)base.Condition; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IConditionBase> InternalCondition
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.IContractCondition>("Condition"); }
            }


    protected internal ContractsApprovalRuleConditionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ContractsApprovalRuleConditionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsCollectionPropertyState<T>, global::Sungero.Contracts.IContractsApprovalRuleConditionsCollectionPropertyState<T>
    where T : global::Sungero.Contracts.IContractsApprovalRuleConditions
  {
    public new global::Sungero.Contracts.IContractsApprovalRuleConditionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleConditionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleConditionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ContractsApprovalRuleConditionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ContractsApprovalRuleConditionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsCollectionPropertyStates, global::Sungero.Contracts.IContractsApprovalRuleConditionsCollectionPropertyStates
  {

    protected internal ContractsApprovalRuleConditionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ContractsApprovalRuleConditionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{  
}

// ==================================================================
// ContractsApprovalRuleConditionsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractsApprovalRuleConditionsInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsInfo, global::Sungero.Contracts.IContractsApprovalRuleConditionsInfo
  {
    public ContractsApprovalRuleConditionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.IContractsApprovalRuleConditionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleConditionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleConditionsPropertiesInfo(entityType);
    }

  }

  public class ContractsApprovalRuleConditionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseConditionsPropertiesInfo, global::Sungero.Contracts.IContractsApprovalRuleConditionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.IContractsApprovalRuleInfo, global::Sungero.Contracts.IContractsApprovalRule> ApprovalRuleBase
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRuleBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.IContractsApprovalRuleInfo, global::Sungero.Contracts.IContractsApprovalRule>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.IContractConditionInfo, global::Sungero.Contracts.IContractCondition> Condition
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Condition");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.IContractConditionInfo, global::Sungero.Contracts.IContractCondition>(propertyMetadata);
          }
        }


    protected internal ContractsApprovalRuleConditionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}