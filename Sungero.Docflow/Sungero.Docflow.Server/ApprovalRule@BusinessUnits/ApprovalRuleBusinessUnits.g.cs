
// ==================================================================
// ApprovalRuleBusinessUnits.g.cs
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


  public class ApprovalRuleBusinessUnits :
    global::Sungero.Docflow.Server.ApprovalRuleBaseBusinessUnits, global::Sungero.Docflow.IApprovalRuleBusinessUnits
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("07e78391-6f52-4e18-b8b8-799c5cfd9977");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ApprovalRuleBusinessUnits.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRuleBusinessUnits, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleBusinessUnitsState State
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBusinessUnitsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRuleBusinessUnitsState(this);
    }

    public new virtual global::Sungero.Docflow.IApprovalRuleBusinessUnitsInfo Info
    {
      get { return (global::Sungero.Docflow.IApprovalRuleBusinessUnitsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ApprovalRuleBusinessUnits()
    {
    }

  }
}

// ==================================================================
// ApprovalRuleBusinessUnitsHandlers.g.cs
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
// ApprovalRuleBusinessUnitsEventArgs.g.cs
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
