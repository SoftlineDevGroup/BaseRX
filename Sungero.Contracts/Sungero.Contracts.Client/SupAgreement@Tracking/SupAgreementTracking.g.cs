
// ==================================================================
// SupAgreementTracking.g.cs
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
  public class SupAgreementTracking :
    global::Sungero.Contracts.Client.ContractualDocumentTracking, global::Sungero.Contracts.ISupAgreementTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("3a1afee8-f45c-4c4e-aa45-6bd6cf2d38a2");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.SupAgreementTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.ISupAgreementTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Contracts.ISupAgreementTrackingState State
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.SupAgreementTrackingState(this);
    }

    public new global::Sungero.Contracts.ISupAgreementTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public SupAgreementTracking()
    {








    }

    #endregion

  }
}
