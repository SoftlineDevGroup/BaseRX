
// ==================================================================
// ApprovalSendingAssignmentCollapsedStagesTypesSenState.g.cs
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
  public class ApprovalSendingAssignmentCollapsedStagesTypesSenState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenState
  {
    public ApprovalSendingAssignmentCollapsedStagesTypesSenState(global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSen entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalSendingAssignmentCollapsedStagesTypesSenPropertyStates(entity);
    }


  }


  public class ApprovalSendingAssignmentCollapsedStagesTypesSenPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalSendingAssignment> ApprovalSendingAssignment 
            {
              get { return this.InternalApprovalSendingAssignment; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalSendingAssignment> InternalApprovalSendingAssignment
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalSendingAssignment>("ApprovalSendingAssignment"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> StageType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("StageType"); }
            }


    protected internal ApprovalSendingAssignmentCollapsedStagesTypesSenPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSen
  {
    public new global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalSendingAssignment
        {
          get { return this.GetChildPropertySummaryState("ApprovalSendingAssignment"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState StageType
        {
          get { return this.GetChildPropertySummaryState("StageType"); }
        }


    protected internal ApprovalSendingAssignmentCollapsedStagesTypesSenCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalSendingAssignmentCollapsedStagesTypesSenEventArgs.g.cs
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
// ApprovalSendingAssignmentCollapsedStagesTypesSenInfo.g.cs
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
  public class ApprovalSendingAssignmentCollapsedStagesTypesSenInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenInfo
  {
    public ApprovalSendingAssignmentCollapsedStagesTypesSenInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalSendingAssignmentCollapsedStagesTypesSenPropertiesInfo(entityType);
    }

  }

  public class ApprovalSendingAssignmentCollapsedStagesTypesSenPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalSendingAssignmentCollapsedStagesTypesSenPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalSendingAssignmentInfo, global::Sungero.Docflow.IApprovalSendingAssignment> ApprovalSendingAssignment 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalSendingAssignment");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalSendingAssignmentInfo, global::Sungero.Docflow.IApprovalSendingAssignment>(propertyMetadata);
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


    protected internal ApprovalSendingAssignmentCollapsedStagesTypesSenPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
