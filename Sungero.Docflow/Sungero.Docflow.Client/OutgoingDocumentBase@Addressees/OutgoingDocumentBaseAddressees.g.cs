
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

namespace Sungero.Docflow.Client
{
  public class OutgoingDocumentBaseAddressees :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IOutgoingDocumentBaseAddressees
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("0f69e0e7-71ef-4df0-8237-39acb1d5d679");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.OutgoingDocumentBaseAddressees.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IOutgoingDocumentBaseAddressees, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesState State
    {
      get
      {
        return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesState(this);
    }

    public new global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IOutgoingDocumentBase> _OutgoingDocumentBase;

    public global::Sungero.Docflow.IOutgoingDocumentBase OutgoingDocumentBase
    {
      get { return this._OutgoingDocumentBase.Value; }
      set { this._OutgoingDocumentBase.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.OutgoingDocumentBase; }
      set { this.OutgoingDocumentBase = (global::Sungero.Docflow.IOutgoingDocumentBase)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Number;

        public virtual global::System.Int32? Number
        {
          get { return this._Number.Value; }
          set { this._Number.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.ICounterparty> _Correspondent;

              public virtual global::Sungero.Parties.ICounterparty Correspondent
              {
              get
              {
                return this._Correspondent.Value as global::Sungero.Parties.ICounterparty;
              }

              set
              {
                (this._Correspondent as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Parties.IContact> _Addressee;

              public virtual global::Sungero.Parties.IContact Addressee
              {
              get
              {
                return this._Addressee.Value as global::Sungero.Parties.IContact;
              }

              set
              {
                (this._Addressee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IMailDeliveryMethod> _DeliveryMethod;

              public virtual global::Sungero.Docflow.IMailDeliveryMethod DeliveryMethod
              {
              get
              {
                return this._DeliveryMethod.Value as global::Sungero.Docflow.IMailDeliveryMethod;
              }

              set
              {
                (this._DeliveryMethod as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.OutgoingDocumentBaseAddresseesSharedHandlers(this);
    }

    #endregion

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



  protected global::Sungero.Parties.ICounterparty CorrespondentValueInputHandler(global::Sungero.Parties.ICounterparty value)
  {
    var args = new global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseesCorrespondentValueInputEventArgs(this.Correspondent, value, this, this.Info.Properties.Correspondent);
    ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesCorrespondentValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Parties.IContact AddresseeValueInputHandler(global::Sungero.Parties.IContact value)
  {
    var args = new global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseesAddresseeValueInputEventArgs(this.Addressee, value, this, this.Info.Properties.Addressee);
    ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesAddresseeValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Docflow.IMailDeliveryMethod DeliveryMethodValueInputHandler(global::Sungero.Docflow.IMailDeliveryMethod value)
  {
    var args = new global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseesDeliveryMethodValueInputEventArgs(this.DeliveryMethod, value, this, this.Info.Properties.DeliveryMethod);
    ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesDeliveryMethodValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? NumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Number, value, this, this.Info.Properties.Number);
    ((global::Sungero.Docflow.OutgoingDocumentBaseAddresseesClientHandlers)this.Handlers).AddresseesNumberValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitCorrespondentNavigationProperty()
              {
                this._Correspondent = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.ICounterparty>("Correspondent", this);
                this._Correspondent.ValueChanged += (sender, e) => { this.CorrespondentChangedHandler(); };
                this.AddProperty(this._Correspondent as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitAddresseeNavigationProperty()
              {
                this._Addressee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Parties.IContact>("Addressee", this);
                this._Addressee.ValueChanged += (sender, e) => { this.AddresseeChangedHandler(); };
                this.AddProperty(this._Addressee as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitDeliveryMethodNavigationProperty()
              {
                this._DeliveryMethod = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IMailDeliveryMethod>("DeliveryMethod", this);
                this._DeliveryMethod.ValueChanged += (sender, e) => { this.DeliveryMethodChangedHandler(); };
                this.AddProperty(this._DeliveryMethod as global::Sungero.Domain.Client.IProperty);
              }




    public OutgoingDocumentBaseAddressees()
    {
      this._OutgoingDocumentBase = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IOutgoingDocumentBase>("OutgoingDocumentBase", this, true);

            this._Number = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Number", this);
            this._Number.ValueChanged += (sender, e) => { this.NumberChangedHandler(); };
            this.AddProperty(this._Number);

            this.InitCorrespondentNavigationProperty();

            this.InitAddresseeNavigationProperty();

            this.InitDeliveryMethodNavigationProperty();








    }

    #endregion

  }
}
