
// ==================================================================
// ApprovalStageApprovalRoles.g.cs
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
  public class ApprovalStageApprovalRoles :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalStageApprovalRoles
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("b58b8d30-76b1-448c-b71e-b58e0716a840");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalStageApprovalRoles.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalStageApprovalRoles, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalStageApprovalRolesState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalStageApprovalRolesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageApprovalRolesState(this);
    }

    public new global::Sungero.Docflow.IApprovalStageApprovalRolesInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalStageApprovalRolesInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStage> _ApprovalStage;

    public global::Sungero.Docflow.IApprovalStage ApprovalStage
    {
      get { return this._ApprovalStage.Value; }
      set { this._ApprovalStage.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalStage; }
      set { this.ApprovalStage = (global::Sungero.Docflow.IApprovalStage)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IApprovalRoleBase> _ApprovalRole;

              public virtual global::Sungero.Docflow.IApprovalRoleBase ApprovalRole
              {
              get
              {
                return this._ApprovalRole.Value as global::Sungero.Docflow.IApprovalRoleBase;
              }

              set
              {
                (this._ApprovalRole as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalStageApprovalRolesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalStageApprovalRolesSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ApprovalRoleChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalStageApprovalRolesApprovalRoleChangedEventArgs(this.State.Properties.ApprovalRole, this.ApprovalRole, this);
     ((global::Sungero.Docflow.ApprovalStageApprovalRolesSharedHandlers)this.SharedHandlers).ApprovalRolesApprovalRoleChanged(args);
    }



  protected global::Sungero.Docflow.IApprovalRoleBase ApprovalRoleValueInputHandler(global::Sungero.Docflow.IApprovalRoleBase value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalStageApprovalRolesApprovalRoleValueInputEventArgs(this.ApprovalRole, value, this, this.Info.Properties.ApprovalRole);
    ((global::Sungero.Docflow.ApprovalStageApprovalRolesClientHandlers)this.Handlers).ApprovalRolesApprovalRoleValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitApprovalRoleNavigationProperty()
              {
                this._ApprovalRole = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRoleBase>("ApprovalRole", this);
                this._ApprovalRole.ValueChanged += (sender, e) => { this.ApprovalRoleChangedHandler(); };
                this.AddProperty(this._ApprovalRole as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalStageApprovalRoles()
    {
      this._ApprovalStage = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStage>("ApprovalStage", this, true);


            this.InitApprovalRoleNavigationProperty();








    }

    #endregion

  }
}
