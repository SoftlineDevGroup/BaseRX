
// ==================================================================
// MinutesBaseVersionsState.g.cs
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
  public class MinutesBaseVersionsState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsState, global::Sungero.Docflow.IMinutesBaseVersionsState
  {
    public MinutesBaseVersionsState(global::Sungero.Docflow.IMinutesBaseVersions entity) : base(entity) { }

    public new global::Sungero.Docflow.IMinutesBaseVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMinutesBaseVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseVersionsPropertyStates(entity);
    }


  }


  public class MinutesBaseVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertyStates, global::Sungero.Docflow.IMinutesBaseVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMinutesBase> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMinutesBase>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IMinutesBase>("ElectronicDocument"); }
            }


    protected internal MinutesBaseVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class MinutesBaseVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyState<T>, global::Sungero.Docflow.IMinutesBaseVersionsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IMinutesBaseVersions
  {
    public new global::Sungero.Docflow.IMinutesBaseVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMinutesBaseVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal MinutesBaseVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class MinutesBaseVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsCollectionPropertyStates, global::Sungero.Docflow.IMinutesBaseVersionsCollectionPropertyStates
  {

    protected internal MinutesBaseVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// MinutesBaseVersionsEventArgs.g.cs
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
// MinutesBaseVersionsInfo.g.cs
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
  public class MinutesBaseVersionsInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsInfo, global::Sungero.Docflow.IMinutesBaseVersionsInfo
  {
    public MinutesBaseVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IMinutesBaseVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IMinutesBaseVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseVersionsPropertiesInfo(entityType);
    }

  }

  public class MinutesBaseVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsPropertiesInfo, global::Sungero.Docflow.IMinutesBaseVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IMinutesBaseInfo, global::Sungero.Docflow.IMinutesBase> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IMinutesBaseInfo, global::Sungero.Docflow.IMinutesBase>(propertyMetadata);
          }
        }


    protected internal MinutesBaseVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}