
// ==================================================================
// RetentionPolicyDocumentKinds.g.cs
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


  public class RetentionPolicyDocumentKinds :
    global::Sungero.Docflow.Server.StoragePolicyBaseDocumentKinds, global::Sungero.Docflow.IRetentionPolicyDocumentKinds
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("93dd73b5-427c-4cea-821e-6e265c8cfbb1");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.RetentionPolicyDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IRetentionPolicyDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IRetentionPolicyDocumentKindsState State
    {
      get { return (global::Sungero.Docflow.IRetentionPolicyDocumentKindsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.RetentionPolicyDocumentKindsState(this);
    }

    public new virtual global::Sungero.Docflow.IRetentionPolicyDocumentKindsInfo Info
    {
      get { return (global::Sungero.Docflow.IRetentionPolicyDocumentKindsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public RetentionPolicyDocumentKinds()
    {
    }

  }
}

// ==================================================================
// RetentionPolicyDocumentKindsHandlers.g.cs
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
// RetentionPolicyDocumentKindsEventArgs.g.cs
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
