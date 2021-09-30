
// ==================================================================
// VisibilityRuleState.g.cs
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
  public class VisibilityRuleState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.Company.IVisibilityRuleState
  {
    public VisibilityRuleState(global::Sungero.Company.IVisibilityRule entity) : base(entity) { }

    public new global::Sungero.Company.IVisibilityRulePropertyStates Properties
    {
      get { return (global::Sungero.Company.IVisibilityRulePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.VisibilityRulePropertyStates(entity);
    }


    public new global::Sungero.Company.IVisibilityRuleControlStates Controls
    {
      get { return (global::Sungero.Company.IVisibilityRuleControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.VisibilityRuleControlStates(entity);
    }

    public new global::Sungero.Company.IVisibilityRulePageStates Pages
    {
      get { return (global::Sungero.Company.IVisibilityRulePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Company.Shared.VisibilityRulePageStates(entity);
    }

  }


  public class VisibilityRuleControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.Company.IVisibilityRuleControlStates
  {

    protected internal VisibilityRuleControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class VisibilityRulePageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.Company.IVisibilityRulePageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal VisibilityRulePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class VisibilityRulePropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.Company.IVisibilityRulePropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Company.IVisibilityRuleRecipientsCollectionPropertyState<global::Sungero.Company.IVisibilityRuleRecipients> Recipients 
            {
              get { return this.GetPropertyState("Recipients", this.CreateRecipientsState); }
            }

            protected virtual global::Sungero.Company.IVisibilityRuleRecipientsCollectionPropertyState<global::Sungero.Company.IVisibilityRuleRecipients> CreateRecipientsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Company.Shared.VisibilityRuleRecipientsCollectionPropertyState<global::Sungero.Company.IVisibilityRuleRecipients>(entity, propertyName);
            }
            public global::Sungero.Company.IVisibilityRuleVisibleMembersCollectionPropertyState<global::Sungero.Company.IVisibilityRuleVisibleMembers> VisibleMembers 
            {
              get { return this.GetPropertyState("VisibleMembers", this.CreateVisibleMembersState); }
            }

            protected virtual global::Sungero.Company.IVisibilityRuleVisibleMembersCollectionPropertyState<global::Sungero.Company.IVisibilityRuleVisibleMembers> CreateVisibleMembersState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Company.Shared.VisibilityRuleVisibleMembersCollectionPropertyState<global::Sungero.Company.IVisibilityRuleVisibleMembers>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }
            public global::Sungero.Company.IVisibilityRuleExcludedMembersCollectionPropertyState<global::Sungero.Company.IVisibilityRuleExcludedMembers> ExcludedMembers 
            {
              get { return this.GetPropertyState("ExcludedMembers", this.CreateExcludedMembersState); }
            }

            protected virtual global::Sungero.Company.IVisibilityRuleExcludedMembersCollectionPropertyState<global::Sungero.Company.IVisibilityRuleExcludedMembers> CreateExcludedMembersState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Company.Shared.VisibilityRuleExcludedMembersCollectionPropertyState<global::Sungero.Company.IVisibilityRuleExcludedMembers>(entity, propertyName);
            }


    protected internal VisibilityRulePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// VisibilityRuleEventArgs.g.cs
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
// VisibilityRuleInfo.g.cs
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
  public class VisibilityRuleInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.Company.IVisibilityRuleInfo
  {
    public VisibilityRuleInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Company.IVisibilityRulePropertiesInfo Properties
    {
      get { return (global::Sungero.Company.IVisibilityRulePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Company.Shared.VisibilityRulePropertiesInfo(entityType);
    }

  }

  public class VisibilityRulePropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.Company.IVisibilityRulePropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Company.IVisibilityRuleRecipientsPropertiesInfo> Recipients 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Recipients");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Company.IVisibilityRuleRecipientsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Company.IVisibilityRuleVisibleMembersPropertiesInfo> VisibleMembers 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("VisibleMembers");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Company.IVisibilityRuleVisibleMembersPropertiesInfo>(propertyMetadata);
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
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Company.IVisibilityRuleExcludedMembersPropertiesInfo> ExcludedMembers 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("ExcludedMembers");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Company.IVisibilityRuleExcludedMembersPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal VisibilityRulePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// VisibilityRuleHandlers.g.cs
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
  public partial class VisibilityRuleSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers
  {
    private global::Sungero.Company.IVisibilityRule _obj
    {
      get { return (global::Sungero.Company.IVisibilityRule)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void RecipientsChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void VisibleMembersChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void NoteChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void ExcludedMembersChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }




    public VisibilityRuleSharedHandlers(global::Sungero.Company.IVisibilityRule entity) : base(entity)
    {
    }
  }

  public partial class VisibilityRuleRecipientsSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers
  {
    private global::Sungero.Company.IVisibilityRuleRecipients _obj
    { 
      get { return (global::Sungero.Company.IVisibilityRuleRecipients)this.Entity; }
    }
    public virtual void RecipientsRecipientChanged(global::Sungero.Company.Shared.VisibilityRuleRecipientsRecipientChangedEventArgs e) { }



    public VisibilityRuleRecipientsSharedHandlers(global::Sungero.Company.IVisibilityRuleRecipients entity) : base(entity)
    {
    }
  }

  public partial class VisibilityRuleRecipientsSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Company.IVisibilityRule _obj
    { 
      get { return (global::Sungero.Company.IVisibilityRule)this.Entity; }
    }

    private global::Sungero.Company.IVisibilityRuleRecipients _added
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipients)this._Added; }
    }

    private global::Sungero.Company.IVisibilityRuleRecipients _deleted
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipients)this._Deleted; }
    }

    private global::Sungero.Company.IVisibilityRuleRecipients _source
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipients)this._Source; }
    }

    public virtual void RecipientsAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void RecipientsDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public VisibilityRuleRecipientsSharedCollectionHandlers(global::Sungero.Company.IVisibilityRule entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

  public partial class VisibilityRuleVisibleMembersSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers
  {
    private global::Sungero.Company.IVisibilityRuleVisibleMembers _obj
    { 
      get { return (global::Sungero.Company.IVisibilityRuleVisibleMembers)this.Entity; }
    }
    public virtual void VisibleMembersRecipientChanged(global::Sungero.Company.Shared.VisibilityRuleVisibleMembersRecipientChangedEventArgs e) { }



    public VisibilityRuleVisibleMembersSharedHandlers(global::Sungero.Company.IVisibilityRuleVisibleMembers entity) : base(entity)
    {
    }
  }

  public partial class VisibilityRuleVisibleMembersSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Company.IVisibilityRule _obj
    { 
      get { return (global::Sungero.Company.IVisibilityRule)this.Entity; }
    }

    private global::Sungero.Company.IVisibilityRuleVisibleMembers _added
    {
      get { return (global::Sungero.Company.IVisibilityRuleVisibleMembers)this._Added; }
    }

    private global::Sungero.Company.IVisibilityRuleVisibleMembers _deleted
    {
      get { return (global::Sungero.Company.IVisibilityRuleVisibleMembers)this._Deleted; }
    }

    private global::Sungero.Company.IVisibilityRuleVisibleMembers _source
    {
      get { return (global::Sungero.Company.IVisibilityRuleVisibleMembers)this._Source; }
    }

    public virtual void VisibleMembersAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void VisibleMembersDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public VisibilityRuleVisibleMembersSharedCollectionHandlers(global::Sungero.Company.IVisibilityRule entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

  public partial class VisibilityRuleExcludedMembersSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers
  {
    private global::Sungero.Company.IVisibilityRuleExcludedMembers _obj
    { 
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembers)this.Entity; }
    }
    public virtual void ExcludedMembersRecipientChanged(global::Sungero.Company.Shared.VisibilityRuleExcludedMembersRecipientChangedEventArgs e) { }



    public VisibilityRuleExcludedMembersSharedHandlers(global::Sungero.Company.IVisibilityRuleExcludedMembers entity) : base(entity)
    {
    }
  }

  public partial class VisibilityRuleExcludedMembersSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.Company.IVisibilityRule _obj
    { 
      get { return (global::Sungero.Company.IVisibilityRule)this.Entity; }
    }

    private global::Sungero.Company.IVisibilityRuleExcludedMembers _added
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembers)this._Added; }
    }

    private global::Sungero.Company.IVisibilityRuleExcludedMembers _deleted
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembers)this._Deleted; }
    }

    private global::Sungero.Company.IVisibilityRuleExcludedMembers _source
    {
      get { return (global::Sungero.Company.IVisibilityRuleExcludedMembers)this._Source; }
    }

    public virtual void ExcludedMembersAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void ExcludedMembersDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public VisibilityRuleExcludedMembersSharedCollectionHandlers(global::Sungero.Company.IVisibilityRule entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// VisibilityRuleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Shared.VisibilityRule
{
  /// <summary>
  /// Represents VisibilityRule resources.
  /// </summary>
  public class VisibilityRuleResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.Company.VisibilityRule.IVisibilityRuleResources
  {
    public virtual global::CommonLibrary.LocalizedString RecipientRestrictModeOff
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Company.IVisibilityRule) , "RecipientRestrictModeOff");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RecipientRestrictModeOffFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.Company.IVisibilityRule), "RecipientRestrictModeOff", false, args);
    }

  }
}

// ==================================================================
// VisibilityRuleSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Company.Shared
{
  public partial class VisibilityRuleFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.Company.IVisibilityRule _obj
    {
      get { return (global::Sungero.Company.IVisibilityRule)this.Entity; }
    }

    public VisibilityRuleFunctions(global::Sungero.Company.IVisibilityRule entity) : base(entity) { }
  }
}

// ==================================================================
// VisibilityRuleFunctions.g.cs
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
  internal static class VisibilityRule
  {
  }
}

// ==================================================================
// VisibilityRuleFilterState.g.cs
// ==================================================================

namespace Sungero.Company.Shared.VisibilityRule
{

  public class VisibilityRuleFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.Company.IVisibilityRuleFilterInfo
  {
    public global::Sungero.Domain.Shared.IFilterControlInfo Active
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Active");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Closed
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Closed");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo Recipient
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("Recipient");
      }
    }

    public global::Sungero.Domain.Shared.IFilterControlInfo VisibleMember
    {
      get
      {
        return new global::Sungero.Domain.Shared.FilterControlInfo("VisibleMember");
      }
    }


  }

  public class VisibilityRuleFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.Company.IVisibilityRuleFilterState
  {
    public bool Active
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }

    public bool Closed
    {
      get { return this.GetValue<bool>(); }
      set { this.SetValue(value); }
    }



    public global::Sungero.CoreEntities.IRecipient Recipient
    {
      get { return this.GetValue<global::Sungero.CoreEntities.IRecipient>(); }
      set { this.SetValue(value); }
    }

    public global::Sungero.CoreEntities.IRecipient VisibleMember
    {
      get { return this.GetValue<global::Sungero.CoreEntities.IRecipient>(); }
      set { this.SetValue(value); }
    }




    public new Sungero.Company.IVisibilityRuleFilterInfo Info
    {
      get
      {
        return (Sungero.Company.IVisibilityRuleFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Company.Shared.VisibilityRule.VisibilityRuleFilterInfo();
    }

  }
}

// ==================================================================
// VisibilityRuleSharedPublicFunctions.g.cs
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
  public class VisibilityRuleSharedPublicFunctions : global::Sungero.Company.Shared.IVisibilityRuleSharedPublicFunctions
  {
  }
}
