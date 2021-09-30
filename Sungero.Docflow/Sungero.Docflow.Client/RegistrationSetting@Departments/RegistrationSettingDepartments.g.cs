
// ==================================================================
// RegistrationSettingDepartments.g.cs
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
  public class RegistrationSettingDepartments :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IRegistrationSettingDepartments
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("12d9bfd1-5355-4b88-8084-3288d8e2b564");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.RegistrationSettingDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IRegistrationSettingDepartments, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IRegistrationSettingDepartmentsState State
    {
      get
      {
        return (global::Sungero.Docflow.IRegistrationSettingDepartmentsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.RegistrationSettingDepartmentsState(this);
    }

    public new global::Sungero.Docflow.IRegistrationSettingDepartmentsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IRegistrationSettingDepartmentsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IRegistrationSetting> _RegistrationSetting;

    public global::Sungero.Docflow.IRegistrationSetting RegistrationSetting
    {
      get { return this._RegistrationSetting.Value; }
      set { this._RegistrationSetting.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.RegistrationSetting; }
      set { this.RegistrationSetting = (global::Sungero.Docflow.IRegistrationSetting)value; }
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
      return new global::Sungero.Docflow.RegistrationSettingDepartmentsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.RegistrationSettingDepartmentsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.RegistrationSettingDepartmentsDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.RegistrationSettingDepartmentsSharedHandlers)this.SharedHandlers).DepartmentsDepartmentChanged(args);
    }



  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Docflow.Client.RegistrationSettingDepartmentsDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Docflow.RegistrationSettingDepartmentsClientHandlers)this.Handlers).DepartmentsDepartmentValueInput(args);
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




    public RegistrationSettingDepartments()
    {
      this._RegistrationSetting = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IRegistrationSetting>("RegistrationSetting", this, true);


            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}