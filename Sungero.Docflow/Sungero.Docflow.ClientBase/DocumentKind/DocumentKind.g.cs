
// ==================================================================
// DocumentKindEventArgs.g.cs
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
  public class DocumentKindDocumentTypeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IDocumentType>
  {
    public DocumentKindDocumentTypeValueInputEventArgs(global::Sungero.Docflow.IDocumentType oldValue, global::Sungero.Docflow.IDocumentType newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






}

// ==================================================================
// DocumentKindHandlers.g.cs
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

  public partial class DocumentKindFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IDocumentKindFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDocumentKindFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DocumentKindFilteringClientHandler(global::Sungero.Docflow.IDocumentKindFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DocumentKindFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DocumentKindClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void DocumentFlowValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void ShortNameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void NumberingTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual void GenerateDocumentNameValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void AutoNumberingValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }





    public virtual void GrantRightsToProjectValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }


    public virtual void IsDefaultValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }



    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> DocumentFlowFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }















    public DocumentKindClientHandlers(global::Sungero.Docflow.IDocumentKind entity) : base(entity)
    {
    }
  }

  public partial class DocumentKindAvailableActionsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IDocumentKindAvailableActions _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKindAvailableActions)this.Entity; }
    }
    public virtual void AvailableActionsActionValueInput(global::Sungero.Docflow.Client.DocumentKindAvailableActionsActionValueInputEventArgs e) { }


    public DocumentKindAvailableActionsClientHandlers(global::Sungero.Docflow.IDocumentKindAvailableActions entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DocumentKindClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class DocumentKindFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentKind _obj
    {
      get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; }
    }

    public DocumentKindFunctions(global::Sungero.Docflow.IDocumentKind entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentKindFunctions.g.cs
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
  internal static class DocumentKind
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Nullable<global::System.DateTime> GetConsiderationDate(global::Sungero.Docflow.IDocumentKind documentKind, global::Sungero.CoreEntities.IUser user)
    {
      return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetConsiderationDate(documentKind, user);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetAvailableDocumentKinds(System.Type documentType)
    {
      return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetAvailableDocumentKinds(documentType);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.DocumentKindFunctions" />
    internal static  global::System.Collections.Generic.List<global::System.String> GetDocumentGuids(System.Type documentType)
    {
      return global::Sungero.Docflow.Shared.DocumentKindFunctions.GetDocumentGuids(documentType);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
      internal static  global::Sungero.Docflow.IDocumentKind GetNativeDocumentKindRemote(global::System.Guid externalLink)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IDocumentKind>(
          global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c"),
          "GetNativeDocumentKindRemote(global::System.Guid)"
      , externalLink);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.DocumentKindFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind> GetDocumentKinds()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.IDocumentKind>>(
          global::System.Guid.Parse("14a59623-89a2-4ea8-b6e9-2ad4365f358c"),
          "GetDocumentKinds()"
      );
      }

    }
  }
}

// ==================================================================
// DocumentKindClientPublicFunctions.g.cs
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
  public class DocumentKindClientPublicFunctions : global::Sungero.Docflow.Client.IDocumentKindClientPublicFunctions
  {
  }
}

// ==================================================================
// DocumentKindActions.g.cs
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
  public partial class DocumentKindActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.IDocumentKind _obj { get { return (global::Sungero.Docflow.IDocumentKind)this.Entity; } }
    public DocumentKindActions(global::Sungero.Docflow.IDocumentKind entity) : base(entity) { }
  }

  public partial class DocumentKindCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IDocumentKind> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IDocumentKind>(this.Entities); }
    }
  }

  public partial class DocumentKindAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class DocumentKindAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }

}