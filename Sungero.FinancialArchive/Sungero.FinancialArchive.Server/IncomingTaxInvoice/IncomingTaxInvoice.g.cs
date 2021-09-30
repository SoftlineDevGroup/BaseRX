
// ==================================================================
// IncomingTaxInvoice.g.cs
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
    public class IncomingTaxInvoiceFilter<T> :
      global::Sungero.Docflow.Server.AccountingDocumentBaseFilter<T>
      where T : class, global::Sungero.FinancialArchive.IIncomingTaxInvoice
    {
      private global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState filter
      {
        get
        {
          return (Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public IncomingTaxInvoiceFilter(global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState filter)
      : base(filter)
      {
      }

      protected IncomingTaxInvoiceFilter()
      {
      }
    }
    public class IncomingTaxInvoiceSearchDialogModel : global::Sungero.Docflow.Server.AccountingDocumentBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.Boolean? IsAdjustment { get; protected set; }
                  public override global::System.String Subject { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> VerificationState { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Content.IAssociatedApplication> AssociatedApplication { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> Author { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IDocumentKind> DocumentKind { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IBusinessUnit> BusinessUnit { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Company.IDepartment> Department { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICounterparty> Counterparty { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.IContact> CounterpartySignatory { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IAccountingDocumentBase> Corrected { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IOfficialDocument> LeadingDocument { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Parties.IContact> Contact { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> OurSignatory { get; protected set; }
                  [Sungero.Domain.Shared.HideInDevStudio()]
                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IRecipient> ResponsibleEmployee { get; protected set; }




                   public new IncomingTaxInvoiceVersionsModel Versions { get { return (IncomingTaxInvoiceVersionsModel)base.Versions; } protected set { base.Versions = value; } }
                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new IncomingTaxInvoiceTrackingModel Tracking { get { return (IncomingTaxInvoiceTrackingModel)base.Tracking; } protected set { base.Tracking = value; } }

        }

      public class IncomingTaxInvoiceVersionsModel : global::Sungero.Docflow.Server.AccountingDocumentBaseVersionsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }
                      public override global::System.String Body { get; protected set; }




         }
      public class IncomingTaxInvoiceTrackingModel : global::Sungero.Docflow.Server.AccountingDocumentBaseTrackingModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int32? Id { get; protected set; }




         }




  public class IncomingTaxInvoiceFilterForCorrected<TQueryEntity, TSourceEntity>
    : global::Sungero.Docflow.Server.AccountingDocumentBaseFilterForCorrected<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IAccountingDocumentBase
    where TSourceEntity : class, global::Sungero.FinancialArchive.IIncomingTaxInvoice
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.FinancialArchive.IncomingTaxInvoiceCorrectedPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).CorrectedFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public IncomingTaxInvoiceFilterForCorrected(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceFilter<global::Sungero.FinancialArchive.IIncomingTaxInvoice>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceFilterForCorrected<global::Sungero.Docflow.IAccountingDocumentBase, global::Sungero.FinancialArchive.IIncomingTaxInvoice>), "Corrected")]


  public class IncomingTaxInvoice :
    global::Sungero.Docflow.Server.AccountingDocumentBase, global::Sungero.FinancialArchive.IIncomingTaxInvoice, global::Sungero.Domain.Shared.ISecurableEntity, global::Sungero.Domain.IInternalSecurableEntity
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("74c9ddd4-4bc4-42b6-8bb0-c91d5e21fb8a");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Server.IncomingTaxInvoice.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IIncomingTaxInvoice, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.FinancialArchive.IIncomingTaxInvoiceState State
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceState(this);
    }

    public new virtual global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo Info
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo)base.Info; }
    }

    public new virtual global::Sungero.FinancialArchive.IIncomingTaxInvoiceAccessRights AccessRights
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.FinancialArchive.IncomingTaxInvoiceServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.FinancialArchive.IncomingTaxInvoiceSharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.FinancialArchive.IIncomingTaxInvoiceVersions>() { RootEntity = this };
    }
    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.FinancialArchive.IIncomingTaxInvoiceTracking>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      return new global::Sungero.FinancialArchive.IncomingTaxInvoiceCreatingFromServerHandler((global::Sungero.FinancialArchive.IIncomingTaxInvoice)entitySource, this.Info);
    }

    #region Framework events





    #endregion


    public IncomingTaxInvoice()
    {
    }

    protected override global::Sungero.Domain.Shared.EntityConvertingFromServerHandler CreateConvertingFromServerHandler(   
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      return new global::Sungero.FinancialArchive.IncomingTaxInvoiceConvertingFromServerHandler((global::Sungero.Content.IElectronicDocument)entitySource, this.Info);
    }

  }
}

// ==================================================================
// IncomingTaxInvoiceHandlers.g.cs
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
  public partial class IncomingTaxInvoiceCorrectedPropertyFilteringServerHandler<T>
    : global::Sungero.Docflow.AccountingDocumentBaseCorrectedPropertyFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IAccountingDocumentBase
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoice _obj
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoice)this.Entity; }
    }

    public IncomingTaxInvoiceCorrectedPropertyFilteringServerHandler(global::Sungero.FinancialArchive.IIncomingTaxInvoice entity)
      : base(entity)
    {
    }
  }



  public partial class IncomingTaxInvoiceFilteringServerHandler<T>
    : global::Sungero.Docflow.AccountingDocumentBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.FinancialArchive.IIncomingTaxInvoice
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState _filter
    {
      get
      {
        return (Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState)this.Filter;
      }
    }

    public IncomingTaxInvoiceFilteringServerHandler(global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState filter)
    : base(filter)
    {
    }

    protected IncomingTaxInvoiceFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }

      public override global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> BusinessUnitFiltering(global::System.Linq.IQueryable<Sungero.Company.IBusinessUnit> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.BusinessUnitFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Company.IDepartment> DepartmentFiltering(global::System.Linq.IQueryable<Sungero.Company.IDepartment> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.DepartmentFiltering(query, e);
              return query;
      }

      public override global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> CounterpartyFiltering(global::System.Linq.IQueryable<Sungero.Parties.ICounterparty> query, global::Sungero.Domain.FilteringEventArgs e)
      {
        query = base.CounterpartyFiltering(query, e);
              return query;
      }


  }

  public partial class IncomingTaxInvoiceSearchDialogServerHandler : global::Sungero.Docflow.AccountingDocumentBaseSearchDialogServerHandler
   {
     private global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceSearchDialogModel)this.Dialog;
       }
     }

     public IncomingTaxInvoiceSearchDialogServerHandler(global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class IncomingTaxInvoiceServerHandlers : global::Sungero.Docflow.AccountingDocumentBaseServerHandlers
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoice _obj
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoice)this.Entity; }
    }

    public IncomingTaxInvoiceServerHandlers(global::Sungero.FinancialArchive.IIncomingTaxInvoice entity)
      : base(entity)
    {
    }
  }

  public partial class IncomingTaxInvoiceCreatingFromServerHandler : global::Sungero.Docflow.AccountingDocumentBaseCreatingFromServerHandler
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoice _source
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoice)this.Source; }
    }

    private global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo _info
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo)this._Info; }
    }

    public IncomingTaxInvoiceCreatingFromServerHandler(global::Sungero.FinancialArchive.IIncomingTaxInvoice source, global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// IncomingTaxInvoiceEventArgs.g.cs
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
// IncomingTaxInvoiceAccessRights.g.cs
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
  public class IncomingTaxInvoiceAccessRights : 
    Sungero.Docflow.Server.AccountingDocumentBaseAccessRights, Sungero.FinancialArchive.IIncomingTaxInvoiceAccessRights
  {

    public IncomingTaxInvoiceAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class IncomingTaxInvoiceTypeAccessRights : 
    Sungero.Docflow.Server.AccountingDocumentBaseTypeAccessRights, Sungero.FinancialArchive.IIncomingTaxInvoiceAccessRights
  {

    public IncomingTaxInvoiceTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// IncomingTaxInvoiceRepositoryImplementer.g.cs
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
    public class IncomingTaxInvoiceRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.AccountingDocumentBaseRepositoryImplementer<T>,
      global::Sungero.FinancialArchive.IIncomingTaxInvoiceRepositoryImplementer<T>
      where T : global::Sungero.FinancialArchive.IIncomingTaxInvoice 
    {
       public new global::Sungero.FinancialArchive.IIncomingTaxInvoiceAccessRights AccessRights
       {
          get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceAccessRights)base.AccessRights; }
       }

       public new global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo Info
       {
          get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.FinancialArchive.Server.IncomingTaxInvoiceTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// IncomingTaxInvoicePanelNavigationFilters.g.cs
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
    public class IncomingTaxInvoiceBusinessUnitPanelNavigationFilter : global::Sungero.Docflow.Server.AccountingDocumentBaseBusinessUnitPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.FinancialArchive.IIncomingTaxInvoice
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>)query;
        var typedState = (global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState)this.State;
        var handlers = new global::Sungero.FinancialArchive.IncomingTaxInvoiceFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.BusinessUnitFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IBusinessUnit>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.FinancialArchive.IIncomingTaxInvoice>(query);
      }
    }

    public class IncomingTaxInvoiceDepartmentPanelNavigationFilter : global::Sungero.Docflow.Server.AccountingDocumentBaseDepartmentPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.FinancialArchive.IIncomingTaxInvoice
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Company.IDepartment>)query;
        var typedState = (global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState)this.State;
        var handlers = new global::Sungero.FinancialArchive.IncomingTaxInvoiceFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.DepartmentFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Company.IDepartment>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.FinancialArchive.IIncomingTaxInvoice>(query);
      }
    }

    public class IncomingTaxInvoiceCounterpartyPanelNavigationFilter : global::Sungero.Docflow.Server.AccountingDocumentBaseCounterpartyPanelNavigationFilter
    {
      private global::System.Linq.IQueryable Apply<T>(global::System.Linq.IQueryable query) where T: class, global::Sungero.FinancialArchive.IIncomingTaxInvoice
      {
        var typedQuery = (global::System.Linq.IQueryable<global::Sungero.Parties.ICounterparty>)query;
        var typedState = (global::Sungero.FinancialArchive.IIncomingTaxInvoiceFilterState)this.State;
        var handlers = new global::Sungero.FinancialArchive.IncomingTaxInvoiceFilteringServerHandler<T>(typedState);
        var args = new global::Sungero.Domain.FilteringEventArgs();
        var result = handlers.CounterpartyFiltering(typedQuery, args);
        if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<global::Sungero.Parties.ICounterparty>();
        return result;
      }

      public override global::System.Linq.IQueryable Apply(global::System.Linq.IQueryable query)
      {
        return this.Apply<global::Sungero.FinancialArchive.IIncomingTaxInvoice>(query);
      }
    }

}

// ==================================================================
// IncomingTaxInvoiceServerFunctions.g.cs
// ==================================================================

namespace Sungero.FinancialArchive.Server
{
  public partial class IncomingTaxInvoiceFunctions : global::Sungero.Docflow.Server.AccountingDocumentBaseFunctions
  {
    private global::Sungero.FinancialArchive.IIncomingTaxInvoice _obj
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoice)this.Entity; }
    }

    public IncomingTaxInvoiceFunctions(global::Sungero.FinancialArchive.IIncomingTaxInvoice entity) : base(entity) { }
  }
}

// ==================================================================
// IncomingTaxInvoiceFunctions.g.cs
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
  internal static class IncomingTaxInvoice
  {
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions" />
    internal static  void FillName(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      var functions = (global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)incomingTaxInvoice).FunctionsContainer.SharedFunctions;
    functions.FillName();
    }
    /// <redirect project="Sungero.FinancialArchive.Shared" type="Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.FinancialArchive.IIncomingTaxInvoice incomingTaxInvoice)
    {
      var functions = (global::Sungero.FinancialArchive.Shared.IncomingTaxInvoiceFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)incomingTaxInvoice).FunctionsContainer.SharedFunctions;
      return functions.IsVerificationModeSupported();
    }

  }
}

// ==================================================================
// IncomingTaxInvoiceServerPublicFunctions.g.cs
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
  public class IncomingTaxInvoiceServerPublicFunctions : global::Sungero.FinancialArchive.Server.IIncomingTaxInvoiceServerPublicFunctions
  {
  }
}

// ==================================================================
// IncomingTaxInvoiceQueries.g.cs
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
  public class IncomingTaxInvoice
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.FinancialArchive.Server.IncomingTaxInvoice.IncomingTaxInvoiceQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}

// ==================================================================
// IncomingTaxInvoiceServerHandlers.g.cs
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
  public partial class IncomingTaxInvoiceConvertingFromServerHandler : global::Sungero.Docflow.AccountingDocumentBaseConvertingFromServerHandler
  { 
    private global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo _info
    {
      get { return (global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo)this._Info; }
    }

    public IncomingTaxInvoiceConvertingFromServerHandler(global::Sungero.Content.IElectronicDocument source, global::Sungero.FinancialArchive.IIncomingTaxInvoiceInfo info)
      : base(source, info)
    {
    }
  }
}
