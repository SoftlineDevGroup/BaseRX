
// ==================================================================
// VerificationTaskObservers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public class VerificationTaskObservers :
    global::Sungero.Workflow.Client.TaskObservers, global::Sungero.SmartProcessing.IVerificationTaskObservers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f28f5ffb-a17a-4269-8fcb-24aff53ad560");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Client.VerificationTaskObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IVerificationTaskObservers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.SmartProcessing.IVerificationTaskObserversState State
    {
      get
      {
        return (global::Sungero.SmartProcessing.IVerificationTaskObserversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.VerificationTaskObserversState(this);
    }

    public new global::Sungero.SmartProcessing.IVerificationTaskObserversInfo Info
    {
      get
      {
        return (global::Sungero.SmartProcessing.IVerificationTaskObserversInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public VerificationTaskObservers()
    {








    }

    #endregion

  }
}
