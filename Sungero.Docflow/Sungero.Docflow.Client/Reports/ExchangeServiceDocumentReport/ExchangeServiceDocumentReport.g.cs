
// ==================================================================
// ExchangeServiceDocumentReport.g.cs
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
  public class ExchangeServiceDocumentReport : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IExchangeServiceDocumentReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("eb9bebab-6c1b-448b-ab15-c0e029f7af3c");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
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

    public global::Sungero.Company.IEmployee Employee
    {
      get
      {
          return this.GetParameterValue("Employee") as global::Sungero.Company.IEmployee;
      }

      set
      {
        this.SetParameterValue("Employee", value);
      }
    }

    public global::Sungero.Parties.ICounterparty Counterparty
    {
      get
      {
          return this.GetParameterValue("Counterparty") as global::Sungero.Parties.ICounterparty;
      }

      set
      {
        this.SetParameterValue("Counterparty", value);
      }
    }

      private Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.ExchangeCore.IExchangeService> _ExchangeServiceAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.ExchangeCore.IExchangeService> ExchangeService
    {
      get
      {
          if(this._ExchangeServiceAdapter == null)
            this._ExchangeServiceAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.ExchangeCore.IExchangeService>(this, "ExchangeService");
          return this._ExchangeServiceAdapter;
      }

    }

    public global::System.Nullable<global::System.DateTime> SendDateFrom
    {
      get
      {
          return this.GetParameterValue("SendDateFrom") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("SendDateFrom", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> SendDateTo
    {
      get
      {
          return this.GetParameterValue("SendDateTo") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("SendDateTo", value);
      }
    }

    public global::System.String SendPeriod
    {
      get
      {
          return this.GetParameterValue("SendPeriod") as global::System.String;
      }

      set
      {
        this.SetParameterValue("SendPeriod", value);
      }
    }

    public global::System.String ParametersInfo
    {
      get
      {
          return this.GetParameterValue("ParametersInfo") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ParametersInfo", value);
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


    public ExchangeServiceDocumentReport()
    {
      this.Handlers = new global::Sungero.Docflow.ExchangeServiceDocumentReportClientHandlers(this);
    }
  }
}

// ==================================================================
// ExchangeServiceDocumentReportRepositoryImplementer.g.cs
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
  public class ExchangeServiceDocumentReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IExchangeServiceDocumentReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IExchangeServiceDocumentReport
    {
    }
}
