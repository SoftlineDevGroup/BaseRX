
// ==================================================================
// CounterpartyDocumentTracking.g.cs
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


  public class CounterpartyDocumentTracking :
    global::Sungero.Docflow.Server.InternalDocumentBaseTracking, global::Sungero.Docflow.ICounterpartyDocumentTracking
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e59c26b4-0386-461e-afc5-df4bf6146533");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.CounterpartyDocumentTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICounterpartyDocumentTracking, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.ICounterpartyDocumentTrackingState State
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentTrackingState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentTrackingState(this);
    }

    public new virtual global::Sungero.Docflow.ICounterpartyDocumentTrackingInfo Info
    {
      get { return (global::Sungero.Docflow.ICounterpartyDocumentTrackingInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public CounterpartyDocumentTracking()
    {
    }

  }
}

// ==================================================================
// CounterpartyDocumentTrackingHandlers.g.cs
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
// CounterpartyDocumentTrackingEventArgs.g.cs
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
