
// ==================================================================
// ApprovalRuleTransitions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalRuleTransitions :
    global::Sungero.Docflow.Client.ApprovalRuleBaseTransitions, global::Sungero.Docflow.IApprovalRuleTransitions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("dc4449c7-5a08-4b4d-a95e-677db85e6d5d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRuleTransitions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRuleTransitions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalRuleTransitionsState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleTransitionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleTransitionsState(this);
    }

    public new global::Sungero.Docflow.IApprovalRuleTransitionsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRuleTransitionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors



    public ApprovalRuleTransitions()
    {








    }

    #endregion

  }
}
