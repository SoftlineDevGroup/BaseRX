
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

namespace Sungero.Parties.Client
{
  public class CompanyBaseExchangeBoxes :
    global::Sungero.Parties.Client.CounterpartyExchangeBoxes, global::Sungero.Parties.ICompanyBaseExchangeBoxes
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1c002846-60f2-4216-853d-9aa101bdcf82");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Client.CompanyBaseExchangeBoxes.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.ICompanyBaseExchangeBoxes, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Parties.ICompanyBaseExchangeBoxesState State
    {
      get
      {
        return (global::Sungero.Parties.ICompanyBaseExchangeBoxesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.CompanyBaseExchangeBoxesState(this);
    }

    public new global::Sungero.Parties.ICompanyBaseExchangeBoxesInfo Info
    {
      get
      {
        return (global::Sungero.Parties.ICompanyBaseExchangeBoxesInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public CompanyBaseExchangeBoxes()
    {








    }

    #endregion

  }
}
