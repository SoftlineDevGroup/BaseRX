
// ==================================================================
// WaybillVersions.g.cs
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
  public class WaybillVersions :
    global::Sungero.Docflow.Client.AccountingDocumentBaseVersions, global::Sungero.FinancialArchive.IWaybillVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1c506636-1d50-4c79-a0c7-09746718d016");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.WaybillVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IWaybillVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.FinancialArchive.IWaybillVersionsState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IWaybillVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.WaybillVersionsState(this);
    }

    public new global::Sungero.FinancialArchive.IWaybillVersionsInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IWaybillVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public WaybillVersions()
    {








    }

    #endregion

  }
}
