
// ==================================================================
// IncomingDocumentsReport.g.cs
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
  public class IncomingDocumentsReport : global::Sungero.Reporting.Server.Report, global::Sungero.RecordManagement.IIncomingDocumentsReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("540f174a-d952-47c4-8b87-eaeb029ddb74");

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


    public global::Sungero.Docflow.IDocumentRegister DocumentRegister
    {
      get
      {
          return this.GetParameterValue("DocumentRegister") as global::Sungero.Docflow.IDocumentRegister;
      }
      set
      {
        this.SetParameterValue("DocumentRegister", value);
      }
    }


    public global::System.String DocumentsDataTableName
    {
      get
      {
          return this.GetParameterValue("DocumentsDataTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("DocumentsDataTableName", value);
      }
    }


    public global::System.String JobsDataTableName
    {
      get
      {
          return this.GetParameterValue("JobsDataTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("JobsDataTableName", value);
      }
    }


    public global::System.String AvailableDocumentsIdsTableName
    {
      get
      {
          return this.GetParameterValue("AvailableDocumentsIdsTableName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("AvailableDocumentsIdsTableName", value);
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



    public IncomingDocumentsReport()
    {
      this.Handlers = new global::Sungero.RecordManagement.IncomingDocumentsReportServerHandlers(this);
    }
  }
}

// ==================================================================
// IncomingDocumentsReportHandlers.g.cs
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
  public partial class IncomingDocumentsReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.RecordManagement.IIncomingDocumentsReport IncomingDocumentsReport
    {
      get { return (global::Sungero.RecordManagement.IIncomingDocumentsReport)this._Report; }
    }

    public IncomingDocumentsReportServerHandlers(global::Sungero.RecordManagement.IIncomingDocumentsReport report) : base(report) { }
  }
}

// ==================================================================
// IncomingDocumentsReportRepositoryImplementer.g.cs
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
  public class IncomingDocumentsReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.RecordManagement.IIncomingDocumentsReportRepositoryImplementer<T>
    where T : global::Sungero.RecordManagement.IIncomingDocumentsReport 
  {
  }
}

// ==================================================================
// IncomingDocumentsReportQueries.g.cs
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
  public class IncomingDocumentsReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.Reports.IncomingDocumentsReport.IncomingDocumentsReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string FillTempTables
    {
       get { return resolver.GetQuery("FillTempTables"); }
    }
    public static string FillSourceTable
    {
       get { return resolver.GetQuery("FillSourceTable"); }
    }
    public static string GetDocuments
    {
       get { return resolver.GetQuery("GetDocuments"); }
    }
    public static string CreateIncomingDocumentsSourceTable
    {
       get { return resolver.GetQuery("CreateIncomingDocumentsSourceTable"); }
    }
  }
}