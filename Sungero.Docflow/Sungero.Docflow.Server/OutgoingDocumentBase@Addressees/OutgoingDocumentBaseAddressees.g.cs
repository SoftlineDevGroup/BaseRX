
// ==================================================================
// OutgoingDocumentBaseAddressees.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class OutgoingDocumentBaseAddresseesFilterForCorrespondent<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICounterparty
    where TSourceEntity : class, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees
    where TRootEntity : class, global::Sungero.Docflow.IOutgoingDocumentBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesCorrespondentPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).AddresseesCorrespondentFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public OutgoingDocumentBaseAddresseesFilterForCorrespondent(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class OutgoingDocumentBaseAddresseesSearchFilterForCorrespondent<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICounterparty
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesCorrespondentSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseesCorrespondentSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public OutgoingDocumentBaseAddresseesSearchFilterForCorrespondent(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class OutgoingDocumentBaseAddresseesFilterForAddressee<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Parties.IContact
    where TSourceEntity : class, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees
    where TRootEntity : class, global::Sungero.Docflow.IOutgoingDocumentBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesAddresseePropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).AddresseesAddresseeFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public OutgoingDocumentBaseAddresseesFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class OutgoingDocumentBaseAddresseesSearchFilterForAddressee<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Parties.IContact
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesAddresseeSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseesAddresseeSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public OutgoingDocumentBaseAddresseesSearchFilterForAddressee(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class OutgoingDocumentBaseAddresseesFilterForDeliveryMethod<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IMailDeliveryMethod
    where TSourceEntity : class, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees
    where TRootEntity : class, global::Sungero.Docflow.IOutgoingDocumentBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesDeliveryMethodPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).AddresseesDeliveryMethodFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public OutgoingDocumentBaseAddresseesFilterForDeliveryMethod(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class OutgoingDocumentBaseAddresseesSearchFilterForDeliveryMethod<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IMailDeliveryMethod
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesDeliveryMethodSearchPropertyFilteringServerHandler<TQueryEntity>().AddresseesDeliveryMethodSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public OutgoingDocumentBaseAddresseesSearchFilterForDeliveryMethod(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.OutgoingDocumentBaseAddresseesFilterForCorrespondent<global::Sungero.Parties.ICounterparty, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees, global::Sungero.Docflow.IOutgoingDocumentBase>), "Correspondent")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.OutgoingDocumentBaseAddresseesSearchFilterForCorrespondent<global::Sungero.Parties.ICounterparty>), "Correspondent")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.OutgoingDocumentBaseAddresseesFilterForAddressee<global::Sungero.Parties.IContact, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees, global::Sungero.Docflow.IOutgoingDocumentBase>), "Addressee")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.OutgoingDocumentBaseAddresseesSearchFilterForAddressee<global::Sungero.Parties.IContact>), "Addressee")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.OutgoingDocumentBaseAddresseesFilterForDeliveryMethod<global::Sungero.Docflow.IMailDeliveryMethod, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees, global::Sungero.Docflow.IOutgoingDocumentBase>), "DeliveryMethod")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.OutgoingDocumentBaseAddresseesSearchFilterForDeliveryMethod<global::Sungero.Docflow.IMailDeliveryMethod>), "DeliveryMethod")]


  public class OutgoingDocumentBaseAddressees :
    global::Sungero.Domain.ChildEntity, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0f69e0e7-71ef-4df0-8237-39acb1d5d679");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.OutgoingDocumentBaseAddressees.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IOutgoingDocumentBaseAddressees, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesState State
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesState(this);
    }

    public new virtual global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesInfo Info
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesInfo)base.Info; }
    }


    public global::Sungero.Docflow.IOutgoingDocumentBase OutgoingDocumentBase { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.OutgoingDocumentBase; }
      set { this.OutgoingDocumentBase = (global::Sungero.Docflow.IOutgoingDocumentBase)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesSharedHandlers(this);
    }

    private global::System.Int32? _Number;
    public virtual global::System.Int32? Number
    {
      get
      {
        return this._Number;
      }

      set
      {
        this.SetPropertyValue("Number", this._Number, value, (propertyValue) => { this._Number = propertyValue; }, this.NumberChangedHandler);
      }
    }







    private global::Sungero.Parties.ICounterparty _Correspondent;
    public virtual global::Sungero.Parties.ICounterparty Correspondent
    {
      get
      {
        return this._Correspondent;
      }

      set
      {
        this.SetPropertyValue("Correspondent", this._Correspondent, value, (propertyValue) => { this._Correspondent = propertyValue; }, this.CorrespondentChangedHandler);
      }
    }
    private global::Sungero.Parties.IContact _Addressee;
    public virtual global::Sungero.Parties.IContact Addressee
    {
      get
      {
        return this._Addressee;
      }

      set
      {
        this.SetPropertyValue("Addressee", this._Addressee, value, (propertyValue) => { this._Addressee = propertyValue; }, this.AddresseeChangedHandler);
      }
    }
    private global::Sungero.Docflow.IMailDeliveryMethod _DeliveryMethod;
    public virtual global::Sungero.Docflow.IMailDeliveryMethod DeliveryMethod
    {
      get
      {
        return this._DeliveryMethod;
      }

      set
      {
        this.SetPropertyValue("DeliveryMethod", this._DeliveryMethod, value, (propertyValue) => { this._DeliveryMethod = propertyValue; }, this.DeliveryMethodChangedHandler);
      }
    }




    #region Framework events

    protected void CorrespondentChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesCorrespondentChangedEventArgs(this.State.Properties.Correspondent, this.Correspondent, this);
     ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesCorrespondentChanged(args);
    }

    protected void AddresseeChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesAddresseeChangedEventArgs(this.State.Properties.Addressee, this.Addressee, this);
     ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesAddresseeChanged(args);
    }

    protected void DeliveryMethodChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesDeliveryMethodChangedEventArgs(this.State.Properties.DeliveryMethod, this.DeliveryMethod, this);
     ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesDeliveryMethodChanged(args);
    }

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesSharedHandlers)this.SharedHandlers).AddresseesNumberChanged(args);
    }



    #endregion


    public OutgoingDocumentBaseAddressees()
    {
    }

  }
}

// ==================================================================
// OutgoingDocumentBaseAddresseesHandlers.g.cs
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
  public partial class OutgoingDocumentBaseAddresseesCorrespondentPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICounterparty
  {
    private global::Sungero.Docflow.IOutgoingDocumentBaseAddressees _obj
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddressees)this.Entity; }
    }

    private global::Sungero.Docflow.IOutgoingDocumentBase _root
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBase)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseesCorrespondentFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public OutgoingDocumentBaseAddresseesCorrespondentPropertyFilteringServerHandler(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees entity, global::Sungero.Docflow.IOutgoingDocumentBase root)
      : base(entity, root)
    {
    }
  }

  public partial class OutgoingDocumentBaseAddresseesCorrespondentSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICounterparty
  {

    public virtual global::System.Linq.IQueryable<T> AddresseesCorrespondentSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public OutgoingDocumentBaseAddresseesCorrespondentSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class OutgoingDocumentBaseAddresseesAddresseePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.IContact
  {
    private global::Sungero.Docflow.IOutgoingDocumentBaseAddressees _obj
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddressees)this.Entity; }
    }

    private global::Sungero.Docflow.IOutgoingDocumentBase _root
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBase)this.Root; }
    }

    public OutgoingDocumentBaseAddresseesAddresseePropertyFilteringServerHandler(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees entity, global::Sungero.Docflow.IOutgoingDocumentBase root)
      : base(entity, root)
    {
    }
  }

  public partial class OutgoingDocumentBaseAddresseesAddresseeSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.IContact
  {

    public virtual global::System.Linq.IQueryable<T> AddresseesAddresseeSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public OutgoingDocumentBaseAddresseesAddresseeSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class OutgoingDocumentBaseAddresseesDeliveryMethodPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IMailDeliveryMethod
  {
    private global::Sungero.Docflow.IOutgoingDocumentBaseAddressees _obj
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddressees)this.Entity; }
    }

    private global::Sungero.Docflow.IOutgoingDocumentBase _root
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBase)this.Root; }
    }

    public virtual global::System.Linq.IQueryable<T> AddresseesDeliveryMethodFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public OutgoingDocumentBaseAddresseesDeliveryMethodPropertyFilteringServerHandler(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees entity, global::Sungero.Docflow.IOutgoingDocumentBase root)
      : base(entity, root)
    {
    }
  }

  public partial class OutgoingDocumentBaseAddresseesDeliveryMethodSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IMailDeliveryMethod
  {

    public virtual global::System.Linq.IQueryable<T> AddresseesDeliveryMethodSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public OutgoingDocumentBaseAddresseesDeliveryMethodSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// OutgoingDocumentBaseAddresseesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}
