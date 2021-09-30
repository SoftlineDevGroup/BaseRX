
// ==================================================================
// ContractualDocumentMilestones.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Client
{
  public class ContractualDocumentMilestones :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Contracts.IContractualDocumentMilestones
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("478d3e3d-4519-4bb0-b009-c43f7fbe0b95");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Contracts.Client.ContractualDocumentMilestones.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Contracts.IContractualDocumentMilestones, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Contracts.IContractualDocumentMilestonesState State
    {
      get
      {
        return (global::Sungero.Contracts.IContractualDocumentMilestonesState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Contracts.Shared.ContractualDocumentMilestonesState(this);
    }

    public new global::Sungero.Contracts.IContractualDocumentMilestonesInfo Info
    {
      get
      {
        return (global::Sungero.Contracts.IContractualDocumentMilestonesInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Contracts.IContractualDocument> _ContractualDocument;

    public global::Sungero.Contracts.IContractualDocument ContractualDocument
    {
      get { return this._ContractualDocument.Value; }
      set { this._ContractualDocument.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ContractualDocument; }
      set { this.ContractualDocument = (global::Sungero.Contracts.IContractualDocument)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Name;

        public virtual global::System.String Name
        {
          get { return this._Name.Value; }
          set { this._Name.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _Deadline;

        public virtual global::System.DateTime? Deadline
        {
          get { return this._Deadline.Value; }
          set { this._Deadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _DaysToFinishWorks;

        public virtual global::System.Int32? DaysToFinishWorks
        {
          get { return this._DaysToFinishWorks.Value; }
          set { this._DaysToFinishWorks.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _IsCompleted;

        public virtual global::System.Boolean? IsCompleted
        {
          get { return this._IsCompleted.Value; }
          set { this._IsCompleted.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.String> _Note;

        public virtual global::System.String Note
        {
          get { return this._Note.Value; }
          set { this._Note.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Performer;

              public virtual global::Sungero.Company.IEmployee Performer
              {
              get
              {
                return this._Performer.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Performer as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Workflow.ISimpleTask> _Task;

              public virtual global::Sungero.Workflow.ISimpleTask Task
              {
              get
              {
                return this._Task.Value as global::Sungero.Workflow.ISimpleTask;
              }

              set
              {
                (this._Task as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesNameChanged(args);
    }

    protected void DeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Deadline, this.Deadline, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesDeadlineChanged(args);
    }

    protected void DaysToFinishWorksChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DaysToFinishWorks, this.DaysToFinishWorks, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesDaysToFinishWorksChanged(args);
    }

    protected void PerformerChangedHandler()
    {
      var args = new global::Sungero.Contracts.Shared.ContractualDocumentMilestonesPerformerChangedEventArgs(this.State.Properties.Performer, this.Performer, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesPerformerChanged(args);
    }

    protected void IsCompletedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsCompleted, this.IsCompleted, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesIsCompletedChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesNoteChanged(args);
    }

    protected void TaskChangedHandler()
    {
      var args = new global::Sungero.Contracts.Shared.ContractualDocumentMilestonesTaskChangedEventArgs(this.State.Properties.Task, this.Task, this);
     ((global::Sungero.Contracts.ContractualDocumentMilestonesSharedHandlers)this.SharedHandlers).MilestonesTaskChanged(args);
    }



  protected global::System.String NameValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Name, value, this, this.Info.Properties.Name);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesNameValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? DeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.Deadline, value, this, this.Info.Properties.Deadline);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? DaysToFinishWorksValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.DaysToFinishWorks, value, this, this.Info.Properties.DaysToFinishWorks);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesDaysToFinishWorksValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee PerformerValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.Contracts.Client.ContractualDocumentMilestonesPerformerValueInputEventArgs(this.Performer, value, this, this.Info.Properties.Performer);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesPerformerValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? IsCompletedValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.IsCompleted, value, this, this.Info.Properties.IsCompleted);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesIsCompletedValueInput(args);
    return args.NewValue;
  }

  protected global::System.String NoteValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.StringValueInputEventArgs(this.Note, value, this, this.Info.Properties.Note);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesNoteValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Workflow.ISimpleTask TaskValueInputHandler(global::Sungero.Workflow.ISimpleTask value)
  {
    var args = new global::Sungero.Contracts.Client.ContractualDocumentMilestonesTaskValueInputEventArgs(this.Task, value, this, this.Info.Properties.Task);
    ((global::Sungero.Contracts.ContractualDocumentMilestonesClientHandlers)this.Handlers).MilestonesTaskValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitPerformerNavigationProperty()
              {
                this._Performer = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Performer", this);
                this._Performer.ValueChanged += (sender, e) => { this.PerformerChangedHandler(); };
                this.AddProperty(this._Performer as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitTaskNavigationProperty()
              {
                this._Task = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Workflow.ISimpleTask>("Task", this);
                this._Task.ValueChanged += (sender, e) => { this.TaskChangedHandler(); };
                this.AddProperty(this._Task as global::Sungero.Domain.Client.IProperty);
              }




    public ContractualDocumentMilestones()
    {
      this._ContractualDocument = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Contracts.IContractualDocument>("ContractualDocument", this, true);

            this._Name = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Name", this);
            this._Name.ValueChanged += (sender, e) => { this.NameChangedHandler(); };
            this.AddProperty(this._Name);

            this._Deadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("Deadline", this);
            this._Deadline.ValueChanged += (sender, e) => { this.DeadlineChangedHandler(); };
            this.AddProperty(this._Deadline);

            this._DaysToFinishWorks = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("DaysToFinishWorks", this);
            this._DaysToFinishWorks.ValueChanged += (sender, e) => { this.DaysToFinishWorksChangedHandler(); };
            this.AddProperty(this._DaysToFinishWorks);

            this._IsCompleted = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("IsCompleted", this);
            this._IsCompleted.ValueChanged += (sender, e) => { this.IsCompletedChangedHandler(); };
            this.AddProperty(this._IsCompleted);

            this._Note = new global::Sungero.Domain.Client.SimpleProperty<global::System.String>("Note", this);
            this._Note.ValueChanged += (sender, e) => { this.NoteChangedHandler(); };
            this.AddProperty(this._Note);

            this.InitPerformerNavigationProperty();

            this.InitTaskNavigationProperty();








    }

    #endregion

  }
}