
// ==================================================================
// ContractualDocumentBaseVersions.g.cs
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


  public class ContractualDocumentBaseVersions :
    global::Sungero.Docflow.Server.OfficialDocumentVersions, global::Sungero.Docflow.IContractualDocumentBaseVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fb051c49-0b94-48b0-8100-af72495c69d5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ContractualDocumentBaseVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IContractualDocumentBaseVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IContractualDocumentBaseVersionsState State
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ContractualDocumentBaseVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IContractualDocumentBaseVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IContractualDocumentBaseVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ContractualDocumentBaseVersions()
    {
    }

  }
}

// ==================================================================
// ContractualDocumentBaseVersionsHandlers.g.cs
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

}

// ==================================================================
// ContractualDocumentBaseVersionsEventArgs.g.cs
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
