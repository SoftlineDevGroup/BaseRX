
// ==================================================================
// MinutesBaseTracking.g.cs
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
  public class MinutesBaseTracking :
    global::Sungero.Docflow.Client.InternalDocumentBaseTracking, global::Sungero.Docflow.IMinutesBaseTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("36482dd6-708f-4d56-921b-ea1e01c74794");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.MinutesBaseTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IMinutesBaseTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IMinutesBaseTrackingState State
    {
      get
      {
        return (global::Sungero.Docflow.IMinutesBaseTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.MinutesBaseTrackingState(this);
    }

    public new global::Sungero.Docflow.IMinutesBaseTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IMinutesBaseTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public MinutesBaseTracking()
    {








    }

    #endregion

  }
}
