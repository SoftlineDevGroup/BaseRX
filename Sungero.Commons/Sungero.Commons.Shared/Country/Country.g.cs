
// ==================================================================
// CountryState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class CountryState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Commons.ICountryState
  {
    public CountryState(global::Sungero.Commons.ICountry entity) : base(entity) { }

    public new global::Sungero.Commons.ICountryPropertyStates Properties
    {
      get { return (global::Sungero.Commons.ICountryPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.CountryPropertyStates(entity);
    }


    public new global::Sungero.Commons.ICountryControlStates Controls
    {
      get { return (global::Sungero.Commons.ICountryControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.CountryControlStates(entity);
    }

    public new global::Sungero.Commons.ICountryPageStates Pages
    {
      get { return (global::Sungero.Commons.ICountryPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Commons.Shared.CountryPageStates(entity);
    }

  }


  public class CountryControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Commons.ICountryControlStates
  {

    protected internal CountryControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class CountryPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Commons.ICountryPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal CountryPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CountryPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Commons.ICountryPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Code 
            {
              get { return this.GetPropertyState<global::System.String>("Code"); }
            }


    protected internal CountryPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// CountryEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{  
}

// ==================================================================
// CountryInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class CountryInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Commons.ICountryInfo
  {
    public CountryInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Commons.ICountryPropertiesInfo Properties
    {
      get { return (global::Sungero.Commons.ICountryPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Commons.ICountryActionsInfo Actions
    {
      get { return (global::Sungero.Commons.ICountryActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Commons.Shared.CountryPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Commons.Shared.CountryActionsInfo(entityType);
    }
  }

  public class CountryPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Commons.ICountryPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Code 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Code");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal CountryPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class CountryActionsInfo : 
    global::Sungero.Domain.Shared.EntityActionsInfo, global::Sungero.Commons.ICountryActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo ShowDuplicates 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ShowDuplicates")); }
        }


    protected internal CountryActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// CountryHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{
  public partial class CountrySharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers
  {
    private global::Sungero.Commons.ICountry _obj
    {
      get { return (global::Sungero.Commons.ICountry)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void CodeChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public CountrySharedHandlers(global::Sungero.Commons.ICountry entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CountryResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared.Country
{
  /// <summary>
  /// Represents Country resources.
  /// </summary>
  public class CountryResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Commons.Country.ICountryResources
  {
    public virtual global::CommonLibrary.LocalizedString InvalidCountryCode
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Commons.ICountry) , "InvalidCountryCode");
      }
    }

    public virtual global::CommonLibrary.LocalizedString InvalidCountryCodeFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Commons.ICountry), "InvalidCountryCode", false, args);
    }

  }
}

// ==================================================================
// CountrySharedFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Shared
{
  public partial class CountryFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Commons.ICountry _obj
    {
      get { return (global::Sungero.Commons.ICountry)this.Entity; }
    }

    public CountryFunctions(global::Sungero.Commons.ICountry entity) : base(entity) { }
  }
}

// ==================================================================
// CountryFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static class Country
  {
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.CountryFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.Commons.ICountry country)
    {
      var functions = (global::Sungero.Commons.Shared.CountryFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)country).FunctionsContainer.SharedFunctions;
      return functions.HaveDuplicates();
    }
    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.CountryFunctions" />
    internal static  global::System.String ValidateCountryCode(global::System.String code)
    {
      return global::Sungero.Commons.Shared.CountryFunctions.ValidateCountryCode(code);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.CountryFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Commons.ICountry> GetDuplicates(global::Sungero.Commons.ICountry country)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Commons.ICountry>>(
          global::System.Guid.Parse("1f612925-95fc-4662-807d-c92c810a62b1"),
          "GetDuplicates(global::Sungero.Commons.ICountry)"
          , country);
      }

    }
  }
}

// ==================================================================
// CountryFilterState.g.cs
// ==================================================================

namespace Sungero.Commons.Shared.Country
{

  public class CountryFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Commons.ICountryFilterInfo
  {
  }

  public class CountryFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Commons.ICountryFilterState
  {



    public new Sungero.Commons.ICountryFilterInfo Info
    {
      get
      {
        return (Sungero.Commons.ICountryFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Commons.Shared.Country.CountryFilterInfo();
    }

  }
}

// ==================================================================
// CountrySharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Shared
{
  public class CountrySharedPublicFunctions : global::Sungero.Commons.Shared.ICountrySharedPublicFunctions
  {
  }
}