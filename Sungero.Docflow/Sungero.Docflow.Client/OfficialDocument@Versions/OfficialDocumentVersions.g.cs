
// ==================================================================
// OfficialDocumentVersions.g.cs
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
  public class OfficialDocumentVersions :
    global::Sungero.Content.Client.ElectronicDocumentVersions, global::Sungero.Docflow.IOfficialDocumentVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6180769e-de94-43ff-8894-e32cb5260789");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.OfficialDocumentVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IOfficialDocumentVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IOfficialDocumentVersionsState State
    {
      get
      {
        return (global::Sungero.Docflow.IOfficialDocumentVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.OfficialDocumentVersionsState(this);
    }

    public new global::Sungero.Docflow.IOfficialDocumentVersionsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IOfficialDocumentVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public OfficialDocumentVersions()
    {








    }

    #endregion

  }
}
