
// ==================================================================
// IncomingLetterVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class IncomingLetterVersions :
    global::Sungero.Docflow.Client.IncomingDocumentBaseVersions, global::Sungero.RecordManagement.IIncomingLetterVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("085982c0-327d-46a1-8451-d0c12b0f6877");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.IncomingLetterVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IIncomingLetterVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IIncomingLetterVersionsState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IIncomingLetterVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.IncomingLetterVersionsState(this);
    }

    public new global::Sungero.RecordManagement.IIncomingLetterVersionsInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IIncomingLetterVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public IncomingLetterVersions()
    {








    }

    #endregion

  }
}