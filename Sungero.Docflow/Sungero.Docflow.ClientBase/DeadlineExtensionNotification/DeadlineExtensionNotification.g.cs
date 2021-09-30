
// ==================================================================
// DeadlineExtensionNotificationEventArgs.g.cs
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
}

// ==================================================================
// DeadlineExtensionNotificationHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

  public partial class DeadlineExtensionNotificationFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IDeadlineExtensionNotificationFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IDeadlineExtensionNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineExtensionNotificationFilteringClientHandler(global::Sungero.Docflow.IDeadlineExtensionNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected DeadlineExtensionNotificationFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class DeadlineExtensionNotificationClientHandlers : global::Sungero.Workflow.NoticeClientHandlers
  {
    private global::Sungero.Docflow.IDeadlineExtensionNotification _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionNotification)this.Entity; }
    }

    public virtual void NewDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void PreviousDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public DeadlineExtensionNotificationClientHandlers(global::Sungero.Docflow.IDeadlineExtensionNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineExtensionNotificationClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class DeadlineExtensionNotificationFunctions : global::Sungero.Workflow.Client.NoticeFunctions
  {
    private global::Sungero.Docflow.IDeadlineExtensionNotification _obj
    {
      get { return (global::Sungero.Docflow.IDeadlineExtensionNotification)this.Entity; }
    }

    public DeadlineExtensionNotificationFunctions(global::Sungero.Docflow.IDeadlineExtensionNotification entity) : base(entity) { }
  }
}

// ==================================================================
// DeadlineExtensionNotificationFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class DeadlineExtensionNotification
  {
  }
}

// ==================================================================
// DeadlineExtensionNotificationClientPublicFunctions.g.cs
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
  public class DeadlineExtensionNotificationClientPublicFunctions : global::Sungero.Docflow.Client.IDeadlineExtensionNotificationClientPublicFunctions
  {
  }
}

// ==================================================================
// DeadlineExtensionNotificationActions.g.cs
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
  public partial class DeadlineExtensionNotificationActions : global::Sungero.Workflow.Client.NoticeActions
  {
    private global::Sungero.Docflow.IDeadlineExtensionNotification _obj { get { return (global::Sungero.Docflow.IDeadlineExtensionNotification)this.Entity; } }
    public DeadlineExtensionNotificationActions(global::Sungero.Docflow.IDeadlineExtensionNotification entity) : base(entity) { }
  }

  public partial class DeadlineExtensionNotificationCollectionActions : global::Sungero.Workflow.Client.NoticeCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IDeadlineExtensionNotification> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IDeadlineExtensionNotification>(this.Entities); }
    }
  }

  public partial class DeadlineExtensionNotificationAnyChildEntityActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityActions
  {
  }

  public partial class DeadlineExtensionNotificationAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityCollectionActions
  {
  }

}
