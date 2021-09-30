
// ==================================================================
// ApprovalTaskAddApproversState.g.cs
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
  public class ApprovalTaskAddApproversState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IApprovalTaskAddApproversState
  {
    public ApprovalTaskAddApproversState(global::Sungero.Docflow.IApprovalTaskAddApprovers entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalTaskAddApproversPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddApproversPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddApproversPropertyStates(entity);
    }


  }


  public class ApprovalTaskAddApproversPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IApprovalTaskAddApproversPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalTask> ApprovalTask 
            {
              get { return this.InternalApprovalTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalTask> InternalApprovalTask
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalTask>("ApprovalTask"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> Approver 
            {
              get { return this.InternalApprover; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> InternalApprover
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.IRecipient>("Approver"); }
            }


    protected internal ApprovalTaskAddApproversPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalTaskAddApproversCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalTaskAddApproversCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalTaskAddApprovers
  {
    public new global::Sungero.Docflow.IApprovalTaskAddApproversCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddApproversCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddApproversCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalTaskAddApproversCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalTaskAddApproversCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IApprovalTaskAddApproversCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ApprovalTask
        {
          get { return this.GetChildPropertySummaryState("ApprovalTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Approver
        {
          get { return this.GetChildPropertySummaryState("Approver"); }
        }


    protected internal ApprovalTaskAddApproversCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalTaskAddApproversEventArgs.g.cs
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
    public class ApprovalTaskAddApproversApproverChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.CoreEntities.IRecipient>
    {
      public ApprovalTaskAddApproversApproverChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> state, global::Sungero.CoreEntities.IRecipient newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

}

// ==================================================================
// ApprovalTaskAddApproversInfo.g.cs
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
  public class ApprovalTaskAddApproversInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IApprovalTaskAddApproversInfo
  {
    public ApprovalTaskAddApproversInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalTaskAddApproversPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalTaskAddApproversPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalTaskAddApproversPropertiesInfo(entityType);
    }

  }

  public class ApprovalTaskAddApproversPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IApprovalTaskAddApproversPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalTaskInfo, global::Sungero.Docflow.IApprovalTask> ApprovalTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalTaskInfo, global::Sungero.Docflow.IApprovalTask>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient> Approver 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Approver");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient>(propertyMetadata);
          }
        }


    protected internal ApprovalTaskAddApproversPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
