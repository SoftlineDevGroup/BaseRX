
// ==================================================================
// SimpleDocumentEventArgs.g.cs
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
}

// ==================================================================
// SimpleDocumentHandlers.g.cs
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

  public partial class SimpleDocumentFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.ISimpleDocumentFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.ISimpleDocumentFilterState)this.Filter;
      }
    }

    public SimpleDocumentFilteringClientHandler(global::Sungero.Docflow.ISimpleDocumentFilterState filter)
    : base(filter)
    {
    }

    protected SimpleDocumentFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class SimpleDocumentClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Docflow.ISimpleDocument _obj
    {
      get { return (global::Sungero.Docflow.ISimpleDocument)this.Entity; }
    }

    public SimpleDocumentClientHandlers(global::Sungero.Docflow.ISimpleDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// SimpleDocumentClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class SimpleDocumentFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.ISimpleDocument _obj
    {
      get { return (global::Sungero.Docflow.ISimpleDocument)this.Entity; }
    }

    public SimpleDocumentFunctions(global::Sungero.Docflow.ISimpleDocument entity) : base(entity) { }
  }
}

// ==================================================================
// SimpleDocumentFunctions.g.cs
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
  internal static class SimpleDocument
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.SimpleDocumentFunctions" />
    internal static  global::System.Collections.Generic.List<Domain.Shared.IEntityInfo> GetTypesAvailableForChange(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var functions = (global::Sungero.Docflow.Client.SimpleDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.ClientFunctions;
      return functions.GetTypesAvailableForChange();
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.ISimpleDocument simpleDocument, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var functions = (global::Sungero.Docflow.Shared.SimpleDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
    functions.ChangeRegistrationPaneVisibility(needShow, repeatRegister);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.SimpleDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
    functions.SetRequiredProperties();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.SimpleDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
    functions.RefreshDocumentForm();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  global::System.Boolean IsVerificationModeSupported(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.SimpleDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      return functions.IsVerificationModeSupported();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.SimpleDocumentFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Docflow.ISimpleDocument simpleDocument)
    {
      var functions = (global::Sungero.Docflow.Shared.SimpleDocumentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)simpleDocument).FunctionsContainer.SharedFunctions;
      return functions.HasEmptyRequiredProperties();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.SimpleDocumentFunctions" />
      internal static  global::System.Boolean AnyApprovalTasksWithCurrentDocument(global::Sungero.Docflow.ISimpleDocument simpleDocument)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("09584896-81e2-4c83-8f6c-70eb8321e1d0"),
          "AnyApprovalTasksWithCurrentDocument(global::Sungero.Docflow.ISimpleDocument)"
          , simpleDocument);
      }

    }
  }
}

// ==================================================================
// SimpleDocumentClientPublicFunctions.g.cs
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
  public class SimpleDocumentClientPublicFunctions : global::Sungero.Docflow.Client.ISimpleDocumentClientPublicFunctions
  {
  }
}

// ==================================================================
// SimpleDocumentActions.g.cs
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
  public partial class SimpleDocumentActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Docflow.ISimpleDocument _obj { get { return (global::Sungero.Docflow.ISimpleDocument)this.Entity; } }
    public SimpleDocumentActions(global::Sungero.Docflow.ISimpleDocument entity) : base(entity) { }
  }

  public partial class SimpleDocumentCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.ISimpleDocument> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.ISimpleDocument>(this.Entities); }
    }
  }

  public partial class SimpleDocumentAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class SimpleDocumentAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }

}
