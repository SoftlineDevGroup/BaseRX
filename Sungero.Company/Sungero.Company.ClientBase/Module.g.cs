
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

namespace Sungero.Company.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void ShowVisibilitySettings()
    {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ShowVisibilitySettings();
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void CreateEmployee()
    {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateEmployee();
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void CreateBusinessUnit()
    {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateBusinessUnit();
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static void CreateDepartment()
    {
    ((global::Sungero.Company.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateDepartment();
    }
    /// <redirect project="Sungero.Company.ClientBase" type="Sungero.Company.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient> GetAllActiveNoSystemGroups()
    {
        return global::Sungero.Company.Client.ModuleFunctions.GetAllActiveNoSystemGroups();
    }

    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.ModuleFunctions" />
    internal static global::System.Collections.Generic.List<global::System.Guid> GetSystemRecipientsSidWithoutAllUsers(global::System.Boolean fullSystemRecipientList)
    {
        return ((global::Sungero.Company.Shared.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Shared)).GetSystemRecipientsSidWithoutAllUsers(fullSystemRecipientList);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IEmployee CreateEmployee()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IEmployee>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "CreateEmployee()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IBusinessUnit CreateBusinessUnit()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IBusinessUnit>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "CreateBusinessUnit()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IDepartment CreateDepartment()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IDepartment>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "CreateDepartment()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IVisibilitySetting GetVisibilitySettings()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IVisibilitySetting>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetVisibilitySettings()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.CoreEntities.IRole GetCEORole()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.CoreEntities.IRole>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetCEORole()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IEmployee GetEmployeeById(global::System.Int32 id)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IEmployee>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetEmployeeById(global::System.Int32)", id);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int32> ids)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetEmployeesByIds(global::System.Collections.Generic.List<global::System.Int32>)", ids);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::Sungero.Company.IDepartment GetDepartmentById(global::System.Int32 id)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IDepartment>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetDepartmentById(global::System.Int32)", id);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.CoreEntities.ICertificate> GetCertificatesOfEmployee(global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.CoreEntities.ICertificate>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetCertificatesOfEmployee(global::Sungero.Company.IEmployee)", employee);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Company.IEmployee> GetNotAutomatedEmployees(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee> employees)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IEmployee>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetNotAutomatedEmployees(global::System.Collections.Generic.List<global::Sungero.Company.IEmployee>)", employees);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.String GetCountResponsibilitiesReportData(global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetCountResponsibilitiesReportData(global::Sungero.Company.IEmployee)", employee);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient> GetAllRecipients()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetAllRecipients()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Boolean IsRecipientRestrict()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "IsRecipientRestrict()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Boolean IsRecipientRestrictModeOn()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "IsRecipientRestrictModeOn()");
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::System.Int32> GetVisibleRecipientIds(global::System.String recipientTypeGuid)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::System.Int32>>(
          global::System.Guid.Parse("d534e107-a54d-48ec-85ff-bc44d731a82f"),
          "GetVisibleRecipientIds(global::System.String)", recipientTypeGuid);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Company.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("d534e107-a54d-48ec-85ff-bc44d731a82f");
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

namespace Sungero.Company.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Company.Client.IModuleClientPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.CoreEntities.IRecipient> GetAllActiveNoSystemGroups()
    {
      return global::Sungero.Company.Functions.Module.GetAllActiveNoSystemGroups();
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

namespace Sungero.Company.Client
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

namespace Sungero.Company.Client
{

}

