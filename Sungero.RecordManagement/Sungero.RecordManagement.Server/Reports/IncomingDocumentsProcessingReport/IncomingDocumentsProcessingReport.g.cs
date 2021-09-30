
// ==================================================================
// IncomingDocumentsProcessingReport.g.cs
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
  public class IncomingDocumentsProcessingReport : global::Sungero.Reporting.Server.Report, global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("50cd6eb3-ad77-4c3b-a681-6dc040964aaa");

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


    public global::System.String DocumentsTableName
    {
      get
      {
          return this.GetParameterValue("DocumentsTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("DocumentsTableName", value);
      }
    }


    public global::System.String TasksTableName
    {
      get
      {
          return this.GetParameterValue("TasksTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("TasksTableName", value);
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


    public global::System.String AvailableIdsTableName
    {
      get
      {
          return this.GetParameterValue("AvailableIdsTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("AvailableIdsTableName", value);
      }
    }


    public global::System.String HyperlinksTableName
    {
      get
      {
          return this.GetParameterValue("HyperlinksTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("HyperlinksTableName", value);
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


    public global::System.String ViewDataTableName
    {
      get
      {
          return this.GetParameterValue("ViewDataTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("ViewDataTableName", value);
      }
    }


    public global::System.String Empty
    {
      get
      {
          return this.GetParameterValue("Empty") as global::System.String;
      }
      set
      {
        this.SetParameterValue("Empty", value);
      }
    }



    public IncomingDocumentsProcessingReport()
    {
      this.Handlers = new global::Sungero.RecordManagement.IncomingDocumentsProcessingReportServerHandlers(this);
    }
  }
}

// ==================================================================
// IncomingDocumentsProcessingReportHandlers.g.cs
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
  public partial class IncomingDocumentsProcessingReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport IncomingDocumentsProcessingReport
    {
      get { return (global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport)this._Report; }
    }

    public IncomingDocumentsProcessingReportServerHandlers(global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport report) : base(report) { }
  }
}

// ==================================================================
// IncomingDocumentsProcessingReportRepositoryImplementer.g.cs
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
  public class IncomingDocumentsProcessingReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.RecordManagement.IIncomingDocumentsProcessingReportRepositoryImplementer<T>
    where T : global::Sungero.RecordManagement.IIncomingDocumentsProcessingReport 
  {
  }
}

// ==================================================================
// IncomingDocumentsProcessingReportQueries.g.cs
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
  public class IncomingDocumentsProcessingReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.Reports.IncomingDocumentsProcessingReport.IncomingDocumentsProcessingReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string SourceQuery
    {
       get { return resolver.GetQuery("SourceQuery"); }
    }
    public static string DataQuery
    {
       get { return resolver.GetQuery("DataQuery"); }
    }
    public static string CreateHyperlinksTableQuery
    {
       get { return resolver.GetQuery("CreateHyperlinksTableQuery"); }
    }
    public static string DocIdSelectQuery
    {
       get { return resolver.GetQuery("DocIdSelectQuery"); }
    }
    public static string UpdateHyperlinksQuery
    {
       get { return resolver.GetQuery("UpdateHyperlinksQuery"); }
    }
    public static string CreateIncomingDocumentsProcessingReportSourceTable
    {
       get { return resolver.GetQuery("CreateIncomingDocumentsProcessingReportSourceTable"); }
    }
    public static string ViewDataQuery
    {
       get { return resolver.GetQuery("ViewDataQuery"); }
    }
    public static string TasksQuery
    {
       get { return resolver.GetQuery("TasksQuery"); }
    }
    public static string UpdateViewDateQuery
    {
       get { return resolver.GetQuery("UpdateViewDateQuery"); }
    }
    public static string CreateViewDateQuery
    {
       get { return resolver.GetQuery("CreateViewDateQuery"); }
    }
  }
}
