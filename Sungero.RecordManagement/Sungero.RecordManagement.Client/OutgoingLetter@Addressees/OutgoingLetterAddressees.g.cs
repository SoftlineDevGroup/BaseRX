
// ==================================================================
// OutgoingLetterAddressees.g.cs
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
  public class OutgoingLetterAddressees :
    global::Sungero.Docflow.Client.OutgoingDocumentBaseAddressees, global::Sungero.RecordManagement.IOutgoingLetterAddressees
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("cb1f24e1-84e2-47e0-b08e-59c651168b56");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.OutgoingLetterAddressees.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IOutgoingLetterAddressees, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IOutgoingLetterAddresseesState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IOutgoingLetterAddresseesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.OutgoingLetterAddresseesState(this);
    }

    public new global::Sungero.RecordManagement.IOutgoingLetterAddresseesInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IOutgoingLetterAddresseesInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors






    public OutgoingLetterAddressees()
    {








    }

    #endregion

  }
}
