
// ==================================================================
// SignatureSettingDocumentKindsState.g.cs
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
  public class SignatureSettingDocumentKindsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.ISignatureSettingDocumentKindsState
  {
    public SignatureSettingDocumentKindsState(global::Sungero.Docflow.ISignatureSettingDocumentKinds entity) : base(entity) { }

    public new global::Sungero.Docflow.ISignatureSettingDocumentKindsPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingDocumentKindsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingDocumentKindsPropertyStates(entity);
    }


  }


  public class SignatureSettingDocumentKindsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.ISignatureSettingDocumentKindsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISignatureSetting> SignatureSetting 
            {
              get { return this.InternalSignatureSetting; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISignatureSetting> InternalSignatureSetting
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ISignatureSetting>("SignatureSetting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> DocumentKind 
            {
              get { return this.InternalDocumentKind; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> InternalDocumentKind
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IDocumentKind>("DocumentKind"); }
            }


    protected internal SignatureSettingDocumentKindsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class SignatureSettingDocumentKindsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.ISignatureSettingDocumentKindsCollectionPropertyState<T>
    where T : global::Sungero.Docflow.ISignatureSettingDocumentKinds
  {
    public new global::Sungero.Docflow.ISignatureSettingDocumentKindsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingDocumentKindsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingDocumentKindsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal SignatureSettingDocumentKindsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class SignatureSettingDocumentKindsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.ISignatureSettingDocumentKindsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState SignatureSetting
        {
          get { return this.GetChildPropertySummaryState("SignatureSetting"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentKind
        {
          get { return this.GetChildPropertySummaryState("DocumentKind"); }
        }


    protected internal SignatureSettingDocumentKindsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// SignatureSettingDocumentKindsEventArgs.g.cs
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
    public class SignatureSettingDocumentKindsDocumentKindChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Docflow.IDocumentKind>
    {
      public SignatureSettingDocumentKindsDocumentKindChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IDocumentKind> state, global::Sungero.Docflow.IDocumentKind newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

}

// ==================================================================
// SignatureSettingDocumentKindsInfo.g.cs
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
  public class SignatureSettingDocumentKindsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.ISignatureSettingDocumentKindsInfo
  {
    public SignatureSettingDocumentKindsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ISignatureSettingDocumentKindsPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ISignatureSettingDocumentKindsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingDocumentKindsPropertiesInfo(entityType);
    }

  }

  public class SignatureSettingDocumentKindsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.ISignatureSettingDocumentKindsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.ISignatureSettingInfo, global::Sungero.Docflow.ISignatureSetting> SignatureSetting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("SignatureSetting");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.ISignatureSettingInfo, global::Sungero.Docflow.ISignatureSetting>(propertyMetadata);
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


    protected internal SignatureSettingDocumentKindsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
