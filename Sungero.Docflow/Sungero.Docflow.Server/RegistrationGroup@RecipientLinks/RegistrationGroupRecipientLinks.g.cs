
// ==================================================================
// RegistrationGroupRecipientLinks.g.cs
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


  public class RegistrationGroupRecipientLinks :
    global::Sungero.CoreEntities.Server.GroupRecipientLinks, global::Sungero.Docflow.IRegistrationGroupRecipientLinks
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("8371fa12-018a-43da-a8b9-786be12e040c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.RegistrationGroupRecipientLinks.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IRegistrationGroupRecipientLinks, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IRegistrationGroupRecipientLinksState State
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupRecipientLinksState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupRecipientLinksState(this);
    }

    public new virtual global::Sungero.Docflow.IRegistrationGroupRecipientLinksInfo Info
    {
      get { return (global::Sungero.Docflow.IRegistrationGroupRecipientLinksInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public RegistrationGroupRecipientLinks()
    {
    }

  }
}

// ==================================================================
// RegistrationGroupRecipientLinksHandlers.g.cs
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
// RegistrationGroupRecipientLinksEventArgs.g.cs
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
