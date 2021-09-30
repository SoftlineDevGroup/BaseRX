
// ==================================================================
// RetentionPolicyState.g.cs
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
  public class RetentionPolicyState : 
    global::Sungero.Docflow.Shared.StoragePolicyBaseState, global::Sungero.Docflow.IRetentionPolicyState
  {
    public RetentionPolicyState(global::Sungero.Docflow.IRetentionPolicy entity) : base(entity) { }

    public new global::Sungero.Docflow.IRetentionPolicyPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IRetentionPolicyPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.RetentionPolicyPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IRetentionPolicyControlStates Controls
    {
      get { return (global::Sungero.Docflow.IRetentionPolicyControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.RetentionPolicyControlStates(entity);
    }

    public new global::Sungero.Docflow.IRetentionPolicyPageStates Pages
    {
      get { return (global::Sungero.Docflow.IRetentionPolicyPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.RetentionPolicyPageStates(entity);
    }

  }


  public class RetentionPolicyControlStates : 
    global::Sungero.Docflow.Shared.StoragePolicyBaseControlStates, global::Sungero.Docflow.IRetentionPolicyControlStates
  {

    protected internal RetentionPolicyControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class RetentionPolicyPageStates : 
    global::Sungero.Docflow.Shared.StoragePolicyBasePageStates, global::Sungero.Docflow.IRetentionPolicyPageStates
  {

    protected internal RetentionPolicyPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class RetentionPolicyPropertyStates : 
    global::Sungero.Docflow.Shared.StoragePolicyBasePropertyStates, global::Sungero.Docflow.IRetentionPolicyPropertyStates
  {
            public new global::Sungero.Docflow.IRetentionPolicyDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IRetentionPolicyDocumentKinds> DocumentKinds
            {
              get { return (global::Sungero.Docflow.IRetentionPolicyDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IRetentionPolicyDocumentKinds>)base.DocumentKinds; }
            }

            protected override global::Sungero.Docflow.IStoragePolicyBaseDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds> CreateDocumentKindsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.RetentionPolicyDocumentKindsCollectionPropertyState<global::Sungero.Docflow.IRetentionPolicyDocumentKinds>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> DocumentDateType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("DocumentDateType"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> DaysToMove 
            {
              get { return this.GetPropertyState<global::System.Int32?>("DaysToMove"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> NextRetention 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("NextRetention"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> LastRetention 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("LastRetention"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> Interval 
            {
              get { return this.GetPropertyState<global::System.Int32?>("Interval"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> RepeatType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("RepeatType"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> IntervalType 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("IntervalType"); }
            }


    protected internal RetentionPolicyPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// RetentionPolicyEventArgs.g.cs
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
// RetentionPolicyInfo.g.cs
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
  public class RetentionPolicyInfo : 
    global::Sungero.Docflow.Shared.StoragePolicyBaseInfo, global::Sungero.Docflow.IRetentionPolicyInfo
  {
    public RetentionPolicyInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IRetentionPolicyPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IRetentionPolicyPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.RetentionPolicyPropertiesInfo(entityType);
    }

  }

  public class RetentionPolicyPropertiesInfo : 
    global::Sungero.Docflow.Shared.StoragePolicyBasePropertiesInfo, global::Sungero.Docflow.IRetentionPolicyPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IRetentionPolicyDocumentKindsPropertiesInfo> DocumentKinds
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("DocumentKinds");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IRetentionPolicyDocumentKindsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo DocumentDateType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("DocumentDateType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo DaysToMove 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("DaysToMove");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo NextRetention 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("NextRetention");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo LastRetention 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("LastRetention");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo Interval 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("Interval");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo RepeatType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("RepeatType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo IntervalType 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("IntervalType");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }


    protected internal RetentionPolicyPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// RetentionPolicyHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class RetentionPolicySharedHandlers : global::Sungero.Docflow.StoragePolicyBaseSharedHandlers
  {
    private global::Sungero.Docflow.IRetentionPolicy _obj
    {
      get { return (global::Sungero.Docflow.IRetentionPolicy)this.Entity; }
    }
    public virtual void DocumentDateTypeChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void DaysToMoveChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void NextRetentionChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void LastRetentionChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }







    public RetentionPolicySharedHandlers(global::Sungero.Docflow.IRetentionPolicy entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// RetentionPolicyResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.RetentionPolicy
{
  /// <summary>
  /// Represents RetentionPolicy resources.
  /// </summary>
  public class RetentionPolicyResources : global::Sungero.Docflow.Shared.StoragePolicyBase.StoragePolicyBaseResources, global::Sungero.Docflow.RetentionPolicy.IRetentionPolicyResources
  {
    public virtual global::CommonLibrary.LocalizedString IncorrectDays
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy) , "IncorrectDays");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IncorrectDaysFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy), "IncorrectDays", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DaysTooMatch
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy) , "DaysTooMatch");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DaysTooMatchFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy), "DaysTooMatch", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString IncorrectIntervalValue
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy) , "IncorrectIntervalValue");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IncorrectIntervalValueFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy), "IncorrectIntervalValue", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString IntervalTooMatch
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy) , "IntervalTooMatch");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IntervalTooMatchFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IRetentionPolicy), "IntervalTooMatch", false, args);
    }

  }
}

// ==================================================================
// RetentionPolicySharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class RetentionPolicyFunctions : global::Sungero.Docflow.Shared.StoragePolicyBaseFunctions
  {
    private global::Sungero.Docflow.IRetentionPolicy _obj
    {
      get { return (global::Sungero.Docflow.IRetentionPolicy)this.Entity; }
    }

    public RetentionPolicyFunctions(global::Sungero.Docflow.IRetentionPolicy entity) : base(entity) { }
  }
}

// ==================================================================
// RetentionPolicyFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class RetentionPolicy
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RetentionPolicyFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.IRetentionPolicy retentionPolicy)
    {
      var functions = (global::Sungero.Docflow.Shared.RetentionPolicyFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)retentionPolicy).FunctionsContainer.SharedFunctions;
    functions.SetRequiredProperties();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RetentionPolicyFunctions" />
    internal static  global::System.Nullable<global::System.DateTime> GetNextRetentionDate(global::System.Nullable<global::Sungero.Core.Enumeration> repeatType, global::System.Nullable<global::Sungero.Core.Enumeration> intervalType, global::System.Nullable<global::System.Int32> interval, global::System.DateTime now)
    {
      return global::Sungero.Docflow.Shared.RetentionPolicyFunctions.GetNextRetentionDate(repeatType, intervalType, interval, now);
    }

  }
}

// ==================================================================
// RetentionPolicyFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.RetentionPolicy
{

  public class RetentionPolicyFilterInfo : global::Sungero.Docflow.Shared.StoragePolicyBase.StoragePolicyBaseFilterInfo,
    global::Sungero.Docflow.IRetentionPolicyFilterInfo
  {
  }

  public class RetentionPolicyFilterState : global::Sungero.Docflow.Shared.StoragePolicyBase.StoragePolicyBaseFilterState,
    global::Sungero.Docflow.IRetentionPolicyFilterState
  {



    public new Sungero.Docflow.IRetentionPolicyFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IRetentionPolicyFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.RetentionPolicy.RetentionPolicyFilterInfo();
    }

  }
}

// ==================================================================
// RetentionPolicySharedPublicFunctions.g.cs
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
  public class RetentionPolicySharedPublicFunctions : global::Sungero.Docflow.Shared.IRetentionPolicySharedPublicFunctions
  {
    public global::System.Nullable<global::System.DateTime> GetNextRetentionDate(global::System.Nullable<global::Sungero.Core.Enumeration> repeatType, global::System.Nullable<global::Sungero.Core.Enumeration> intervalType, global::System.Nullable<global::System.Int32> interval, global::System.DateTime now)
    {
      return global::Sungero.Docflow.Functions.RetentionPolicy.GetNextRetentionDate(repeatType, intervalType, interval, now);
    }
  }
}