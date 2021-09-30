
// ==================================================================
// BusinessUnitEventArgs.g.cs
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
  public class BusinessUnitCityValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.ICity>
  {
    public BusinessUnitCityValueInputEventArgs(global::Sungero.Commons.ICity oldValue, global::Sungero.Commons.ICity newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



  public class BusinessUnitRegionValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Commons.IRegion>
  {
    public BusinessUnitRegionValueInputEventArgs(global::Sungero.Commons.IRegion oldValue, global::Sungero.Commons.IRegion newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class BusinessUnitHeadCompanyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IBusinessUnit>
  {
    public BusinessUnitHeadCompanyValueInputEventArgs(global::Sungero.Company.IBusinessUnit oldValue, global::Sungero.Company.IBusinessUnit newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }




  public class BusinessUnitCompanyValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICompany>
  {
    public BusinessUnitCompanyValueInputEventArgs(global::Sungero.Parties.ICompany oldValue, global::Sungero.Parties.ICompany newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class BusinessUnitCEOValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public BusinessUnitCEOValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }







  public class BusinessUnitBankValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IBank>
  {
    public BusinessUnitBankValueInputEventArgs(global::Sungero.Parties.IBank oldValue, global::Sungero.Parties.IBank newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



}

// ==================================================================
// BusinessUnitHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{

  public partial class BusinessUnitFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Company.IBusinessUnitFilterState Filter { get; private set; }

    private global::Sungero.Company.IBusinessUnitFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public BusinessUnitFilteringClientHandler(global::Sungero.Company.IBusinessUnitFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected BusinessUnitFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class BusinessUnitClientHandlers : global::Sungero.CoreEntities.GroupClientHandlers
  {
    private global::Sungero.Company.IBusinessUnit _obj
    {
      get { return (global::Sungero.Company.IBusinessUnit)this.Entity; }
    }

    public virtual void TRRCValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CityValueInput(global::Sungero.Company.Client.BusinessUnitCityValueInputEventArgs e) { }


    public virtual void PhonesValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void LegalNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void RegionValueInput(global::Sungero.Company.Client.BusinessUnitRegionValueInputEventArgs e) { }


    public virtual void HeadCompanyValueInput(global::Sungero.Company.Client.BusinessUnitHeadCompanyValueInputEventArgs e) { }


    public virtual void LegalAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void PostalAddressValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void CompanyValueInput(global::Sungero.Company.Client.BusinessUnitCompanyValueInputEventArgs e) { }




    public virtual void HomepageValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }




    public virtual void NCEAValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void BankValueInput(global::Sungero.Company.Client.BusinessUnitBankValueInputEventArgs e) { }




    public BusinessUnitClientHandlers(global::Sungero.Company.IBusinessUnit entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// BusinessUnitClientFunctions.g.cs
// ==================================================================

namespace Sungero.Company.Client
{
  public partial class BusinessUnitFunctions : global::Sungero.CoreEntities.Client.GroupFunctions
  {
    private global::Sungero.Company.IBusinessUnit _obj
    {
      get { return (global::Sungero.Company.IBusinessUnit)this.Entity; }
    }

    public BusinessUnitFunctions(global::Sungero.Company.IBusinessUnit entity) : base(entity) { }
  }
}

// ==================================================================
// BusinessUnitFunctions.g.cs
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
  internal static class BusinessUnit
  {
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.BusinessUnitFunctions" />
    internal static  global::System.String GetCounterpartyDuplicatesErrorText(global::Sungero.Company.IBusinessUnit businessUnit)
    {
      var functions = (global::Sungero.Company.Shared.BusinessUnitFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)businessUnit).FunctionsContainer.SharedFunctions;
      return functions.GetCounterpartyDuplicatesErrorText();
    }
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.BusinessUnitFunctions" />
    internal static  global::System.String CheckTinLength(global::Sungero.Company.IBusinessUnit businessUnit, global::System.String tin)
    {
      var functions = (global::Sungero.Company.Shared.BusinessUnitFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)businessUnit).FunctionsContainer.SharedFunctions;
      return functions.CheckTinLength(tin);
    }
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.BusinessUnitFunctions" />
    internal static  global::System.String CheckPsrnLength(global::Sungero.Company.IBusinessUnit businessUnit, global::System.String psrn)
    {
      var functions = (global::Sungero.Company.Shared.BusinessUnitFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)businessUnit).FunctionsContainer.SharedFunctions;
      return functions.CheckPsrnLength(psrn);
    }
    /// <redirect project="Sungero.Company.Shared" type="Sungero.Company.Shared.BusinessUnitFunctions" />
    internal static  global::System.String CheckNceoLength(global::Sungero.Company.IBusinessUnit businessUnit, global::System.String nceo)
    {
      var functions = (global::Sungero.Company.Shared.BusinessUnitFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)businessUnit).FunctionsContainer.SharedFunctions;
      return functions.CheckNceoLength(nceo);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.BusinessUnitFunctions" />
      internal static  global::Sungero.Company.IBusinessUnit GetBusinessUnit(global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Company.IBusinessUnit>(
          global::System.Guid.Parse("eff95720-181f-4f7d-892d-dec034c7b2ab"),
          "GetBusinessUnit(global::Sungero.Company.IEmployee)"
      , employee);
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.BusinessUnitFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit> GetBusinessUnits()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Company.IBusinessUnit>>(
          global::System.Guid.Parse("eff95720-181f-4f7d-892d-dec034c7b2ab"),
          "GetBusinessUnits()"
      );
      }
      /// <redirect project="Sungero.Company.Server" type="Sungero.Company.Server.BusinessUnitFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Company.IBusinessUnit> GetDuplicateBusinessUnit(global::Sungero.Company.IBusinessUnit businessUnit)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Company.IBusinessUnit>>(
          global::System.Guid.Parse("eff95720-181f-4f7d-892d-dec034c7b2ab"),
          "GetDuplicateBusinessUnit(global::Sungero.Company.IBusinessUnit)"
          , businessUnit);
      }

    }
  }
}

// ==================================================================
// BusinessUnitClientPublicFunctions.g.cs
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
  public class BusinessUnitClientPublicFunctions : global::Sungero.Company.Client.IBusinessUnitClientPublicFunctions
  {
  }
}

// ==================================================================
// BusinessUnitActions.g.cs
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
  public partial class BusinessUnitActions : global::Sungero.CoreEntities.Client.GroupActions
  {
    private global::Sungero.Company.IBusinessUnit _obj { get { return (global::Sungero.Company.IBusinessUnit)this.Entity; } }
    public BusinessUnitActions(global::Sungero.Company.IBusinessUnit entity) : base(entity) { }
  }

  public partial class BusinessUnitCollectionActions : global::Sungero.CoreEntities.Client.GroupCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Company.IBusinessUnit> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Company.IBusinessUnit>(this.Entities); }
    }
  }

  public partial class BusinessUnitAnyChildEntityActions : global::Sungero.CoreEntities.Client.GroupAnyChildEntityActions
  {
  }

  public partial class BusinessUnitAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.GroupAnyChildEntityCollectionActions
  {
  }

}
