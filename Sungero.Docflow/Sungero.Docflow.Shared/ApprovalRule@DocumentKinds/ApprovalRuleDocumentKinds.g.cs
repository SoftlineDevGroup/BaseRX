
// ==================================================================
// ApprovalRuleDocumentKindsState.g.cs
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
  public class ApprovalRuleDocumentKindsState : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentKindsState, global::Sungero.Docflow.IApprovalRuleDocumentKindsState
  {
    public ApprovalRuleDocumentKindsState(global::Sungero.Docflow.IApprovalRuleDocumentKinds entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleDocumentKindsPropertyStates(entity);
    }


  }


  public class ApprovalRuleDocumentKindsPropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentKindsPropertyStates, global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRule> ApprovalRuleBase
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRule>)base.ApprovalRuleBase; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> InternalApprovalRuleBase
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalRule>("ApprovalRuleBase"); }
            }


    protected internal ApprovalRuleDocumentKindsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalRuleDocumentKindsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentKindsCollectionPropertyState<T>, global::Sungero.Docflow.IApprovalRuleDocumentKindsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IApprovalRuleDocumentKinds
  {
    public new global::Sungero.Docflow.IApprovalRuleDocumentKindsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleDocumentKindsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleDocumentKindsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ApprovalRuleDocumentKindsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ApprovalRuleDocumentKindsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentKindsCollectionPropertyStates, global::Sungero.Docflow.IApprovalRuleDocumentKindsCollectionPropertyStates
  {

    protected internal ApprovalRuleDocumentKindsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ApprovalRuleDocumentKindsEventArgs.g.cs
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
// ApprovalRuleDocumentKindsInfo.g.cs
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
  public class ApprovalRuleDocumentKindsInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentKindsInfo, global::Sungero.Docflow.IApprovalRuleDocumentKindsInfo
  {
    public ApprovalRuleDocumentKindsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleDocumentKindsPropertiesInfo(entityType);
    }

  }

  public class ApprovalRuleDocumentKindsPropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRuleBaseDocumentKindsPropertiesInfo, global::Sungero.Docflow.IApprovalRuleDocumentKindsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleInfo, global::Sungero.Docflow.IApprovalRule> ApprovalRuleBase
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRuleBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleInfo, global::Sungero.Docflow.IApprovalRule>(propertyMetadata);
          }
        }


    protected internal ApprovalRuleDocumentKindsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}