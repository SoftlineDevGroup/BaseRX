
// ==================================================================
// InternalDocumentBaseVersionsState.g.cs
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
  public class InternalDocumentBaseVersionsState : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsState, global::Sungero.Docflow.IInternalDocumentBaseVersionsState
  {
    public InternalDocumentBaseVersionsState(global::Sungero.Docflow.IInternalDocumentBaseVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IInternalDocumentBaseVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IInternalDocumentBaseVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertyStates(entity);
    }


  }


  public class InternalDocumentBaseVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsPropertyStates, global::Sungero.Docflow.IInternalDocumentBaseVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IInternalDocumentBase> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IInternalDocumentBase>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IInternalDocumentBase>("ElectronicDocument"); }
            }


    protected internal InternalDocumentBaseVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class InternalDocumentBaseVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IInternalDocumentBaseVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IInternalDocumentBaseVersions
  {
    public new global::Sungero.Docflow.IInternalDocumentBaseVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IInternalDocumentBaseVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal InternalDocumentBaseVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class InternalDocumentBaseVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsCollectionPropertyStates, global::Sungero.Docflow.IInternalDocumentBaseVersionsCollectionPropertyStates
  {

    protected internal InternalDocumentBaseVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// InternalDocumentBaseVersionsEventArgs.g.cs
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
// InternalDocumentBaseVersionsInfo.g.cs
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
  public class InternalDocumentBaseVersionsInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsInfo, global::Sungero.Docflow.IInternalDocumentBaseVersionsInfo
  {
    public InternalDocumentBaseVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IInternalDocumentBaseVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IInternalDocumentBaseVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertiesInfo(entityType);
    }

  }

  public class InternalDocumentBaseVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.OfficialDocumentVersionsPropertiesInfo, global::Sungero.Docflow.IInternalDocumentBaseVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IInternalDocumentBaseInfo, global::Sungero.Docflow.IInternalDocumentBase> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IInternalDocumentBaseInfo, global::Sungero.Docflow.IInternalDocumentBase>(propertyMetadata);
          }
        }


    protected internal InternalDocumentBaseVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
