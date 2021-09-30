
// ==================================================================
// RegistrationSettingDocumentKindsState.g.cs
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
  public class RegistrationSettingDocumentKindsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IRegistrationSettingDocumentKindsState
  {
    public RegistrationSettingDocumentKindsState(global::Sungero.Docflow.IRegistrationSettingDocumentKinds entity) : base(entity) { }

    public new global::Sungero.Docflow.IRegistrationSettingDocumentKindsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationSettingDocumentKindsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.RegistrationSettingDocumentKindsPropertyStates(entity);
    }


  }


  public class RegistrationSettingDocumentKindsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IRegistrationSettingDocumentKindsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IRegistrationSetting> RegistrationSetting 
            {
              get { return this.InternalRegistrationSetting; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IRegistrationSetting> InternalRegistrationSetting
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IRegistrationSetting>("RegistrationSetting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> DocumentKind 
            {
              get { return this.InternalDocumentKind; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> InternalDocumentKind
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentKind>("DocumentKind"); }
            }


    protected internal RegistrationSettingDocumentKindsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class RegistrationSettingDocumentKindsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IRegistrationSettingDocumentKindsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IRegistrationSettingDocumentKinds
  {
    public new global::Sungero.Docflow.IRegistrationSettingDocumentKindsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationSettingDocumentKindsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.RegistrationSettingDocumentKindsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal RegistrationSettingDocumentKindsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class RegistrationSettingDocumentKindsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IRegistrationSettingDocumentKindsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState RegistrationSetting
        {
          get { return this.GetChildPropertySummaryState("RegistrationSetting"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentKind
        {
          get { return this.GetChildPropertySummaryState("DocumentKind"); }
        }


    protected internal RegistrationSettingDocumentKindsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// RegistrationSettingDocumentKindsEventArgs.g.cs
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
    public class RegistrationSettingDocumentKindsDocumentKindChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Docflow.IDocumentKind>
    {
      public RegistrationSettingDocumentKindsDocumentKindChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> state, global::Sungero.Docflow.IDocumentKind newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

}

// ==================================================================
// RegistrationSettingDocumentKindsInfo.g.cs
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
  public class RegistrationSettingDocumentKindsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IRegistrationSettingDocumentKindsInfo
  {
    public RegistrationSettingDocumentKindsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IRegistrationSettingDocumentKindsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IRegistrationSettingDocumentKindsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.RegistrationSettingDocumentKindsPropertiesInfo(entityType);
    }

  }

  public class RegistrationSettingDocumentKindsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IRegistrationSettingDocumentKindsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IRegistrationSettingInfo, global::Sungero.Docflow.IRegistrationSetting> RegistrationSetting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("RegistrationSetting");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IRegistrationSettingInfo, global::Sungero.Docflow.IRegistrationSetting>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IDocumentKindInfo, global::Sungero.Docflow.IDocumentKind> DocumentKind 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DocumentKind");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IDocumentKindInfo, global::Sungero.Docflow.IDocumentKind>(propertyMetadata);
          }
        }


    protected internal RegistrationSettingDocumentKindsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
