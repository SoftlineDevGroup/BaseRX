
// ==================================================================
// ContractTracking.g.cs
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
  public class ContractTracking :
    global::Sungero.Contracts.Client.ContractBaseTracking, global::Sungero.Contracts.IContractTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c3c85262-6f62-400a-b238-27a76aa4e860");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ContractTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Contracts.IContractTrackingState State
    {
      get
      {
        return (global::Sungero.Contracts.IContractTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractTrackingState(this);
    }

    public new global::Sungero.Contracts.IContractTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IContractTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public ContractTracking()
    {








    }

    #endregion

  }
}
