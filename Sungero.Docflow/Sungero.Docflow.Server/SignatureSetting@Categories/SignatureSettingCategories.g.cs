
// ==================================================================
// SignatureSettingCategories.g.cs
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
  public class SignatureSettingCategoriesFilterForCategory<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentGroupBase
    where TSourceEntity : class, global::Sungero.Docflow.ISignatureSettingCategories
    where TRootEntity : class, global::Sungero.Docflow.ISignatureSetting
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.SignatureSettingCategoriesCategoryPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).CategoriesCategoryFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public SignatureSettingCategoriesFilterForCategory(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class SignatureSettingCategoriesSearchFilterForCategory<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IDocumentGroupBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.SignatureSettingCategoriesCategorySearchPropertyFilteringServerHandler<TQueryEntity>().CategoriesCategorySearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public SignatureSettingCategoriesSearchFilterForCategory(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.SignatureSettingCategoriesFilterForCategory<global::Sungero.Docflow.IDocumentGroupBase, global::Sungero.Docflow.ISignatureSettingCategories, global::Sungero.Docflow.ISignatureSetting>), "Category")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.SignatureSettingCategoriesSearchFilterForCategory<global::Sungero.Docflow.IDocumentGroupBase>), "Category")]


  public class SignatureSettingCategories :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.ISignatureSettingCategories
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("9dc422bc-7d00-4fab-884b-0dba748a4ea3");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.SignatureSettingCategories.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISignatureSettingCategories, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.ISignatureSettingCategoriesState State
    {
      get { return (global::Sungero.Docflow.ISignatureSettingCategoriesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SignatureSettingCategoriesState(this);
    }

    public new virtual global::Sungero.Docflow.ISignatureSettingCategoriesInfo Info
    {
      get { return (global::Sungero.Docflow.ISignatureSettingCategoriesInfo)base.Info; }
    }


    public global::Sungero.Docflow.ISignatureSetting SignatureSetting { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.SignatureSetting; }
      set { this.SignatureSetting = (global::Sungero.Docflow.ISignatureSetting)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SignatureSettingCategoriesSharedHandlers(this);
    }







    private global::Sungero.Docflow.IDocumentGroupBase _Category;
    public virtual global::Sungero.Docflow.IDocumentGroupBase Category
    {
      get
      {
        return this._Category;
      }

      set
      {
        this.SetPropertyValue("Category", this._Category, value, (propertyValue) => { this._Category = propertyValue; }, this.CategoryChangedHandler);
      }
    }




    #region Framework events

    protected void CategoryChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.SignatureSettingCategoriesCategoryChangedEventArgs(this.State.Properties.Category, this.Category, this);
     ((global::Sungero.Docflow.SignatureSettingCategoriesSharedHandlers)this.SharedHandlers).CategoriesCategoryChanged(args);
    }



    #endregion


    public SignatureSettingCategories()
    {
    }

  }
}

// ==================================================================
// SignatureSettingCategoriesHandlers.g.cs
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
  public partial class SignatureSettingCategoriesCategoryPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentGroupBase
  {
    private global::Sungero.Docflow.ISignatureSettingCategories _obj
    {
      get { return (global::Sungero.Docflow.ISignatureSettingCategories)this.Entity; }
    }

    private global::Sungero.Docflow.ISignatureSetting _root
    {
      get { return (global::Sungero.Docflow.ISignatureSetting)this.Root; }
    }

    public SignatureSettingCategoriesCategoryPropertyFilteringServerHandler(global::Sungero.Docflow.ISignatureSettingCategories entity, global::Sungero.Docflow.ISignatureSetting root)
      : base(entity, root)
    {
    }
  }

  public partial class SignatureSettingCategoriesCategorySearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IDocumentGroupBase
  {

    public virtual global::System.Linq.IQueryable<T> CategoriesCategorySearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public SignatureSettingCategoriesCategorySearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// SignatureSettingCategoriesEventArgs.g.cs
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
