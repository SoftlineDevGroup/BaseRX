
// ==================================================================
// OutgoingDocumentBaseVersions.g.cs
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


  public class OutgoingDocumentBaseVersions :
    global::Sungero.Docflow.Server.OfficialDocumentVersions, global::Sungero.Docflow.IOutgoingDocumentBaseVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c3ce5ceb-6563-4d57-bab9-64800301243c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.OutgoingDocumentBaseVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IOutgoingDocumentBaseVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IOutgoingDocumentBaseVersionsState State
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IOutgoingDocumentBaseVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public OutgoingDocumentBaseVersions()
    {
    }

  }
}

// ==================================================================
// OutgoingDocumentBaseVersionsHandlers.g.cs
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
// OutgoingDocumentBaseVersionsEventArgs.g.cs
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
