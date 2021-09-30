
// ==================================================================
// DocumentKindAvailableActions.g.cs
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
  public class DocumentKindAvailableActions :
    global::Sungero.Domain.Client.ChildEntityProxy, global::Sungero.Docflow.IDocumentKindAvailableActions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("79e911f6-531b-482f-8984-a89bb41f65f6");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.DocumentKindAvailableActions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentKindAvailableActions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Docflow.IDocumentKindAvailableActionsState State
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentKindAvailableActionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentKindAvailableActionsState(this);
    }

    public new global::Sungero.Docflow.IDocumentKindAvailableActionsInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IDocumentKindAvailableActionsInfo)base.Info;
      }
    }

    protected global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IDocumentKind> _DocumentKind;

    public global::Sungero.Docflow.IDocumentKind DocumentKind
    {
      get { return this._DocumentKind.Value; }
      set { this._DocumentKind.Value = value; }
    }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.DocumentKind; }
      set { this.DocumentKind = (global::Sungero.Docflow.IDocumentKind)value; }
    }




              protected global::Sungero.Domain.Client.INavigationProperty<global::Sungero.Docflow.IDocumentSendAction> _Action;

              public virtual global::Sungero.Docflow.IDocumentSendAction Action
              {
              get
              {
                return this._Action.Value as global::Sungero.Docflow.IDocumentSendAction;
              }

              set
              {
                (this._Action as global::Sungero.Domain.Client.IProperty).Value = value;
              }
            }










    #endregion

    #region Methods

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentKindAvailableActionsClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentKindAvailableActionsSharedHandlers(this);
    }

    #endregion

    #region Framework events

    protected void ActionChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentKindAvailableActionsActionChangedEventArgs(this.State.Properties.Action, this.Action, this);
     ((global::Sungero.Docflow.DocumentKindAvailableActionsSharedHandlers)this.SharedHandlers).AvailableActionsActionChanged(args);
    }



  protected global::Sungero.Docflow.IDocumentSendAction ActionValueInputHandler(global::Sungero.Docflow.IDocumentSendAction value)
  {
    var args = new global::Sungero.Docflow.Client.DocumentKindAvailableActionsActionValueInputEventArgs(this.Action, value, this, this.Info.Properties.Action);
    ((global::Sungero.Docflow.DocumentKindAvailableActionsClientHandlers)this.Handlers).AvailableActionsActionValueInput(args);
    return args.NewValue;
  }



    #endregion

    #region Constructors



              protected virtual void InitActionNavigationProperty()
              {
                this._Action = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IDocumentSendAction>("Action", this);
                this._Action.ValueChanged += (sender, e) => { this.ActionChangedHandler(); };
                this.AddProperty(this._Action as global::Sungero.Domain.Client.IProperty);
              }




    public DocumentKindAvailableActions()
    {
      this._DocumentKind = new global::Sungero.Domain.Client.NavigationProperty<global::Sungero.Docflow.IDocumentKind>("DocumentKind", this, true);


            this.InitActionNavigationProperty();








    }

    #endregion

  }
}
