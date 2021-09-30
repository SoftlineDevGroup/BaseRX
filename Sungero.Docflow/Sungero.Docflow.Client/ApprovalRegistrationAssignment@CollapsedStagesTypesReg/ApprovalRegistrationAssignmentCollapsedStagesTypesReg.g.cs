
// ==================================================================
// ApprovalRegistrationAssignmentCollapsedStagesTypesReg.g.cs
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
  public class ApprovalRegistrationAssignmentCollapsedStagesTypesReg :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6f3a5243-37f1-43d1-8e76-f7e7dc1999fd");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentCollapsedStagesTypesReg.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesReg, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRegistrationAssignmentCollapsedStagesTypesRegState(this);
    }

    public new global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRegistrationAssignmentCollapsedStagesTypesRegInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRegistrationAssignment> _ApprovalRegistrationAssignment;

    public global::Sungero.Docflow.IApprovalRegistrationAssignment ApprovalRegistrationAssignment
    {
      get { return this._ApprovalRegistrationAssignment.Value; }
      set { this._ApprovalRegistrationAssignment.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.ApprovalRegistrationAssignment; }
      set { this.ApprovalRegistrationAssignment = (global::Sungero.Docflow.IApprovalRegistrationAssignment)value; }
    }

        protected global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?> _StageType;

        public virtual global::Sungero.Core.Enumeration? StageType
        {
          get { return this._StageType.Value; }
          set { this._StageType.Value = value; }
        }


        private static global::Sungero.Domain.Shared.EnumerationItems _StageTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
          null,
          typeof(global::Sungero.Docflow.ApprovalRegistrationAssignmentCollapsedStagesTypesReg.StageType),
          typeof(global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentCollapsedStagesTypesReg),
          "StageType");

        public static global::Sungero.Domain.Shared.EnumerationItems StageTypeItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentCollapsedStagesTypesReg._StageTypeItems; }
        }

        public virtual global::Sungero.Domain.Shared.EnumerationItems StageTypeAllowedItems
        {
          get { return global::Sungero.Docflow.Client.ApprovalRegistrationAssignmentCollapsedStagesTypesReg.StageTypeItems; }
        }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRegistrationAssignmentCollapsedStagesTypesRegClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRegistrationAssignmentCollapsedStagesTypesRegSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void StageTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.StageType, this.StageType, this);
     ((global::Sungero.Docflow.ApprovalRegistrationAssignmentCollapsedStagesTypesRegSharedHandlers)this.SharedHandlers).CollapsedStagesTypesRegStageTypeChanged(args);
    }



  protected global::Sungero.Core.Enumeration? StageTypeValueInputHandler(global::Sungero.Core.Enumeration? value)
  {
    var args = new global::Sungero.Presentation.EnumerationValueInputEventArgs(this.StageType, value, this, this.Info.Properties.StageType);
    ((global::Sungero.Docflow.ApprovalRegistrationAssignmentCollapsedStagesTypesRegClientHandlers)this.Handlers).CollapsedStagesTypesRegStageTypeValueInput(args);
    return args.NewValue;
  }


  protected global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> StageTypeFilteringHandler()
  {
    return ((global::Sungero.Docflow.ApprovalRegistrationAssignmentCollapsedStagesTypesRegClientHandlers)this.Handlers).CollapsedStagesTypesRegStageTypeFiltering(this.StageTypeAllowedItems);
  }


    #endregion

    #region Constructors



    public ApprovalRegistrationAssignmentCollapsedStagesTypesReg()
    {
      this._ApprovalRegistrationAssignment = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IApprovalRegistrationAssignment>("ApprovalRegistrationAssignment", this, true);

            this._StageType = new global::Sungero.Domain.Client.EnumSimpleProperty<global::Sungero.Core.Enumeration?>("StageType", this);
            this._StageType.ValueChanged += (sender, e) => { this.StageTypeChangedHandler(); };
            this.AddProperty(this._StageType);








    }

    #endregion

  }
}
