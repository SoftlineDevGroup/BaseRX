
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

namespace Sungero.RecordManagementUI.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.RecordManagementUI.ClientBase" type="Sungero.RecordManagementUI.Client.ModuleFunctions" />
    internal static void CreateDocument()
    {
    ((global::Sungero.RecordManagementUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateDocument();
    }
    /// <redirect project="Sungero.RecordManagementUI.ClientBase" type="Sungero.RecordManagementUI.Client.ModuleFunctions" />
    internal static void ShowSkippedNumbersReport()
    {
    ((global::Sungero.RecordManagementUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ShowSkippedNumbersReport();
    }
    /// <redirect project="Sungero.RecordManagementUI.ClientBase" type="Sungero.RecordManagementUI.Client.ModuleFunctions" />
    internal static void ShowAllReports()
    {
    ((global::Sungero.RecordManagementUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ShowAllReports();
    }
    /// <redirect project="Sungero.RecordManagementUI.ClientBase" type="Sungero.RecordManagementUI.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument> SearchByRegistrationData()
    {
        return ((global::Sungero.RecordManagementUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).SearchByRegistrationData();
    }
    /// <redirect project="Sungero.RecordManagementUI.ClientBase" type="Sungero.RecordManagementUI.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument> GetOfficialCorrespondenceWithCounterparty()
    {
        return ((global::Sungero.RecordManagementUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).GetOfficialCorrespondenceWithCounterparty();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagementUI.Server" type="Sungero.RecordManagementUI.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument> GetFilteredRegisteredDocuments(global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDateFrom, global::System.Nullable<global::System.DateTime> registrationDateTo, global::Sungero.Docflow.IDocumentRegister documentRegister, global::Sungero.Docflow.ICaseFile caseFile, global::Sungero.Company.IEmployee registeredBy)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument>>(
          global::System.Guid.Parse("51247c94-981f-4bc8-819a-128704b5aa31"),
          "GetFilteredRegisteredDocuments(global::System.String,global::System.Nullable<global::System.DateTime>,global::System.Nullable<global::System.DateTime>,global::Sungero.Docflow.IDocumentRegister,global::Sungero.Docflow.ICaseFile,global::Sungero.Company.IEmployee)", registrationNumber, registrationDateFrom, registrationDateTo, documentRegister, caseFile, registeredBy);
      }
      /// <redirect project="Sungero.RecordManagementUI.Server" type="Sungero.RecordManagementUI.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument> GetOfficialCorrespondenceWithCounterparty(global::Sungero.Parties.ICounterparty counterparty, global::System.Nullable<global::System.DateTime> periodBegin, global::System.Nullable<global::System.DateTime> periodEnd)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument>>(
          global::System.Guid.Parse("51247c94-981f-4bc8-819a-128704b5aa31"),
          "GetOfficialCorrespondenceWithCounterparty(global::Sungero.Parties.ICounterparty,global::System.Nullable<global::System.DateTime>,global::System.Nullable<global::System.DateTime>)", counterparty, periodBegin, periodEnd);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.RecordManagementUI.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("51247c94-981f-4bc8-819a-128704b5aa31");
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

namespace Sungero.RecordManagementUI.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.RecordManagementUI.Client.IModuleClientPublicFunctions
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

namespace Sungero.RecordManagementUI.Client
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

namespace Sungero.RecordManagementUI.Client
{

  public partial class DocumentsToReturnFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagementUI.FolderFilterState.IDocumentsToReturnFilterState Filter { get; private set; }

    private global::Sungero.RecordManagementUI.FolderFilterState.IDocumentsToReturnFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void DocumentsToReturnValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public DocumentsToReturnFolderHandlers(global::Sungero.RecordManagementUI.FolderFilterState.IDocumentsToReturnFilterState filter)
    {
      this.Filter = filter;
    }

  }

}

