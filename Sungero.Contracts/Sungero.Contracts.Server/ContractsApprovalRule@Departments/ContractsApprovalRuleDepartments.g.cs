
// ==================================================================
// ContractsApprovalRuleDepartments.g.cs
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


  public class ContractsApprovalRuleDepartments :
    global::Sungero.Docflow.Server.ApprovalRuleBaseDepartments, global::Sungero.Contracts.IContractsApprovalRuleDepartments
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6c966139-e0f7-4c62-8c83-ed8702ca54c5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractsApprovalRuleDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractsApprovalRuleDepartments, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.IContractsApprovalRuleDepartmentsState State
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleDepartmentsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleDepartmentsState(this);
    }

    public new virtual global::Sungero.Contracts.IContractsApprovalRuleDepartmentsInfo Info
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleDepartmentsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ContractsApprovalRuleDepartments()
    {
    }

  }
}

// ==================================================================
// ContractsApprovalRuleDepartmentsHandlers.g.cs
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
// ContractsApprovalRuleDepartmentsEventArgs.g.cs
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
