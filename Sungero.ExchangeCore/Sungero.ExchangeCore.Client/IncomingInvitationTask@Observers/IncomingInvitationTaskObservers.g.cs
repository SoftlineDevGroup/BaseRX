
// ==================================================================
// IncomingInvitationTaskObservers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.ExchangeCore.Client
{
  public class IncomingInvitationTaskObservers :
    global::Sungero.Workflow.Client.TaskObservers, global::Sungero.ExchangeCore.IIncomingInvitationTaskObservers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("f987aacd-10e2-4009-bb5c-762bf66ba50d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.ExchangeCore.Client.IncomingInvitationTaskObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.ExchangeCore.IIncomingInvitationTaskObservers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.ExchangeCore.IIncomingInvitationTaskObserversState State
    {
      get
      {
        return (global::Sungero.ExchangeCore.IIncomingInvitationTaskObserversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.ExchangeCore.Shared.IncomingInvitationTaskObserversState(this);
    }

    public new global::Sungero.ExchangeCore.IIncomingInvitationTaskObserversInfo Info
    {
      get
      {
        return (global::Sungero.ExchangeCore.IIncomingInvitationTaskObserversInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public IncomingInvitationTaskObservers()
    {








    }

    #endregion

  }
}
