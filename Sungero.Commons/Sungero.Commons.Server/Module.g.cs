
// ==================================================================
// Module.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public partial class CommonsModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("459fa497-ee5b-49a4-9980-de00cada9b7a"); }
    }

    public override string Name
    {
      get { return "Sungero.Commons"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.IModuleServerInitializationFunctions, global::Sungero.Commons.Server.ModuleServerInitializationFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("3a0c21f8-aa88-429c-891f-56c24d56fcef"), new Sungero.Commons.Shared.CityInfo(typeof(global::Sungero.Commons.ICity)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.ICityServerPublicFunctions, global::Sungero.Commons.Server.CityServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.ICitySharedPublicFunctions, global::Sungero.Commons.Shared.CitySharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("1f612925-95fc-4662-807d-c92c810a62b1"), new Sungero.Commons.Shared.CountryInfo(typeof(global::Sungero.Commons.ICountry)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.ICountryServerPublicFunctions, global::Sungero.Commons.Server.CountryServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.ICountrySharedPublicFunctions, global::Sungero.Commons.Shared.CountrySharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ffc2629f-dc30-4106-a3ce-c402ae7d32b9"), new Sungero.Commons.Shared.CurrencyInfo(typeof(global::Sungero.Commons.ICurrency)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.ICurrencyServerPublicFunctions, global::Sungero.Commons.Server.CurrencyServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.ICurrencySharedPublicFunctions, global::Sungero.Commons.Shared.CurrencySharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("32ea0857-adf7-41c2-bc0c-188320e40786"), new Sungero.Commons.Shared.EntityRecognitionInfoInfo(typeof(global::Sungero.Commons.IEntityRecognitionInfo)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.IEntityRecognitionInfoServerPublicFunctions, global::Sungero.Commons.Server.EntityRecognitionInfoServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.IEntityRecognitionInfoSharedPublicFunctions, global::Sungero.Commons.Shared.EntityRecognitionInfoSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("977c2af3-1cde-4f76-a516-b6c36ad031dd"), new Sungero.Commons.Shared.EntityRecognitionInfoAdditionalClassifiersInfo(typeof(global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ea588697-56d5-4a14-9a78-39fa6517351b"), new Sungero.Commons.Shared.EntityRecognitionInfoFactsInfo(typeof(global::Sungero.Commons.IEntityRecognitionInfoFacts)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4346363e-39b9-40eb-9c12-64f0cf48d87f"), new Sungero.Commons.Shared.ExternalEntityLinkInfo(typeof(global::Sungero.Commons.IExternalEntityLink)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.IExternalEntityLinkServerPublicFunctions, global::Sungero.Commons.Server.ExternalEntityLinkServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.IExternalEntityLinkSharedPublicFunctions, global::Sungero.Commons.Shared.ExternalEntityLinkSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4efe2fa9-b1d1-4b47-b366-4128fe0a391c"), new Sungero.Commons.Shared.RegionInfo(typeof(global::Sungero.Commons.IRegion)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.IRegionServerPublicFunctions, global::Sungero.Commons.Server.RegionServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.IRegionSharedPublicFunctions, global::Sungero.Commons.Shared.RegionSharedPublicFunctions>();


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.ICityFilterState, global::Sungero.Commons.Shared.City.CityFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.ICountryFilterState, global::Sungero.Commons.Shared.Country.CountryFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.ICurrencyFilterState, global::Sungero.Commons.Shared.Currency.CurrencyFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.IEntityRecognitionInfoFilterState, global::Sungero.Commons.Shared.EntityRecognitionInfo.EntityRecognitionInfoFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.IExternalEntityLinkFilterState, global::Sungero.Commons.Shared.ExternalEntityLink.ExternalEntityLinkFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.IRegionFilterState, global::Sungero.Commons.Shared.Region.RegionFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Server.IModuleServerPublicFunctions, global::Sungero.Commons.Server.ModuleServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.Commons.Shared.IModuleSharedPublicFunctions, global::Sungero.Commons.Shared.ModuleSharedPublicFunctions>();
    }
  }
}

// ==================================================================
// ModuleHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// ModuleFunctions.g.cs
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
  internal static partial class Module
  {
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Commons.IExternalEntityLink> GetExternalEntityLinks(global::System.String uuid, global::System.String sysid)
    {
        return ((global::Sungero.Commons.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).GetExternalEntityLinks(uuid, sysid);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static global::Sungero.Commons.ICity CreateNewCity()
    {
        return global::Sungero.Commons.Server.ModuleFunctions.CreateNewCity();
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Boolean IsAllExternalEntityLinksDeleted(global::Sungero.Domain.Shared.IEntity entity)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.IsAllExternalEntityLinksDeleted(entity);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Boolean IsServerCultureRussian()
    {
        return global::Sungero.Commons.Server.ModuleFunctions.IsServerCultureRussian();
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.String GetFinalTypeName(global::Sungero.Domain.Shared.IEntity entity)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFinalTypeName(entity);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::Sungero.Commons.IEntityRecognitionInfoFacts GetPreviousPropertyRecognitionResults(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String propertyName)
    {
        return ((global::Sungero.Commons.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).GetPreviousPropertyRecognitionResults(fact, propertyName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::Sungero.Commons.IEntityRecognitionInfoFacts GetPreviousPropertyRecognitionResults(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String propertyName, global::System.String filterPropertyValue, global::System.String filterPropertyName)
    {
        return ((global::Sungero.Commons.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).GetPreviousPropertyRecognitionResults(fact, propertyName, filterPropertyValue, filterPropertyName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> GetFacts(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFacts(facts, factName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> GetFacts(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFacts(facts, factName, fieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.String GetFactLabel(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String propertyName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFactLabel(fact, propertyName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> GetOrderedFacts(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName, global::System.String orderFieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetOrderedFacts(facts, factName, orderFieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::Sungero.Commons.Structures.Module.IArioFactField GetField(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetField(fact, fieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Commons.Structures.Module.IArioFactField> GetFields(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.Collections.Generic.List<global::System.String> fieldNames)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFields(fact, fieldNames);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Double GetAggregateFieldsProbability(System.Collections.Generic.IDictionary<global::Sungero.Commons.Structures.Module.IArioFactField, global::System.Double> weightedFields)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetAggregateFieldsProbability(weightedFields);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.String GetFieldValue(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFieldValue(fact, fieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.String GetFieldValue(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFieldValue(facts, factName, fieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Nullable<global::System.DateTime> GetFieldDateTimeValue(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFieldDateTimeValue(fact, fieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Nullable<global::System.Double> GetFieldNumericalValue(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFieldNumericalValue(fact, fieldName);
    }
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleFunctions" />
    internal static global::System.Nullable<global::System.Double> GetFieldProbability(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
        return global::Sungero.Commons.Server.ModuleFunctions.GetFieldProbability(fact, fieldName);
    }

    /// <redirect project="Sungero.Commons.Shared" type="Sungero.Commons.Shared.ModuleFunctions" />
    internal static global::System.String GetValueAsString(System.Object propertyValue)
    {
        return global::Sungero.Commons.Shared.ModuleFunctions.GetValueAsString(propertyValue);
    }

    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Commons.Server.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("459fa497-ee5b-49a4-9980-de00cada9b7a");
      var finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(moduleId));
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      return moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static).Invoke(null, null);
    }
  }
}

// ==================================================================
// ModuleInitializationInstantiation.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.ModuleInitialization
{
  internal static partial class Module
  {
     /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleInitializer" />
     internal static void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
     {
     ((global::Sungero.Commons.Server.ModuleInitializer)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).Initializing(e);
     }
     /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ModuleInitializer" />
     internal static void CreateCountryRegionsCitiesFromFIAS()
     {
     global::Sungero.Commons.Server.ModuleInitializer.CreateCountryRegionsCitiesFromFIAS();
     }


    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Commons.Server.ModuleInitializer();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("459fa497-ee5b-49a4-9980-de00cada9b7a");
      var finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(moduleId));
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.ModuleInitializationNamespace, "Module", assemblyName));
      return moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static).Invoke(null, null);
    }

  }
}


// ==================================================================
// ModuleEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// ModuleServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public partial class ModuleServerPublicFunctions : global::Sungero.Commons.Server.IModuleServerPublicFunctions
  {
    public global::System.Double GetAggregateFieldsProbability(System.Collections.Generic.IDictionary<global::Sungero.Commons.Structures.Module.IArioFactField, global::System.Double> weightedFields)
    {
      return global::Sungero.Commons.Functions.Module.GetAggregateFieldsProbability(weightedFields);
    }
    public global::System.Linq.IQueryable<global::Sungero.Commons.IExternalEntityLink> GetExternalEntityLinks(global::System.String uuid, global::System.String sysid)
    {
      return global::Sungero.Commons.Functions.Module.GetExternalEntityLinks(uuid, sysid);
    }
    public global::System.String GetFactLabel(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String propertyName)
    {
      return global::Sungero.Commons.Functions.Module.GetFactLabel(fact, propertyName);
    }
    public global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> GetFacts(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName)
    {
      return global::Sungero.Commons.Functions.Module.GetFacts(facts, factName);
    }
    public global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> GetFacts(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetFacts(facts, factName, fieldName);
    }
    public global::Sungero.Commons.Structures.Module.IArioFactField GetField(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetField(fact, fieldName);
    }
    public global::System.Nullable<global::System.DateTime> GetFieldDateTimeValue(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetFieldDateTimeValue(fact, fieldName);
    }
    public global::System.Nullable<global::System.Double> GetFieldNumericalValue(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetFieldNumericalValue(fact, fieldName);
    }
    public global::System.Nullable<global::System.Double> GetFieldProbability(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetFieldProbability(fact, fieldName);
    }
    public global::System.Linq.IQueryable<global::Sungero.Commons.Structures.Module.IArioFactField> GetFields(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.Collections.Generic.List<global::System.String> fieldNames)
    {
      return global::Sungero.Commons.Functions.Module.GetFields(fact, fieldNames);
    }
    public global::System.String GetFieldValue(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetFieldValue(fact, fieldName);
    }
    public global::System.String GetFieldValue(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName, global::System.String fieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetFieldValue(facts, factName, fieldName);
    }
    public global::System.String GetFinalTypeName(global::Sungero.Domain.Shared.IEntity entity)
    {
      return global::Sungero.Commons.Functions.Module.GetFinalTypeName(entity);
    }
    public global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> GetOrderedFacts(global::System.Collections.Generic.List<global::Sungero.Commons.Structures.Module.IArioFact> facts, global::System.String factName, global::System.String orderFieldName)
    {
      return global::Sungero.Commons.Functions.Module.GetOrderedFacts(facts, factName, orderFieldName);
    }
    public global::Sungero.Commons.IEntityRecognitionInfoFacts GetPreviousPropertyRecognitionResults(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String propertyName)
    {
      return global::Sungero.Commons.Functions.Module.GetPreviousPropertyRecognitionResults(fact, propertyName);
    }
    public global::Sungero.Commons.IEntityRecognitionInfoFacts GetPreviousPropertyRecognitionResults(global::Sungero.Commons.Structures.Module.IArioFact fact, global::System.String propertyName, global::System.String filterPropertyValue, global::System.String filterPropertyName)
    {
      return global::Sungero.Commons.Functions.Module.GetPreviousPropertyRecognitionResults(fact, propertyName, filterPropertyValue, filterPropertyName);
    }
    public global::System.Boolean IsAllExternalEntityLinksDeleted(global::Sungero.Domain.Shared.IEntity entity)
    {
      return global::Sungero.Commons.Functions.Module.IsAllExternalEntityLinksDeleted(entity);
    }
    public global::System.Boolean IsServerCultureRussian()
    {
      return global::Sungero.Commons.Functions.Module.IsServerCultureRussian();
    }
  }
}

namespace Sungero.Commons.Server
{
  public partial class ModuleServerPublicFunctions : global::Sungero.Commons.Server.IModuleServerPublicFunctions
  {

  }
}

// ==================================================================
// ModuleServerInitializationFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public partial class ModuleServerInitializationFunctions : global::Sungero.Commons.Server.IModuleServerInitializationFunctions
  {
  }
}


// ==================================================================
// ModuleWidgetHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// ModuleQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Queries
{
  public class Module
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Commons.Server.ModuleQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string idx_EEntLink_EId_EType_EEType_ESId_SD
    {
       get { return resolver.GetQuery("idx_EEntLink_EId_EType_EEType_ESId_SD"); }
    }
    public static string idx_EEntLink_EEId_ESId
    {
       get { return resolver.GetQuery("idx_EEntLink_EEId_ESId"); }
    }
    public static string idx_EELinks_Discr_EId_EEType_ESysId_SyncDate
    {
       get { return resolver.GetQuery("idx_EELinks_Discr_EId_EEType_ESysId_SyncDate"); }
    }
    public static string idx_EEntityLinks_Disc_ExtEntityId_ExtSystemId
    {
       get { return resolver.GetQuery("idx_EEntityLinks_Disc_ExtEntityId_ExtSystemId"); }
    }
    public static string CreateCountryRegionsCitiesFromFIAS
    {
       get { return resolver.GetQuery("CreateCountryRegionsCitiesFromFIAS"); }
    }
  }
}

// ==================================================================
// ModuleInitializer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public partial class ModuleInitializer : global::Sungero.Domain.AppliedModuleInitializer
  {
  }
}

