
// ==================================================================
// ActionItemExecutionTaskActionItemParts.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class ActionItemExecutionTaskActionItemParts :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("e2e199fe-7c2e-403f-8986-7a6801f86191");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.ActionItemExecutionTaskActionItemParts.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsState State
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsState(this);
    }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask> _ActionItemExecutionTask;

    public global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemExecutionTask
    {
      get { return this._ActionItemExecutionTask.Value; }
      set { this._ActionItemExecutionTask.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ActionItemExecutionTask; }
      set { this.ActionItemExecutionTask = (global::Sungero.RecordManagement.IActionItemExecutionTask)value; }
    }

        protected global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?> _Deadline;

        public virtual global::System.DateTime? Deadline
        {
          get { return this._Deadline.Value; }
          set { this._Deadline.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?> _Number;

        public virtual global::System.Int32? Number
        {
          get { return this._Number.Value; }
          set { this._Number.Value = value; }
        }
        protected global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?> _AssignmentCreated;

        public virtual global::System.Boolean? AssignmentCreated
        {
          get { return this._AssignmentCreated.Value; }
          set { this._AssignmentCreated.Value = value; }
        }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Company.IEmployee> _Assignee;

              public virtual global::Sungero.Company.IEmployee Assignee
              {
              get
              {
                return this._Assignee.Value as global::Sungero.Company.IEmployee;
              }

              set
              {
                (this._Assignee as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }



              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask> _ActionItemPartExecutionTask;

              public virtual global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemPartExecutionTask
              {
              get
              {
                return this._ActionItemPartExecutionTask.Value as global::Sungero.RecordManagement.IActionItemExecutionTask;
              }

              set
              {
                (this._ActionItemPartExecutionTask as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }








      protected global::Sungero.Domain.Client.TextProperty _ActionItemPart;

      [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
      public virtual System.String ActionItemPart
      {
        get { return this._ActionItemPart.Value; }
        set { this._ActionItemPart.Value = value; }
      }



    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ActionItemPartChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.ActionItemPart, this.ActionItemPart, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsActionItemPartChanged(args);
    }

    protected void AssigneeChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsAssigneeChangedEventArgs(this.State.Properties.Assignee, this.Assignee, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsAssigneeChanged(args);
    }

    protected void DeadlineChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Deadline, this.Deadline, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsDeadlineChanged(args);
    }

    protected void NumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.Number, this.Number, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsNumberChanged(args);
    }

    protected void ActionItemPartExecutionTaskChangedHandler()
    {
      var args = new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskChangedEventArgs(this.State.Properties.ActionItemPartExecutionTask, this.ActionItemPartExecutionTask, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsActionItemPartExecutionTaskChanged(args);
    }

    protected void AssignmentCreatedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.AssignmentCreated, this.AssignmentCreated, this);
     ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsSharedHandlers)this.SharedHandlers).ActionItemPartsAssignmentCreatedChanged(args);
    }



  protected global::System.String ActionItemPartValueInputHandler(global::System.String value)
  {
    var args = new global::Sungero.Presentation.TextValueInputEventArgs(this.ActionItemPart, value, this, this.Info.Properties.ActionItemPart);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers)this.Handlers).ActionItemPartsActionItemPartValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.Company.IEmployee AssigneeValueInputHandler(global::Sungero.Company.IEmployee value)
  {
    var args = new global::Sungero.RecordManagement.Client.ActionItemExecutionTaskActionItemPartsAssigneeValueInputEventArgs(this.Assignee, value, this, this.Info.Properties.Assignee);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers)this.Handlers).ActionItemPartsAssigneeValueInput(args);
    return args.NewValue;
  }

  protected global::System.DateTime? DeadlineValueInputHandler(global::System.DateTime? value)
  {
    var args = new global::Sungero.Presentation.DateTimeValueInputEventArgs(this.Deadline, value, this, this.Info.Properties.Deadline);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers)this.Handlers).ActionItemPartsDeadlineValueInput(args);
    return args.NewValue;
  }

  protected global::System.Int32? NumberValueInputHandler(global::System.Int32? value)
  {
    var args = new global::Sungero.Presentation.IntegerValueInputEventArgs(this.Number, value, this, this.Info.Properties.Number);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers)this.Handlers).ActionItemPartsNumberValueInput(args);
    return args.NewValue;
  }

  protected global::Sungero.RecordManagement.IActionItemExecutionTask ActionItemPartExecutionTaskValueInputHandler(global::Sungero.RecordManagement.IActionItemExecutionTask value)
  {
    var args = new global::Sungero.RecordManagement.Client.ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskValueInputEventArgs(this.ActionItemPartExecutionTask, value, this, this.Info.Properties.ActionItemPartExecutionTask);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers)this.Handlers).ActionItemPartsActionItemPartExecutionTaskValueInput(args);
    return args.NewValue;
  }

  protected global::System.Boolean? AssignmentCreatedValueInputHandler(global::System.Boolean? value)
  {
    var args = new global::Sungero.Presentation.BooleanValueInputEventArgs(this.AssignmentCreated, value, this, this.Info.Properties.AssignmentCreated);
    ((global::Sungero.RecordManagement.ActionItemExecutionTaskActionItemPartsClientHandlers)this.Handlers).ActionItemPartsAssignmentCreatedValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitAssigneeNavigationProperty()
              {
                this._Assignee = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Company.IEmployee>("Assignee", this);
                this._Assignee.ValueChanged += (sender, e) => { this.AssigneeChangedHandler(); };
                this.AddProperty(this._Assignee as global::Sungero.Domain.Client.IProperty);
              }




              protected virtual void InitActionItemPartExecutionTaskNavigationProperty()
              {
                this._ActionItemPartExecutionTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemPartExecutionTask", this);
                this._ActionItemPartExecutionTask.ValueChanged += (sender, e) => { this.ActionItemPartExecutionTaskChangedHandler(); };
                this.AddProperty(this._ActionItemPartExecutionTask as global::Sungero.Domain.Client.IProperty);
              }




    public ActionItemExecutionTaskActionItemParts()
    {
      this._ActionItemExecutionTask = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemExecutionTask", this, true);

            this._Deadline = new global::Sungero.Domain.Client.SimpleProperty<global::System.DateTime?>("Deadline", this);
            this._Deadline.ValueChanged += (sender, e) => { this.DeadlineChangedHandler(); };
            this.AddProperty(this._Deadline);

            this._Number = new global::Sungero.Domain.Client.SimpleProperty<global::System.Int32?>("Number", this);
            this._Number.ValueChanged += (sender, e) => { this.NumberChangedHandler(); };
            this.AddProperty(this._Number);

            this._AssignmentCreated = new global::Sungero.Domain.Client.SimpleProperty<global::System.Boolean?>("AssignmentCreated", this);
            this._AssignmentCreated.ValueChanged += (sender, e) => { this.AssignmentCreatedChangedHandler(); };
            this.AddProperty(this._AssignmentCreated);

            this.InitAssigneeNavigationProperty();

            this.InitActionItemPartExecutionTaskNavigationProperty();



            this._ActionItemPart = new global::Sungero.Domain.Client.TextProperty("ActionItemPart", this);
            this._ActionItemPart.ValueChanged += (sender, e) => { this.ActionItemPartChangedHandler(); };
            this.AddProperty(this._ActionItemPart);






    }

    #endregion

  }
}
