
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

namespace Sungero.DirectumRX.Functions
{
  internal static partial class Module
  {
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.DirectumRX.Shared.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("e4fe1153-919e-4732-aadc-2c8e9b5c0b5a");
      var finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(moduleId));
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      return moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static).Invoke(null, null);
    }
  }
}

// ==================================================================
// ModuleHyperlinks.g.cs
// ==================================================================

namespace Sungero.DirectumRX
{
  public static class DirectumRXClientFunctionHyperlinksExtensions
  {
  }
}

// ==================================================================
// ModuleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.DirectumRX.Shared
{
  public class ModuleResources : global::Sungero.DirectumRX.IModuleResources
  {
  }
}

// ==================================================================
// ModuleFoldersFilterStates.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.DirectumRX.Shared
{
}

// ==================================================================
// ModuleSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.DirectumRX.Shared
{
  public partial class ModuleSharedPublicFunctions : global::Sungero.DirectumRX.Shared.IModuleSharedPublicFunctions
  {
  }
}

// ==================================================================
// ModuleWidgetParameters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.DirectumRX.Shared
{  
}