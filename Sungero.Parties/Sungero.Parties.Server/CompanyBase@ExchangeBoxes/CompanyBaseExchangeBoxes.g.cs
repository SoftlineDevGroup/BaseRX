
// ==================================================================
// CompanyBaseExchangeBoxes.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{


  public class CompanyBaseExchangeBoxes :
    global::Sungero.Parties.Server.CounterpartyExchangeBoxes, global::Sungero.Parties.ICompanyBaseExchangeBoxes
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1c002846-60f2-4216-853d-9aa101bdcf82");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Server.CompanyBaseExchangeBoxes.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.ICompanyBaseExchangeBoxes, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Parties.ICompanyBaseExchangeBoxesState State
    {
      get { return (global::Sungero.Parties.ICompanyBaseExchangeBoxesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesState(this);
    }

    public new virtual global::Sungero.Parties.ICompanyBaseExchangeBoxesInfo Info
    {
      get { return (global::Sungero.Parties.ICompanyBaseExchangeBoxesInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public CompanyBaseExchangeBoxes()
    {
    }

  }
}

// ==================================================================
// CompanyBaseExchangeBoxesHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties
{

}

// ==================================================================
// CompanyBaseExchangeBoxesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
}
