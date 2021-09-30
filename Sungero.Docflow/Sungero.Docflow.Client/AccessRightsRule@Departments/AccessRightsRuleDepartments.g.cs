
// ==================================================================
// AccessRightsRuleDepartments.g.cs
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
  public class AccessRightsRuleDepartments :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IAccessRightsRuleDepartments
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("69cd7eee-b6e6-4f00-9562-5a3281c166f6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.AccessRightsRuleDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IAccessRightsRuleDepartments, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IAccessRightsRuleDepartmentsState State
    {
      get
      {
        return (global::Sungero.Docflow.IAccessRightsRuleDepartmentsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.AccessRightsRuleDepartmentsState(this);
    }

    public new global::Sungero.Docflow.IAccessRightsRuleDepartmentsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IAccessRightsRuleDepartmentsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IAccessRightsRule> _AccessRightsRule;

    public global::Sungero.Docflow.IAccessRightsRule AccessRightsRule
    {
      get { return this._AccessRightsRule.Value; }
      set { this._AccessRightsRule.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AccessRightsRule; }
      set { this.AccessRightsRule = (global::Sungero.Docflow.IAccessRightsRule)value; }
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
      return new global::Sungero.Docflow.AccessRightsRuleDepartmentsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.AccessRightsRuleDepartmentsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.AccessRightsRuleDepartmentsDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.AccessRightsRuleDepartmentsSharedHandlers)this.SharedHandlers).DepartmentsDepartmentChanged(args);
    }



  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Docflow.Client.AccessRightsRuleDepartmentsDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Docflow.AccessRightsRuleDepartmentsClientHandlers)this.Handlers).DepartmentsDepartmentValueInput(args);
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




    public AccessRightsRuleDepartments()
    {
      this._AccessRightsRule = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IAccessRightsRule>("AccessRightsRule", this, true);


            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}
