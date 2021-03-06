
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

namespace Sungero.FinancialArchiveUI.Functions
{
  internal static partial class Module
  {
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.FinancialArchiveUI.Shared.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("e99ae7e2-edb7-4904-a19a-4577f07609a4");
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

namespace Sungero.FinancialArchiveUI
{
  public static class FinancialArchiveUIClientFunctionHyperlinksExtensions
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

namespace Sungero.FinancialArchiveUI.Shared
{
  public class ModuleResources : global::Sungero.FinancialArchiveUI.IModuleResources
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

namespace Sungero.FinancialArchiveUI.Shared
{


public class FinContractListFilterInfo : global::Sungero.Domain.Shared.FilterInfoBase,
    global::Sungero.FinancialArchiveUI.FolderFilterInfo.IFinContractListFilterInfo
  {
    public global::Sungero.Domain.Shared.IFilterControlInfo Contracts
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Contracts");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo SupAgreements
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("SupAgreements");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentMonth
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentMonth");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PreviousMonth
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PreviousMonth");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentQuarter
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentQuarter");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PreviousQuarter
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PreviousQuarter");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo ManualPeriod
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("ManualPeriod");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo DocumentKind
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DocumentKind");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Category
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Category");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Contractor
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Contractor");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo BusinessUnit
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("BusinessUnit");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Department
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Department");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeFrom
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeFrom");
      }
    }
    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeTo
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeTo");
      }
    }


  }

  public class FinContractListFilterState : global::Sungero.Domain.Shared.FilterStateBase,
    global::Sungero.FinancialArchiveUI.FolderFilterState.IFinContractListFilterState
  {
    public bool Contracts
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool SupAgreements
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool CurrentMonth
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PreviousMonth
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool CurrentQuarter
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PreviousQuarter
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool ManualPeriod
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }



    public global::Sungero.Docflow.IDocumentKind DocumentKind
    {
      get { return this.GetValue<global::Sungero.Docflow.IDocumentKind>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Contracts.IContractCategory Category
    {
      get { return this.GetValue<global::Sungero.Contracts.IContractCategory>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Parties.ICounterparty Contractor
    {
      get { return this.GetValue<global::Sungero.Parties.ICounterparty>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Company.IBusinessUnit BusinessUnit
    {
      get { return this.GetValue<global::Sungero.Company.IBusinessUnit>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Company.IDepartment Department
    {
      get { return this.GetValue<global::Sungero.Company.IDepartment>(); }
      set { this.SetValue(value); }
    }



    public global::System.DateTime? DateRangeFrom
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }
    public global::System.DateTime? DateRangeTo
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }



    public new Sungero.FinancialArchiveUI.FolderFilterInfo.IFinContractListFilterInfo Info
    {
      get
      {
        return (Sungero.FinancialArchiveUI.FolderFilterInfo.IFinContractListFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new FinContractListFilterInfo();
    }

  }




public class DocumentsWithoutScanFilterInfo : global::Sungero.Domain.Shared.FilterInfoBase,
    global::Sungero.FinancialArchiveUI.FolderFilterInfo.IDocumentsWithoutScanFilterInfo
  {
    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentMonth
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentMonth");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PreviousMonth
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PreviousMonth");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentQuarter
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentQuarter");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PreviousQuarter
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PreviousQuarter");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo ManualPeriod
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("ManualPeriod");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo BusinessUnit
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("BusinessUnit");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Department
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Department");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Counterparty
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Counterparty");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeFrom
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeFrom");
      }
    }
    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeTo
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeTo");
      }
    }


  }

  public class DocumentsWithoutScanFilterState : global::Sungero.Domain.Shared.FilterStateBase,
    global::Sungero.FinancialArchiveUI.FolderFilterState.IDocumentsWithoutScanFilterState
  {
    public bool CurrentMonth
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PreviousMonth
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool CurrentQuarter
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PreviousQuarter
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool ManualPeriod
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }



    public global::Sungero.Company.IBusinessUnit BusinessUnit
    {
      get { return this.GetValue<global::Sungero.Company.IBusinessUnit>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Company.IDepartment Department
    {
      get { return this.GetValue<global::Sungero.Company.IDepartment>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Parties.ICounterparty Counterparty
    {
      get { return this.GetValue<global::Sungero.Parties.ICounterparty>(); }
      set { this.SetValue(value); }
    }



    public global::System.DateTime? DateRangeFrom
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }
    public global::System.DateTime? DateRangeTo
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }



    public new Sungero.FinancialArchiveUI.FolderFilterInfo.IDocumentsWithoutScanFilterInfo Info
    {
      get
      {
        return (Sungero.FinancialArchiveUI.FolderFilterInfo.IDocumentsWithoutScanFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new DocumentsWithoutScanFilterInfo();
    }

  }




public class SignAwaitedDocumentsFilterInfo : global::Sungero.Domain.Shared.FilterInfoBase,
    global::Sungero.FinancialArchiveUI.FolderFilterInfo.ISignAwaitedDocumentsFilterInfo
  {
    public global::Sungero.Domain.Shared.IFilterControlInfo ByBusinessUnit
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("ByBusinessUnit");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo ByCounterparty
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("ByCounterparty");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentMonth
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentMonth");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PreviousMonth
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PreviousMonth");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo CurrentQuarter
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("CurrentQuarter");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo PreviousQuarter
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("PreviousQuarter");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo ManualPeriod
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("ManualPeriod");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo BusinessUnit
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("BusinessUnit");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Department
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Department");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Counterparty
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Counterparty");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeFrom
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeFrom");
      }
    }
    public global::Sungero.Domain.Shared.IFilterControlInfo DateRangeTo
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("DateRangeTo");
      }
    }


  }

  public class SignAwaitedDocumentsFilterState : global::Sungero.Domain.Shared.FilterStateBase,
    global::Sungero.FinancialArchiveUI.FolderFilterState.ISignAwaitedDocumentsFilterState
  {
    public bool ByBusinessUnit
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool ByCounterparty
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool CurrentMonth
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PreviousMonth
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool CurrentQuarter
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool PreviousQuarter
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool ManualPeriod
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }



    public global::Sungero.Company.IBusinessUnit BusinessUnit
    {
      get { return this.GetValue<global::Sungero.Company.IBusinessUnit>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Company.IDepartment Department
    {
      get { return this.GetValue<global::Sungero.Company.IDepartment>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.Parties.ICounterparty Counterparty
    {
      get { return this.GetValue<global::Sungero.Parties.ICounterparty>(); }
      set { this.SetValue(value); }
    }



    public global::System.DateTime? DateRangeFrom
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }
    public global::System.DateTime? DateRangeTo
    {
      get { return this.GetValue<global::System.DateTime?>(); }
      set { this.SetValue(value); }
    }



    public new Sungero.FinancialArchiveUI.FolderFilterInfo.ISignAwaitedDocumentsFilterInfo Info
    {
      get
      {
        return (Sungero.FinancialArchiveUI.FolderFilterInfo.ISignAwaitedDocumentsFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new SignAwaitedDocumentsFilterInfo();
    }

  }


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

namespace Sungero.FinancialArchiveUI.Shared
{
  public partial class ModuleSharedPublicFunctions : global::Sungero.FinancialArchiveUI.Shared.IModuleSharedPublicFunctions
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

namespace Sungero.FinancialArchiveUI.Shared
{  
}
