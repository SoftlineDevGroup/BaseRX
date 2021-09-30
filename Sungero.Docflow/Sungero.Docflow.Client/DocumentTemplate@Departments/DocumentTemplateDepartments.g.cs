
// ==================================================================
// DocumentTemplateDepartments.g.cs
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
  public class DocumentTemplateDepartments :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IDocumentTemplateDepartments
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("aa04723b-5dd6-49e5-9254-a36e245c045c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DocumentTemplateDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentTemplateDepartments, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IDocumentTemplateDepartmentsState State
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentTemplateDepartmentsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentTemplateDepartmentsState(this);
    }

    public new global::Sungero.Docflow.IDocumentTemplateDepartmentsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentTemplateDepartmentsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IDocumentTemplate> _DocumentTemplate;

    public global::Sungero.Docflow.IDocumentTemplate DocumentTemplate
    {
      get { return this._DocumentTemplate.Value; }
      set { this._DocumentTemplate.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.DocumentTemplate; }
      set { this.DocumentTemplate = (global::Sungero.Docflow.IDocumentTemplate)value; }
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
      return new global::Sungero.Docflow.DocumentTemplateDepartmentsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentTemplateDepartmentsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentTemplateDepartmentsDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.DocumentTemplateDepartmentsSharedHandlers)this.SharedHandlers).DepartmentsDepartmentChanged(args);
    }



  protected global::Sungero.Company.IDepartment DepartmentValueInputHandler(global::Sungero.Company.IDepartment value)
  {
    var args = new global::Sungero.Docflow.Client.DocumentTemplateDepartmentsDepartmentValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Docflow.DocumentTemplateDepartmentsClientHandlers)this.Handlers).DepartmentsDepartmentValueInput(args);
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




    public DocumentTemplateDepartments()
    {
      this._DocumentTemplate = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IDocumentTemplate>("DocumentTemplate", this, true);


            this.InitDepartmentNavigationProperty();








    }

    #endregion

  }
}
