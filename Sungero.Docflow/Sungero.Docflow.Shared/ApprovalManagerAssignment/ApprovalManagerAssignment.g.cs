
// ==================================================================
// ApprovalManagerAssignmentState.g.cs
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
  public class ApprovalManagerAssignmentState : 
    global::Sungero.Workflow.Shared.AssignmentState, global::Sungero.Docflow.IApprovalManagerAssignmentState
  {
    public ApprovalManagerAssignmentState(global::Sungero.Docflow.IApprovalManagerAssignment entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentPropertyStates(entity);
    }


    public new global::Sungero.Docflow.IApprovalManagerAssignmentControlStates Controls
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentControlStates(entity);
    }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentPageStates Pages
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentPageStates(entity);
    }

    #region Workflow attachments extention

    public global::Sungero.Docflow.IApprovalManagerAssignmentAttachmentStates Attachments { get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAttachmentStates)this.AttachmentStates; }}

      protected override global::Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentStates CreateAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) 
      {
        return new ApprovalManagerAssignmentAttachmentStates(entity);
      }

    #endregion
  }

  #region Workflow attachments extention

    public class ApprovalManagerAssignmentAttachmentStates :
      global::Sungero.Workflow.Shared.AssignmentAttachmentStates, global::Sungero.Docflow.IApprovalManagerAssignmentAttachmentStates
    {
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState AddendaGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("852b3e7d-f178-47d3-8fad-a64021065cfd"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState OtherGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("bd87e6b5-e247-485a-93bf-52f24a64af5a"));
        }
      }
      public global::Sungero.Workflow.Interfaces.IAttachmentGroupState DocumentGroup 
      {
        get
        {
          return this.AttachmentGroups.GetAttachmentGroupState(global::System.Guid.Parse("08e1ef90-521f-41a1-a13f-c6f175007e54"));
        }
      }


      protected internal ApprovalManagerAssignmentAttachmentStates(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity) { }
    }

  #endregion

  public class ApprovalManagerAssignmentControlStates : 
    global::Sungero.Workflow.Shared.AssignmentControlStates, global::Sungero.Docflow.IApprovalManagerAssignmentControlStates
  {
        public global::Sungero.Domain.Shared.IControlState DocumentSummary
        {
        get { return this.GetControlState(global::System.Guid.Parse("f64fec94-7476-4b46-834c-6e460e7bec02")); }
        }
        public global::Sungero.Domain.Shared.IControlState Control
        {
        get { return this.GetControlState(global::System.Guid.Parse("8ad82c7d-c4fe-42aa-b4ea-53e3a91c1bf8")); }
        }


    protected internal ApprovalManagerAssignmentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ApprovalManagerAssignmentPageStates : 
    global::Sungero.Workflow.Shared.AssignmentPageStates, global::Sungero.Docflow.IApprovalManagerAssignmentPageStates
  {
        public global::Sungero.Domain.Shared.IInplacePageState StatusStages
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IInplacePageState>("StatusStages"); }
        }


    protected internal ApprovalManagerAssignmentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalManagerAssignmentPropertyStates : 
    global::Sungero.Workflow.Shared.AssignmentPropertyStates, global::Sungero.Docflow.IApprovalManagerAssignmentPropertyStates
  {
            public global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversCollectionPropertyState<global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers> AddApprovers 
            {
              get { return this.GetPropertyState("AddApprovers", this.CreateAddApproversState); }
            }

            protected virtual global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversCollectionPropertyState<global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers> CreateAddApproversState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddApproversCollectionPropertyState<global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Signatory 
            {
              get { return this.InternalSignatory; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalSignatory
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Signatory"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> Stage 
            {
              get { return this.InternalStage; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> InternalStage
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalStage>("Stage"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> ApprovalRule 
            {
              get { return this.InternalApprovalRule; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> InternalApprovalRule
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IApprovalRuleBase>("ApprovalRule"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Addressee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> StageNumber 
            {
              get { return this.GetPropertyState<global::System.Int32?>("StageNumber"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> DeliveryMethod 
            {
              get { return this.InternalDeliveryMethod; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> InternalDeliveryMethod
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IMailDeliveryMethod>("DeliveryMethod"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IExchangeService> ExchangeService 
            {
              get { return this.InternalExchangeService; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IExchangeService> InternalExchangeService
            {
              get { return this.GetPropertyState<global::Sungero.ExchangeCore.IExchangeService>("ExchangeService"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> ReworkPerformer 
            {
              get { return this.InternalReworkPerformer; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalReworkPerformer
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("ReworkPerformer"); }
            }


    protected internal ApprovalManagerAssignmentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ApprovalManagerAssignmentEventArgs.g.cs
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
    public class ApprovalManagerAssignmentSignatoryChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public ApprovalManagerAssignmentSignatoryChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class ApprovalManagerAssignmentStageChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Docflow.IApprovalStage>
    {
      public ApprovalManagerAssignmentStageChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalStage> state, global::Sungero.Docflow.IApprovalStage newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class ApprovalManagerAssignmentApprovalRuleChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Docflow.IApprovalRuleBase>
    {
      public ApprovalManagerAssignmentApprovalRuleChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IApprovalRuleBase> state, global::Sungero.Docflow.IApprovalRuleBase newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class ApprovalManagerAssignmentAddresseeChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public ApprovalManagerAssignmentAddresseeChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }


    public class ApprovalManagerAssignmentDeliveryMethodChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Docflow.IMailDeliveryMethod>
    {
      public ApprovalManagerAssignmentDeliveryMethodChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> state, global::Sungero.Docflow.IMailDeliveryMethod newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class ApprovalManagerAssignmentExchangeServiceChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.ExchangeCore.IExchangeService>
    {
      public ApprovalManagerAssignmentExchangeServiceChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.ExchangeCore.IExchangeService> state, global::Sungero.ExchangeCore.IExchangeService newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class ApprovalManagerAssignmentReworkPerformerChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public ApprovalManagerAssignmentReworkPerformerChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

}

// ==================================================================
// ApprovalManagerAssignmentInfo.g.cs
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
  public class ApprovalManagerAssignmentInfo : 
    global::Sungero.Workflow.Shared.AssignmentInfo, global::Sungero.Docflow.IApprovalManagerAssignmentInfo
  {
    public ApprovalManagerAssignmentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentPropertiesInfo)base.Properties; }
    }

    public new global::Sungero.Docflow.IApprovalManagerAssignmentActionsInfo Actions
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentActionsInfo)base.Actions; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentPropertiesInfo(entityType);
    }

    protected override global::Sungero.Domain.Shared.IEntityActionsInfo CreateEntityActionsInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalManagerAssignmentActionsInfo(entityType);
    }
  }

  public class ApprovalManagerAssignmentPropertiesInfo : 
    global::Sungero.Workflow.Shared.AssignmentPropertiesInfo, global::Sungero.Docflow.IApprovalManagerAssignmentPropertiesInfo
  {
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversPropertiesInfo> AddApprovers 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("AddApprovers");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Docflow.IApprovalManagerAssignmentAddApproversPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Signatory 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Signatory");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage> Stage 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Stage");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalStageInfo, global::Sungero.Docflow.IApprovalStage>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleBaseInfo, global::Sungero.Docflow.IApprovalRuleBase> ApprovalRule 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ApprovalRule");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IApprovalRuleBaseInfo, global::Sungero.Docflow.IApprovalRuleBase>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo StageNumber 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("StageNumber");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IMailDeliveryMethodInfo, global::Sungero.Docflow.IMailDeliveryMethod> DeliveryMethod 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DeliveryMethod");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IMailDeliveryMethodInfo, global::Sungero.Docflow.IMailDeliveryMethod>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.ExchangeCore.IExchangeServiceInfo, global::Sungero.ExchangeCore.IExchangeService> ExchangeService 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ExchangeService");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.ExchangeCore.IExchangeServiceInfo, global::Sungero.ExchangeCore.IExchangeService>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> ReworkPerformer 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ReworkPerformer");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }


    protected internal ApprovalManagerAssignmentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

  public class ApprovalManagerAssignmentActionsInfo : 
    global::Sungero.Workflow.Shared.AssignmentActionsInfo, global::Sungero.Docflow.IApprovalManagerAssignmentActionsInfo
  {
        public global::Sungero.Domain.Shared.IActionInfo Approved 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("Approved")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ForRevision 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ForRevision")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ApprovalForm 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ApprovalForm")); }
        }
        public global::Sungero.Domain.Shared.IActionInfo ExtendDeadline 
        {
          get { return new global::Sungero.Domain.Shared.ActionInfo(this.GetActionMetadata("ExtendDeadline")); }
        }


    protected internal ApprovalManagerAssignmentActionsInfo(global::System.Type entityType) : base(entityType) { }
  }
}

// ==================================================================
// ApprovalManagerAssignmentHandlers.g.cs
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
  public partial class ApprovalManagerAssignmentSharedHandlers : global::Sungero.Workflow.AssignmentSharedHandlers
  {
    private global::Sungero.Docflow.IApprovalManagerAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignment)this.Entity; }
    }
    public virtual void StageChanged(global::Sungero.Docflow.Shared.ApprovalManagerAssignmentStageChangedEventArgs e) { }


    public virtual void ApprovalRuleChanged(global::Sungero.Docflow.Shared.ApprovalManagerAssignmentApprovalRuleChangedEventArgs e) { }


    public virtual void AddresseeChanged(global::Sungero.Docflow.Shared.ApprovalManagerAssignmentAddresseeChangedEventArgs e) { }


    public virtual void StageNumberChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }




    public virtual void ReworkPerformerChanged(global::Sungero.Docflow.Shared.ApprovalManagerAssignmentReworkPerformerChangedEventArgs e) { }



    #region Workflow attachments extention

        public virtual void AddendaGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void AddendaGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void AddendaGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void OtherGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void OtherGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void OtherGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }

        public virtual void DocumentGroupCreated(global::Sungero.Workflow.Interfaces.AttachmentCreatedEventArgs e) { }
        public virtual void DocumentGroupAdded(global::Sungero.Workflow.Interfaces.AttachmentAddedEventArgs e) { }
        public virtual void DocumentGroupDeleted(global::Sungero.Workflow.Interfaces.AttachmentDeletedEventArgs e) { }


    #endregion

    public ApprovalManagerAssignmentSharedHandlers(global::Sungero.Docflow.IApprovalManagerAssignment entity) : base(entity)
    {
    }
  }

  public partial class ApprovalManagerAssignmentAddApproversSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers
  {
    private global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers _obj
    { 
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers)this.Entity; }
    }

    public ApprovalManagerAssignmentAddApproversSharedHandlers(global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers entity) : base(entity)
    {
    }
  }

  public partial class ApprovalManagerAssignmentAddApproversSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Docflow.IApprovalManagerAssignment _obj
    { 
      get { return (global::Sungero.Docflow.IApprovalManagerAssignment)this.Entity; }
    }

    private global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers _added
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers)this._Added; }
    }

    private global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers _deleted
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers)this._Deleted; }
    }

    private global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers _source
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignmentAddApprovers)this._Source; }
    }

    public virtual void AddApproversAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void AddApproversDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public ApprovalManagerAssignmentAddApproversSharedCollectionHandlers(global::Sungero.Docflow.IApprovalManagerAssignment entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// ApprovalManagerAssignmentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ApprovalManagerAssignment
{
  /// <summary>
  /// Represents ApprovalManagerAssignment resources.
  /// </summary>
  public class ApprovalManagerAssignmentResources : global::Sungero.Workflow.Shared.Assignment.AssignmentResources, global::Sungero.Docflow.ApprovalManagerAssignment.IApprovalManagerAssignmentResources
  {
  }
}

// ==================================================================
// ApprovalManagerAssignmentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ApprovalManagerAssignmentFunctions : global::Sungero.Workflow.Shared.AssignmentFunctions
  {
    private global::Sungero.Docflow.IApprovalManagerAssignment _obj
    {
      get { return (global::Sungero.Docflow.IApprovalManagerAssignment)this.Entity; }
    }

    public ApprovalManagerAssignmentFunctions(global::Sungero.Docflow.IApprovalManagerAssignment entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalManagerAssignmentFunctions.g.cs
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
  internal static class ApprovalManagerAssignment
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.ApprovalManagerAssignmentFunctions" />
    internal static  void UpdateDeliveryMethod(global::Sungero.Docflow.IApprovalManagerAssignment approvalManagerAssignment)
    {
      var functions = (global::Sungero.Docflow.Shared.ApprovalManagerAssignmentFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)approvalManagerAssignment).FunctionsContainer.SharedFunctions;
    functions.UpdateDeliveryMethod();
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalManagerAssignmentFunctions" />
      internal static global::System.String  GetStagesStateView(global::Sungero.Docflow.IApprovalManagerAssignment approvalManagerAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("bbb08f45-60c1-4496-9ff6-b32caed44215"),
          "GetStagesStateView(global::Sungero.Docflow.IApprovalManagerAssignment)"
          , approvalManagerAssignment);
      }
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.ApprovalManagerAssignmentFunctions" />
      internal static global::System.String  GetDocumentSummary(global::Sungero.Docflow.IApprovalManagerAssignment approvalManagerAssignment)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("bbb08f45-60c1-4496-9ff6-b32caed44215"),
          "GetDocumentSummary(global::Sungero.Docflow.IApprovalManagerAssignment)"
          , approvalManagerAssignment);
      }

    }
  }
}

// ==================================================================
// ApprovalManagerAssignmentFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ApprovalManagerAssignment
{

  public class ApprovalManagerAssignmentFilterInfo : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterInfo,
    global::Sungero.Docflow.IApprovalManagerAssignmentFilterInfo
  {
  }

  public class ApprovalManagerAssignmentFilterState : global::Sungero.Workflow.Shared.Assignment.AssignmentFilterState,
    global::Sungero.Docflow.IApprovalManagerAssignmentFilterState
  {



    public new Sungero.Docflow.IApprovalManagerAssignmentFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IApprovalManagerAssignmentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ApprovalManagerAssignment.ApprovalManagerAssignmentFilterInfo();
    }

  }
}

// ==================================================================
// ApprovalManagerAssignmentSharedPublicFunctions.g.cs
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
  public class ApprovalManagerAssignmentSharedPublicFunctions : global::Sungero.Docflow.Shared.IApprovalManagerAssignmentSharedPublicFunctions
  {
  }
}

// ==================================================================
// ApprovalManagerAssignmentAttachmentGroups.g.cs
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

  public class ApprovalManagerAssignmentAddendaGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalManagerAssignmentAddendaGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ApprovalManagerAssignmentAddendaGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "852b3e7d-f178-47d3-8fad-a64021065cfd") { }
  }

  public class ApprovalManagerAssignmentOtherGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalManagerAssignmentOtherGroupAttachments
  {

    public ApprovalManagerAssignmentOtherGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "bd87e6b5-e247-485a-93bf-52f24a64af5a") { }
  }

  public class ApprovalManagerAssignmentDocumentGroupAttachments : global::Sungero.Workflow.Shared.WorkflowEntityAttachmentGroupDecorator,
    global::Sungero.Docflow.IApprovalManagerAssignmentDocumentGroupAttachments
  {
      public global::System.Collections.Generic.ICollection<global::Sungero.Docflow.IOfficialDocument> OfficialDocuments
      { 
        get 
        { 
          return this.GetAttachmentGroupCollection<global::Sungero.Docflow.IOfficialDocument>();
        } 
      }


    public ApprovalManagerAssignmentDocumentGroupAttachments(global::Sungero.Workflow.Interfaces.IWorkflowEntity entity) : base(entity, "08e1ef90-521f-41a1-a13f-c6f175007e54") { }
  }

}

// ==================================================================
// ApprovalManagerAssignmentExtendedSchemeVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.ApprovalManagerAssignment
{

    /// <summary>
    /// Список версий схемы.
    /// </summary>
    public static class LayerSchemeVersions
    {
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V1 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(1, global::System.Guid.Parse("0745199f-eaac-4875-8563-40ed1e5ce317"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V2 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(2, global::System.Guid.Parse("5d0fc175-90d1-403e-8925-56540910cc8c"));
      public static readonly global::Sungero.Workflow.Shared.ExtendedSchemeVersion V3 =
        new global::Sungero.Workflow.Shared.ExtendedSchemeVersion(3, global::System.Guid.Parse("a74b50c6-c2b5-432c-97bb-468af776c4da"));
}

    public static class TaskExtensions
    {
      /// <summary>
      /// Получить версию схемы запущенной задачи.
      /// </summary>
      /// <param name="task">Задача.</param>
      /// <returns>Версия схемы запущенной задачи.</returns>
      public static global::Sungero.Workflow.Shared.ExtendedSchemeVersion GetStartedSchemeVersion(this global::Sungero.Workflow.ITask task)
      {
        return global::Sungero.Workflow.Shared.OverriddenTaskHelper.FindLayerSchemeVersionForTask(task,
          global::System.Guid.Parse("100950d0-03d2-44f0-9e31-f9c8dfdf3829"));
      }
    }

}
