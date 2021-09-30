
// ==================================================================
// ExchangeDocumentEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class ExchangeDocumentCounterpartyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public ExchangeDocumentCounterpartyValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class ExchangeDocumentBusinessUnitBoxValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.ExchangeCore.IBusinessUnitBox>
  {
    public ExchangeDocumentBusinessUnitBoxValueInputEventArgs(global::Sungero.ExchangeCore.IBusinessUnitBox oldValue, global::Sungero.ExchangeCore.IBusinessUnitBox newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

}

// ==================================================================
// ExchangeDocumentHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

  public partial class ExchangeDocumentFilteringClientHandler
    : global::Sungero.Docflow.OfficialDocumentFilteringClientHandler
  {
    private global::Sungero.Docflow.IExchangeDocumentFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IExchangeDocumentFilterState)this.Filter;
      }
    }

    public ExchangeDocumentFilteringClientHandler(global::Sungero.Docflow.IExchangeDocumentFilterState filter)
    : base(filter)
    {
    }

    protected ExchangeDocumentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class ExchangeDocumentClientHandlers : global::Sungero.Docflow.OfficialDocumentClientHandlers
  {
    private global::Sungero.Docflow.IExchangeDocument _obj
    {
      get { return (global::Sungero.Docflow.IExchangeDocument)this.Entity; }
    }

    public virtual void CounterpartyValueInput(global::Sungero.Docflow.Client.ExchangeDocumentCounterpartyValueInputEventArgs e) { }


    public virtual void BusinessUnitBoxValueInput(global::Sungero.Docflow.Client.ExchangeDocumentBusinessUnitBoxValueInputEventArgs e) { }


    public ExchangeDocumentClientHandlers(global::Sungero.Docflow.IExchangeDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ExchangeDocumentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class ExchangeDocumentFunctions : global::Sungero.Docflow.Client.OfficialDocumentFunctions
  {
    private global::Sungero.Docflow.IExchangeDocument _obj
    {
      get { return (global::Sungero.Docflow.IExchangeDocument)this.Entity; }
    }

    public ExchangeDocumentFunctions(global::Sungero.Docflow.IExchangeDocument entity) : base(entity) { }
  }
}

// ==================================================================
// ExchangeDocumentFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class ExchangeDocument
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.ExchangeDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var functions = (global::Sungero.Docflow.Client.ExchangeDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.ClientFunctions;
      return functions.GetTypesAvailableForChange();
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.ExchangeDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
    functions.FillName();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.ExchangeDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
      return functions.GetCounterparties();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void SetLifeCycleState(global::Sungero.Docflow.IExchangeDocument exchangeDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.ExchangeDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
    functions.SetLifeCycleState();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ExchangeDocumentFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IExchangeDocument exchangeDocument, global::System.Boolean isEnabled, global::System.Boolean counterpartyCodeInNumber)
    {
      var functions = (global::Sungero.Docflow.Shared.ExchangeDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)exchangeDocument).FunctionsContainer.SharedFunctions;
    functions.ChangeCounterpartyPropertyAccess(isEnabled, counterpartyCodeInNumber);
    }

  }
}

// ==================================================================
// ExchangeDocumentClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ExchangeDocumentClientPublicFunctions : global::Sungero.Docflow.Client.IExchangeDocumentClientPublicFunctions
  {
  }
}

// ==================================================================
// ExchangeDocumentActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class ExchangeDocumentActions : global::Sungero.Docflow.Client.OfficialDocumentActions
  {
    private global::Sungero.Docflow.IExchangeDocument _obj { get { return (global::Sungero.Docflow.IExchangeDocument)this.Entity; } }
    public ExchangeDocumentActions(global::Sungero.Docflow.IExchangeDocument entity) : base(entity) { }
  }

  public partial class ExchangeDocumentCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IExchangeDocument> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IExchangeDocument>(this.Entities); }
    }
  }

  public partial class ExchangeDocumentAnyChildEntityActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityActions
  {
  }

  public partial class ExchangeDocumentAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityCollectionActions
  {
  }

  public partial class ExchangeDocumentVersionsActions : global::Sungero.Docflow.Client.OfficialDocumentVersionsActions
  {
    private global::Sungero.Docflow.IExchangeDocumentVersions _obj { get { return (global::Sungero.Docflow.IExchangeDocumentVersions)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentVersions> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentVersions>)this.AllEntities; }
    }
  }

  public partial class ExchangeDocumentVersionsCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentVersionsCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IExchangeDocumentVersions> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IExchangeDocumentVersions>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentVersions> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentVersions>)this.AllEntities; }
    }
  }
  public partial class ExchangeDocumentTrackingActions : global::Sungero.Docflow.Client.OfficialDocumentTrackingActions
  {
    private global::Sungero.Docflow.IExchangeDocumentTracking _obj { get { return (global::Sungero.Docflow.IExchangeDocumentTracking)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentTracking> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentTracking>)this.AllEntities; }
    }
  }

  public partial class ExchangeDocumentTrackingCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentTrackingCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IExchangeDocumentTracking> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IExchangeDocumentTracking>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentTracking> _all
    { 
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IExchangeDocumentTracking>)this.AllEntities; }
    }
  }

}