
// ==================================================================
// ProjectTeamMembers.g.cs
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
  public class ProjectTeamMembers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Projects.IProjectTeamMembers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c06142f1-0fbd-4946-b382-227591508986");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Client.ProjectTeamMembers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectTeamMembers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Projects.IProjectTeamMembersState State
    {
      get
      {
        return (global::Sungero.Projects.IProjectTeamMembersState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectTeamMembersState(this);
    }

    public new global::Sungero.Projects.IProjectTeamMembersInfo Info
    {
      get
      {
        return (global::Sungero.Projects.IProjectTeamMembersInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Projects.IProject> _Project;

    public global::Sungero.Projects.IProject Project
    {
      get { return this._Project.Value; }
      set { this._Project.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.Project; }
      set { this.Project = (global::Sungero.Projects.IProject)value; }
    }

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _Group;

        public virtual global::Sungero.Core.Enumeration? Group
        {
          get { return this._Group.Value; }
          set { this._Group.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _GroupItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Projects.ProjectTeamMembers.Group),
          typeof(global::Sungero.Projects.Client.ProjectTeamMembers),
          "Group");

        public static global::Sungero.Domain.Shared.EnumerationItems GroupItems
        {
          get { return global::Sungero.Projects.Client.ProjectTeamMembers._GroupItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems GroupAllowedItems
        {
          get { return global::Sungero.Projects.Client.ProjectTeamMembers.GroupItems; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _Member;

              public virtual global::Sungero.CoreEntities.IRecipient Member
              {
              get
              {
                return this._Member.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._Member as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Projects.ProjectTeamMembersClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectTeamMembersSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void MemberChangedHandler()
    {
      var args = new global::Sungero.Projects.Shared.ProjectTeamMembersMemberChangedEventArgs(this.State.Properties.Member, this.Member, this);
     ((global::Sungero.Projects.ProjectTeamMembersSharedHandlers)this.SharedHandlers).TeamMembersMemberChanged(args);
    }

    protected void GroupChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.Group, this.Group, this);
     ((global::Sungero.Projects.ProjectTeamMembersSharedHandlers)this.SharedHandlers).TeamMembersGroupChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient MemberValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.Projects.Client.ProjectTeamMembersMemberValueInputEventArgs(this.Member, value, this, this.Info.Properties.Member);
    ((global::Sungero.Projects.ProjectTeamMembersClientHandlers)this.Handlers).TeamMembersMemberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Core.Enumeration? GroupValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.Group, value, this, this.Info.Properties.Group);
    ((global::Sungero.Projects.ProjectTeamMembersClientHandlers)this.Handlers).TeamMembersGroupValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> GroupFilteringHandler()
  {
    return ((global::Sungero.Projects.ProjectTeamMembersClientHandlers)this.Handlers).TeamMembersGroupFiltering(this.GroupAllowedItems);
  }


    #endregion

    #region Constructors



              protected virtual void InitMemberNavigationProperty()
              {
                this._Member = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("Member", this);
                this._Member.ValueChanged += (sender, e) => { this.MemberChangedHandler(); };
                this.AddProperty(this._Member as global::Sungero.Domain.Client.IProperty);
              }




    public ProjectTeamMembers()
    {
      this._Project = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Projects.IProject>("Project", this, true);

            this._Group = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("Group", this);
            this._Group.ValueChanged += (sender, e) => { this.GroupChangedHandler(); };
            this.AddProperty(this._Group);

            this.InitMemberNavigationProperty();








    }

    #endregion

  }
}
