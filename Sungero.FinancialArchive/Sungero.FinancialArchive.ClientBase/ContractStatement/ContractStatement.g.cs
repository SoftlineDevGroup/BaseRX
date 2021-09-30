
// ==================================================================
// ContractStatementEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{ 
}

// ==================================================================
// ContractStatementHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive
{

  public partial class ContractStatementFilteringClientHandler
    : global::Sungero.Docflow.AccountingDocumentBaseFilteringClientHandler
  {
    private global::Sungero.FinancialArchive.IContractStatementFilterState _filter
    {
      get
      {
        return (Sungero.FinancialArchive.IContractStatementFilterState)this.Filter;
      }
    }

    public ContractStatementFilteringClientHandler(global::Sungero.FinancialArchive.IContractStatementFilterState filter)
    : base(filter)
    {
    }

    protected ContractStatementFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ContractStatementClientHandlers : global::Sungero.Docflow.AccountingDocumentBaseClientHandlers
  {
    private global::Sungero.FinancialArchive.IContractStatement _obj
    {
      get { return (global::Sungero.FinancialArchive.IContractStatement)this.Entity; }
    }

    public ContractStatementClientHandlers(global::Sungero.FinancialArchive.IContractStatement entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ContractStatementClientFunctions.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Client
{
  public partial class ContractStatementFunctions : global::Sungero.Docflow.Client.AccountingDocumentBaseFunctions
  {
    private global::Sungero.FinancialArchive.IContractStatement _obj
    {
      get { return (global::Sungero.FinancialArchive.IContractStatement)this.Entity; }
    }

    public ContractStatementFunctions(global::Sungero.FinancialArchive.IContractStatement entity) : base(entity) { }
  }
}

// ==================================================================
// ContractStatementFunctions.g.cs
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
  internal static class ContractStatement
  {
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.ContractStatementFunctions" />
    internal static  global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var functions = (global::Sungero.FinancialArchive.Client.ContractStatementFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.ClientFunctions;
      return functions.GetTypesAvailableForChange();
    }
    /// <redirect project="Sungero.FinancialArchive.Client" type="Sungero.FinancialArchive.Client.ContractStatementFunctions" />
    internal static  global::Sungero.Docflow.IOfficialDocument ChangeDocumentType(global::Sungero.FinancialArchive.IContractStatement contractStatement, global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> types)
    {
      var functions = (global::Sungero.FinancialArchive.Client.ContractStatementFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.ClientFunctions;
      return functions.ChangeDocumentType(types);
    }

    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.FinancialArchive.IContractStatement contractStatement, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Docflow.IOfficialDocument leadingDocument)
    {
      return global::Sungero.FinancialArchive.Shared.ContractStatementFunctions.HaveDuplicates(contractStatement, businessUnit, registrationNumber, registrationDate, counterparty, leadingDocument);
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.String GetLeadDocumentNumber(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var functions = (global::Sungero.FinancialArchive.Shared.ContractStatementFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      return functions.GetLeadDocumentNumber();
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  void FillName(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var functions = (global::Sungero.FinancialArchive.Shared.ContractStatementFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
    functions.FillName();
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDocumentResponsibleEmployee(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var functions = (global::Sungero.FinancialArchive.Shared.ContractStatementFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      return functions.GetDocumentResponsibleEmployee();
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.ContractStatementFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IContractStatement contractStatement)
    {
      var functions = (global::Sungero.FinancialArchive.Shared.ContractStatementFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractStatement).FunctionsContainer.SharedFunctions;
      return functions.IsVerificationModeSupported();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.FinancialArchive.Server" type="Sungero.FinancialArchive.Server.ContractStatementFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.FinancialArchive.IContractStatement> GetDuplicates(global::Sungero.FinancialArchive.IContractStatement contractStatement, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty, global::Sungero.Docflow.IOfficialDocument leadingDocument)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.FinancialArchive.IContractStatement>>(
          global::System.Guid.Parse("f2f5774d-5ca3-4725-b31d-ac618f6b8850"),
          "GetDuplicates(global::Sungero.FinancialArchive.IContractStatement,global::Sungero.Company.IBusinessUnit,global::System.String,global::System.Nullable<global::System.DateTime>,global::Sungero.Parties.ICounterparty,global::Sungero.Docflow.IOfficialDocument)"
      , contractStatement, businessUnit, registrationNumber, registrationDate, counterparty, leadingDocument);
      }

    }
  }
}

// ==================================================================
// ContractStatementClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class ContractStatementClientPublicFunctions : global::Sungero.FinancialArchive.Client.IContractStatementClientPublicFunctions
  {
  }
}

// ==================================================================
// ContractStatementActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public partial class ContractStatementActions : global::Sungero.Docflow.Client.AccountingDocumentBaseActions
  {
    private global::Sungero.FinancialArchive.IContractStatement _obj { get { return (global::Sungero.FinancialArchive.IContractStatement)this.Entity; } }
    public ContractStatementActions(global::Sungero.FinancialArchive.IContractStatement entity) : base(entity) { }
  }

  public partial class ContractStatementCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.FinancialArchive.IContractStatement> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.FinancialArchive.IContractStatement>(this.Entities); }
    }
  }

  public partial class ContractStatementAnyChildEntityActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityActions
  {
  }

  public partial class ContractStatementAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.AccountingDocumentBaseAnyChildEntityCollectionActions
  {
  }

}
