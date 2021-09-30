
// ==================================================================
// EntityRecognitionInfoAdditionalClassifiers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Client
{
  public class EntityRecognitionInfoAdditionalClassifiers :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("977c2af3-1cde-4f76-a516-b6c36ad031dd");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Commons.Client.EntityRecognitionInfoAdditionalClassifiers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersState State
    {
      get
      {
        return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Commons.Shared.EntityRecognitionInfoAdditionalClassifiersState(this);
    }

    public new global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersInfo Info
    {
      get
      {
        return (global::Sungero.Commons.IEntityRecognitionInfoAdditionalClassifiersInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Commons.IEntityRecognitionInfo> _EntityRecognitionInfo;

    public global::Sungero.Commons.IEntityRecognitionInfo EntityRecognitionInfo
    {
      get { return this._EntityRecognitionInfo.Value; }
      set { this._EntityRecognitionInfo.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.EntityRecognitionInfo; }
      set { this.EntityRecognitionInfo = (global::Sungero.Commons.IEntityRecognitionInfo)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _ClassifierID;

        public virtual global::System.Int32? ClassifierID
        {
          get { return this._ClassifierID.Value; }
          set { this._ClassifierID.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _PredictedClass;

        public virtual global::System.String PredictedClass
        {
          get { return this._PredictedClass.Value; }
          set { this._PredictedClass.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Double?> _Probability;

        public virtual global::System.Double? Probability
        {
          get { return this._Probability.Value; }
          set { this._Probability.Value = value; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ClassifierIDChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ClassifierID, this.ClassifierID, this);
     ((global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersClassifierIDChanged(args);
    }

    protected void PredictedClassChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.PredictedClass, this.PredictedClass, this);
     ((global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersPredictedClassChanged(args);
    }

    protected void ProbabilityChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DoublePropertyChangedEventArgs(this.State.Properties.Probability, this.Probability, this);
     ((global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersSharedHandlers)this.SharedHandlers).AdditionalClassifiersProbabilityChanged(args);
    }



  protected global::System.Int32? ClassifierIDValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.ClassifierID, value, this, this.Info.Properties.ClassifierID);
    ((global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersClientHandlers)this.Handlers).AdditionalClassifiersClassifierIDValueInput(args);
    return args.NewValue;
  }

  protected global::System.String PredictedClassValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.PredictedClass, value, this, this.Info.Properties.PredictedClass);
    ((global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersClientHandlers)this.Handlers).AdditionalClassifiersPredictedClassValueInput(args);
    return args.NewValue;
  }

  protected global::System.Double? ProbabilityValueInputHandler(global::System.Double? value)
  {
    var args = new global::Sungero.Presentation.DoubleValueInputEventArgs(this.Probability, value, this, this.Info.Properties.Probability);
    ((global::Sungero.Commons.EntityRecognitionInfoAdditionalClassifiersClientHandlers)this.Handlers).AdditionalClassifiersProbabilityValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



    public EntityRecognitionInfoAdditionalClassifiers()
    {
      this._EntityRecognitionInfo = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Commons.IEntityRecognitionInfo>("EntityRecognitionInfo", this, true);

            this._ClassifierID = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("ClassifierID", this);
            this._ClassifierID.ValueChanged += (sender, e) => { this.ClassifierIDChangedHandler(); };
            this.AddProperty(this._ClassifierID);

            this._PredictedClass = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("PredictedClass", this);
            this._PredictedClass.ValueChanged += (sender, e) => { this.PredictedClassChangedHandler(); };
            this.AddProperty(this._PredictedClass);

            this._Probability = new global::Sungero.Domain.Client.SimpleProperty<global::System.Double?>("Probability", this);
            this._Probability.ValueChanged += (sender, e) => { this.ProbabilityChangedHandler(); };
            this.AddProperty(this._Probability);








    }

    #endregion

  }
}