
// ==================================================================
// DepartmentRecipientLinks.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{


  public class DepartmentRecipientLinks :
    global::Sungero.CoreEntities.Server.GroupRecipientLinks, global::Sungero.Company.IDepartmentRecipientLinks
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("a9e935d5-3b72-4e3a-9e43-711d8f32b84e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Server.DepartmentRecipientLinks.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IDepartmentRecipientLinks, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Company.IDepartmentRecipientLinksState State
    {
      get { return (global::Sungero.Company.IDepartmentRecipientLinksState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.DepartmentRecipientLinksState(this);
    }

    public new virtual global::Sungero.Company.IDepartmentRecipientLinksInfo Info
    {
      get { return (global::Sungero.Company.IDepartmentRecipientLinksInfo)base.Info; }
    }







    public new virtual global::Sungero.Company.IEmployee Member
    {
      get
      {
      return base.Member as global::Sungero.Company.IEmployee;
      }

      set
      {
      base.Member = value;
      }
    }




    #region Framework events



    #endregion


    public DepartmentRecipientLinks()
    {
    }

  }
}

// ==================================================================
// DepartmentRecipientLinksHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{

}

// ==================================================================
// DepartmentRecipientLinksEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
}
