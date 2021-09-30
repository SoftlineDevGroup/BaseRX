
// ==================================================================
// AcquaintanceListExcludedParticipants.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class AcquaintanceListExcludedParticipantsFilterForExcludedParticipant<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants
    where TRootEntity : class, global::Sungero.RecordManagement.IAcquaintanceList
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsExcludedParticipantPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).ExcludedParticipantsExcludedParticipantFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public AcquaintanceListExcludedParticipantsFilterForExcludedParticipant(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class AcquaintanceListExcludedParticipantsSearchFilterForExcludedParticipant<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsExcludedParticipantSearchPropertyFilteringServerHandler<TQueryEntity>().ExcludedParticipantsExcludedParticipantSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public AcquaintanceListExcludedParticipantsSearchFilterForExcludedParticipant(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceListExcludedParticipantsFilterForExcludedParticipant<global::Sungero.CoreEntities.IRecipient, global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants, global::Sungero.RecordManagement.IAcquaintanceList>), "ExcludedParticipant")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.RecordManagement.Server.AcquaintanceListExcludedParticipantsSearchFilterForExcludedParticipant<global::Sungero.CoreEntities.IRecipient>), "ExcludedParticipant")]


  public class AcquaintanceListExcludedParticipants :
    global::Sungero.Domain.ChildEntity, global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0f1e26fd-415a-4f74-a806-3bd76afb7fca");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.AcquaintanceListExcludedParticipants.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IAcquaintanceListExcludedParticipants, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsState State
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceListExcludedParticipantsState(this);
    }

    public new virtual global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsInfo Info
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipantsInfo)base.Info; }
    }


    public global::Sungero.RecordManagement.IAcquaintanceList AcquaintanceList { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.AcquaintanceList; }
      set { this.AcquaintanceList = (global::Sungero.RecordManagement.IAcquaintanceList)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _ExcludedParticipant;
    public virtual global::Sungero.CoreEntities.IRecipient ExcludedParticipant
    {
      get
      {
        return this._ExcludedParticipant;
      }

      set
      {
        this.SetPropertyValue("ExcludedParticipant", this._ExcludedParticipant, value, (propertyValue) => { this._ExcludedParticipant = propertyValue; }, this.ExcludedParticipantChangedHandler);
      }
    }




    #region Framework events

    protected void ExcludedParticipantChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.AcquaintanceListExcludedParticipantsExcludedParticipantChangedEventArgs(this.State.Properties.ExcludedParticipant, this.ExcludedParticipant, this);
     ((global::Sungero.RecordManagement.AcquaintanceListExcludedParticipantsSharedHandlers)this.SharedHandlers).ExcludedParticipantsExcludedParticipantChanged(args);
    }



    #endregion


    public AcquaintanceListExcludedParticipants()
    {
    }

  }
}

// ==================================================================
// AcquaintanceListExcludedParticipantsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{
  public partial class AcquaintanceListExcludedParticipantsExcludedParticipantPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants _obj
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants)this.Entity; }
    }

    private global::Sungero.RecordManagement.IAcquaintanceList _root
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceList)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> ExcludedParticipantsExcludedParticipantFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public AcquaintanceListExcludedParticipantsExcludedParticipantPropertyFilteringServerHandler(global::Sungero.RecordManagement.IAcquaintanceListExcludedParticipants entity, global::Sungero.RecordManagement.IAcquaintanceList root)
      : base(entity, root)
    {
    }
  }

  public partial class AcquaintanceListExcludedParticipantsExcludedParticipantSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> ExcludedParticipantsExcludedParticipantSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public AcquaintanceListExcludedParticipantsExcludedParticipantSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// AcquaintanceListExcludedParticipantsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}
