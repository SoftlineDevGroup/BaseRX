
// ==================================================================
// ApprovalStageRecipients.g.cs
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
  public class ApprovalStageRecipients :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalStageRecipients
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("278a6b5f-97b8-4f82-a0e7-9b9031ed27d4");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalStageRecipients.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalStageRecipients, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalStageRecipientsState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalStageRecipientsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalStageRecipientsState(this);
    }

    public new global::Sungero.Docflow.IApprovalStageRecipientsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalStageRecipientsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStage> _ApprovalStage;

    public global::Sungero.Docflow.IApprovalStage ApprovalStage
    {
      get { return this._ApprovalStage.Value; }
      set { this._ApprovalStage.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalStage; }
      set { this.ApprovalStage = (global::Sungero.Docflow.IApprovalStage)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.CoreEntities.IRecipient> _Recipient;

              public virtual global::Sungero.CoreEntities.IRecipient Recipient
              {
              get
              {
                return this._Recipient.Value as global::Sungero.CoreEntities.IRecipient;
              }

              set
              {
                (this._Recipient as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalStageRecipientsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalStageRecipientsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void RecipientChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.ApprovalStageRecipientsRecipientChangedEventArgs(this.State.Properties.Recipient, this.Recipient, this);
     ((global::Sungero.Docflow.ApprovalStageRecipientsSharedHandlers)this.SharedHandlers).RecipientsRecipientChanged(args);
    }



  protected global::Sungero.CoreEntities.IRecipient RecipientValueInputHandler(global::Sungero.CoreEntities.IRecipient value)
  {
    var args = new global::Sungero.Docflow.Client.ApprovalStageRecipientsRecipientValueInputEventArgs(this.Recipient, value, this, this.Info.Properties.Recipient);
    ((global::Sungero.Docflow.ApprovalStageRecipientsClientHandlers)this.Handlers).RecipientsRecipientValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitRecipientNavigationProperty()
              {
                this._Recipient = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.CoreEntities.IRecipient>("Recipient", this);
                this._Recipient.ValueChanged += (sender, e) => { this.RecipientChangedHandler(); };
                this.AddProperty(this._Recipient as global::Sungero.Domain.Client.IProperty);
              }




    public ApprovalStageRecipients()
    {
      this._ApprovalStage = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalStage>("ApprovalStage", this, true);


            this.InitRecipientNavigationProperty();








    }

    #endregion

  }
}