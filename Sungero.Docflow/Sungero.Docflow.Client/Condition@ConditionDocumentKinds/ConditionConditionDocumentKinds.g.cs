
// ==================================================================
// ConditionConditionDocumentKinds.g.cs
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
  public class ConditionConditionDocumentKinds :
    global::Sungero.Docflow.Client.ConditionBaseConditionDocumentKinds, global::Sungero.Docflow.IConditionConditionDocumentKinds
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("1a4f42ad-c033-4c71-a3c0-9c41bc76d211");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ConditionConditionDocumentKinds.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IConditionConditionDocumentKinds, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IConditionConditionDocumentKindsState State
    {
      get
      {
        return (global::Sungero.Docflow.IConditionConditionDocumentKindsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ConditionConditionDocumentKindsState(this);
    }

    public new global::Sungero.Docflow.IConditionConditionDocumentKindsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IConditionConditionDocumentKindsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public ConditionConditionDocumentKinds()
    {








    }

    #endregion

  }
}
