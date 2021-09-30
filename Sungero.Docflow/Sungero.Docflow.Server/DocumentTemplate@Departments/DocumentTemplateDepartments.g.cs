
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

namespace Sungero.Docflow.Server
{
  public class DocumentTemplateDepartmentsFilterForDepartment<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Company.IDepartment
    where TSourceEntity : class, global::Sungero.Docflow.IDocumentTemplateDepartments
    where TRootEntity : class, global::Sungero.Docflow.IDocumentTemplate
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.DocumentTemplateDepartmentsDepartmentPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).DepartmentsDepartmentFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentTemplateDepartmentsFilterForDepartment(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class DocumentTemplateDepartmentsSearchFilterForDepartment<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Company.IDepartment
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.DocumentTemplateDepartmentsDepartmentSearchPropertyFilteringServerHandler<TQueryEntity>().DepartmentsDepartmentSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentTemplateDepartmentsSearchFilterForDepartment(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentTemplateDepartmentsFilterForDepartment<global::Sungero.Company.IDepartment, global::Sungero.Docflow.IDocumentTemplateDepartments, global::Sungero.Docflow.IDocumentTemplate>), "Department")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentTemplateDepartmentsSearchFilterForDepartment<global::Sungero.Company.IDepartment>), "Department")]


  public class DocumentTemplateDepartments :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IDocumentTemplateDepartments
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("aa04723b-5dd6-49e5-9254-a36e245c045c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentTemplateDepartments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentTemplateDepartments, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IDocumentTemplateDepartmentsState State
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateDepartmentsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentTemplateDepartmentsState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentTemplateDepartmentsInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateDepartmentsInfo)base.Info; }
    }


    public global::Sungero.Docflow.IDocumentTemplate DocumentTemplate { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.DocumentTemplate; }
      set { this.DocumentTemplate = (global::Sungero.Docflow.IDocumentTemplate)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentTemplateDepartmentsSharedHandlers(this);
    }







    private global::Sungero.Company.IDepartment _Department;
    public virtual global::Sungero.Company.IDepartment Department
    {
      get
      {
        return this._Department;
      }

      set
      {
        this.SetPropertyValue("Department", this._Department, value, (propertyValue) => { this._Department = propertyValue; }, this.DepartmentChangedHandler);
      }
    }




    #region Framework events

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentTemplateDepartmentsDepartmentChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Docflow.DocumentTemplateDepartmentsSharedHandlers)this.SharedHandlers).DepartmentsDepartmentChanged(args);
    }



    #endregion


    public DocumentTemplateDepartments()
    {
    }

  }
}

// ==================================================================
// DocumentTemplateDepartmentsHandlers.g.cs
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
  public partial class DocumentTemplateDepartmentsDepartmentPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IDepartment
  {
    private global::Sungero.Docflow.IDocumentTemplateDepartments _obj
    {
      get { return (global::Sungero.Docflow.IDocumentTemplateDepartments)this.Entity; }
    }

    private global::Sungero.Docflow.IDocumentTemplate _root
    {
      get { return (global::Sungero.Docflow.IDocumentTemplate)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> DepartmentsDepartmentFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public DocumentTemplateDepartmentsDepartmentPropertyFilteringServerHandler(global::Sungero.Docflow.IDocumentTemplateDepartments entity, global::Sungero.Docflow.IDocumentTemplate root)
      : base(entity, root)
    {
    }
  }

  public partial class DocumentTemplateDepartmentsDepartmentSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Company.IDepartment
  {

    public virtual global::System.Linq.IQueryable<T> DepartmentsDepartmentSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public DocumentTemplateDepartmentsDepartmentSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// DocumentTemplateDepartmentsEventArgs.g.cs
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
