
// ==================================================================
// BlobState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class BlobState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.SmartProcessing.IBlobState
  {
    public BlobState(global::Sungero.SmartProcessing.IBlob entity) : base(entity) { }

    public new global::Sungero.SmartProcessing.IBlobPropertyStates Properties
    {
      get { return (global::Sungero.SmartProcessing.IBlobPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPropertyStates(entity);
    }


    public new global::Sungero.SmartProcessing.IBlobControlStates Controls
    {
      get { return (global::Sungero.SmartProcessing.IBlobControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.BlobControlStates(entity);
    }

    public new global::Sungero.SmartProcessing.IBlobPageStates Pages
    {
      get { return (global::Sungero.SmartProcessing.IBlobPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPageStates(entity);
    }

  }


  public class BlobControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.SmartProcessing.IBlobControlStates
  {

    protected internal BlobControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class BlobPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.SmartProcessing.IBlobPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal BlobPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class BlobPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.SmartProcessing.IBlobPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> FilePath 
            {
              get { return this.GetPropertyState<global::System.String>("FilePath"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> OriginalFileName 
            {
              get { return this.GetPropertyState<global::System.String>("OriginalFileName"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState ArioResultJson 
            {
              get { return this.GetDataPropertyState("ArioResultJson"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Body 
            {
              get { return this.GetDataPropertyState("Body"); }
            }


    protected internal BlobPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// BlobEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{  
}

// ==================================================================
// BlobInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class BlobInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.SmartProcessing.IBlobInfo
  {
    public BlobInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.SmartProcessing.IBlobPropertiesInfo Properties
    {
      get { return (global::Sungero.SmartProcessing.IBlobPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPropertiesInfo(entityType);
    }

  }

  public class BlobPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.SmartProcessing.IBlobPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo FilePath 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("FilePath");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo OriginalFileName 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("OriginalFileName");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo ArioResultJson 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("ArioResultJson");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBinaryDataPropertyInfo Body 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BinaryDataPropertyMetadata>("Body");
             return new global::Sungero.Domain.Shared.BinaryDataPropertyInfo(propertyMetadata);
          }
        }


    protected internal BlobPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// BlobHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{
  public partial class BlobSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers
  {
    private global::Sungero.SmartProcessing.IBlob _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlob)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void FilePathChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void OriginalFileNameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ArioResultJsonChanged(global::Sungero.Domain.Shared.TextPropertyChangedEventArgs e) { }


    public virtual void BodyChanged(global::Sungero.Domain.Shared.BinaryDataPropertyChangedEventArgs e) { }




    public BlobSharedHandlers(global::Sungero.SmartProcessing.IBlob entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// BlobResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared.Blob
{
  /// <summary>
  /// Represents Blob resources.
  /// </summary>
  public class BlobResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.SmartProcessing.Blob.IBlobResources
  {
  }
}

// ==================================================================
// BlobSharedFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Shared
{
  public partial class BlobFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.SmartProcessing.IBlob _obj
    {
      get { return (global::Sungero.SmartProcessing.IBlob)this.Entity; }
    }

    public BlobFunctions(global::Sungero.SmartProcessing.IBlob entity) : base(entity) { }
  }
}

// ==================================================================
// BlobFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class Blob
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.BlobFunctions" />
      internal static  global::Sungero.SmartProcessing.IBlob CreateBlob()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.SmartProcessing.IBlob>(
          global::System.Guid.Parse("668418c4-bd08-4aeb-94d7-d0c30869c1a0"),
          "CreateBlob()"
      );
      }

    }
  }
}

// ==================================================================
// BlobFilterState.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Shared.Blob
{

  public class BlobFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.SmartProcessing.IBlobFilterInfo
  {
  }

  public class BlobFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.SmartProcessing.IBlobFilterState
  {



    public new Sungero.SmartProcessing.IBlobFilterInfo Info
    {
      get
      {
        return (Sungero.SmartProcessing.IBlobFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.SmartProcessing.Shared.Blob.BlobFilterInfo();
    }

  }
}

// ==================================================================
// BlobSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class BlobSharedPublicFunctions : global::Sungero.SmartProcessing.Shared.IBlobSharedPublicFunctions
  {
    public global::Sungero.SmartProcessing.IBlob Remote_CreateBlob()
    {
      return global::Sungero.SmartProcessing.Functions.Blob.Remote.CreateBlob();
    }
  }
}