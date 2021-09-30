
// ==================================================================
// SmartProcessingSettingCaptureSourcesState.g.cs
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
  public class SmartProcessingSettingCaptureSourcesState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesState
  {
    public SmartProcessingSettingCaptureSourcesState(global::Sungero.Docflow.ISmartProcessingSettingCaptureSources entity) : base(entity) { }

    public new global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingCaptureSourcesPropertyStates(entity);
    }


  }


  public class SmartProcessingSettingCaptureSourcesPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISmartProcessingSetting> SmartProcessingSetting 
            {
              get { return this.InternalSmartProcessingSetting; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ISmartProcessingSetting> InternalSmartProcessingSetting
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ISmartProcessingSetting>("SmartProcessingSetting"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> SenderLineName 
            {
              get { return this.GetPropertyState<global::System.String>("SenderLineName"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> Responsible 
            {
              get { return this.InternalResponsible; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> InternalResponsible
            {
              get { return this.GetPropertyState<global::Sungero.CoreEntities.IRecipient>("Responsible"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }


    protected internal SmartProcessingSettingCaptureSourcesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class SmartProcessingSettingCaptureSourcesCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesCollectionPropertyState<T>
    where T : global::Sungero.Docflow.ISmartProcessingSettingCaptureSources
  {
    public new global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingCaptureSourcesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal SmartProcessingSettingCaptureSourcesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class SmartProcessingSettingCaptureSourcesCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState SmartProcessingSetting
        {
          get { return this.GetChildPropertySummaryState("SmartProcessingSetting"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState SenderLineName
        {
          get { return this.GetChildPropertySummaryState("SenderLineName"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Responsible
        {
          get { return this.GetChildPropertySummaryState("Responsible"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Note
        {
          get { return this.GetChildPropertySummaryState("Note"); }
        }


    protected internal SmartProcessingSettingCaptureSourcesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// SmartProcessingSettingCaptureSourcesEventArgs.g.cs
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
    public class SmartProcessingSettingCaptureSourcesResponsibleChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.CoreEntities.IRecipient>
    {
      public SmartProcessingSettingCaptureSourcesResponsibleChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.CoreEntities.IRecipient> state, global::Sungero.CoreEntities.IRecipient newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }


}

// ==================================================================
// SmartProcessingSettingCaptureSourcesInfo.g.cs
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
  public class SmartProcessingSettingCaptureSourcesInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesInfo
  {
    public SmartProcessingSettingCaptureSourcesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingCaptureSourcesPropertiesInfo(entityType);
    }

  }

  public class SmartProcessingSettingCaptureSourcesPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.ISmartProcessingSettingCaptureSourcesPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.ISmartProcessingSettingInfo, global::Sungero.Docflow.ISmartProcessingSetting> SmartProcessingSetting 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("SmartProcessingSetting");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.ISmartProcessingSettingInfo, global::Sungero.Docflow.ISmartProcessingSetting>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo SenderLineName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("SenderLineName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient> Responsible 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Responsible");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.CoreEntities.IRecipientInfo, global::Sungero.CoreEntities.IRecipient>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Note 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Note");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal SmartProcessingSettingCaptureSourcesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
