
// ==================================================================
// MailDeliveryMethodState.g.cs
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
  public class MailDeliveryMethodState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Docflow.IMailDeliveryMethodState
  {
    public MailDeliveryMethodState(global::Sungero.Docflow.IMailDeliveryMethod entity) : base(entity) { }

    public new global::Sungero.Docflow.IMailDeliveryMethodPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IMailDeliveryMethodPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.MailDeliveryMethodPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IMailDeliveryMethodControlStates Controls
    {
      get { return (global::Sungero.Docflow.IMailDeliveryMethodControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.MailDeliveryMethodControlStates(entity);
    }

    public new global::Sungero.Docflow.IMailDeliveryMethodPageStates Pages
    {
      get { return (global::Sungero.Docflow.IMailDeliveryMethodPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.MailDeliveryMethodPageStates(entity);
    }

  }


  public class MailDeliveryMethodControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Docflow.IMailDeliveryMethodControlStates
  {

    protected internal MailDeliveryMethodControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class MailDeliveryMethodPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Docflow.IMailDeliveryMethodPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal MailDeliveryMethodPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class MailDeliveryMethodPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Docflow.IMailDeliveryMethodPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Sid 
            {
              get { return this.GetPropertyState<global::System.String>("Sid"); }
            }


    protected internal MailDeliveryMethodPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// MailDeliveryMethodEventArgs.g.cs
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
// MailDeliveryMethodInfo.g.cs
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
  public class MailDeliveryMethodInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Docflow.IMailDeliveryMethodInfo
  {
    public MailDeliveryMethodInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IMailDeliveryMethodPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IMailDeliveryMethodPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.MailDeliveryMethodPropertiesInfo(entityType);
    }

  }

  public class MailDeliveryMethodPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Docflow.IMailDeliveryMethodPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Note 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Note");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Sid 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Sid");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal MailDeliveryMethodPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// MailDeliveryMethodHandlers.g.cs
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
  public partial class MailDeliveryMethodSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers
  {
    private global::Sungero.Docflow.IMailDeliveryMethod _obj
    {
      get { return (global::Sungero.Docflow.IMailDeliveryMethod)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void SidChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }




    public MailDeliveryMethodSharedHandlers(global::Sungero.Docflow.IMailDeliveryMethod entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// MailDeliveryMethodResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.MailDeliveryMethod
{
  /// <summary>
  /// Represents MailDeliveryMethod resources.
  /// </summary>
  public class MailDeliveryMethodResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Docflow.MailDeliveryMethod.IMailDeliveryMethodResources
  {
    public virtual global::CommonLibrary.LocalizedString ExchangeMethod
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod) , "ExchangeMethod");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ExchangeMethodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod), "ExchangeMethod", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString MailMethod
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod) , "MailMethod");
      }
    }

    public virtual global::CommonLibrary.LocalizedString MailMethodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod), "MailMethod", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString CourierMethod
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod) , "CourierMethod");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CourierMethodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod), "CourierMethod", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString FaxMethod
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod) , "FaxMethod");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FaxMethodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod), "FaxMethod", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString EmailMethod
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod) , "EmailMethod");
      }
    }

    public virtual global::CommonLibrary.LocalizedString EmailMethodFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Docflow.IMailDeliveryMethod), "EmailMethod", false, args);
    }

  }
}

// ==================================================================
// MailDeliveryMethodSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class MailDeliveryMethodFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IMailDeliveryMethod _obj
    {
      get { return (global::Sungero.Docflow.IMailDeliveryMethod)this.Entity; }
    }

    public MailDeliveryMethodFunctions(global::Sungero.Docflow.IMailDeliveryMethod entity) : base(entity) { }
  }
}

// ==================================================================
// MailDeliveryMethodFunctions.g.cs
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
  internal static class MailDeliveryMethod
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.MailDeliveryMethodFunctions" />
      internal static  global::Sungero.Docflow.IMailDeliveryMethod GetExchangeDeliveryMethod()
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.Docflow.IMailDeliveryMethod>(
          global::System.Guid.Parse("276d7e4a-ea11-4740-af17-893abc6bc6e9"),
          "GetExchangeDeliveryMethod()"
      );
      }

    }
  }
}

// ==================================================================
// MailDeliveryMethodFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.MailDeliveryMethod
{

  public class MailDeliveryMethodFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Docflow.IMailDeliveryMethodFilterInfo
  {
  }

  public class MailDeliveryMethodFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Docflow.IMailDeliveryMethodFilterState
  {



    public new Sungero.Docflow.IMailDeliveryMethodFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IMailDeliveryMethodFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.MailDeliveryMethod.MailDeliveryMethodFilterInfo();
    }

  }
}

// ==================================================================
// MailDeliveryMethodSharedPublicFunctions.g.cs
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
  public class MailDeliveryMethodSharedPublicFunctions : global::Sungero.Docflow.Shared.IMailDeliveryMethodSharedPublicFunctions
  {
    public global::Sungero.Docflow.IMailDeliveryMethod Remote_GetExchangeDeliveryMethod()
    {
      return global::Sungero.Docflow.Functions.MailDeliveryMethod.Remote.GetExchangeDeliveryMethod();
    }
  }
}
