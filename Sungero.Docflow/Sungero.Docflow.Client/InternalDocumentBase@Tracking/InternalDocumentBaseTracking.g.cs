
// ==================================================================
// InternalDocumentBaseTracking.g.cs
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
  public class InternalDocumentBaseTracking :
    global::Sungero.Docflow.Client.OfficialDocumentTracking, global::Sungero.Docflow.IInternalDocumentBaseTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8686b382-12c4-4dad-bd3e-d9067fce92d3");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.InternalDocumentBaseTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IInternalDocumentBaseTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IInternalDocumentBaseTrackingState State
    {
      get
      {
        return (global::Sungero.Docflow.IInternalDocumentBaseTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.InternalDocumentBaseTrackingState(this);
    }

    public new global::Sungero.Docflow.IInternalDocumentBaseTrackingInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IInternalDocumentBaseTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public InternalDocumentBaseTracking()
    {








    }

    #endregion

  }
}
