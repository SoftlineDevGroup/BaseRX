
// ==================================================================
// PowerOfAttorneyVersions.g.cs
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
  public class PowerOfAttorneyVersions :
    global::Sungero.Docflow.Client.InternalDocumentBaseVersions, global::Sungero.Docflow.IPowerOfAttorneyVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c6798c1f-1d6d-4250-b2d3-88f5f04f745c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.PowerOfAttorneyVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IPowerOfAttorneyVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyVersionsState State
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.PowerOfAttorneyVersionsState(this);
    }

    public new global::Sungero.Docflow.IPowerOfAttorneyVersionsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IPowerOfAttorneyVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public PowerOfAttorneyVersions()
    {








    }

    #endregion

  }
}
