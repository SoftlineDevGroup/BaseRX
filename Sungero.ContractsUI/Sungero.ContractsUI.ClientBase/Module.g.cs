
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

namespace Sungero.ContractsUI.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.ContractsUI.ClientBase" type="Sungero.ContractsUI.Client.ModuleFunctions" />
    internal static void CreateDocument()
    {
    ((global::Sungero.ContractsUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).CreateDocument();
    }
    /// <redirect project="Sungero.ContractsUI.ClientBase" type="Sungero.ContractsUI.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Contracts.IContractualDocument> SearchContractualDocumentsWithCounterparty()
    {
        return ((global::Sungero.ContractsUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).SearchContractualDocumentsWithCounterparty();
    }
    /// <redirect project="Sungero.ContractsUI.ClientBase" type="Sungero.ContractsUI.Client.ModuleFunctions" />
    internal static global::System.Linq.IQueryable<global::Sungero.Contracts.IContractualDocument> SearchByRegistrationData()
    {
        return ((global::Sungero.ContractsUI.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).SearchByRegistrationData();
    }

    private static object GetFunctionsContainer()
    {
      return new global::Sungero.ContractsUI.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("3c8b7d3a-187d-4445-8a8c-1d00ece44556");
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

namespace Sungero.ContractsUI.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.ContractsUI.Client.IModuleClientPublicFunctions
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

namespace Sungero.ContractsUI.Client
{
      public partial class MyContractsWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.ContractsUI.Shared.MyContractsWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.ContractsUI.Shared.MyContractsWidgetParameters)this.InnerParameters;
          }
        }


        public MyContractsWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class ContractTotalAmountGraphWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.ContractsUI.Shared.ContractTotalAmountGraphWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.ContractsUI.Shared.ContractTotalAmountGraphWidgetParameters)this.InnerParameters;
          }
        }


        public ContractTotalAmountGraphWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
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

namespace Sungero.ContractsUI.Client
{

  public partial class ContractsListFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ContractsUI.FolderFilterState.IContractsListFilterState Filter { get; private set; }

    private global::Sungero.ContractsUI.FolderFilterState.IContractsListFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ContractsListValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ContractsListFolderHandlers(global::Sungero.ContractsUI.FolderFilterState.IContractsListFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class ExpiringSoonContractsFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ContractsUI.FolderFilterState.IExpiringSoonContractsFilterState Filter { get; private set; }

    private global::Sungero.ContractsUI.FolderFilterState.IExpiringSoonContractsFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ExpiringSoonContractsValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ExpiringSoonContractsFolderHandlers(global::Sungero.ContractsUI.FolderFilterState.IExpiringSoonContractsFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class ContractsAtContractorsFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ContractsUI.FolderFilterState.IContractsAtContractorsFilterState Filter { get; private set; }

    private global::Sungero.ContractsUI.FolderFilterState.IContractsAtContractorsFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ContractsAtContractorsValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ContractsAtContractorsFolderHandlers(global::Sungero.ContractsUI.FolderFilterState.IContractsAtContractorsFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class ContractsHistoryFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ContractsUI.FolderFilterState.IContractsHistoryFilterState Filter { get; private set; }

    private global::Sungero.ContractsUI.FolderFilterState.IContractsHistoryFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ContractsHistoryValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ContractsHistoryFolderHandlers(global::Sungero.ContractsUI.FolderFilterState.IContractsHistoryFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class IssuanceJournalFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.ContractsUI.FolderFilterState.IIssuanceJournalFilterState Filter { get; private set; }

    private global::Sungero.ContractsUI.FolderFilterState.IIssuanceJournalFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void IssuanceJournalValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public IssuanceJournalFolderHandlers(global::Sungero.ContractsUI.FolderFilterState.IIssuanceJournalFilterState filter)
    {
      this.Filter = filter;
    }

  }

}

