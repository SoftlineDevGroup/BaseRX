
// ==================================================================
// ContractualDocumentTracking.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractualDocumentTracking :
    global::Sungero.Docflow.Client.ContractualDocumentBaseTracking, global::Sungero.Contracts.IContractualDocumentTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("19c5aee5-f67f-497e-ac1b-ab98bab0901b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ContractualDocumentTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractualDocumentTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Contracts.IContractualDocumentTrackingState State
    {
      get
      {
        return (global::Sungero.Contracts.IContractualDocumentTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractualDocumentTrackingState(this);
    }

    public new global::Sungero.Contracts.IContractualDocumentTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IContractualDocumentTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public ContractualDocumentTracking()
    {








    }

    #endregion

  }
}