
// ==================================================================
// CounterpartyDocumentVersions.g.cs
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
  public class CounterpartyDocumentVersions :
    global::Sungero.Docflow.Client.InternalDocumentBaseVersions, global::Sungero.Docflow.ICounterpartyDocumentVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("aac43fbf-beb1-4891-b709-04118b7caecf");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.CounterpartyDocumentVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ICounterpartyDocumentVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.ICounterpartyDocumentVersionsState State
    {
      get
      {
        return (global::Sungero.Docflow.ICounterpartyDocumentVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.CounterpartyDocumentVersionsState(this);
    }

    public new global::Sungero.Docflow.ICounterpartyDocumentVersionsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.ICounterpartyDocumentVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public CounterpartyDocumentVersions()
    {








    }

    #endregion

  }
}
