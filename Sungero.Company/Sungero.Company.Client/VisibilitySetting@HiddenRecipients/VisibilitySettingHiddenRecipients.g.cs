
// ==================================================================
// VisibilitySettingHiddenRecipients.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Client
{
  public class VisibilitySettingHiddenRecipients :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Company.IVisibilitySettingHiddenRecipients
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e3186c22-e557-43ae-aa99-87dd89dcc1b0");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Client.VisibilitySettingHiddenRecipients.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IVisibilitySettingHiddenRecipients, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Company.IVisibilitySettingHiddenRecipientsState State
    {
      get
      {
        return (global::Sungero.Company.IVisibilitySettingHiddenRecipientsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.VisibilitySettingHiddenRecipientsState(this);
    }

    public new global::Sungero.Company.IVisibilitySettingHiddenRecipientsInfo Info
    {
      get
      {
        return (global::Sungero.Company.IVisibilitySettingHiddenRecipientsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IVisibilitySetting> _VisibilitySetting;

    public global::Sungero.Company.IVisibilitySetting VisibilitySetting
    {
      get { return this._VisibilitySetting.Value; }
      set { this._VisibilitySetting.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.VisibilitySetting; }
      set { this.VisibilitySetting = (global::Sungero.Company.IVisibilitySetting)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Recipient;

              public virtual global::Sungero.Company.IEmployee Recipient
              {
              get
              {
                return this._Recipient.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Recipient as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Company.VisibilitySettingHiddenRecipientsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Company.VisibilitySettingHiddenRecipientsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void RecipientChangedHandler()
    {
      var args = new global::Sungero.Company.Shared.VisibilitySettingHiddenRecipientsRecipientChangedEventArgs(this.State.Properties.Recipient, this.Recipient, this);
     ((global::Sungero.Company.VisibilitySettingHiddenRecipientsSharedHandlers)this.SharedHandlers).HiddenRecipientsRecipientChanged(args);
    }



  protected global::Sungero.Company.IEmployee RecipientValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Company.Client.VisibilitySettingHiddenRecipientsRecipientValueInputEventArgs(this.Recipient, value, this, this.Info.Properties.Recipient);
    ((global::Sungero.Company.VisibilitySettingHiddenRecipientsClientHandlers)this.Handlers).HiddenRecipientsRecipientValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitRecipientNavigationProperty()
              {
                this._Recipient = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Recipient", this);
                this._Recipient.ValueChanged += (sender, e) => { this.RecipientChangedHandler(); };
                this.AddProperty(this._Recipient as global::Sungero.Domain.Client.IProperty);
              }




    public VisibilitySettingHiddenRecipients()
    {
      this._VisibilitySetting = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IVisibilitySetting>("VisibilitySetting", this, true);


            this.InitRecipientNavigationProperty();








    }

    #endregion

  }
}
