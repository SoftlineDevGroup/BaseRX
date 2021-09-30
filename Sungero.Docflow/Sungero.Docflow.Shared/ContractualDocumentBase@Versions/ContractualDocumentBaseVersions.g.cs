
// ==================================================================
// ContractualDocumentBaseVersionsState.g.cs
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
  public class ContractualDocumentBaseVersionsState : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsState, global::Sungero.Docflow.IContractualDocumentBaseVersionsState
  {
    public ContractualDocumentBaseVersionsState(global::Sungero.Docflow.IContractualDocumentBaseVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBaseVersionsPropertyStates(entity);
    }


  }


  public class ContractualDocumentBaseVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsPropertyStates, global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IContractualDocumentBase> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IContractualDocumentBase>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IContractualDocumentBase>("ElectronicDocument"); }
            }


    protected internal ContractualDocumentBaseVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ContractualDocumentBaseVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IContractualDocumentBaseVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IContractualDocumentBaseVersions
  {
    public new global::Sungero.Docflow.IContractualDocumentBaseVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBaseVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ContractualDocumentBaseVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ContractualDocumentBaseVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsCollectionPropertyStates, global::Sungero.Docflow.IContractualDocumentBaseVersionsCollectionPropertyStates
  {

    protected internal ContractualDocumentBaseVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ContractualDocumentBaseVersionsEventArgs.g.cs
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
// ContractualDocumentBaseVersionsInfo.g.cs
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
  public class ContractualDocumentBaseVersionsInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsInfo, global::Sungero.Docflow.IContractualDocumentBaseVersionsInfo
  {
    public ContractualDocumentBaseVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBaseVersionsPropertiesInfo(entityType);
    }

  }

  public class ContractualDocumentBaseVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsPropertiesInfo, global::Sungero.Docflow.IContractualDocumentBaseVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IContractualDocumentBaseInfo, global::Sungero.Docflow.IContractualDocumentBase> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IContractualDocumentBaseInfo, global::Sungero.Docflow.IContractualDocumentBase>(propertyMetadata);
          }
        }


    protected internal ContractualDocumentBaseVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
