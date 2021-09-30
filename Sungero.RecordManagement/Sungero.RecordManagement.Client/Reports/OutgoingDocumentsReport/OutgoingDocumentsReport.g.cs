
// ==================================================================
// OutgoingDocumentsReport.g.cs
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
  public class OutgoingDocumentsReport : global::Sungero.Reporting.Client.Report, global::Sungero.RecordManagement.IOutgoingDocumentsReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("c6f32f03-13fa-4752-93d2-ff750a88dca7");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
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


    public OutgoingDocumentsReport()
    {
      this.Handlers = new global::Sungero.RecordManagement.OutgoingDocumentsReportClientHandlers(this);
    }
  }
}

// ==================================================================
// OutgoingDocumentsReportRepositoryImplementer.g.cs
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
  public class OutgoingDocumentsReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IOutgoingDocumentsReportRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IOutgoingDocumentsReport
    {
    }
}