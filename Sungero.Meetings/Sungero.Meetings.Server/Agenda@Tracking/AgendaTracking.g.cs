
// ==================================================================
// AgendaTracking.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{


  public class AgendaTracking :
    global::Sungero.Docflow.Server.InternalDocumentBaseTracking, global::Sungero.Meetings.IAgendaTracking
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("231c12b0-800c-457a-a920-6f1a9f51f252");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Meetings.Server.AgendaTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Meetings.IAgendaTracking, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Meetings.IAgendaTrackingState State
    {
      get { return (global::Sungero.Meetings.IAgendaTrackingState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Meetings.Shared.AgendaTrackingState(this);
    }

    public new virtual global::Sungero.Meetings.IAgendaTrackingInfo Info
    {
      get { return (global::Sungero.Meetings.IAgendaTrackingInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public AgendaTracking()
    {
    }

  }
}

// ==================================================================
// AgendaTrackingHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings
{

}

// ==================================================================
// AgendaTrackingEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Server
{
}
