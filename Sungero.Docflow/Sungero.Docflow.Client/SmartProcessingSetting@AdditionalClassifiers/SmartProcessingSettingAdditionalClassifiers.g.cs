
// ==================================================================
// SmartProcessingSettingAdditionalClassifiers.g.cs
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
  public class SmartProcessingSettingAdditionalClassifiers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("9291a868-0317-4b38-880b-45688b98506c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.SmartProcessingSettingAdditionalClassifiers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersState State
    {
      get
      {
        return (global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.SmartProcessingSettingAdditionalClassifiersState(this);
    }

    public new global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.ISmartProcessingSettingAdditionalClassifiersInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.ISmartProcessingSetting> _SmartProcessingSetting;

    public global::Sungero.Docflow.ISmartProcessingSetting SmartProcessingSetting
    {
      get { return this._SmartProcessingSetting.Value; }
      set { this._SmartProcessingSetting.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.SmartProcessingSetting; }
      set { this.SmartProcessingSetting = (global::Sungero.Docflow.ISmartProcessingSetting)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _ClassifierId;

        public virtual global::System.Int32? ClassifierId
        {
          get { return this._ClassifierId.Value; }
          set { this._ClassifierId.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _ClassifierName;

        public virtual global::System.String ClassifierName
        {
          get { return this._ClassifierName.Value; }
          set { this._ClassifierName.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.SmartProcessingSettingAdditionalClassifiersClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.SmartProcessingSettingAdditionalClassifiersSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ClassifierIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ClassifierId, this.ClassifierId, this);
     ((global::Sungero.Docflow.SmartProcessingSettingAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersClassifierIdChanged(args);
    }

    protected void ClassifierNameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ClassifierName, this.ClassifierName, this);
     ((global::Sungero.Docflow.SmartProcessingSettingAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersClassifierNameChanged(args);
    }



  protected global::System.Int32? ClassifierIdValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.ClassifierId, value, this, this.Info.Properties.ClassifierId);
    ((global::Sungero.Docflow.SmartProcessingSettingAdditionalClassifiersClientHandlers)this.Handlers).AdditionalClassifiersClassifierIdValueInput(args);
    return args.NewValue;
  }

  protected global::System.String ClassifierNameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.ClassifierName, value, this, this.Info.Properties.ClassifierName);
    ((global::Sungero.Docflow.SmartProcessingSettingAdditionalClassifiersClientHandlers)this.Handlers).AdditionalClassifiersClassifierNameValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public SmartProcessingSettingAdditionalClassifiers()
    {
      this._SmartProcessingSetting = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.ISmartProcessingSetting>("SmartProcessingSetting", this, true);

            this._ClassifierId = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("ClassifierId", this);
            this._ClassifierId.ValueChanged += (sender, e) => { this.ClassifierIdChangedHandler(); };
            this.AddProperty(this._ClassifierId);

            this._ClassifierName = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("ClassifierName", this);
            this._ClassifierName.ValueChanged += (sender, e) => { this.ClassifierNameChangedHandler(); };
            this.AddProperty(this._ClassifierName);








    }

    #endregion

  }
}
