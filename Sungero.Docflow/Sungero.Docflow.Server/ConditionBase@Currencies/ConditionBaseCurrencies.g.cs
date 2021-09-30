
// ==================================================================
// ConditionBaseCurrencies.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class ConditionBaseCurrenciesFilterForCurrency<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Commons.ICurrency
    where TSourceEntity : class, global::Sungero.Docflow.IConditionBaseCurrencies
    where TRootEntity : class, global::Sungero.Docflow.IConditionBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.ConditionBaseCurrenciesCurrencyPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).CurrenciesCurrencyFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ConditionBaseCurrenciesFilterForCurrency(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ConditionBaseCurrenciesSearchFilterForCurrency<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Commons.ICurrency
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.ConditionBaseCurrenciesCurrencySearchPropertyFilteringServerHandler<TQueryEntity>().CurrenciesCurrencySearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ConditionBaseCurrenciesSearchFilterForCurrency(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.ConditionBaseCurrenciesFilterForCurrency<global::Sungero.Commons.ICurrency, global::Sungero.Docflow.IConditionBaseCurrencies, global::Sungero.Docflow.IConditionBase>), "Currency")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.ConditionBaseCurrenciesSearchFilterForCurrency<global::Sungero.Commons.ICurrency>), "Currency")]


  public class ConditionBaseCurrencies :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IConditionBaseCurrencies
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("02d2a095-58f6-4746-8a9d-35a55e2f9d64");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ConditionBaseCurrencies.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IConditionBaseCurrencies, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IConditionBaseCurrenciesState State
    {
      get { return (global::Sungero.Docflow.IConditionBaseCurrenciesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ConditionBaseCurrenciesState(this);
    }

    public new virtual global::Sungero.Docflow.IConditionBaseCurrenciesInfo Info
    {
      get { return (global::Sungero.Docflow.IConditionBaseCurrenciesInfo)base.Info; }
    }


    public global::Sungero.Docflow.IConditionBase ConditionBase { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ConditionBase; }
      set { this.ConditionBase = (global::Sungero.Docflow.IConditionBase)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ConditionBaseCurrenciesSharedHandlers(this);
    }







    private global::Sungero.Commons.ICurrency _Currency;
    public virtual global::Sungero.Commons.ICurrency Currency
    {
      get
      {
        return this._Currency;
      }

      set
      {
        this.SetPropertyValue("Currency", this._Currency, value, (propertyValue) => { this._Currency = propertyValue; }, this.CurrencyChangedHandler);
      }
    }




    #region Framework events

    protected void CurrencyChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ConditionBaseCurrenciesCurrencyChangedEventArgs(this.State.Properties.Currency, this.Currency, this);
     ((global::Sungero.Docflow.ConditionBaseCurrenciesSharedHandlers)this.SharedHandlers).CurrenciesCurrencyChanged(args);
    }



    #endregion


    public ConditionBaseCurrencies()
    {
    }

  }
}

// ==================================================================
// ConditionBaseCurrenciesHandlers.g.cs
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
  public partial class ConditionBaseCurrenciesCurrencyPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Commons.ICurrency
  {
    private global::Sungero.Docflow.IConditionBaseCurrencies _obj
    {
      get { return (global::Sungero.Docflow.IConditionBaseCurrencies)this.Entity; }
    }

    private global::Sungero.Docflow.IConditionBase _root
    {
      get { return (global::Sungero.Docflow.IConditionBase)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> CurrenciesCurrencyFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ConditionBaseCurrenciesCurrencyPropertyFilteringServerHandler(global::Sungero.Docflow.IConditionBaseCurrencies entity, global::Sungero.Docflow.IConditionBase root)
      : base(entity, root)
    {
    }
  }

  public partial class ConditionBaseCurrenciesCurrencySearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Commons.ICurrency
  {

    public virtual global::System.Linq.IQueryable<T> CurrenciesCurrencySearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ConditionBaseCurrenciesCurrencySearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// ConditionBaseCurrenciesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}