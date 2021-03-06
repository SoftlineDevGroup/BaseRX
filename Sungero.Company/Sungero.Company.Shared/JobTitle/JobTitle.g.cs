
// ==================================================================
// JobTitleState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class JobTitleState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Company.IJobTitleState
  {
    public JobTitleState(global::Sungero.Company.IJobTitle entity) : base(entity) { }

    public new global::Sungero.Company.IJobTitlePropertyStates Properties
    {
      get { return (global::Sungero.Company.IJobTitlePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.JobTitlePropertyStates(entity);
    }


    public new global::Sungero.Company.IJobTitleControlStates Controls
    {
      get { return (global::Sungero.Company.IJobTitleControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.JobTitleControlStates(entity);
    }

    public new global::Sungero.Company.IJobTitlePageStates Pages
    {
      get { return (global::Sungero.Company.IJobTitlePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.JobTitlePageStates(entity);
    }

  }


  public class JobTitleControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Company.IJobTitleControlStates
  {

    protected internal JobTitleControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class JobTitlePageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Company.IJobTitlePageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal JobTitlePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class JobTitlePropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Company.IJobTitlePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }


    protected internal JobTitlePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// JobTitleEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{  
}

// ==================================================================
// JobTitleInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class JobTitleInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Company.IJobTitleInfo
  {
    public JobTitleInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Company.IJobTitlePropertiesInfo Properties
    {
      get { return (global::Sungero.Company.IJobTitlePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Company.Shared.JobTitlePropertiesInfo(entityType);
    }

  }

  public class JobTitlePropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Company.IJobTitlePropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal JobTitlePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// JobTitleHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{
  public partial class JobTitleSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers
  {
    private global::Sungero.Company.IJobTitle _obj
    {
      get { return (global::Sungero.Company.IJobTitle)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public JobTitleSharedHandlers(global::Sungero.Company.IJobTitle entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// JobTitleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared.JobTitle
{
  /// <summary>
  /// Represents JobTitle resources.
  /// </summary>
  public class JobTitleResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Company.JobTitle.IJobTitleResources
  {
    public virtual global::CommonLibrary.LocalizedString JobTitleNameAlreadyExists
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Company.IJobTitle) , "JobTitleNameAlreadyExists");
      }
    }

    public virtual global::CommonLibrary.LocalizedString JobTitleNameAlreadyExistsFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Company.IJobTitle), "JobTitleNameAlreadyExists", false, args);
    }

  }
}

// ==================================================================
// JobTitleSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Company.Shared
{
  public partial class JobTitleFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Company.IJobTitle _obj
    {
      get { return (global::Sungero.Company.IJobTitle)this.Entity; }
    }

    public JobTitleFunctions(global::Sungero.Company.IJobTitle entity) : base(entity) { }
  }
}

// ==================================================================
// JobTitleFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Functions
{
  internal static class JobTitle
  {
  }
}

// ==================================================================
// JobTitleFilterState.g.cs
// ==================================================================

namespace Sungero.Company.Shared.JobTitle
{

  public class JobTitleFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Company.IJobTitleFilterInfo
  {
  }

  public class JobTitleFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Company.IJobTitleFilterState
  {



    public new Sungero.Company.IJobTitleFilterInfo Info
    {
      get
      {
        return (Sungero.Company.IJobTitleFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Company.Shared.JobTitle.JobTitleFilterInfo();
    }

  }
}

// ==================================================================
// JobTitleSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared
{
  public class JobTitleSharedPublicFunctions : global::Sungero.Company.Shared.IJobTitleSharedPublicFunctions
  {
  }
}
