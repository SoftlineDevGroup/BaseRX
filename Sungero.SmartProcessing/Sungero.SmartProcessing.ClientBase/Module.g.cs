
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

namespace Sungero.SmartProcessing.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void ProcessCapturedPackage(global::System.String senderLineName, global::System.String instanceInfosXmlPath, global::System.String deviceInfoXmlPath, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
    ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ProcessCapturedPackage(senderLineName, instanceInfosXmlPath, deviceInfoXmlPath, inputFilesXmlPath, packageFolderPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void ValidateSettings(global::System.String senderLineName, global::System.String instanceInfosXmlPath, global::System.String deviceInfoXmlPath, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
    ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ValidateSettings(senderLineName, instanceInfosXmlPath, deviceInfoXmlPath, inputFilesXmlPath, packageFolderPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::Sungero.SmartProcessing.IBlobPackage PrepareDcsPackage(global::System.String senderLineName, global::System.String instanceInfosXmlPath, global::System.String deviceInfoXmlPath, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).PrepareDcsPackage(senderLineName, instanceInfosXmlPath, deviceInfoXmlPath, inputFilesXmlPath, packageFolderPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.String GetSourceType(global::System.String deviceInfoXmlPath)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).GetSourceType(deviceInfoXmlPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::Sungero.SmartProcessing.IBlobPackage FillBlobs(global::Sungero.SmartProcessing.IBlobPackage blobPackage, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).FillBlobs(blobPackage, inputFilesXmlPath, packageFolderPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::Sungero.SmartProcessing.IBlob GetMailBody(global::System.Collections.Generic.List<System.Xml.Linq.XElement> fileElements, global::System.String packageFolderPath)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).GetMailBody(fileElements, packageFolderPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::Sungero.SmartProcessing.IBlob CreateBlobFromXelement(System.Xml.Linq.XElement xmlElement, global::System.String packageFolderPath, global::System.Boolean sentByEmail)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateBlobFromXelement(xmlElement, packageFolderPath, sentByEmail);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<System.Xml.Linq.XElement> FilterEmailBodyInlineImages(global::System.String htmlBodyPath, global::System.Collections.Generic.List<System.Xml.Linq.XElement> attachments)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).FilterEmailBodyInlineImages(htmlBodyPath, attachments);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void FillMailInfo(global::Sungero.SmartProcessing.IBlobPackage blobPackage, global::System.String instanceInfosXmlPath)
    {
    ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).FillMailInfo(blobPackage, instanceInfosXmlPath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.String GetAttributeStringValue(System.Xml.Linq.XElement element, global::System.String attributeName)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).GetAttributeStringValue(element, attributeName);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void ProcessPackageInArio(global::Sungero.SmartProcessing.IBlobPackage blobPackage)
    {
    ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ProcessPackageInArio(blobPackage);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.Boolean CanArioProcessFile(global::System.String fileName)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CanArioProcessFile(fileName);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::Sungero.Docflow.IOfficialDocument GetLeadingDocument(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
        return ((global::Sungero.SmartProcessing.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).GetLeadingDocument(documents);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void CreateClassifier(global::System.String classifierName, global::System.String minProbability)
    {
    global::Sungero.SmartProcessing.Client.ModuleFunctions.CreateClassifier(classifierName, minProbability);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void ImportClassifierModel(global::System.String classifierName, global::System.String filePath)
    {
    global::Sungero.SmartProcessing.Client.ModuleFunctions.ImportClassifierModel(classifierName, filePath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void ExportClassifierModel(global::System.String classifierName, global::System.String modelId, global::System.String filePath)
    {
    global::Sungero.SmartProcessing.Client.ModuleFunctions.ExportClassifierModel(classifierName, modelId, filePath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void ShowClassifierModels(global::System.String classifierName)
    {
    global::Sungero.SmartProcessing.Client.ModuleFunctions.ShowClassifierModels(classifierName);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void PublishClassifierModel(global::System.String classifierName, global::System.String modelId)
    {
    global::Sungero.SmartProcessing.Client.ModuleFunctions.PublishClassifierModel(classifierName, modelId);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static void TrainClassifierModel(global::System.String classifierName, global::System.String filePath)
    {
    global::Sungero.SmartProcessing.Client.ModuleFunctions.TrainClassifierModel(classifierName, filePath);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::System.Int32> DeleteDocumentsDialogInWeb(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documentList)
    {
        return global::Sungero.SmartProcessing.Client.ModuleFunctions.DeleteDocumentsDialogInWeb(documentList);
    }
    /// <redirect project="Sungero.SmartProcessing.ClientBase" type="Sungero.SmartProcessing.Client.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> TryDeleteDocuments(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
        return global::Sungero.SmartProcessing.Client.ModuleFunctions.TryDeleteDocuments(documents);
    }

    /// <redirect project="Sungero.SmartProcessing.Shared" type="Sungero.SmartProcessing.Shared.ModuleFunctions" />
    internal static System.Collections.Generic.IDictionary<System.Type, global::System.Int32> GetPackageDocumentTypePriorities()
    {
        return ((global::Sungero.SmartProcessing.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).GetPackageDocumentTypePriorities();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static void ProcessCapturedPackage(global::Sungero.SmartProcessing.IBlobPackage blobPackage)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "ProcessCapturedPackage(global::Sungero.SmartProcessing.IBlobPackage)", blobPackage);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static global::Sungero.Docflow.ISimpleDocument CreateSimpleDocumentFromEmailBody(global::Sungero.SmartProcessing.IBlobPackage blobPackage, global::Sungero.Company.IEmployee responsible)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.ISimpleDocument>(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "CreateSimpleDocumentFromEmailBody(global::Sungero.SmartProcessing.IBlobPackage,global::Sungero.Company.IEmployee)", blobPackage, responsible);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static void ProcessCapturedPackageTest(global::Sungero.SmartProcessing.IBlobPackage blobPackage)
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "ProcessCapturedPackageTest(global::Sungero.SmartProcessing.IBlobPackage)", blobPackage);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ModuleFunctions" />
      internal static void RequeueDeleteBlobPackagesJob()
      {
      global::Sungero.Domain.Shared.RemoteFunctionExecutor.Execute(
          global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"),
          "RequeueDeleteBlobPackagesJob()");
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.SmartProcessing.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("bb685d97-a673-42ea-8605-66889967467f");
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

namespace Sungero.SmartProcessing.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.SmartProcessing.Client.IModuleClientPublicFunctions
  {
    public global::Sungero.SmartProcessing.IBlobPackage FillBlobs(global::Sungero.SmartProcessing.IBlobPackage blobPackage, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
      return global::Sungero.SmartProcessing.Functions.Module.FillBlobs(blobPackage, inputFilesXmlPath, packageFolderPath);
    }
    public void FillMailInfo(global::Sungero.SmartProcessing.IBlobPackage blobPackage, global::System.String instanceInfosXmlPath)
    {
global::Sungero.SmartProcessing.Functions.Module.FillMailInfo(blobPackage, instanceInfosXmlPath);
    }
    public global::Sungero.Docflow.IOfficialDocument GetLeadingDocument(global::System.Collections.Generic.List<global::Sungero.Docflow.IOfficialDocument> documents)
    {
      return global::Sungero.SmartProcessing.Functions.Module.GetLeadingDocument(documents);
    }
    public global::System.String GetSourceType(global::System.String deviceInfoXmlPath)
    {
      return global::Sungero.SmartProcessing.Functions.Module.GetSourceType(deviceInfoXmlPath);
    }
    public global::Sungero.SmartProcessing.IBlobPackage PrepareDcsPackage(global::System.String senderLineName, global::System.String instanceInfosXmlPath, global::System.String deviceInfoXmlPath, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
      return global::Sungero.SmartProcessing.Functions.Module.PrepareDcsPackage(senderLineName, instanceInfosXmlPath, deviceInfoXmlPath, inputFilesXmlPath, packageFolderPath);
    }
    public void ProcessPackageInArio(global::Sungero.SmartProcessing.IBlobPackage blobPackage)
    {
global::Sungero.SmartProcessing.Functions.Module.ProcessPackageInArio(blobPackage);
    }
    public void ValidateSettings(global::System.String senderLineName, global::System.String instanceInfosXmlPath, global::System.String deviceInfoXmlPath, global::System.String inputFilesXmlPath, global::System.String packageFolderPath)
    {
global::Sungero.SmartProcessing.Functions.Module.ValidateSettings(senderLineName, instanceInfosXmlPath, deviceInfoXmlPath, inputFilesXmlPath, packageFolderPath);
    }
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

namespace Sungero.SmartProcessing.Client
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

namespace Sungero.SmartProcessing.Client
{

}

