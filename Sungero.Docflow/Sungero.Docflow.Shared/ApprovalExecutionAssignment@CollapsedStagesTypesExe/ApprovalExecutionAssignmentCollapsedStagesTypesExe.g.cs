
// ==================================================================
// ApprovalExecutionAssignmentCollapsedStagesTypesExeState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalExecutionAssignmentCollapsedStagesTypesExeState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeState
  {
    public ApprovalExecutionAssignmentCollapsedStagesTypesExeState(global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentCollapsedStagesTypesExePropertyStates(entity);
    }


  }


  public class ApprovalExecutionAssignmentCollapsedStagesTypesExePropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalExecutionAssignment> ApprovalExecutionAssignment 
            {
              get { return this.InternalApprovalExecutionAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalExecutionAssignment> InternalApprovalExecutionAssignment
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalExecutionAssignment>("ApprovalExecutionAssignment"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> StageType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("StageType"); }
            }


    protected internal ApprovalExecutionAssignmentCollapsedStagesTypesExePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExe
  {
    public new global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalExecutionAssignment
        {
          get { return this.GetChildPropertySummaryState("ApprovalExecutionAssignment"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState StageType
        {
          get { return this.GetChildPropertySummaryState("StageType"); }
        }


    protected internal ApprovalExecutionAssignmentCollapsedStagesTypesExeCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalExecutionAssignmentCollapsedStagesTypesExeEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{  
}

// ==================================================================
// ApprovalExecutionAssignmentCollapsedStagesTypesExeInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalExecutionAssignmentCollapsedStagesTypesExeInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExeInfo
  {
    public ApprovalExecutionAssignmentCollapsedStagesTypesExeInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo(entityType);
    }

  }

  public class ApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalExecutionAssignmentInfo, global::Sungero.Docflow.IApprovalExecutionAssignment> ApprovalExecutionAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalExecutionAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalExecutionAssignmentInfo, global::Sungero.Docflow.IApprovalExecutionAssignment>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo StageType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("StageType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }


    protected internal ApprovalExecutionAssignmentCollapsedStagesTypesExePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
