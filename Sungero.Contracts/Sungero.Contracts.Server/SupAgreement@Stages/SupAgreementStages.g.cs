
// ==================================================================
// SupAgreementStages.g.cs
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


  public class SupAgreementStages :
    global::Sungero.Contracts.Server.ContractualDocumentMilestones, global::Sungero.Contracts.ISupAgreementStages
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("cece0295-1cc2-465f-bb38-f193e0a786a0");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.SupAgreementStages.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.ISupAgreementStages, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.ISupAgreementStagesState State
    {
      get { return (global::Sungero.Contracts.ISupAgreementStagesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.SupAgreementStagesState(this);
    }

    public new virtual global::Sungero.Contracts.ISupAgreementStagesInfo Info
    {
      get { return (global::Sungero.Contracts.ISupAgreementStagesInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public SupAgreementStages()
    {
    }

  }
}

// ==================================================================
// SupAgreementStagesHandlers.g.cs
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
// SupAgreementStagesEventArgs.g.cs
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
