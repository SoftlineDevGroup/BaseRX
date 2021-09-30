
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

namespace Sungero.Integration1C.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> GetChangedEntitiesFromSyncDate(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.Int32 processedEntitiesCount, global::System.Int32 entitiesCountForProcessing, global::System.String extEntityType, global::System.String systemId)
    {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).GetChangedEntitiesFromSyncDate(entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Int32 GetChangedEntitiesFromSyncDateCount(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.String extEntityType, global::System.String systemId)
    {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).GetChangedEntitiesFromSyncDateCount(entityTypeGuids, extEntityType, systemId);
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::Sungero.Docflow.ISimpleDocument GetTodayDocument(global::System.Boolean fileExist)
    {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).GetTodayDocument(fileExist);
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.Boolean IsSummaryProtocolExist()
    {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).IsSummaryProtocolExist();
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static void SendNotificationBySimpleTaskRemote(global::System.String title, global::System.String text)
    {
    ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).SendNotificationBySimpleTaskRemote(title, text);
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static void UpdateLastNotificationDateRemote(global::System.DateTime date, global::System.String systemId)
    {
    ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).UpdateLastNotificationDateRemote(date, systemId);
    }
    /// <redirect project="Sungero.Integration1C.Shared" type="Sungero.Integration1C.Shared.ModuleFunctions" />
    internal static global::System.String GetLastNotificationDateRemote(global::System.String systemId)
    {
        return ((global::Sungero.Integration1C.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).GetLastNotificationDateRemote(systemId);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static void SendNotificationBySimpleTask(global::System.String title, global::System.String text)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "SendNotificationBySimpleTask(global::System.String,global::System.String)", title, text);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity> GetChangedEntitiesFromSyncDateRemote(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.Int32 processedEntitiesCount, global::System.Int32 entitiesCountForProcessing, global::System.String extEntityType, global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Domain.Shared.IEntity>>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetChangedEntitiesFromSyncDateRemote(global::System.Collections.Generic.List<global::System.Guid>,global::System.Int32,global::System.Int32,global::System.String,global::System.String)", entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Int32 GetChangedEntitiesFromSyncDateRemoteCount(global::System.Collections.Generic.List<global::System.Guid> entityTypeGuids, global::System.String extEntityType, global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Int32>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetChangedEntitiesFromSyncDateRemoteCount(global::System.Collections.Generic.List<global::System.Guid>,global::System.String,global::System.String)", entityTypeGuids, extEntityType, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::Sungero.Docflow.ISimpleDocument GetTodayDocumentRemote(global::System.Boolean fileExist)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.ISimpleDocument>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetTodayDocumentRemote(global::System.Boolean)", fileExist);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.Boolean IsSummaryProtocolExistRemote()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "IsSummaryProtocolExistRemote()");
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static void UpdateLastNotificationDate(global::System.DateTime date, global::System.String systemId)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "UpdateLastNotificationDate(global::System.DateTime,global::System.String)", date, systemId);
      }
      /// <redirect project="Sungero.Integration1C.Server" type="Sungero.Integration1C.Server.ModuleFunctions" />
      internal static global::System.String GetLastNotificationDate(global::System.String systemId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195"),
          "GetLastNotificationDate(global::System.String)", systemId);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Integration1C.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("f7b1d5b7-5af1-4a9f-b4d7-4e18840d7195");
      var finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(moduleId));
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      return moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static).Invoke(null, null);
    }
  }
}

// ==================================================================
// ModuleClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Integration1C.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Integration1C.Client.IModuleClientPublicFunctions
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

namespace Sungero.Integration1C.Client
{
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

namespace Sungero.Integration1C.Client
{

}

