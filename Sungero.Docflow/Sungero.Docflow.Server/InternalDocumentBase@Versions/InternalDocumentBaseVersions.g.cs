
// ==================================================================
// InternalDocumentBaseVersions.g.cs
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


  public class InternalDocumentBaseVersions :
    global::Sungero.Docflow.Server.OfficialDocumentVersions, global::Sungero.Docflow.IInternalDocumentBaseVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("38660ede-96d3-4c57-87a5-8fe53a47615c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.InternalDocumentBaseVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IInternalDocumentBaseVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IInternalDocumentBaseVersionsState State
    {
      get { return (global::Sungero.Docflow.IInternalDocumentBaseVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.InternalDocumentBaseVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IInternalDocumentBaseVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IInternalDocumentBaseVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public InternalDocumentBaseVersions()
    {
    }

  }
}

// ==================================================================
// InternalDocumentBaseVersionsHandlers.g.cs
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
// InternalDocumentBaseVersionsEventArgs.g.cs
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
