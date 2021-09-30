
// ==================================================================
// RegistrationGroupDepartments.g.cs
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
  public class RegistrationGroupDepartments :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IRegistrationGroupDepartments
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("fa2d7d49-b02a-4d89-a3bc-70a99999c61d");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.RegistrationGroupDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IRegistrationGroupDepartments, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IRegistrationGroupDepartmentsState State
    {
      get
      {
        return (global::Sungero.Docflow.IRegistrationGroupDepartmentsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.RegistrationGroupDepartmentsState(this);
    }

    public new global::Sungero.Docflow.IRegistrationGroupDepartmentsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IRegistrationGroupDepartmentsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IRegistrationGroup> _RegistrationGroup;

    public global::Sungero.Docflow.IRegistrationGroup RegistrationGroup
    {
      get { return this._RegistrationGroup.Value; }
      set { this._RegistrationGroup.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.RegistrationGroup; }
      set { this.RegistrationGroup = (global::Sungero.Docflow.IRegistrationGroup)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IDepartment> _Department;

              public virtual global::Sungero.Company.IDepartment Department
              {
              get
              {
                return this._Department.Value as global::Sungero.Company.IDepartment;
              }

              set
              {
                (this._Department as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.RegistrationGroupDepartmentsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.RegistrationGroupDepartmentsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.RegistrationGroupDepartmentsDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.RegistrationGroupDepartmentsSharedHandlers)this.SharedHandlers).DepartmentsDepartmentChanged(args);
    }



  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Docflow.Client.RegistrationGroupDepartmentsDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Docflow.RegistrationGroupDepartmentsClientHandlers)this.Handlers).DepartmentsDepartmentValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitDepartmentNavigationProperty()
              {
                this._Department = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IDepartment>("Department", this);
                this._Department.ValueChanged += (sender, e) => { this.DepartmentChangedHandler(); };
                this.AddProperty(this._Department as global::Sungero.Domain.Client.IProperty);
              }




    public RegistrationGroupDepartments()
    {
      this._RegistrationGroup = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IRegistrationGroup>("RegistrationGroup", this, true);


            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}