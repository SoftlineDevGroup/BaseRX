
// ==================================================================
// SmartProcessingSettingAdditionalClassifiersState.g.cs
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
  public class SmartProcessingSettingAdditionalClassifiersState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersState
  {
    public SmartProcessingSettingAdditionalClassifiersState(global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers entity) : base(entity) { }

    public new global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingAdditionalClassifiersPropertyStates(entity);
    }


  }


  public class SmartProcessingSettingAdditionalClassifiersPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISmartProcessingSetting> SmartProcessingSetting 
            {
              get { return this.InternalSmartProcessingSetting; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISmartProcessingSetting> InternalSmartProcessingSetting
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ISmartProcessingSetting>("SmartProcessingSetting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> ClassifierId 
            {
              get { return this.GetPropertyState<global::System.Int32?>("ClassifierId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> ClassifierName 
            {
              get { return this.GetPropertyState<global::System.String>("ClassifierName"); }
            }


    protected internal SmartProcessingSettingAdditionalClassifiersPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class SmartProcessingSettingAdditionalClassifiersCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersCollectionPropertyState<T>
    where T : global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers
  {
    public new global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingAdditionalClassifiersCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal SmartProcessingSettingAdditionalClassifiersCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class SmartProcessingSettingAdditionalClassifiersCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState SmartProcessingSetting
        {
          get { return this.GetChildPropertySummaryState("SmartProcessingSetting"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ClassifierId
        {
          get { return this.GetChildPropertySummaryState("ClassifierId"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ClassifierName
        {
          get { return this.GetChildPropertySummaryState("ClassifierName"); }
        }


    protected internal SmartProcessingSettingAdditionalClassifiersCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// SmartProcessingSettingAdditionalClassifiersEventArgs.g.cs
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
// SmartProcessingSettingAdditionalClassifiersInfo.g.cs
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
  public class SmartProcessingSettingAdditionalClassifiersInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersInfo
  {
    public SmartProcessingSettingAdditionalClassifiersInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingAdditionalClassifiersPropertiesInfo(entityType);
    }

  }

  public class SmartProcessingSettingAdditionalClassifiersPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.ISmartProcessingSettingInfo, global::Sungero.Docflow.ISmartProcessingSetting> SmartProcessingSetting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("SmartProcessingSetting");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.ISmartProcessingSettingInfo, global::Sungero.Docflow.ISmartProcessingSetting>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo ClassifierId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("ClassifierId");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo ClassifierName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("ClassifierName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal SmartProcessingSettingAdditionalClassifiersPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
