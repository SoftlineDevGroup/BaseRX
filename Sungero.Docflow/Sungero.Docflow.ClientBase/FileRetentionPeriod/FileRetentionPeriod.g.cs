
// ==================================================================
// FileRetentionPeriodEventArgs.g.cs
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
// FileRetentionPeriodHandlers.g.cs
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

  public partial class FileRetentionPeriodFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IFileRetentionPeriodFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IFileRetentionPeriodFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public FileRetentionPeriodFilteringClientHandler(global::Sungero.Docflow.IFileRetentionPeriodFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected FileRetentionPeriodFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class FileRetentionPeriodClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.IFileRetentionPeriod _obj
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriod)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }



    public virtual void NoteValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public FileRetentionPeriodClientHandlers(global::Sungero.Docflow.IFileRetentionPeriod entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// FileRetentionPeriodClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class FileRetentionPeriodFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IFileRetentionPeriod _obj
    {
      get { return (global::Sungero.Docflow.IFileRetentionPeriod)this.Entity; }
    }

    public FileRetentionPeriodFunctions(global::Sungero.Docflow.IFileRetentionPeriod entity) : base(entity) { }
  }
}

// ==================================================================
// FileRetentionPeriodFunctions.g.cs
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
  internal static class FileRetentionPeriod
  {
  }
}

// ==================================================================
// FileRetentionPeriodClientPublicFunctions.g.cs
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
  public class FileRetentionPeriodClientPublicFunctions : global::Sungero.Docflow.Client.IFileRetentionPeriodClientPublicFunctions
  {
  }
}

// ==================================================================
// FileRetentionPeriodActions.g.cs
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
  public partial class FileRetentionPeriodActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.IFileRetentionPeriod _obj { get { return (global::Sungero.Docflow.IFileRetentionPeriod)this.Entity; } }
    public FileRetentionPeriodActions(global::Sungero.Docflow.IFileRetentionPeriod entity) : base(entity) { }
  }

  public partial class FileRetentionPeriodCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IFileRetentionPeriod> _objs
    { 
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IFileRetentionPeriod>(this.Entities); }
    }
  }

  public partial class FileRetentionPeriodAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class FileRetentionPeriodAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }

}
