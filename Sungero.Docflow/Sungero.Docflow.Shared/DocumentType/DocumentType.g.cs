
// ==================================================================
// DocumentTypeState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class DocumentTypeState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Docflow.IDocumentTypeState
  {
    public DocumentTypeState(global::Sungero.Docflow.IDocumentType entity) : base(entity) { }

    public new global::Sungero.Docflow.IDocumentTypePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IDocumentTypePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentTypePropertyStates(entity);
    }


    public new global::Sungero.Docflow.IDocumentTypeControlStates Controls
    {
      get { return (global::Sungero.Docflow.IDocumentTypeControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentTypeControlStates(entity);
    }

    public new global::Sungero.Docflow.IDocumentTypePageStates Pages
    {
      get { return (global::Sungero.Docflow.IDocumentTypePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.DocumentTypePageStates(entity);
    }

  }


  public class DocumentTypeControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Docflow.IDocumentTypeControlStates
  {

    protected internal DocumentTypeControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class DocumentTypePageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Docflow.IDocumentTypePageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal DocumentTypePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DocumentTypePropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Docflow.IDocumentTypePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> DocumentTypeGuid 
            {
              get { return this.GetPropertyState<global::System.String>("DocumentTypeGuid"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> DocumentFlow 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("DocumentFlow"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsRegistrationAllowed 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsRegistrationAllowed"); }
            }


    protected internal DocumentTypePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// DocumentTypeEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{  
}

// ==================================================================
// DocumentTypeInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class DocumentTypeInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Docflow.IDocumentTypeInfo
  {
    public DocumentTypeInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IDocumentTypePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IDocumentTypePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.DocumentTypePropertiesInfo(entityType);
    }

  }

  public class DocumentTypePropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Docflow.IDocumentTypePropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo DocumentTypeGuid 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("DocumentTypeGuid");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo DocumentFlow 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("DocumentFlow");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsRegistrationAllowed 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsRegistrationAllowed");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }


    protected internal DocumentTypePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// DocumentTypeHandlers.g.cs
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
  public partial class DocumentTypeSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers
  {
    private global::Sungero.Docflow.IDocumentType _obj
    {
      get { return (global::Sungero.Docflow.IDocumentType)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void DocumentTypeGuidChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void DocumentFlowChanged(global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs e) { }


    public virtual void IsRegistrationAllowedChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }




    public DocumentTypeSharedHandlers(global::Sungero.Docflow.IDocumentType entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DocumentTypeResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.DocumentType
{
  /// <summary>
  /// Represents DocumentType resources.
  /// </summary>
  public class DocumentTypeResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Docflow.DocumentType.IDocumentTypeResources
  {
  }
}

// ==================================================================
// DocumentTypeSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class DocumentTypeFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IDocumentType _obj
    {
      get { return (global::Sungero.Docflow.IDocumentType)this.Entity; }
    }

    public DocumentTypeFunctions(global::Sungero.Docflow.IDocumentType entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentTypeFunctions.g.cs
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
  internal static class DocumentType
  {
  }
}

// ==================================================================
// DocumentTypeFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.DocumentType
{

  public class DocumentTypeFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Docflow.IDocumentTypeFilterInfo
  {
  }

  public class DocumentTypeFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Docflow.IDocumentTypeFilterState
  {



    public new Sungero.Docflow.IDocumentTypeFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IDocumentTypeFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.DocumentType.DocumentTypeFilterInfo();
    }

  }
}

// ==================================================================
// DocumentTypeSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class DocumentTypeSharedPublicFunctions : global::Sungero.Docflow.Shared.IDocumentTypeSharedPublicFunctions
  {
  }
}