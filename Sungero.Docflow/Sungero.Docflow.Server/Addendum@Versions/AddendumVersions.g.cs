
// ==================================================================
// AddendumVersions.g.cs
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


  public class AddendumVersions :
    global::Sungero.Docflow.Server.InternalDocumentBaseVersions, global::Sungero.Docflow.IAddendumVersions
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c8333ee7-aa39-4ccf-9fac-0ef0429db167");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.AddendumVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAddendumVersions, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IAddendumVersionsState State
    {
      get { return (global::Sungero.Docflow.IAddendumVersionsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AddendumVersionsState(this);
    }

    public new virtual global::Sungero.Docflow.IAddendumVersionsInfo Info
    {
      get { return (global::Sungero.Docflow.IAddendumVersionsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public AddendumVersions()
    {
    }

  }
}

// ==================================================================
// AddendumVersionsHandlers.g.cs
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
// AddendumVersionsEventArgs.g.cs
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