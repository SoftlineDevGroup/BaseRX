
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

namespace Sungero.FinancialArchive.Server
{
  public partial class FinancialArchiveModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("59797aba-7718-45df-8ac1-5bb7a36c7a66"); }
    }

    public override string Name
    {
      get { return "Sungero.FinancialArchive"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IModuleServerInitializationFunctions, global::Sungero.FinancialArchive.Server.ModuleServerInitializationFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f2f5774d-5ca3-4725-b31d-ac618f6b8850"), new Sungero.FinancialArchive.Shared.ContractStatementInfo(typeof(global::Sungero.FinancialArchive.IContractStatement)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IContractStatementServerPublicFunctions, global::Sungero.FinancialArchive.Server.ContractStatementServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IContractStatementSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.ContractStatementSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("b3aa9cb5-17a0-4570-97f7-cc5635cd94df"), new Sungero.FinancialArchive.Shared.ContractStatementTrackingInfo(typeof(global::Sungero.FinancialArchive.IContractStatementTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("ae5566c8-cefa-412f-81ee-b1a84f153024"), new Sungero.FinancialArchive.Shared.ContractStatementVersionsInfo(typeof(global::Sungero.FinancialArchive.IContractStatementVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("74c9ddd4-4bc4-42b6-8bb0-c91d5e21fb8a"), new Sungero.FinancialArchive.Shared.IncomingTaxInvoiceInfo(typeof(global::Sungero.FinancialArchive.IIncomingTaxInvoice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IIncomingTaxInvoiceServerPublicFunctions, global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IIncomingTaxInvoiceSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("422752c6-5348-46bc-bbfd-0d2520f09ca2"), new Sungero.FinancialArchive.Shared.IncomingTaxInvoiceTrackingInfo(typeof(global::Sungero.FinancialArchive.IIncomingTaxInvoiceTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("bb90f6e2-57e5-42ed-9c8a-9d37cbe6f593"), new Sungero.FinancialArchive.Shared.IncomingTaxInvoiceVersionsInfo(typeof(global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f50c4d8a-56bc-43ef-bac3-856f57ca70be"), new Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceInfo(typeof(global::Sungero.FinancialArchive.IOutgoingTaxInvoice)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IOutgoingTaxInvoiceServerPublicFunctions, global::Sungero.FinancialArchive.Server.OutgoingTaxInvoiceServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IOutgoingTaxInvoiceSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("efde70aa-7f41-4673-aeab-0f996a1e8215"), new Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceTrackingInfo(typeof(global::Sungero.FinancialArchive.IOutgoingTaxInvoiceTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("9c4a7356-509e-4e63-bc4f-f2fae3350447"), new Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceVersionsInfo(typeof(global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("58986e23-2b0a-4082-af37-bd1991bc6f7e"), new Sungero.FinancialArchive.Shared.UniversalTransferDocumentInfo(typeof(global::Sungero.FinancialArchive.IUniversalTransferDocument)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IUniversalTransferDocumentServerPublicFunctions, global::Sungero.FinancialArchive.Server.UniversalTransferDocumentServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IUniversalTransferDocumentSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.UniversalTransferDocumentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("edffd4a9-b71c-43e1-aaf8-0d537258a027"), new Sungero.FinancialArchive.Shared.UniversalTransferDocumentTrackingInfo(typeof(global::Sungero.FinancialArchive.IUniversalTransferDocumentTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("7f57a617-9c0e-412e-8dcf-920360cc8976"), new Sungero.FinancialArchive.Shared.UniversalTransferDocumentVersionsInfo(typeof(global::Sungero.FinancialArchive.IUniversalTransferDocumentVersions)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("4e81f9ca-b95a-4fd4-bf76-ea7176c215a7"), new Sungero.FinancialArchive.Shared.WaybillInfo(typeof(global::Sungero.FinancialArchive.IWaybill)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IWaybillServerPublicFunctions, global::Sungero.FinancialArchive.Server.WaybillServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IWaybillSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.WaybillSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("831a7d69-593c-4f19-a953-9b8c43efe03c"), new Sungero.FinancialArchive.Shared.WaybillTrackingInfo(typeof(global::Sungero.FinancialArchive.IWaybillTracking)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("1c506636-1d50-4c79-a0c7-09746718d016"), new Sungero.FinancialArchive.Shared.WaybillVersionsInfo(typeof(global::Sungero.FinancialArchive.IWaybillVersions)));


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IContractStatementFilterState, global::Sungero.FinancialArchive.Shared.ContractStatement.ContractStatementFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState, global::Sungero.FinancialArchive.Shared.IncomingTaxInvoice.IncomingTaxInvoiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IOutgoingTaxInvoiceFilterState, global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoice.OutgoingTaxInvoiceFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IUniversalTransferDocumentFilterState, global::Sungero.FinancialArchive.Shared.UniversalTransferDocument.UniversalTransferDocumentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.IWaybillFilterState, global::Sungero.FinancialArchive.Shared.Waybill.WaybillFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Server.IModuleServerPublicFunctions, global::Sungero.FinancialArchive.Server.ModuleServerPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.FinancialArchive.Shared.IModuleSharedPublicFunctions, global::Sungero.FinancialArchive.Shared.ModuleSharedPublicFunctions>();
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

namespace Sungero.FinancialArchive.Server
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

namespace Sungero.FinancialArchive.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::Sungero.FinancialArchive.IWaybill CreateWaybillDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.CreateWaybillDocument(comment, box, counterparty, info);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::Sungero.FinancialArchive.IIncomingTaxInvoice CreateIncomingTaxInvoiceDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.CreateIncomingTaxInvoiceDocument(comment, box, counterparty, isAdjustment, corrected, info);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::Sungero.FinancialArchive.IOutgoingTaxInvoice CreateOutgoingTaxInvoiceDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.CreateOutgoingTaxInvoiceDocument(comment, box, counterparty, isAdjustment, corrected, info);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::Sungero.FinancialArchive.IContractStatement CreateContractStatementDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.CreateContractStatementDocument(comment, box, counterparty, info);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::Sungero.Docflow.IAccountingDocumentBase CreateUniversalTaxInvoiceAndBasic(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.CreateUniversalTaxInvoiceAndBasic(comment, box, counterparty, isAdjustment, corrected, info);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::Sungero.Docflow.IAccountingDocumentBase CreateUniversalBasic(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.CreateUniversalBasic(comment, box, counterparty, isAdjustment, corrected, info);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static global::System.Collections.Generic.List<global::Sungero.Docflow.IAccountingDocumentBase> FindAccountingDocuments(global::System.String number, global::System.String date, global::System.String butin, global::System.String butrrc, global::System.String cuuid, global::System.String ctin, global::System.String ctrrc, global::System.Boolean corrective, global::System.Boolean incomingTaxInvoice, global::System.Boolean outgoingTaxInvoice, global::System.Boolean contractStatement, global::System.Boolean waybill, global::System.Boolean universalTransferDocument)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).FindAccountingDocuments(number, date, butin, butrrc, cuuid, ctin, ctrrc, corrective, incomingTaxInvoice, outgoingTaxInvoice, contractStatement, waybill, universalTransferDocument);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static global::Sungero.FinancialArchive.Structures.Module.IImportResult ImportFormalizedDocument(global::Sungero.Docflow.Structures.Module.IByteArray file, global::System.Boolean requireFtsId)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).ImportFormalizedDocument(file, requireFtsId);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static global::System.Boolean HasSellerSignatoryInfo(global::Sungero.Docflow.IAccountingDocumentBase document)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).HasSellerSignatoryInfo(document);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static global::System.Boolean HasSellerTitleInfo(global::Sungero.Docflow.IAccountingDocumentBase document)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).HasSellerTitleInfo(document);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static void AddOrReplaceSellerTitleInfo(global::Sungero.Docflow.IAccountingDocumentBase document)
    {
    ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).AddOrReplaceSellerTitleInfo(document);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static void GenerateSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase statement, global::Sungero.Docflow.Structures.AccountingDocumentBase.ISellerTitle sellerTitle)
    {
    global::Sungero.FinancialArchive.Server.ModuleFunctions.GenerateSellerTitle(statement, sellerTitle);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    [global::Sungero.Core.RemoteAttribute()]
    internal static global::System.Boolean HasUnsignedSellerTitle(global::Sungero.Docflow.IAccountingDocumentBase statement)
    {
        return global::Sungero.FinancialArchive.Server.ModuleFunctions.HasUnsignedSellerTitle(statement);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::System.Boolean CanExportWithSignatures(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).CanExportWithSignatures(document, version);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::System.Nullable<global::System.Int32> GetSenderSignatureId(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).GetSenderSignatureId(document, version);
    }
    /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleFunctions" />
    internal static global::System.Nullable<global::System.Int32> GetReceiverSignatureId(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
        return ((global::Sungero.FinancialArchive.Server.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).GetReceiverSignatureId(document, version);
    }

    private static object GetFunctionsContainer()
    {
      return new global::Sungero.FinancialArchive.Server.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
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

namespace Sungero.FinancialArchive.ModuleInitialization
{
  internal static partial class Module
  {
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void Initializing(Sungero.Domain.ModuleInitializingEventArgs e)
     {
     ((global::Sungero.FinancialArchive.Server.ModuleInitializer)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.Server)).Initializing(e);
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void CreateRoles()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateRoles();
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void GrantRightToFinancialResponsible()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.GrantRightToFinancialResponsible();
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void GrantRightOnFolders(global::Sungero.CoreEntities.IRole role)
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.GrantRightOnFolders(role);
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static global::Sungero.Docflow.IDocumentKind GetDefaultDocumentKind(global::System.Guid documentKindEntityGuid)
     {
         return global::Sungero.FinancialArchive.Server.ModuleInitializer.GetDefaultDocumentKind(documentKindEntityGuid);
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static global::Sungero.Contracts.IContractsApprovalRule CreateDefaultRule(global::System.String ruleName, global::Sungero.Core.Enumeration documentFlow, global::System.Collections.Generic.List<global::Sungero.Core.Enumeration> stages)
     {
         return global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateDefaultRule(ruleName, documentFlow, stages);
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void CreateDefaultFinancialApprovalRules()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateDefaultFinancialApprovalRules();
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void CreateDocumentTypes()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateDocumentTypes();
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void CreateDocumentKinds()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateDocumentKinds();
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void CreateFinancialDocumentRegistersAndSettings()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateFinancialDocumentRegistersAndSettings();
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static global::Sungero.Docflow.IDocumentRegister CreateLeadNumberedDocumentRegister(global::System.String name, global::System.String index, global::Sungero.Core.Enumeration documentFlow, global::System.Guid entityId)
     {
         return global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateLeadNumberedDocumentRegister(name, index, documentFlow, entityId);
     }
     /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ModuleInitializer" />
     internal static void CreateReportsTables()
     {
     global::Sungero.FinancialArchive.Server.ModuleInitializer.CreateReportsTables();
     }


    private static object GetFunctionsContainer()
    {
      return new global::Sungero.FinancialArchive.Server.ModuleInitializer();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("59797aba-7718-45df-8ac1-5bb7a36c7a66");
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

namespace Sungero.FinancialArchive.Server
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

namespace Sungero.FinancialArchive.Server
{
  public partial class ModuleServerPublicFunctions : global::Sungero.FinancialArchive.Server.IModuleServerPublicFunctions
  {
    public global::System.Boolean CanExportWithSignatures(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CanExportWithSignatures(document, version);
    }
    public global::Sungero.FinancialArchive.IContractStatement CreateContractStatementDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CreateContractStatementDocument(comment, box, counterparty, info);
    }
    public global::Sungero.FinancialArchive.IIncomingTaxInvoice CreateIncomingTaxInvoiceDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CreateIncomingTaxInvoiceDocument(comment, box, counterparty, isAdjustment, corrected, info);
    }
    public global::Sungero.FinancialArchive.IOutgoingTaxInvoice CreateOutgoingTaxInvoiceDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CreateOutgoingTaxInvoiceDocument(comment, box, counterparty, isAdjustment, corrected, info);
    }
    public global::Sungero.Docflow.IAccountingDocumentBase CreateUniversalBasic(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CreateUniversalBasic(comment, box, counterparty, isAdjustment, corrected, info);
    }
    public global::Sungero.Docflow.IAccountingDocumentBase CreateUniversalTaxInvoiceAndBasic(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::System.Boolean isAdjustment, global::Sungero.Docflow.IAccountingDocumentBase corrected, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CreateUniversalTaxInvoiceAndBasic(comment, box, counterparty, isAdjustment, corrected, info);
    }
    public global::Sungero.FinancialArchive.IWaybill CreateWaybillDocument(global::System.String comment, global::Sungero.ExchangeCore.IBoxBase box, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Exchange.IExchangeDocumentInfo info)
    {
      return global::Sungero.FinancialArchive.Functions.Module.CreateWaybillDocument(comment, box, counterparty, info);
    }
    public global::System.Nullable<global::System.Int32> GetReceiverSignatureId(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
      return global::Sungero.FinancialArchive.Functions.Module.GetReceiverSignatureId(document, version);
    }
    public global::System.Nullable<global::System.Int32> GetSenderSignatureId(global::Sungero.Docflow.IOfficialDocument document, global::Sungero.Content.IElectronicDocumentVersions version)
    {
      return global::Sungero.FinancialArchive.Functions.Module.GetSenderSignatureId(document, version);
    }
  }
}

namespace Sungero.FinancialArchive.Server
{
  public partial class ModuleServerPublicFunctions : global::Sungero.FinancialArchive.Server.IModuleServerPublicFunctions
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

namespace Sungero.FinancialArchive.Server
{
  public partial class ModuleServerInitializationFunctions : global::Sungero.FinancialArchive.Server.IModuleServerInitializationFunctions
  {
         public global::Sungero.Contracts.IContractsApprovalRule CreateDefaultRule(global::System.String ruleName, global::Sungero.Core.Enumeration documentFlow, global::System.Collections.Generic.List<global::Sungero.Core.Enumeration> stages)
         {
           return global:: Sungero.FinancialArchive.ModuleInitialization.Module.CreateDefaultRule(ruleName, documentFlow, stages);
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

namespace Sungero.FinancialArchive.Server
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

namespace Sungero.FinancialArchive.Queries
{
  public class Module
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.FinancialArchive.Server.ModuleQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
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

namespace Sungero.FinancialArchive.Server
{
  public partial class ModuleInitializer : global::Sungero.Domain.AppliedModuleInitializer
  {
  }
}

