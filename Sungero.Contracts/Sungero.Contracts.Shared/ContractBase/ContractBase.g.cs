
// ==================================================================
// ContractBaseState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractBaseState : 
    global::Sungero.Contracts.Shared.ContractualDocumentState, global::Sungero.Contracts.IContractBaseState
  {
    public ContractBaseState(global::Sungero.Contracts.IContractBase entity) : base(entity) { }

    public new global::Sungero.Contracts.IContractBasePropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IContractBasePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.ContractBasePropertyStates(entity);
    }


    public new global::Sungero.Contracts.IContractBaseControlStates Controls
    {
      get { return (global::Sungero.Contracts.IContractBaseControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.ContractBaseControlStates(entity);
    }

    public new global::Sungero.Contracts.IContractBasePageStates Pages
    {
      get { return (global::Sungero.Contracts.IContractBasePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.ContractBasePageStates(entity);
    }

  }


  public class ContractBaseControlStates : 
    global::Sungero.Contracts.Shared.ContractualDocumentControlStates, global::Sungero.Contracts.IContractBaseControlStates
  {

    protected internal ContractBaseControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ContractBasePageStates : 
    global::Sungero.Contracts.Shared.ContractualDocumentPageStates, global::Sungero.Contracts.IContractBasePageStates
  {

    protected internal ContractBasePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ContractBasePropertyStates : 
    global::Sungero.Contracts.Shared.ContractualDocumentPropertyStates, global::Sungero.Contracts.IContractBasePropertyStates
  {
            public new global::Sungero.Contracts.IContractBaseVersionsCollectionPropertyState<global::Sungero.Contracts.IContractBaseVersions> Versions
            {
              get { return (global::Sungero.Contracts.IContractBaseVersionsCollectionPropertyState<global::Sungero.Contracts.IContractBaseVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Contracts.Shared.ContractBaseVersionsCollectionPropertyState<global::Sungero.Contracts.IContractBaseVersions>(entity, propertyName);
            }
            public new global::Sungero.Contracts.IContractBaseTrackingCollectionPropertyState<global::Sungero.Contracts.IContractBaseTracking> Tracking
            {
              get { return (global::Sungero.Contracts.IContractBaseTrackingCollectionPropertyState<global::Sungero.Contracts.IContractBaseTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Contracts.Shared.ContractBaseTrackingCollectionPropertyState<global::Sungero.Contracts.IContractBaseTracking>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsAutomaticRenewal 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsAutomaticRenewal"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> DaysToFinishWorks 
            {
              get { return this.GetPropertyState<global::System.Int32?>("DaysToFinishWorks"); }
            }
            public new global::Sungero.Contracts.IContractBaseStagesCollectionPropertyState<global::Sungero.Contracts.IContractBaseStages> Milestones
            {
              get { return (global::Sungero.Contracts.IContractBaseStagesCollectionPropertyState<global::Sungero.Contracts.IContractBaseStages>)base.Milestones; }
            }

            protected override global::Sungero.Contracts.IContractualDocumentMilestonesCollectionPropertyState<global::Sungero.Contracts.IContractualDocumentMilestones> CreateMilestonesState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Contracts.Shared.ContractBaseStagesCollectionPropertyState<global::Sungero.Contracts.IContractBaseStages>(entity, propertyName);
            }


    protected internal ContractBasePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ContractBaseEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{  
}

// ==================================================================
// ContractBaseInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractBaseInfo : 
    global::Sungero.Contracts.Shared.ContractualDocumentInfo, global::Sungero.Contracts.IContractBaseInfo
  {
    public ContractBaseInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.IContractBasePropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.IContractBasePropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Contracts.IContractBaseActionsInfo Actions
    {
      get { return (global::Sungero.Contracts.IContractBaseActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.ContractBasePropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.ContractBaseActionsInfo(entityType);
    }
  }

  public class ContractBasePropertiesInfo : 
    global::Sungero.Contracts.Shared.ContractualDocumentPropertiesInfo, global::Sungero.Contracts.IContractBasePropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Contracts.IContractBaseVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Contracts.IContractBaseVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Contracts.IContractBaseTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Contracts.IContractBaseTrackingPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsAutomaticRenewal 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsAutomaticRenewal");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo DaysToFinishWorks 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("DaysToFinishWorks");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Contracts.IContractBaseStagesPropertiesInfo> Milestones
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Milestones");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Contracts.IContractBaseStagesPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal ContractBasePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ContractBaseActionsInfo : 
    global::Sungero.Contracts.Shared.ContractualDocumentActionsInfo, global::Sungero.Contracts.IContractBaseActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo CreateSupAgreement 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateSupAgreement")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo CreateContractStatement 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("CreateContractStatement")); }
        }


    protected internal ContractBaseActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ContractBaseHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts
{
  public partial class ContractBaseSharedHandlers : global::Sungero.Contracts.ContractualDocumentSharedHandlers
  {
    private global::Sungero.Contracts.IContractBase _obj
    {
      get { return (global::Sungero.Contracts.IContractBase)this.Entity; }
    }


    public ContractBaseSharedHandlers(global::Sungero.Contracts.IContractBase entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ContractBaseResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared.ContractBase
{
  /// <summary>
  /// Represents ContractBase resources.
  /// </summary>
  public class ContractBaseResources : global::Sungero.Contracts.Shared.ContractualDocument.ContractualDocumentResources, global::Sungero.Contracts.ContractBase.IContractBaseResources
  {
    public virtual global::CommonLibrary.LocalizedString NamePartForContractor
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "NamePartForContractor");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NamePartForContractorFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "NamePartForContractor", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString IncorrectReminder
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "IncorrectReminder");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IncorrectReminderFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "IncorrectReminder", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString IncorrectValidDates
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "IncorrectValidDates");
      }
    }

    public virtual global::CommonLibrary.LocalizedString IncorrectValidDatesFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "IncorrectValidDates", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Counterparty
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "Counterparty");
      }
    }

    public virtual global::CommonLibrary.LocalizedString CounterpartyFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "Counterparty", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Subject
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "Subject");
      }
    }

    public virtual global::CommonLibrary.LocalizedString SubjectFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "Subject", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Validity
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "Validity");
      }
    }

    public virtual global::CommonLibrary.LocalizedString ValidityFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "Validity", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Note
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "Note");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NoteFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "Note", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString isStandartContract
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "isStandartContract");
      }
    }

    public virtual global::CommonLibrary.LocalizedString isStandartContractFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "isStandartContract", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString isNotStandartContract
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "isNotStandartContract");
      }
    }

    public virtual global::CommonLibrary.LocalizedString isNotStandartContractFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "isNotStandartContract", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Renewal
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "Renewal");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RenewalFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "Renewal", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString Till
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "Till");
      }
    }

    public virtual global::CommonLibrary.LocalizedString TillFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "Till", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString From
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "From");
      }
    }

    public virtual global::CommonLibrary.LocalizedString FromFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "From", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString NoLicenceCreateSupAgreement
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "NoLicenceCreateSupAgreement");
      }
    }

    public virtual global::CommonLibrary.LocalizedString NoLicenceCreateSupAgreementFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "NoLicenceCreateSupAgreement", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DaysToFinishTooMatch
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "DaysToFinishTooMatch");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DaysToFinishTooMatchFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "DaysToFinishTooMatch", false, args);
    }
    public virtual global::CommonLibrary.LocalizedString DocumentAlreadyFinish
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase) , "DocumentAlreadyFinish");
      }
    }

    public virtual global::CommonLibrary.LocalizedString DocumentAlreadyFinishFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Contracts.IContractBase), "DocumentAlreadyFinish", false, args);
    }

  }
}

// ==================================================================
// ContractBaseSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Contracts.Shared
{
  public partial class ContractBaseFunctions : global::Sungero.Contracts.Shared.ContractualDocumentFunctions
  {
    private global::Sungero.Contracts.IContractBase _obj
    {
      get { return (global::Sungero.Contracts.IContractBase)this.Entity; }
    }

    public ContractBaseFunctions(global::Sungero.Contracts.IContractBase entity) : base(entity) { }
  }
}

// ==================================================================
// ContractBaseFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Functions
{
  internal static class ContractBase
  {
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.Contracts.IContractBase contract, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty)
    {
      return global::Sungero.Contracts.Shared.ContractBaseFunctions.HaveDuplicates(contract, businessUnit, registrationNumber, registrationDate, counterparty);
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void ChangeDocumentPropertiesAccess(global::Sungero.Contracts.IContractBase contractBase, global::System.Boolean isEnabled, global::System.Boolean isRepeatRegister)
    {
      var functions = (global::Sungero.Contracts.Shared.ContractBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
    functions.ChangeDocumentPropertiesAccess(isEnabled, isRepeatRegister);
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.String GetNamePartByContract(global::Sungero.Contracts.IContractualDocument contract)
    {
      return global::Sungero.Contracts.Shared.ContractBaseFunctions.GetNamePartByContract(contract);
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.String GetContractNamePart(global::Sungero.Contracts.IContractBase contract)
    {
      return global::Sungero.Contracts.Shared.ContractBaseFunctions.GetContractNamePart(contract);
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void SetObsolete(global::Sungero.Contracts.IContractBase contractBase, global::System.Boolean isActive)
    {
      var functions = (global::Sungero.Contracts.Shared.ContractBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
    functions.SetObsolete(isActive);
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void FillName(global::Sungero.Contracts.IContractBase contractBase)
    {
      var functions = (global::Sungero.Contracts.Shared.ContractBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
    functions.FillName();
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Contracts.IContractBase contractBase)
    {
      var functions = (global::Sungero.Contracts.Shared.ContractBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
    functions.SetRequiredProperties();
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.Boolean CheckRegistrationNumberUnique(global::Sungero.Contracts.IContractBase contractBase)
    {
      var functions = (global::Sungero.Contracts.Shared.ContractBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      return functions.CheckRegistrationNumberUnique();
    }
    /// <redirect project="Sungero.Contracts.Shared" type="Sungero.Contracts.Shared.ContractBaseFunctions" />
    internal static  global::System.Boolean HasEmptyRequiredProperties(global::Sungero.Contracts.IContractBase contractBase)
    {
      var functions = (global::Sungero.Contracts.Shared.ContractBaseFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contractBase).FunctionsContainer.SharedFunctions;
      return functions.HasEmptyRequiredProperties();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
      internal static  global::System.Linq.IQueryable<global::Sungero.Contracts.IContractBase> GetDuplicates(global::Sungero.Contracts.IContractBase contract, global::Sungero.Company.IBusinessUnit businessUnit, global::System.String registrationNumber, global::System.Nullable<global::System.DateTime> registrationDate, global::Sungero.Parties.ICounterparty counterparty)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Contracts.IContractBase>>(
          global::System.Guid.Parse("306da7fa-dc27-437c-bb83-42c92436b7e2"),
          "GetDuplicates(global::Sungero.Contracts.IContractBase,global::Sungero.Company.IBusinessUnit,global::System.String,global::System.Nullable<global::System.DateTime>,global::Sungero.Parties.ICounterparty)"
      , contract, businessUnit, registrationNumber, registrationDate, counterparty);
      }
      /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
      internal static  global::System.String GetNamePartByContractIgnoreAccessRights(global::System.Int32 contractId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("306da7fa-dc27-437c-bb83-42c92436b7e2"),
          "GetNamePartByContractIgnoreAccessRights(global::System.Int32)"
      , contractId);
      }
      /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase> GetApprovalRules(global::Sungero.Contracts.IContractBase contractBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IApprovalRuleBase>>(
          global::System.Guid.Parse("306da7fa-dc27-437c-bb83-42c92436b7e2"),
          "GetApprovalRules(global::Sungero.Contracts.IContractBase)"
          , contractBase);
      }
      /// <redirect project="Sungero.Contracts.Server" type="Sungero.Contracts.Server.ContractBaseFunctions" />
      internal static global::System.String  GetDocumentSummary(global::Sungero.Contracts.IContractBase contractBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("306da7fa-dc27-437c-bb83-42c92436b7e2"),
          "GetDocumentSummary(global::Sungero.Contracts.IContractBase)"
          , contractBase);
      }

    }
  }
}

// ==================================================================
// ContractBaseFilterState.g.cs
// ==================================================================

namespace Sungero.Contracts.Shared.ContractBase
{

  public class ContractBaseFilterInfo : global::Sungero.Contracts.Shared.ContractualDocument.ContractualDocumentFilterInfo,
    global::Sungero.Contracts.IContractBaseFilterInfo
  {
  }

  public class ContractBaseFilterState : global::Sungero.Contracts.Shared.ContractualDocument.ContractualDocumentFilterState,
    global::Sungero.Contracts.IContractBaseFilterState
  {



    public new Sungero.Contracts.IContractBaseFilterInfo Info
    {
      get
      {
        return (Sungero.Contracts.IContractBaseFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Contracts.Shared.ContractBase.ContractBaseFilterInfo();
    }

  }
}

// ==================================================================
// ContractBaseSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class ContractBaseSharedPublicFunctions : global::Sungero.Contracts.Shared.IContractBaseSharedPublicFunctions
  {
    public global::System.String GetContractNamePart(global::Sungero.Contracts.IContractBase contract)
    {
      return global::Sungero.Contracts.Functions.ContractBase.GetContractNamePart(contract);
    }
  }
}
