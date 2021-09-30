
// ==================================================================
// AcquaintanceFormReport.g.cs
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
  public class AcquaintanceFormReport : global::Sungero.Reporting.Server.Report, global::Sungero.RecordManagement.IAcquaintanceFormReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("4fb95eaa-eed1-4fcb-a601-e0b88ad0f5ae");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
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


    public global::System.String DocumentName
    {
      get
      {
          return this.GetParameterValue("DocumentName") as global::System.String;
      }
      set
      {
        this.SetParameterValue("DocumentName", value);
      }
    }


    public global::System.String AddendaDescription
    {
      get
      {
          return this.GetParameterValue("AddendaDescription") as global::System.String;
      }
      set
      {
        this.SetParameterValue("AddendaDescription", value);
      }
    }


    public global::System.String Printed
    {
      get
      {
          return this.GetParameterValue("Printed") as global::System.String;
      }
      set
      {
        this.SetParameterValue("Printed", value);
      }
    }


    public global::Sungero.RecordManagement.IAcquaintanceTask Task
    {
      get
      {
          return this.GetParameterValue("Task") as global::Sungero.RecordManagement.IAcquaintanceTask;
      }
      set
      {
        this.SetParameterValue("Task", value);
      }
    }



    public AcquaintanceFormReport()
    {
      this.Handlers = new global::Sungero.RecordManagement.AcquaintanceFormReportServerHandlers(this);
    }
  }
}

// ==================================================================
// AcquaintanceFormReportHandlers.g.cs
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
  public partial class AcquaintanceFormReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.RecordManagement.IAcquaintanceFormReport AcquaintanceFormReport
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceFormReport)this._Report; }
    }

    public AcquaintanceFormReportServerHandlers(global::Sungero.RecordManagement.IAcquaintanceFormReport report) : base(report) { }
  }
}

// ==================================================================
// AcquaintanceFormReportRepositoryImplementer.g.cs
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
  public class AcquaintanceFormReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.RecordManagement.IAcquaintanceFormReportRepositoryImplementer<T>
    where T : global::Sungero.RecordManagement.IAcquaintanceFormReport 
  {
  }
}

// ==================================================================
// AcquaintanceFormReportQueries.g.cs
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
  public class AcquaintanceFormReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.RecordManagement.Server.Reports.AcquaintanceFormReport.AcquaintanceFormReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string CreateAcquaintanceFormReportTable
    {
       get { return resolver.GetQuery("CreateAcquaintanceFormReportTable"); }
    }
    public static string SelectDataFromTable
    {
       get { return resolver.GetQuery("SelectDataFromTable"); }
    }
  }
}
