
// ==================================================================
// ContractualDocumentVersions.g.cs
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


  public class ContractualDocumentVersions :
    global::Sungero.Docflow.Server.ContractualDocumentBaseVersions, global::Sungero.Contracts.IContractualDocumentVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fff6fbcb-3478-43fb-b8d4-888d2c5038c2");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractualDocumentVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractualDocumentVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.IContractualDocumentVersionsState State
    {
      get { return (global::Sungero.Contracts.IContractualDocumentVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractualDocumentVersionsState(this);
    }

    public new virtual global::Sungero.Contracts.IContractualDocumentVersionsInfo Info
    {
      get { return (global::Sungero.Contracts.IContractualDocumentVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ContractualDocumentVersions()
    {
    }

  }
}

// ==================================================================
// ContractualDocumentVersionsHandlers.g.cs
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
// ContractualDocumentVersionsEventArgs.g.cs
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
