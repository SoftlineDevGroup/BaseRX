
// ==================================================================
// ContractBaseVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{


  public class ContractBaseVersions :
    global::Sungero.Contracts.Server.ContractualDocumentVersions, global::Sungero.Contracts.IContractBaseVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c7a89d8e-e835-42f5-81af-6c741c43d259");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractBaseVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractBaseVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.IContractBaseVersionsState State
    {
      get { return (global::Sungero.Contracts.IContractBaseVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractBaseVersionsState(this);
    }

    public new virtual global::Sungero.Contracts.IContractBaseVersionsInfo Info
    {
      get { return (global::Sungero.Contracts.IContractBaseVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ContractBaseVersions()
    {
    }

  }
}

// ==================================================================
// ContractBaseVersionsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{

}

// ==================================================================
// ContractBaseVersionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Server
{
}
