
// ==================================================================
// ContractsApprovalRuleDocumentGroups.g.cs
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


  public class ContractsApprovalRuleDocumentGroups :
    global::Sungero.Docflow.Server.ApprovalRuleBaseDocumentGroups, global::Sungero.Contracts.IContractsApprovalRuleDocumentGroups
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("9039aab1-4ce6-4769-ab73-2eb1f47f6cb7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Server.ContractsApprovalRuleDocumentGroups.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractsApprovalRuleDocumentGroups, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Contracts.IContractsApprovalRuleDocumentGroupsState State
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleDocumentGroupsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractsApprovalRuleDocumentGroupsState(this);
    }

    public new virtual global::Sungero.Contracts.IContractsApprovalRuleDocumentGroupsInfo Info
    {
      get { return (global::Sungero.Contracts.IContractsApprovalRuleDocumentGroupsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ContractsApprovalRuleDocumentGroups()
    {
    }

  }
}

// ==================================================================
// ContractsApprovalRuleDocumentGroupsHandlers.g.cs
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
// ContractsApprovalRuleDocumentGroupsEventArgs.g.cs
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
