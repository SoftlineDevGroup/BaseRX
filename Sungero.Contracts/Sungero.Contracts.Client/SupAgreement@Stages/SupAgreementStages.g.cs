
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

namespace Sungero.Contracts.Client
{
  public class SupAgreementStages :
    global::Sungero.Contracts.Client.ContractualDocumentMilestones, global::Sungero.Contracts.ISupAgreementStages
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("cece0295-1cc2-465f-bb38-f193e0a786a0");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.SupAgreementStages.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.ISupAgreementStages, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Contracts.ISupAgreementStagesState State
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementStagesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.SupAgreementStagesState(this);
    }

    public new global::Sungero.Contracts.ISupAgreementStagesInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.ISupAgreementStagesInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public SupAgreementStages()
    {








    }

    #endregion

  }
}
