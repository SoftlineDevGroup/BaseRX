
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

namespace Sungero.Parties.Client
{
  public class Contact :
    global::Sungero.CoreEntities.Client.DatabookEntry, global::Sungero.Parties.IContact
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c8daaef9-a679-4a29-ac01-b93c1637c72e");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Parties.Client.Contact.ClassTypeGuid; }
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

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Parties.IContactState State
    {
      get
      {
        return (global::Sungero.Parties.IContactState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Parties.Shared.ContactState(this);
    }

    public new global::Sungero.Parties.IContactInfo Info
    {
      get
      {
        return (global::Sungero.Parties.IContactInfo)base.Info;
      }
    }

    public new global::Sungero.Parties.IContactAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Parties.IContactAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Parties.Client.ContactAccessRights(this);
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Department;

        public virtual global::System.String Department
        {
          get { return this._Department.Value; }
          set { this._Department.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _JobTitle;

        public virtual global::System.String JobTitle
        {
          get { return this._JobTitle.Value; }
          set { this._JobTitle.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Phone;

        public virtual global::System.String Phone
        {
          get { return this._Phone.Value; }
          set { this._Phone.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Fax;

        public virtual global::System.String Fax
        {
          get { return this._Fax.Value; }
          set { this._Fax.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Email;

        public virtual global::System.String Email
        {
          get { return this._Email.Value; }
          set { this._Email.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Homepage;

        public virtual global::System.String Homepage
        {
          get { return this._Homepage.Value; }
          set { this._Homepage.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.IPerson> _Person;

              public virtual global::Sungero.Parties.IPerson Person
              {
              get
              {
                return this._Person.Value as global::Sungero.Parties.IPerson;
              }

              set
              {
                (this._Person as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.ICompanyBase> _Company;

              public virtual global::Sungero.Parties.ICompanyBase Company
              {
              get
              {
                return this._Company.Value as global::Sungero.Parties.ICompanyBase;
              }

              set
              {
                (this._Company as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }








      protected global::Sungero.Domain.Client.TextProperty _Note;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String Note
      {
        get { return this._Note.Value; }
        set { this._Note.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Parties.Client.ContactActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Parties.Client.ContactCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Parties.Client.ContactAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Parties.Client.ContactAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Parties.Client.ContactFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Parties.Shared.ContactFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Parties.ContactClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Parties.ContactSharedHandlers(this);
    }

    #endregion

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



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).NameValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Parties.IPerson PersonValueInputHandler(global::Sungero.Parties.IPerson value)
  {
    var args = new global::Sungero.Parties.Client.ContactPersonValueInputEventArgs(this.Person, value, this, this.Info.Properties.Person);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).PersonValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Parties.ICompanyBase CompanyValueInputHandler(global::Sungero.Parties.ICompanyBase value)
  {
    var args = new global::Sungero.Parties.Client.ContactCompanyValueInputEventArgs(this.Company, value, this, this.Info.Properties.Company);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).CompanyValueInput(args);
    return args.NewValue;
  }

  protected global::System.String DepartmentValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Department, value, this, this.Info.Properties.Department);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).DepartmentValueInput(args);
    return args.NewValue;
  }

  protected global::System.String JobTitleValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.JobTitle, value, this, this.Info.Properties.JobTitle);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).JobTitleValueInput(args);
    return args.NewValue;
  }

  protected global::System.String PhoneValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Phone, value, this, this.Info.Properties.Phone);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).PhoneValueInput(args);
    return args.NewValue;
  }

  protected global::System.String FaxValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Fax, value, this, this.Info.Properties.Fax);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).FaxValueInput(args);
    return args.NewValue;
  }

  protected global::System.String EmailValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Email, value, this, this.Info.Properties.Email);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).EmailValueInput(args);
    return args.NewValue;
  }

  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).NoteValueInput(args);
    return args.NewValue;
  }

  protected global::System.String HomepageValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Homepage, value, this, this.Info.Properties.Homepage);
    ((global::Sungero.Parties.ContactClientHandlers)this.Handlers).HomepageValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitPersonNavigationProperty()
              {
                this._Person = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.IPerson>("Person", this);
                this._Person.ValueChanged += (sender, e) => { this.PersonChangedHandler(); };
                this.AddProperty(this._Person as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitCompanyNavigationProperty()
              {
                this._Company = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICompanyBase>("Company", this);
                this._Company.ValueChanged += (sender, e) => { this.CompanyChangedHandler(); };
                this.AddProperty(this._Company as global::Sungero.Domain.Client.IProperty);
              }




    public Contact()
    {
            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._Department = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Department", this);
            this._Department.ValueChanged += (sender, e) => { this.DepartmentChangedHandler(); };
            this.AddProperty(this._Department);

            this._JobTitle = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("JobTitle", this);
            this._JobTitle.ValueChanged += (sender, e) => { this.JobTitleChangedHandler(); };
            this.AddProperty(this._JobTitle);

            this._Phone = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Phone", this);
            this._Phone.ValueChanged += (sender, e) => { this.PhoneChangedHandler(); };
            this.AddProperty(this._Phone);

            this._Fax = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Fax", this);
            this._Fax.ValueChanged += (sender, e) => { this.FaxChangedHandler(); };
            this.AddProperty(this._Fax);

            this._Email = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Email", this);
            this._Email.ValueChanged += (sender, e) => { this.EmailChangedHandler(); };
            this.AddProperty(this._Email);

            this._Homepage = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Homepage", this);
            this._Homepage.ValueChanged += (sender, e) => { this.HomepageChangedHandler(); };
            this.AddProperty(this._Homepage);

            this.InitPersonNavigationProperty();

            this.InitCompanyNavigationProperty();



            this._Note = new global::Sungero.Domain.Client.TextProperty("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);






    }

    #endregion

  }
}

// ==================================================================
// ContactPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class ContactPresenter<T> :
    global::Sungero.Domain.Client.EntityPresenter<T>
    where T : class, global::Sungero.Parties.IContact
  {
    #region Fields and properties

          private global::System.Windows.Input.ICommand _WriteLetterCommand;

          public global::System.Windows.Input.ICommand WriteLetterCommand
          {
            get
            {
              if (this._WriteLetterCommand == null)
                  this._WriteLetterCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("WriteLetter", this, this.WriteLetter, this.CanWriteLetter) { IsEmptyParameterAllowed = true };
              return this._WriteLetterCommand;
            }
          }
          private global::System.Windows.Input.ICommand _GoToWebsiteCommand;

          public global::System.Windows.Input.ICommand GoToWebsiteCommand
          {
            get
            {
              if (this._GoToWebsiteCommand == null)
                  this._GoToWebsiteCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("GoToWebsite", this, this.GoToWebsite, this.CanGoToWebsite) { IsEmptyParameterAllowed = true };
              return this._GoToWebsiteCommand;
            }
          }
          private global::System.Windows.Input.ICommand _ShowDuplicatesCommand;

          public global::System.Windows.Input.ICommand ShowDuplicatesCommand
          {
            get
            {
              if (this._ShowDuplicatesCommand == null)
                  this._ShowDuplicatesCommand = new global::Sungero.Domain.Client.SingleEntityCommand<T>("ShowDuplicates", this, this.ShowDuplicates, this.CanShowDuplicates) { IsEmptyParameterAllowed = true };
              return this._ShowDuplicatesCommand;
            }
          }




    #endregion

    #region Methods

              private bool CanWriteLetter(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Parties.Client.ContactActions)(entity as Sungero.Parties.Client.Contact).ActionsHandlers).CanWriteLetter(args);
              }

              private void WriteLetter(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.WriteLetter);
                ((Sungero.Parties.Client.ContactActions)(entity as Sungero.Parties.Client.Contact).ActionsHandlers).WriteLetter(args);
              }

              private bool CanGoToWebsite(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Parties.Client.ContactActions)(entity as Sungero.Parties.Client.Contact).ActionsHandlers).CanGoToWebsite(args);
              }

              private void GoToWebsite(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.GoToWebsite);
                ((Sungero.Parties.Client.ContactActions)(entity as Sungero.Parties.Client.Contact).ActionsHandlers).GoToWebsite(args);
              }

              private bool CanShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfCanExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this);
                return ((Sungero.Parties.Client.ContactActions)(entity as Sungero.Parties.Client.Contact).ActionsHandlers).CanShowDuplicates(args);
              }

              private void ShowDuplicates(T entity)
              {
                var args = new global::Sungero.Domain.Client.WpfExecuteActionArgs(global::Sungero.Domain.Shared.FormType.Card, entity, this, entity.Info.Actions.ShowDuplicates);
                ((Sungero.Parties.Client.ContactActions)(entity as Sungero.Parties.Client.Contact).ActionsHandlers).ShowDuplicates(args);
              }


    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion

              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _PersonCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter PersonCollectionPresenter
              {
          get { return this._PersonCollectionPresenter; }
        }
              protected global::Sungero.Domain.Client.IEntityCollectionPresenter _CompanyCollectionPresenter;
              public global::Sungero.Domain.Client.IEntityCollectionPresenter CompanyCollectionPresenter
              {
          get { return this._CompanyCollectionPresenter; }
        }



    #region Constructors

    private void Init()
    {
                  this._PersonCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.IPerson>(global::System.Guid.Parse("6608a7f8-7d05-490c-803b-75868b5d175d"));
              this._PersonCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.IPerson>(() => this.Entity.Id, typeof(T), "Person");

                  this._CompanyCollectionPresenter = this.CreateCollectionPresenterForNavigationProperty<global::Sungero.Parties.ICompanyBase>(global::System.Guid.Parse("4dbbc652-f787-43d7-af74-4a64b2ad5385"));
              this._CompanyCollectionPresenter
              .Query = global::Sungero.Domain.Client.Session.GetValuesForNavigationPropertyWithoutSourceEntity<global::Sungero.Parties.ICompanyBase>(() => this.Entity.Id, typeof(T), "Company");


    }

    public ContactPresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ContactCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Parties.Client
{
  public class ContactCollectionPresenter<T> : 
    global::Sungero.Domain.Client.EntityCollectionPresenter<T>
    where T: class, global::Sungero.Parties.IContact
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ContactCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ContactCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ContactCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ContactCollectionPresenter()
      : this(null, null) { }
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

namespace Sungero.Parties.Client
{ 
  public class ContactRepositoryImplementer<T> : 
      global::Sungero.Domain.Client.RepositoryImplementer<T>,
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
         return new global::Sungero.Parties.Client.ContactTypeAccessRights(typeof(T));
       }
    }
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

namespace Sungero.Parties.Client
{
  public class ContactAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryAccessRights, Sungero.Parties.IContactAccessRights
  {

    public ContactAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ContactTypeAccessRights : 
    Sungero.CoreEntities.Client.DatabookEntryTypeAccessRights, Sungero.Parties.IContactAccessRights
  {

    public ContactTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
