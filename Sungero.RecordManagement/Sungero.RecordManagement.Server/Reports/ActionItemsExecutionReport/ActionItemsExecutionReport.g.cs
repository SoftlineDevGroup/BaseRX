
// ==================================================================
// ActionItemsExecutionReport.g.cs
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
  public class ActionItemsExecutionReport : global::Sungero.Reporting.Server.Report, global::Sungero.RecordManagement.IActionItemsExecutionReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("48704d21-fc8c-4081-8a24-575cc8264537");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
    }


    public global::System.Nullable<global::System.DateTime> BeginDate
    {
      get
      {
          return this.GetParameterValue("BeginDate") as global::System.Nullable<global::System.DateTime>;
      }
      set
      {
        this.SetParameterValue("BeginDate", value);
      }
    }


    public global::System.Nullable<global::System.DateTime> EndDate
    {
      get
      {
          return this.GetParameterValue("EndDate") as global::System.Nullable<global::System.DateTime>;
      }
      set
      {
        this.SetParameterValue("EndDate", value);
      }
    }


    public global::System.String ExecutiveDisciplineLevel
    {
      get
      {
          return this.GetParameterValue("ExecutiveDisciplineLevel") as global::System.String;
      }
      set
      {
        this.SetParameterValue("ExecutiveDisciplineLevel", value);
      }
    }


    public global::System.Nullable<global::System.DateTime> ClientEndDate
    {
      get
      {
          return this.GetParameterValue("ClientEndDate") as global::System.Nullable<global::System.DateTime>;
      }
      set
      {
        this.SetParameterValue("ClientEndDate", value);
      }
    }


    public global::System.Nullable<global::System.DateTime> ReportDate
    {
      get
      {
          return this.GetParameterValue("ReportDate") as global::System.Nullable<global::System.DateTime>;
      }
      set
      {
        this.SetParameterValue("ReportDate", value);
      }
    }


    public global::Sungero.CoreEntities.IUser Performer
    {
      get
      {
          return this.GetParameterValue("Performer") as global::Sungero.CoreEntities.IUser;
      }
      set
      {
        this.SetParameterValue("Performer", value);
      }
    }


    public global::Sungero.Company.IDepartment Department
    {
      get
      {
          return this.GetParameterValue("Department") as global::Sungero.Company.IDepartment;
      }
      set
      {
        this.SetParameterValue("Department", value);
      }
    }


    public global::Sungero.Company.IEmployee Author
    {
      get
      {
          return this.GetParameterValue("Author") as global::Sungero.Company.IEmployee;
      }
      set
      {
        this.SetParameterValue("Author", value);
      }
    }


    public global::Sungero.Company.IBusinessUnit BusinessUnit
    {
      get
      {
          return this.GetParameterValue("BusinessUnit") as global::Sungero.Company.IBusinessUnit;
      }
      set
      {
        this.SetParameterValue("BusinessUnit", value);
      }
    }


    public global::System.Nullable<global::System.Int32> TotalCount
    {
      get
      {
          return this.GetParameterValue("TotalCount") as global::System.Nullable<global::System.Int32>;
      }
      set
      {
        this.SetParameterValue("TotalCount", value);
      }
    }


    public global::System.Nullable<global::System.Int32> Completed
    {
      get
      {
          return this.GetParameterValue("Completed") as global::System.Nullable<global::System.Int32>;
      }
      set
      {
        this.SetParameterValue("Completed", value);
      }
    }


    public global::System.Nullable<global::System.Int32> CompletedInTime
    {
      get
      {
          return this.GetParameterValue("CompletedInTime") as global::System.Nullable<global::System.Int32>;
      }
      set
      {
        this.SetParameterValue("CompletedInTime", value);
      }
    }


    public global::System.Nullable<global::System.Int32> CompletedOverdue
    {
      get
      {
          return this.GetParameterValue("CompletedOverdue") as global::System.Nullable<global::System.Int32>;
      }
      set
      {
        this.SetParameterValue("CompletedOverdue", value);
      }
    }


    public global::System.Nullable<global::System.Int32> InProcess
    {
      get
      {
          return this.GetParameterValue("InProcess") as global::System.Nullable<global::System.Int32>;
      }
      set
      {
        this.SetParameterValue("InProcess", value);
      }
    }


    public global::System.Nullable<global::System.Int32> InProcessOverdue
    {
      get
      {
          return this.GetParameterValue("InProcessOverdue") as global::System.Nullable<global::System.Int32>;
      }
      set
      {
        this.SetParameterValue("InProcessOverdue", value);
      }
    }


    public global::System.String ParamsDescriprion
    {
      get
      {
          return this.GetParameterValue("ParamsDescriprion") as global::System.String;
      }
      set
      {
        this.SetParameterValue("ParamsDescriprion", value);
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


    public global::Sungero.Docflow.IOfficialDocument Document
    {
      get
      {
          return this.GetParameterValue("Document") as global::Sungero.Docflow.IOfficialDocument;
      }
      set
      {
        this.SetParameterValue("Document", value);
      }
    }


    public global::System.String Subheader
    {
      get
      {
          return this.GetParameterValue("Subheader") as global::System.String;
      }
      set
      {
        this.SetParameterValue("Subheader", value);
      }
    }


    public global::Sungero.Meetings.IMeeting Meeting
    {
      get
      {
          return this.GetParameterValue("Meeting") as global::Sungero.Meetings.IMeeting;
      }
      set
      {
        this.SetParameterValue("Meeting", value);
      }
    }


    public global::System.Nullable<global::System.Boolean> IsMeetingsCoverContext
    {
      get
      {
          return this.GetParameterValue("IsMeetingsCoverContext") as global::System.Nullable<global::System.Boolean>;
      }
      set
      {
        this.SetParameterValue("IsMeetingsCoverContext", value);
      }
    }


    public global::System.String Header
    {
      get
      {
          return this.GetParameterValue("Header") as global::System.String;
      }
      set
      {
        this.SetParameterValue("Header", value);
      }
    }


    public global::Sungero.Docflow.IDocumentType DocumentType
    {
      get
      {
          return this.GetParameterValue("DocumentType") as global::Sungero.Docflow.IDocumentType;
      }
      set
      {
        this.SetParameterValue("DocumentType", value);
      }
    }



    public ActionItemsExecutionReport()
    {
      this.Handlers = new global::Sungero.RecordManagement.ActionItemsExecutionReportServerHandlers(this);
    }
  }
}

// ==================================================================
// ActionItemsExecutionReportHandlers.g.cs
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
  public partial class ActionItemsExecutionReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.RecordManagement.IActionItemsExecutionReport ActionItemsExecutionReport
    {
      get { return (global::Sungero.RecordManagement.IActionItemsExecutionReport)this._Report; }
    }

    public ActionItemsExecutionReportServerHandlers(global::Sungero.RecordManagement.IActionItemsExecutionReport report) : base(report) { }
  }
}

// ==================================================================
// ActionItemsExecutionReportRepositoryImplementer.g.cs
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
  public class ActionItemsExecutionReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.RecordManagement.IActionItemsExecutionReportRepositoryImplementer<T>
    where T : global::Sungero.RecordManagement.IActionItemsExecutionReport 
  {
  }
}

// ==================================================================
// ActionItemsExecutionReportQueries.g.cs
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
  public class ActionItemsExecutionReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.Reports.ActionItemsExecutionReport.ActionItemsExecutionReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string PasteDocumentNames
    {
       get { return resolver.GetQuery("PasteDocumentNames"); }
    }
    public static string SelectDataFromTable
    {
       get { return resolver.GetQuery("SelectDataFromTable"); }
    }
    public static string CreateActionItemExecutionReportSourceTable
    {
       get { return resolver.GetQuery("CreateActionItemExecutionReportSourceTable"); }
    }
  }
}
