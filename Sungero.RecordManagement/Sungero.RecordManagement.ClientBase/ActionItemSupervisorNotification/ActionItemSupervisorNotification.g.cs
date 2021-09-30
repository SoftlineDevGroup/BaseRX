
// ==================================================================
// ActionItemSupervisorNotificationEventArgs.g.cs
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
// ActionItemSupervisorNotificationHandlers.g.cs
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

  public partial class ActionItemSupervisorNotificationFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.RecordManagement.IActionItemSupervisorNotificationFilterState Filter { get; private set; }

    private global::Sungero.RecordManagement.IActionItemSupervisorNotificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ActionItemSupervisorNotificationFilteringClientHandler(global::Sungero.RecordManagement.IActionItemSupervisorNotificationFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ActionItemSupervisorNotificationFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class ActionItemSupervisorNotificationClientHandlers : global::Sungero.Workflow.NoticeClientHandlers
  {
    private global::Sungero.RecordManagement.IActionItemSupervisorNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotification)this.Entity; }
    }

    public ActionItemSupervisorNotificationClientHandlers(global::Sungero.RecordManagement.IActionItemSupervisorNotification entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ActionItemSupervisorNotificationClientFunctions.g.cs
// ==================================================================

namespace Sungero.RecordManagement.Client
{
  public partial class ActionItemSupervisorNotificationFunctions : global::Sungero.Workflow.Client.NoticeFunctions
  {
    private global::Sungero.RecordManagement.IActionItemSupervisorNotification _obj
    {
      get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotification)this.Entity; }
    }

    public ActionItemSupervisorNotificationFunctions(global::Sungero.RecordManagement.IActionItemSupervisorNotification entity) : base(entity) { }
  }
}

// ==================================================================
// ActionItemSupervisorNotificationFunctions.g.cs
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
  internal static class ActionItemSupervisorNotification
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.RecordManagement.Server" type="Sungero.RecordManagement.Server.ActionItemSupervisorNotificationFunctions" />
      internal static global::System.String  GetStateView(global::Sungero.RecordManagement.IActionItemSupervisorNotification actionItemSupervisorNotification)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("da4946ab-6876-4bae-b35b-fc63e76974fd"),
          "GetStateView(global::Sungero.RecordManagement.IActionItemSupervisorNotification)"
          , actionItemSupervisorNotification);
      }

    }
  }
}

// ==================================================================
// ActionItemSupervisorNotificationClientPublicFunctions.g.cs
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
  public class ActionItemSupervisorNotificationClientPublicFunctions : global::Sungero.RecordManagement.Client.IActionItemSupervisorNotificationClientPublicFunctions
  {
  }
}

// ==================================================================
// ActionItemSupervisorNotificationActions.g.cs
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
  public partial class ActionItemSupervisorNotificationActions : global::Sungero.Workflow.Client.NoticeActions
  {
    private global::Sungero.RecordManagement.IActionItemSupervisorNotification _obj { get { return (global::Sungero.RecordManagement.IActionItemSupervisorNotification)this.Entity; } }
    public ActionItemSupervisorNotificationActions(global::Sungero.RecordManagement.IActionItemSupervisorNotification entity) : base(entity) { }
  }

  public partial class ActionItemSupervisorNotificationCollectionActions : global::Sungero.Workflow.Client.NoticeCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.RecordManagement.IActionItemSupervisorNotification> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.RecordManagement.IActionItemSupervisorNotification>(this.Entities); }
    }
  }

  public partial class ActionItemSupervisorNotificationAnyChildEntityActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityActions
  {
  }

  public partial class ActionItemSupervisorNotificationAnyChildEntityCollectionActions : global::Sungero.Workflow.Client.NoticeAnyChildEntityCollectionActions
  {
  }

}
