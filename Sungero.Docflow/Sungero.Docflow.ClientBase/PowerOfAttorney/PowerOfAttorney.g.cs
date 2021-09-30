
// ==================================================================
// PowerOfAttorneyEventArgs.g.cs
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
  public class PowerOfAttorneyIssuedToValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Company.IEmployee>
  {
    public PowerOfAttorneyIssuedToValueInputEventArgs(global::Sungero.Company.IEmployee oldValue, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }


}

// ==================================================================
// PowerOfAttorneyHandlers.g.cs
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

  public partial class PowerOfAttorneyFilteringClientHandler
    : global::Sungero.Docflow.InternalDocumentBaseFilteringClientHandler
  {
    private global::Sungero.Docflow.IPowerOfAttorneyFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IPowerOfAttorneyFilterState)this.Filter;
      }
    }

    public PowerOfAttorneyFilteringClientHandler(global::Sungero.Docflow.IPowerOfAttorneyFilterState filter)
    : base(filter)
    {
    }

    protected PowerOfAttorneyFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class PowerOfAttorneyClientHandlers : global::Sungero.Docflow.InternalDocumentBaseClientHandlers
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public virtual void IssuedToValueInput(global::Sungero.Docflow.Client.PowerOfAttorneyIssuedToValueInputEventArgs e) { }



    public PowerOfAttorneyClientHandlers(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class PowerOfAttorneyFunctions : global::Sungero.Docflow.Client.InternalDocumentBaseFunctions
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj
    {
      get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; }
    }

    public PowerOfAttorneyFunctions(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyFunctions.g.cs
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
  internal static class PowerOfAttorney
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.PowerOfAttorneyFunctions" />
    internal static  global::System.String CheckCorrectnessDaysToFinishWorks(global::System.Nullable<global::System.DateTime> validTill, global::System.Nullable<global::System.Int32> daysToFinishWorks)
    {
      return global::Sungero.Docflow.Client.PowerOfAttorneyFunctions.CheckCorrectnessDaysToFinishWorks(validTill, daysToFinishWorks);
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyFunctions" />
    internal static  void FillName(global::Sungero.Docflow.IPowerOfAttorney powerOfAttorney)
    {
      var functions = (global::Sungero.Docflow.Shared.PowerOfAttorneyFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorney).FunctionsContainer.SharedFunctions;
    functions.FillName();
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IPowerOfAttorney powerOfAttorney, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var functions = (global::Sungero.Docflow.Shared.PowerOfAttorneyFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorney).FunctionsContainer.SharedFunctions;
    functions.ChangeRegistrationPaneVisibility(needShow, repeatRegister);
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.PowerOfAttorneyFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Docflow.IPowerOfAttorney powerOfAttorney, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var functions = (global::Sungero.Docflow.Shared.PowerOfAttorneyFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)powerOfAttorney).FunctionsContainer.SharedFunctions;
    functions.ChangeDocumentPropertiesAccess(isEnabled, isRepeatRegister);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting> GetSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorney powerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting>>(
          global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627"),
          "GetSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorney)"
          , powerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting> GetActiveSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorney powerOfAttorney)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Docflow.ISignatureSetting>>(
          global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627"),
          "GetActiveSignatureSettingsByPOA(global::Sungero.Docflow.IPowerOfAttorney)"
          , powerOfAttorney);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.PowerOfAttorneyFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney> GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee employee, global::System.Nullable<global::System.DateTime> date)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IPowerOfAttorney>>(
          global::System.Guid.Parse("be859f9b-7a04-4f07-82bc-441352bce627"),
          "GetActivePowerOfAttorneys(global::Sungero.Company.IEmployee,global::System.Nullable<global::System.DateTime>)"
      , employee, date);
      }

    }
  }
}

// ==================================================================
// PowerOfAttorneyClientPublicFunctions.g.cs
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
  public class PowerOfAttorneyClientPublicFunctions : global::Sungero.Docflow.Client.IPowerOfAttorneyClientPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyActions.g.cs
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
  public partial class PowerOfAttorneyActions : global::Sungero.Docflow.Client.InternalDocumentBaseActions
  {
    private global::Sungero.Docflow.IPowerOfAttorney _obj { get { return (global::Sungero.Docflow.IPowerOfAttorney)this.Entity; } }
    public PowerOfAttorneyActions(global::Sungero.Docflow.IPowerOfAttorney entity) : base(entity) { }
  }

  public partial class PowerOfAttorneyCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IPowerOfAttorney> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IPowerOfAttorney>(this.Entities); }
    }
  }

  public partial class PowerOfAttorneyAnyChildEntityActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityActions
  {
  }

  public partial class PowerOfAttorneyAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.InternalDocumentBaseAnyChildEntityCollectionActions
  {
  }

}
