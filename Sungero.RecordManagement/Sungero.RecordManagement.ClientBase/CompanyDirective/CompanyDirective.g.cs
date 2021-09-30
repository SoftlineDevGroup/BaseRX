
// ==================================================================
// CompanyDirectiveEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
}

// ==================================================================
// CompanyDirectiveHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

  public partial class CompanyDirectiveFilteringClientHandler
    : global::Sungero.RecordManagement.OrderBaseFilteringClientHandler
  {
    private global::Sungero.RecordManagement.ICompanyDirectiveFilterState _filter
    {
      get
      {
        return (Sungero.RecordManagement.ICompanyDirectiveFilterState)this.Filter;
      }
    }

    public CompanyDirectiveFilteringClientHandler(global::Sungero.RecordManagement.ICompanyDirectiveFilterState filter)
    : base(filter)
    {
    }

    protected CompanyDirectiveFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class CompanyDirectiveClientHandlers : global::Sungero.RecordManagement.OrderBaseClientHandlers
  {
    private global::Sungero.RecordManagement.ICompanyDirective _obj
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirective)this.Entity; }
    }

    public CompanyDirectiveClientHandlers(global::Sungero.RecordManagement.ICompanyDirective entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CompanyDirectiveClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class CompanyDirectiveFunctions : global::Sungero.RecordManagement.Client.OrderBaseFunctions
  {
    private global::Sungero.RecordManagement.ICompanyDirective _obj
    {
      get { return (global::Sungero.RecordManagement.ICompanyDirective)this.Entity; }
    }

    public CompanyDirectiveFunctions(global::Sungero.RecordManagement.ICompanyDirective entity) : base(entity) { }
  }
}

// ==================================================================
// CompanyDirectiveFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Functions
{
  internal static class CompanyDirective
  {
  }
}

// ==================================================================
// CompanyDirectiveClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class CompanyDirectiveClientPublicFunctions : global::Sungero.RecordManagement.Client.ICompanyDirectiveClientPublicFunctions
  {
  }
}

// ==================================================================
// CompanyDirectiveActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public partial class CompanyDirectiveActions : global::Sungero.RecordManagement.Client.OrderBaseActions
  {
    private global::Sungero.RecordManagement.ICompanyDirective _obj { get { return (global::Sungero.RecordManagement.ICompanyDirective)this.Entity; } }
    public CompanyDirectiveActions(global::Sungero.RecordManagement.ICompanyDirective entity) : base(entity) { }
  }

  public partial class CompanyDirectiveCollectionActions : global::Sungero.RecordManagement.Client.OrderBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.ICompanyDirective> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.ICompanyDirective>(this.Entities); }
    }
  }

  public partial class CompanyDirectiveAnyChildEntityActions : global::Sungero.RecordManagement.Client.OrderBaseAnyChildEntityActions
  {
  }

  public partial class CompanyDirectiveAnyChildEntityCollectionActions : global::Sungero.RecordManagement.Client.OrderBaseAnyChildEntityCollectionActions
  {
  }

}
