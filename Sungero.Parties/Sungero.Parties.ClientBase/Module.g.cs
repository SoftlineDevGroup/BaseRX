
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

namespace Sungero.Parties.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void GoToWebsite(global::System.String website, Sungero.Domain.Client.ExecuteActionArgs e)
    {
    global::Sungero.Parties.Client.ModuleFunctions.GoToWebsite(website, e);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static global::System.Boolean CanGoToWebsite(global::System.String website)
    {
        return global::Sungero.Parties.Client.ModuleFunctions.CanGoToWebsite(website);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void WriteLetter(global::System.String email)
    {
    ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).WriteLetter(email);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void CreateCompany()
    {
    ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateCompany();
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void CreateContact()
    {
    ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateContact();
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void CreatePerson()
    {
    ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreatePerson();
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty> ShowCounterpartiesAvailableForExchange()
    {
        return ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ShowCounterpartiesAvailableForExchange();
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void InviteCounterpartyToExchange()
    {
    ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).InviteCounterpartyToExchange();
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static global::System.String ConvertCounterpartyToString(global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService counterparty)
    {
        return global::Sungero.Parties.Client.ModuleFunctions.ConvertCounterpartyToString(counterparty);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService ConvertStringToCounterparty(global::System.Collections.Generic.List<global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService> counterparties, global::System.String counterpartyString, global::Sungero.ExchangeCore.IBusinessUnitBox box)
    {
        return ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).ConvertStringToCounterparty(counterparties, counterpartyString, box);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void ShowCounterpartyCard(global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService counterparty)
    {
    global::Sungero.Parties.Client.ModuleFunctions.ShowCounterpartyCard(counterparty);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static global::Sungero.ExchangeCore.IBusinessUnitBox[] GetAvailableBoxes(global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService foundCompany, global::Sungero.ExchangeCore.IBusinessUnitBox[] connectedBoxes)
    {
        return global::Sungero.Parties.Client.ModuleFunctions.GetAvailableBoxes(foundCompany, connectedBoxes);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    internal static void CreateInvitationEmail(global::Sungero.ExchangeCore.IBusinessUnitBox box, global::System.String recipientEMail)
    {
    global::Sungero.Parties.Client.ModuleFunctions.CreateInvitationEmail(box, recipientEMail);
    }
    /// <redirect project="Sungero.Parties.ClientBase" type="Sungero.Parties.Client.ModuleFunctions" />
    [global::Sungero.Core.HyperlinkAttribute()]
    internal static void FindCounterparty(global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.String sysid)
    {
    ((global::Sungero.Parties.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).FindCounterparty(cuuid, ctin, ctrrc, sysid);
    }

    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.ModuleFunctions" />
    internal static global::System.Boolean EmailIsValid(global::System.String emailAddress)
    {
        return global::Sungero.Parties.Shared.ModuleFunctions.EmailIsValid(emailAddress);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::Sungero.Parties.ICompany CreateCompany()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.ICompany>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "CreateCompany()");
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::Sungero.Parties.IContact CreateContact()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.IContact>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "CreateContact()");
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::Sungero.Parties.IPerson CreatePerson()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.IPerson>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "CreatePerson()");
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty> CounterpartiesAvailableForExchange()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "CounterpartiesAvailableForExchange()");
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Parties.IContact> GetContactsFromCompany(global::Sungero.Parties.ICompanyBase company)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.IContact>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "GetContactsFromCompany(global::Sungero.Parties.ICompanyBase)", company);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.String GetEmailByTinTrrc(global::System.String tin, global::System.String trrc)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "GetEmailByTinTrrc(global::System.String,global::System.String)", tin, trrc);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService> FindCompanyInExchangeServices(global::System.String tin, global::System.String trrc, global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox> boxes)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.Structures.Module.CounterpartyFromExchangeService>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "FindCompanyInExchangeServices(global::System.String,global::System.String,global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IBusinessUnitBox>)", tin, trrc, boxes);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::Sungero.Parties.ICounterparty FindCounterpartyByOrganizationId(global::Sungero.ExchangeCore.IBusinessUnitBox box, global::System.String organizationId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Parties.ICounterparty>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "FindCounterpartyByOrganizationId(global::Sungero.ExchangeCore.IBusinessUnitBox,global::System.String)", box, organizationId);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Boolean CheckAnyBusinessUnitBoxes()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "CheckAnyBusinessUnitBoxes()");
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicateCounterpartiesFromList(global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> counterparties, global::System.String tin, global::System.String trrc, global::System.String name, global::System.Boolean excludeClosed)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "GetDuplicateCounterpartiesFromList(global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>,global::System.String,global::System.String,global::System.String,global::System.Boolean)", counterparties, tin, trrc, name, excludeClosed);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicateCounterparties(global::System.String tin, global::System.String trrc, global::System.String name, global::System.Boolean excludeClosed)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "GetDuplicateCounterparties(global::System.String,global::System.String,global::System.String,global::System.Boolean)", tin, trrc, name, excludeClosed);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetDuplicateCounterparties(global::System.String tin, global::System.String trrc, global::System.String name, global::System.Nullable<global::System.Int32> excludedCounterpartyId, global::System.Boolean excludeClosed)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "GetDuplicateCounterparties(global::System.String,global::System.String,global::System.String,global::System.Nullable<global::System.Int32>,global::System.Boolean)", tin, trrc, name, excludedCounterpartyId, excludeClosed);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> FindCounterparty(global::System.String uuid, global::System.String tin, global::System.String trrc, global::System.String sysid)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "FindCounterparty(global::System.String,global::System.String,global::System.String,global::System.String)", uuid, tin, trrc, sysid);
      }
      /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ModuleFunctions" />
      internal static global::System.String GetCompanyDataServiceURL()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("243b34ec-8425-4c7e-b66f-27f7b9c8f38d"),
          "GetCompanyDataServiceURL()");
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Parties.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("243b34ec-8425-4c7e-b66f-27f7b9c8f38d");
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

namespace Sungero.Parties.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Parties.Client.IModuleClientPublicFunctions
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

namespace Sungero.Parties.Client
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

namespace Sungero.Parties.Client
{

  public partial class BlockedCounterpartiesFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Parties.FolderFilterState.IBlockedCounterpartiesFilterState Filter { get; private set; }

    private global::Sungero.Parties.FolderFilterState.IBlockedCounterpartiesFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void BlockedCounterpartiesValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public BlockedCounterpartiesFolderHandlers(global::Sungero.Parties.FolderFilterState.IBlockedCounterpartiesFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class InvitedCounterpartiesFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Parties.FolderFilterState.IInvitedCounterpartiesFilterState Filter { get; private set; }

    private global::Sungero.Parties.FolderFilterState.IInvitedCounterpartiesFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void InvitedCounterpartiesValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public InvitedCounterpartiesFolderHandlers(global::Sungero.Parties.FolderFilterState.IInvitedCounterpartiesFilterState filter)
    {
      this.Filter = filter;
    }

  }

}

