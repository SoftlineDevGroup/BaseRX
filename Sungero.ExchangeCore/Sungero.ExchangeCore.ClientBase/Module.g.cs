
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

namespace Sungero.ExchangeCore.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.ExchangeCore.ClientBase" type="Sungero.ExchangeCore.Client.ModuleFunctions" />
    internal static void SyncBoxes()
    {
    global::Sungero.ExchangeCore.Client.ModuleFunctions.SyncBoxes();
    }
    /// <redirect project="Sungero.ExchangeCore.ClientBase" type="Sungero.ExchangeCore.Client.ModuleFunctions" />
    internal static void SyncCounterparties()
    {
    global::Sungero.ExchangeCore.Client.ModuleFunctions.SyncCounterparties();
    }
    /// <redirect project="Sungero.ExchangeCore.ClientBase" type="Sungero.ExchangeCore.Client.ModuleFunctions" />
    internal static void GoToWebsite(global::System.String website, Sungero.Domain.Client.ExecuteActionArgs e)
    {
    global::Sungero.ExchangeCore.Client.ModuleFunctions.GoToWebsite(website, e);
    }
    /// <redirect project="Sungero.ExchangeCore.ClientBase" type="Sungero.ExchangeCore.Client.ModuleFunctions" />
    internal static global::System.Boolean CanGoToWebsite(global::System.String website)
    {
        return global::Sungero.ExchangeCore.Client.ModuleFunctions.CanGoToWebsite(website);
    }

    /// <redirect project="Sungero.ExchangeCore.Shared" type="Sungero.ExchangeCore.Shared.ModuleFunctions" />
    internal static void SetDepartmentBoxConnectionStatus(global::Sungero.ExchangeCore.IBusinessUnitBox box)
    {
    ((global::Sungero.ExchangeCore.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).SetDepartmentBoxConnectionStatus(box);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static void RequeueCounterpartySync()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "RequeueCounterpartySync()");
      }
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static void RequeueBoxSync()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "RequeueBoxSync()");
      }
      /// <redirect project="Sungero.ExchangeCore.Server" type="Sungero.ExchangeCore.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::System.String> FindOrganizationsInExchangeServices(global::System.String tin, global::System.String trrc, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox> boxes)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::System.String>>(
          global::System.Guid.Parse("bc0d1897-640a-4b4d-a43a-a23c5984a009"),
          "FindOrganizationsInExchangeServices(global::System.String,global::System.String,global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox>)", tin, trrc, boxes);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.ExchangeCore.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("bc0d1897-640a-4b4d-a43a-a23c5984a009");
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

namespace Sungero.ExchangeCore.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.ExchangeCore.Client.IModuleClientPublicFunctions
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

namespace Sungero.ExchangeCore.Client
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

namespace Sungero.ExchangeCore.Client
{

}

