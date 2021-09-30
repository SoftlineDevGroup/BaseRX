
// ==================================================================
// AssignmentCompletionReport.g.cs
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
  public class AssignmentCompletionReport : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IAssignmentCompletionReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("47007468-7f22-4f94-8f69-19d33ada3657");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::System.Nullable<global::System.DateTime> PeriodBegin
    {
      get
      {
          return this.GetParameterValue("PeriodBegin") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("PeriodBegin", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> PeriodEnd
    {
      get
      {
          return this.GetParameterValue("PeriodEnd") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("PeriodEnd", value);
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

    public global::System.String AssignmentViewTableName
    {
      get
      {
          return this.GetParameterValue("AssignmentViewTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("AssignmentViewTableName", value);
      }
    }

    public global::System.Nullable<global::System.Int32> DepartmentId
    {
      get
      {
          return this.GetParameterValue("DepartmentId") as global::System.Nullable<global::System.Int32>;
      }

      set
      {
        this.SetParameterValue("DepartmentId", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> ClientPeriodEnd
    {
      get
      {
          return this.GetParameterValue("ClientPeriodEnd") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("ClientPeriodEnd", value);
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

    public global::System.Nullable<global::System.Boolean> LoadOldAssignments
    {
      get
      {
          return this.GetParameterValue("LoadOldAssignments") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("LoadOldAssignments", value);
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

    public global::System.Nullable<global::System.Int32> PerformerId
    {
      get
      {
          return this.GetParameterValue("PerformerId") as global::System.Nullable<global::System.Int32>;
      }

      set
      {
        this.SetParameterValue("PerformerId", value);
      }
    }

    public global::System.String TaskTypeGuid2
    {
      get
      {
          return this.GetParameterValue("TaskTypeGuid2") as global::System.String;
      }

      set
      {
        this.SetParameterValue("TaskTypeGuid2", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> IncludeTask
    {
      get
      {
          return this.GetParameterValue("IncludeTask") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("IncludeTask", value);
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

    public global::System.Nullable<global::System.Int32> BusinessUnitId
    {
      get
      {
          return this.GetParameterValue("BusinessUnitId") as global::System.Nullable<global::System.Int32>;
      }

      set
      {
        this.SetParameterValue("BusinessUnitId", value);
      }
    }

    public global::System.String ParamsDescription
    {
      get
      {
          return this.GetParameterValue("ParamsDescription") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ParamsDescription", value);
      }
    }

    public global::System.String DoneAndNotOverdue
    {
      get
      {
          return this.GetParameterValue("DoneAndNotOverdue") as global::System.String;
      }

      set
      {
        this.SetParameterValue("DoneAndNotOverdue", value);
      }
    }

    public global::System.String DoneAndOverdue
    {
      get
      {
          return this.GetParameterValue("DoneAndOverdue") as global::System.String;
      }

      set
      {
        this.SetParameterValue("DoneAndOverdue", value);
      }
    }

    public global::System.String UndoneAndNotOverdue
    {
      get
      {
          return this.GetParameterValue("UndoneAndNotOverdue") as global::System.String;
      }

      set
      {
        this.SetParameterValue("UndoneAndNotOverdue", value);
      }
    }

    public global::System.String UndoneAndOverdue
    {
      get
      {
          return this.GetParameterValue("UndoneAndOverdue") as global::System.String;
      }

      set
      {
        this.SetParameterValue("UndoneAndOverdue", value);
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


    public AssignmentCompletionReport()
    {
      this.Handlers = new global::Sungero.Docflow.AssignmentCompletionReportClientHandlers(this);
    }
  }
}

// ==================================================================
// AssignmentCompletionReportRepositoryImplementer.g.cs
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
  public class AssignmentCompletionReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IAssignmentCompletionReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IAssignmentCompletionReport
    {
    }
}
