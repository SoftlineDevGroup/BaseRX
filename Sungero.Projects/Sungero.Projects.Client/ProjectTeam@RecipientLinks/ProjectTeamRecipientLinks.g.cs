
// ==================================================================
// ProjectTeamRecipientLinks.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Client
{
  public class ProjectTeamRecipientLinks :
    global::Sungero.CoreEntities.Client.GroupRecipientLinks, global::Sungero.Projects.IProjectTeamRecipientLinks
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("852ceba8-5b3c-4c4e-8a69-b659654ec1f7");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Client.ProjectTeamRecipientLinks.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectTeamRecipientLinks, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Projects.IProjectTeamRecipientLinksState State
    {
      get
      {
        return (global::Sungero.Projects.IProjectTeamRecipientLinksState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectTeamRecipientLinksState(this);
    }

    public new global::Sungero.Projects.IProjectTeamRecipientLinksInfo Info
    {
      get
      {
        return (global::Sungero.Projects.IProjectTeamRecipientLinksInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public ProjectTeamRecipientLinks()
    {








    }

    #endregion

  }
}
