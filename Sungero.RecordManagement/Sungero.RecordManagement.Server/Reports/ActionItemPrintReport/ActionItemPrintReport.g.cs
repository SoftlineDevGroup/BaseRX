
// ==================================================================
// ActionItemPrintReport.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class ActionItemPrintReport : global::Sungero.Reporting.Server.Report, global::Sungero.RecordManagement.IActionItemPrintReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("b3c50de9-0a56-42bb-a52a-48309c5ccef3");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
    }


    public global::Sungero.RecordManagement.IActionItemExecutionTask Task
    {
      get
      {
          return this.GetParameterValue("Task") as global::Sungero.RecordManagement.IActionItemExecutionTask;
      }
      set
      {
        this.SetParameterValue("Task", value);
      }
    }


    public global::System.String Supervisor
    {
      get
      {
          return this.GetParameterValue("Supervisor") as global::System.String;
      }
      set
      {
        this.SetParameterValue("Supervisor", value);
      }
    }


    public global::System.String DocumentShortName
    {
      get
      {
          return this.GetParameterValue("DocumentShortName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("DocumentShortName", value);
      }
    }


    public global::System.String ReportSessionId
    {
      get
      {
          return this.GetParameterValue("ReportSessionId") as global::System.String;
      }
      set
      {
        this.SetParameterValue("ReportSessionId", value);
      }
    }


    public global::Sungero.Workflow.IAssignment Assignment
    {
      get
      {
          return this.GetParameterValue("Assignment") as global::Sungero.Workflow.IAssignment;
      }
      set
      {
        this.SetParameterValue("Assignment", value);
      }
    }


    public global::System.String Author
    {
      get
      {
          return this.GetParameterValue("Author") as global::System.String;
      }
      set
      {
        this.SetParameterValue("Author", value);
      }
    }


    public global::System.String PrintedBy
    {
      get
      {
          return this.GetParameterValue("PrintedBy") as global::System.String;
      }
      set
      {
        this.SetParameterValue("PrintedBy", value);
      }
    }



    public ActionItemPrintReport()
    {
      this.Handlers = new global::Sungero.RecordManagement.ActionItemPrintReportServerHandlers(this);
    }
  }
}

// ==================================================================
// ActionItemPrintReportHandlers.g.cs
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
  public partial class ActionItemPrintReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.RecordManagement.IActionItemPrintReport ActionItemPrintReport
    {
      get { return (global::Sungero.RecordManagement.IActionItemPrintReport)this._Report; }
    }

    public ActionItemPrintReportServerHandlers(global::Sungero.RecordManagement.IActionItemPrintReport report) : base(report) { }
  }
}

// ==================================================================
// ActionItemPrintReportRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
  public class ActionItemPrintReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.RecordManagement.IActionItemPrintReportRepositoryImplementer<T>
    where T : global::Sungero.RecordManagement.IActionItemPrintReport 
  {
  }
}

// ==================================================================
// ActionItemPrintReportQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Queries
{
  public class ActionItemPrintReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.Reports.ActionItemPrintReport.ActionItemPrintReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string SelectData
    {
       get { return resolver.GetQuery("SelectData"); }
    }
    public static string CreateActionItemPrintReportTable
    {
       get { return resolver.GetQuery("CreateActionItemPrintReportTable"); }
    }
  }
}
