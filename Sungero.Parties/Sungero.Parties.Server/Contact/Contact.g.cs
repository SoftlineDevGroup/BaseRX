
// ==================================================================
// Contact.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
    public class ContactFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Parties.IContact
    {
      protected new global::Sungero.Parties.IContactFilterState Filter { get; private set; }

      private global::Sungero.Parties.IContactFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ContactFilter(global::Sungero.Parties.IContactFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ContactFilter()
      {
      }
    }
      public class ContactUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Parties.IContact
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ContactSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Phone { get; protected set; }
                  public virtual global::System.String Email { get; protected set; }
                  public virtual global::System.String Homepage { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Parties.ICompanyBase> Company { get; protected set; }


        }




  public class ContactFilterForPerson<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Parties.IPerson
    where TSourceEntity : class, global::Sungero.Parties.IContact
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Parties.ContactPersonPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).PersonFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContactFilterForPerson(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ContactSearchFilterForPerson<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Parties.IPerson
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Parties.ContactPersonSearchPropertyFilteringServerHandler<TQueryEntity>().PersonSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContactSearchFilterForPerson(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ContactFilterForCompany<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICompanyBase
    where TSourceEntity : class, global::Sungero.Parties.IContact
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Parties.ContactCompanyPropertyFilteringServerHandler<TQueryEntity>(sourceEntity).CompanyFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContactFilterForCompany(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class ContactSearchFilterForCompany<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Parties.ICompanyBase
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Parties.ContactCompanySearchPropertyFilteringServerHandler<TQueryEntity>().CompanySearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public ContactSearchFilterForCompany(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Parties.Server.ContactFilter<global::Sungero.Parties.IContact>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Parties.Server.ContactUiFilter<global::Sungero.Parties.IContact>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Parties.Server.ContactFilterForPerson<global::Sungero.Parties.IPerson, global::Sungero.Parties.IContact>), "Person")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Parties.Server.ContactSearchFilterForPerson<global::Sungero.Parties.IPerson>), "Person")]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Parties.Server.ContactFilterForCompany<global::Sungero.Parties.ICompanyBase, global::Sungero.Parties.IContact>), "Company")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Parties.Server.ContactSearchFilterForCompany<global::Sungero.Parties.ICompanyBase>), "Company")]


  public class Contact :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Parties.IContact
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c8daaef9-a679-4a29-ac01-b93c1637c72e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Server.Contact.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Parties.IContact, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Parties.IContactState State
    {
      get { return (global::Sungero.Parties.IContactState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.ContactState(this);
    }

    public new virtual global::Sungero.Parties.IContactInfo Info
    {
      get { return (global::Sungero.Parties.IContactInfo)base.Info; }
    }

    public new virtual global::Sungero.Parties.IContactAccessRights AccessRights
    {
      get { return (global::Sungero.Parties.IContactAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Parties.Server.ContactAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Parties.Server.ContactFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Parties.Shared.ContactFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Parties.ContactServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Parties.ContactSharedHandlers(this);
    }

    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }
    private global::System.String _Department;
    public virtual global::System.String Department
    {
      get
      {
        return this._Department;
      }

      set
      {
        this.SetPropertyValue("Department", this._Department, value, (propertyValue) => { this._Department = propertyValue; }, this.DepartmentChangedHandler);
      }
    }
    private global::System.String _JobTitle;
    public virtual global::System.String JobTitle
    {
      get
      {
        return this._JobTitle;
      }

      set
      {
        this.SetPropertyValue("JobTitle", this._JobTitle, value, (propertyValue) => { this._JobTitle = propertyValue; }, this.JobTitleChangedHandler);
      }
    }
    private global::System.String _Phone;
    public virtual global::System.String Phone
    {
      get
      {
        return this._Phone;
      }

      set
      {
        this.SetPropertyValue("Phone", this._Phone, value, (propertyValue) => { this._Phone = propertyValue; }, this.PhoneChangedHandler);
      }
    }
    private global::System.String _Fax;
    public virtual global::System.String Fax
    {
      get
      {
        return this._Fax;
      }

      set
      {
        this.SetPropertyValue("Fax", this._Fax, value, (propertyValue) => { this._Fax = propertyValue; }, this.FaxChangedHandler);
      }
    }
    private global::System.String _Email;
    public virtual global::System.String Email
    {
      get
      {
        return this._Email;
      }

      set
      {
        this.SetPropertyValue("Email", this._Email, value, (propertyValue) => { this._Email = propertyValue; }, this.EmailChangedHandler);
      }
    }
    private global::System.String _Homepage;
    public virtual global::System.String Homepage
    {
      get
      {
        return this._Homepage;
      }

      set
      {
        this.SetPropertyValue("Homepage", this._Homepage, value, (propertyValue) => { this._Homepage = propertyValue; }, this.HomepageChangedHandler);
      }
    }



    private global::System.String _Note;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }





    private global::Sungero.Parties.IPerson _Person;
    public virtual global::Sungero.Parties.IPerson Person
    {
      get
      {
        return this._Person;
      }

      set
      {
        this.SetPropertyValue("Person", this._Person, value, (propertyValue) => { this._Person = propertyValue; }, this.PersonChangedHandler);
      }
    }
    private global::Sungero.Parties.ICompanyBase _Company;
    public virtual global::Sungero.Parties.ICompanyBase Company
    {
      get
      {
        return this._Company;
      }

      set
      {
        this.SetPropertyValue("Company", this._Company, value, (propertyValue) => { this._Company = propertyValue; }, this.CompanyChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      return new global::Sungero.Parties.ContactCreatingFromServerHandler((global::Sungero.Parties.IContact)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void PersonChangedHandler()
    {
      var args = new global::Sungero.Parties.Shared.ContactPersonChangedEventArgs(this.State.Properties.Person, this.Person, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).PersonChanged(args);
    }

    protected void CompanyChangedHandler()
    {
      var args = new global::Sungero.Parties.Shared.ContactCompanyChangedEventArgs(this.State.Properties.Company, this.Company, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).CompanyChanged(args);
    }

    protected void DepartmentChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Department, this.Department, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).DepartmentChanged(args);
    }

    protected void JobTitleChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.JobTitle, this.JobTitle, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).JobTitleChanged(args);
    }

    protected void PhoneChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Phone, this.Phone, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).PhoneChanged(args);
    }

    protected void FaxChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Fax, this.Fax, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).FaxChanged(args);
    }

    protected void EmailChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Email, this.Email, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).EmailChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }

    protected void HomepageChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Homepage, this.Homepage, this);
     ((global::Sungero.Parties.ContactSharedHandlers)this.SharedHandlers).HomepageChanged(args);
    }



    #endregion


    public Contact()
    {
    }

  }
}

// ==================================================================
// ContactHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties
{
  public partial class ContactPersonPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.IPerson
  {
    private global::Sungero.Parties.IContact _obj
    {
      get { return (global::Sungero.Parties.IContact)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> PersonFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ContactPersonPropertyFilteringServerHandler(global::Sungero.Parties.IContact entity)
      : base(entity)
    {
    }
  }

  public partial class ContactPersonSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.IPerson
  {

    public virtual global::System.Linq.IQueryable<T> PersonSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ContactPersonSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }

  public partial class ContactCompanyPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICompanyBase
  {
    private global::Sungero.Parties.IContact _obj
    {
      get { return (global::Sungero.Parties.IContact)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> CompanyFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public ContactCompanyPropertyFilteringServerHandler(global::Sungero.Parties.IContact entity)
      : base(entity)
    {
    }
  }

  public partial class ContactCompanySearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Parties.ICompanyBase
  {

    public virtual global::System.Linq.IQueryable<T> CompanySearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public ContactCompanySearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class ContactFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Parties.IContact
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Parties.IContactFilterState Filter { get; private set; }

    private global::Sungero.Parties.IContactFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ContactFilteringServerHandler(global::Sungero.Parties.IContactFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ContactFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ContactUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Parties.IContact
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ContactSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Parties.Server.ContactSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Parties.Server.ContactSearchDialogModel)this.Dialog;
       }
     }

     public ContactSearchDialogServerHandler(global::Sungero.Parties.Server.ContactSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ContactServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Parties.IContact _obj
    {
      get { return (global::Sungero.Parties.IContact)this.Entity; }
    }

    public ContactServerHandlers(global::Sungero.Parties.IContact entity)
      : base(entity)
    {
    }
  }

  public partial class ContactCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Parties.IContact _source
    {
      get { return (global::Sungero.Parties.IContact)this.Source; }
    }

    private global::Sungero.Parties.IContactInfo _info
    {
      get { return (global::Sungero.Parties.IContactInfo)this._Info; }
    }

    public ContactCreatingFromServerHandler(global::Sungero.Parties.IContact source, global::Sungero.Parties.IContactInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ContactEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
}

// ==================================================================
// ContactAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
  public class ContactAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Parties.IContactAccessRights
  {

    public ContactAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContactTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Parties.IContactAccessRights
  {

    public ContactTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ContactRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
    public class ContactRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Parties.IContactRepositoryImplementer<T>
      where T : global::Sungero.Parties.IContact 
    {
       public new global::Sungero.Parties.IContactAccessRights AccessRights
       {
          get { return (global::Sungero.Parties.IContactAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Parties.IContactInfo Info
       {
          get { return (global::Sungero.Parties.IContactInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Parties.Server.ContactTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ContactPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
}

// ==================================================================
// ContactServerFunctions.g.cs
// ==================================================================

namespace Sungero.Parties.Server
{
  public partial class ContactFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Parties.IContact _obj
    {
      get { return (global::Sungero.Parties.IContact)this.Entity; }
    }

    public ContactFunctions(global::Sungero.Parties.IContact entity) : base(entity) { }
  }
}

// ==================================================================
// ContactFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Functions
{
  internal static class Contact
  {
    /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ContactFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::System.Linq.IQueryable<global::Sungero.Parties.IContact> GetDuplicates(global::Sungero.Parties.IContact contact)
    {
      var functions = (global::Sungero.Parties.Server.ContactFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contact).FunctionsContainer.ServerFunctions;
      return functions.GetDuplicates();
    }
    /// <redirect project="Sungero.Parties.Server" type="Sungero.Parties.Server.ContactFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Parties.IContact> GetContactsByName(global::System.String name, global::System.String personShortName, global::Sungero.Parties.ICounterparty counterparty)
    {
      return global::Sungero.Parties.Server.ContactFunctions.GetContactsByName(name, personShortName, counterparty);
    }

    /// <redirect project="Sungero.Parties.Shared" type="Sungero.Parties.Shared.ContactFunctions" />
    internal static  global::System.Boolean HaveDuplicates(global::Sungero.Parties.IContact contact)
    {
      var functions = (global::Sungero.Parties.Shared.ContactFunctions)((global::Sungero.Domain.Shared.IEntityFunctions)contact).FunctionsContainer.SharedFunctions;
      return functions.HaveDuplicates();
    }

  }
}

// ==================================================================
// ContactServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Server
{
  public class ContactServerPublicFunctions : global::Sungero.Parties.Server.IContactServerPublicFunctions
  {
    public global::System.Linq.IQueryable<global::Sungero.Parties.IContact> GetContactsByName(global::System.String name, global::System.String personShortName, global::Sungero.Parties.ICounterparty counterparty)
    {
      return global::Sungero.Parties.Functions.Contact.GetContactsByName(name, personShortName, counterparty);
    }
  }
}

// ==================================================================
// ContactQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Queries
{
  public class Contact
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Parties.Server.Contact.ContactQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}