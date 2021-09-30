
// ==================================================================
// CounterpartyDocumentState.g.cs
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
  public class CounterpartyDocumentState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseState, global::Sungero.Docflow.ICounterpartyDocumentState
  {
    public CounterpartyDocumentState(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity) { }

    public new global::Sungero.Docflow.ICounterpartyDocumentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.ICounterpartyDocumentControlStates Controls
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentControlStates(entity);
    }

    public new global::Sungero.Docflow.ICounterpartyDocumentPageStates Pages
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentPageStates(entity);
    }

  }


  public class CounterpartyDocumentControlStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseControlStates, global::Sungero.Docflow.ICounterpartyDocumentControlStates
  {

    protected internal CounterpartyDocumentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CounterpartyDocumentPageStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBasePageStates, global::Sungero.Docflow.ICounterpartyDocumentPageStates
  {

    protected internal CounterpartyDocumentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CounterpartyDocumentPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBasePropertyStates, global::Sungero.Docflow.ICounterpartyDocumentPropertyStates
  {
            public new global::Sungero.Docflow.ICounterpartyDocumentVersionsCollectionPropertyState<global::Sungero.Docflow.ICounterpartyDocumentVersions> Versions
            {
              get { return (global::Sungero.Docflow.ICounterpartyDocumentVersionsCollectionPropertyState<global::Sungero.Docflow.ICounterpartyDocumentVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.CounterpartyDocumentVersionsCollectionPropertyState<global::Sungero.Docflow.ICounterpartyDocumentVersions>(entity, propertyName);
            }
            public new global::Sungero.Docflow.ICounterpartyDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.ICounterpartyDocumentTracking> Tracking
            {
              get { return (global::Sungero.Docflow.ICounterpartyDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.ICounterpartyDocumentTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.CounterpartyDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.ICounterpartyDocumentTracking>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> Counterparty 
            {
              get { return this.InternalCounterparty; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> InternalCounterparty
            {
              get { return this.GetPropertyState<global::Sungero.Parties.ICounterparty>("Counterparty"); }
            }


    protected internal CounterpartyDocumentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CounterpartyDocumentEventArgs.g.cs
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
    public class CounterpartyDocumentCounterpartyChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Parties.ICounterparty>
    {
      public CounterpartyDocumentCounterpartyChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> state, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

}

// ==================================================================
// CounterpartyDocumentInfo.g.cs
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
  public class CounterpartyDocumentInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseInfo, global::Sungero.Docflow.ICounterpartyDocumentInfo
  {
    public CounterpartyDocumentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ICounterpartyDocumentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentPropertiesInfo(entityType);
    }

  }

  public class CounterpartyDocumentPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBasePropertiesInfo, global::Sungero.Docflow.ICounterpartyDocumentPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.ICounterpartyDocumentVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.ICounterpartyDocumentVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.ICounterpartyDocumentTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.ICounterpartyDocumentTrackingPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty> Counterparty 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Counterparty");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty>(propertyMetadata);
          }
        }


    protected internal CounterpartyDocumentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// CounterpartyDocumentHandlers.g.cs
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
  public partial class CounterpartyDocumentSharedHandlers : global::Sungero.Docflow.InternalDocumentBaseSharedHandlers
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }


    public CounterpartyDocumentSharedHandlers(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CounterpartyDocumentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.CounterpartyDocument
{
  /// <summary>
  /// Represents CounterpartyDocument resources.
  /// </summary>
  public class CounterpartyDocumentResources : global::Sungero.Docflow.Shared.InternalDocumentBase.InternalDocumentBaseResources, global::Sungero.Docflow.CounterpartyDocument.ICounterpartyDocumentResources
  {
  }
}

// ==================================================================
// CounterpartyDocumentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class CounterpartyDocumentFunctions : global::Sungero.Docflow.Shared.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.ICounterpartyDocument _obj
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocument)this.Entity; }
    }

    public CounterpartyDocumentFunctions(global::Sungero.Docflow.ICounterpartyDocument entity) : base(entity) { }
  }
}

// ==================================================================
// CounterpartyDocumentFunctions.g.cs
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
  internal static class CounterpartyDocument
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.CounterpartyDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
      return functions.GetCounterparties();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void FillName(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.CounterpartyDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
    functions.FillName();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.CounterpartyDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
    functions.SetLifeCycleState();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.CounterpartyDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Docflow.ICounterpartyDocument counterpartyDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.CounterpartyDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)counterpartyDocument).FunctionsContainer.SharedFunctions;
    functions.RefreshDocumentForm();
    }

  }
}

// ==================================================================
// CounterpartyDocumentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.CounterpartyDocument
{

  public class CounterpartyDocumentFilterInfo : global::Sungero.Docflow.Shared.InternalDocumentBase.InternalDocumentBaseFilterInfo,
    global::Sungero.Docflow.ICounterpartyDocumentFilterInfo
  {
    public global::Sungero.Domain.Shared.IFilterControlInfo Active
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Active");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo InWork
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("InWork");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Obsolete
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Obsolete");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentYear
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentYear");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo LastYear
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("LastYear");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Manual
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Manual");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Kind
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Kind");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo RangeOfDateFrom
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("RangeOfDateFrom");
      }
    }
    public global::Sungero.Domain.Shared.IFilterControlInfo RangeOfDateTo
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("RangeOfDateTo");
      }
    }


  }

  public class CounterpartyDocumentFilterState : global::Sungero.Docflow.Shared.InternalDocumentBase.InternalDocumentBaseFilterState,
    global::Sungero.Docflow.ICounterpartyDocumentFilterState
  {
    public bool Active
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool InWork
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool Obsolete
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool CurrentYear
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool LastYear
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool Manual
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }



    public global::Sungero.Docflow.IDocumentKind Kind
    {
      get { return this.GetValue<global::Sungero.Docflow.IDocumentKind>(); }
      set { this.SetValue(value); }
    }



    public global::System.DateTime? RangeOfDateFrom
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }
    public global::System.DateTime? RangeOfDateTo
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }



    public new Sungero.Docflow.ICounterpartyDocumentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.ICounterpartyDocumentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.CounterpartyDocument.CounterpartyDocumentFilterInfo();
    }

  }
}

// ==================================================================
// CounterpartyDocumentSharedPublicFunctions.g.cs
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
  public class CounterpartyDocumentSharedPublicFunctions : global::Sungero.Docflow.Shared.ICounterpartyDocumentSharedPublicFunctions
  {
  }
}
