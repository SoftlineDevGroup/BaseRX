
// ==================================================================
// CaseFileEventArgs.g.cs
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
  public class CaseFileDepartmentValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IDepartment>
  {
    public CaseFileDepartmentValueInputEventArgs(global::Sungero.Company.IDepartment oldValue, global::Sungero.Company.IDepartment newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class CaseFileRetentionPeriodValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IFileRetentionPeriod>
  {
    public CaseFileRetentionPeriodValueInputEventArgs(global::Sungero.Docflow.IFileRetentionPeriod oldValue, global::Sungero.Docflow.IFileRetentionPeriod newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



  public class CaseFileRegistrationGroupValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IRegistrationGroup>
  {
    public CaseFileRegistrationGroupValueInputEventArgs(global::Sungero.Docflow.IRegistrationGroup oldValue, global::Sungero.Docflow.IRegistrationGroup newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// CaseFileHandlers.g.cs
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

  public partial class CaseFileFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.ICaseFileFilterState Filter { get; private set; }

    private global::Sungero.Docflow.ICaseFileFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public CaseFileFilteringClientHandler(global::Sungero.Docflow.ICaseFileFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected CaseFileFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class CaseFileClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.ICaseFile _obj
    {
      get { return (global::Sungero.Docflow.ICaseFile)this.Entity; }
    }

    public virtual void TitleValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void StartDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void EndDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void DepartmentValueInput(global::Sungero.Docflow.Client.CaseFileDepartmentValueInputEventArgs e) { }


    public virtual void RetentionPeriodValueInput(global::Sungero.Docflow.Client.CaseFileRetentionPeriodValueInputEventArgs e) { }


    public virtual void LongTermValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void LocationValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void RegistrationGroupValueInput(global::Sungero.Docflow.Client.CaseFileRegistrationGroupValueInputEventArgs e) { }


    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public CaseFileClientHandlers(global::Sungero.Docflow.ICaseFile entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// CaseFileClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class CaseFileFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.ICaseFile _obj
    {
      get { return (global::Sungero.Docflow.ICaseFile)this.Entity; }
    }

    public CaseFileFunctions(global::Sungero.Docflow.ICaseFile entity) : base(entity) { }
  }
}

// ==================================================================
// CaseFileFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class CaseFile
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.CaseFileFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument> ShowCaseDocuments(global::Sungero.Docflow.ICaseFile caseFile)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IOfficialDocument>>(
          global::System.Guid.Parse("493bb59e-ae48-4cb5-ab66-071de5f890b0"),
          "ShowCaseDocuments(global::Sungero.Docflow.ICaseFile)"
          , caseFile);
      }

    }
  }
}

// ==================================================================
// CaseFileClientPublicFunctions.g.cs
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
  public class CaseFileClientPublicFunctions : global::Sungero.Docflow.Client.ICaseFileClientPublicFunctions
  {
  }
}

// ==================================================================
// CaseFileActions.g.cs
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
  public partial class CaseFileActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.ICaseFile _obj { get { return (global::Sungero.Docflow.ICaseFile)this.Entity; } }
    public CaseFileActions(global::Sungero.Docflow.ICaseFile entity) : base(entity) { }
  }

  public partial class CaseFileCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.ICaseFile> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.ICaseFile>(this.Entities); }
    }
  }

  public partial class CaseFileAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class CaseFileAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }

}
