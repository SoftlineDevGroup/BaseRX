
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

namespace Sungero.RecordManagement.Client
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

namespace Sungero.RecordManagement
{

  public partial class DeadlineExtensionNotificationFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IDeadlineExtensionNotificationFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IDeadlineExtensionNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public DeadlineExtensionNotificationFilteringClientHandler(global::Sungero.RecordManagement.IDeadlineExtensionNotificationFilterState filter)
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
    private global::Sungero.RecordManagement.IDeadlineExtensionNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionNotification)this.Entity; }
    }

    public virtual void NewDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public virtual void PreviousDeadlineValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }


    public DeadlineExtensionNotificationClientHandlers(global::Sungero.RecordManagement.IDeadlineExtensionNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// DeadlineExtensionNotificationClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class DeadlineExtensionNotificationFunctions : global::Sungero.Workflow.Client.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IDeadlineExtensionNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IDeadlineExtensionNotification)this.Entity; }
    }

    public DeadlineExtensionNotificationFunctions(global::Sungero.RecordManagement.IDeadlineExtensionNotification entity) : base(entity) { }
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

namespace Sungero.RecordManagement.Functions
{
  internal static class DeadlineExtensionNotification
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.DeadlineExtensionNotificationFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IDeadlineExtensionNotification deadlineExtensionNotification)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("db855988-d42a-4cc5-a610-afff7ffb9560"),
          "GetStateView(global::Sungero.RecordManagement.IDeadlineExtensionNotification)"
          , deadlineExtensionNotification);
      }

    }
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

namespace Sungero.RecordManagement.Client
{
  public class DeadlineExtensionNotificationClientPublicFunctions : global::Sungero.RecordManagement.Client.IDeadlineExtensionNotificationClientPublicFunctions
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

namespace Sungero.RecordManagement.Client
{
  public partial class DeadlineExtensionNotificationActions : global::Sungero.Workflow.Client.NoticeActions
  {
    private global::Sungero.RecordManagement.IDeadlineExtensionNotification _obj { get { return (global::Sungero.RecordManagement.IDeadlineExtensionNotification)this.Entity; } }
    public DeadlineExtensionNotificationActions(global::Sungero.RecordManagement.IDeadlineExtensionNotification entity) : base(entity) { }
  }

  public partial class DeadlineExtensionNotificationCollectionActions : global::Sungero.Workflow.Client.NoticeCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IDeadlineExtensionNotification> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IDeadlineExtensionNotification>(this.Entities); }
    }
  }

  public partial class DeadlineExtensionNotificationAnyChildEntityActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityActions
  {
  }

  public partial class DeadlineExtensionNotificationAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityCollectionActions
  {
  }

}
