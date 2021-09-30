
// ==================================================================
// ModuleFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Shell.Functions
{
  internal static partial class Module
  {
    /// <redirect project="Sungero.Shell.ClientBase" type="Sungero.Shell.Client.ModuleFunctions" />
    internal static void SearchDocumentsWithCounterparties(global::Sungero.Parties.ICounterparty counterparty)
    {
    ((global::Sungero.Shell.Client.ModuleFunctions)GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType.ClientBase)).SearchDocumentsWithCounterparties(counterparty);
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.PerformerLoad> GetTopLoaded(global::Sungero.Core.Enumeration carriedObject, global::Sungero.Core.Enumeration period)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.PerformerLoad>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetTopLoaded(global::Sungero.Core.Enumeration,global::Sungero.Core.Enumeration)", carriedObject, period);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.DepartmentLoad> GetTopLoadedDepartaments(global::Sungero.Core.Enumeration period)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.DepartmentLoad>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetTopLoadedDepartaments(global::Sungero.Core.Enumeration)", period);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Workflow.ITask> GetTasks(global::System.DateTime periodBegin, global::System.DateTime periodEnd)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Workflow.ITask>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetTasks(global::System.DateTime,global::System.DateTime)", periodBegin, periodEnd);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Content.IElectronicDocument> GetDocuments(global::System.DateTime periodBegin, global::System.DateTime periodEnd)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Content.IElectronicDocument>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetDocuments(global::System.DateTime,global::System.DateTime)", periodBegin, periodEnd);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.EmployeeDiscipline> GetEmployeeDisciplineForChart(global::Sungero.Core.Enumeration performer, global::Sungero.Core.Enumeration period)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.EmployeeDiscipline>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetEmployeeDisciplineForChart(global::Sungero.Core.Enumeration,global::Sungero.Core.Enumeration)", performer, period);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.DepartmentDiscipline> GetDepartmentDisciplineForChart(global::Sungero.Core.Enumeration period)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Shell.Structures.Module.DepartmentDiscipline>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetDepartmentDisciplineForChart(global::Sungero.Core.Enumeration)", period);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Content.IElectronicDocument> GetDocumentsWithCounterparties(global::Sungero.Parties.ICounterparty counterparty)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Content.IElectronicDocument>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetDocumentsWithCounterparties(global::Sungero.Parties.ICounterparty)", counterparty);
      }
      /// <redirect project="Sungero.Shell.Server" type="Sungero.Shell.Server.ModuleFunctions" />
      internal static global::System.Linq.IQueryable<global::Sungero.Content.IElectronicDocument> GetRespondingEmployeeDocuments(global::Sungero.Company.IEmployee employee)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Linq.IQueryable<global::Sungero.Content.IElectronicDocument>>(
          global::System.Guid.Parse("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a"),
          "GetRespondingEmployeeDocuments(global::Sungero.Company.IEmployee)", employee);
      }

    }
    private static object GetFunctionsContainer()
    {
      return new global::Sungero.Shell.Client.ModuleFunctions();
    }

    private static object GetFinalFunctionsContainer(global::Sungero.Metadata.ModuleProjectType projectType)
    {
      var moduleId = new global::System.Guid("fcc573ab-5f4e-4b20-88e8-7b1e11a7a59a");
      var finalModuleMetadatda = global::Sungero.Metadata.MetadataExtension.GetFinal(global::Sungero.Metadata.Services.MetadataSearcher.FindModuleMetadata(moduleId) ?? global::Sungero.Metadata.Services.MetadataSearcher.FindLayerModuleMetadata(moduleId));
      var assemblyName = finalModuleMetadatda.GetAssemblyName(projectType);
      var moduleFunctionsType = global::System.Type.GetType(global::System.String.Format("{0}.{1}, {2}", finalModuleMetadatda.FunctionNamespace, "Module", assemblyName));
      return moduleFunctionsType.GetMethod("GetFunctionsContainer", global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Static).Invoke(null, null);
    }
  }
}

// ==================================================================
// ModuleClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Shell.Client
{
  public partial class ModuleClientPublicFunctions : global::Sungero.Shell.Client.IModuleClientPublicFunctions
  {
    public void SearchDocumentsWithCounterparties(global::Sungero.Parties.ICounterparty counterparty)
    {
global::Sungero.Shell.Functions.Module.SearchDocumentsWithCounterparties(counterparty);
    }
  }
}

// ==================================================================
// ModuleWidgetHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Shell.Client
{
      public partial class TopLoadedPerformersGraphWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.TopLoadedPerformersGraphWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.TopLoadedPerformersGraphWidgetParameters)this.InnerParameters;
          }
        }


        public TopLoadedPerformersGraphWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class TopLoadedDepartmentsGraphWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.TopLoadedDepartmentsGraphWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.TopLoadedDepartmentsGraphWidgetParameters)this.InnerParameters;
          }
        }


        public TopLoadedDepartmentsGraphWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class ActiveAssignmentsDynamicWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.ActiveAssignmentsDynamicWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.ActiveAssignmentsDynamicWidgetParameters)this.InnerParameters;
          }
        }

          public virtual void ExecuteActiveAssignmentsDynamicAssignmentsDynamicChartAction()
          {
          }


        public ActiveAssignmentsDynamicWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class DocumentsCreatingDynamicWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.DocumentsCreatingDynamicWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.DocumentsCreatingDynamicWidgetParameters)this.InnerParameters;
          }
        }

          public virtual void ExecuteDocumentsCreatingDynamicDocumentsDynamicChartAction()
          {
          }


        public DocumentsCreatingDynamicWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class TasksCreatingDynamicWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.TasksCreatingDynamicWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.TasksCreatingDynamicWidgetParameters)this.InnerParameters;
          }
        }

          public virtual void ExecuteTasksCreatingDynamicTasksDynamicChartAction()
          {
          }


        public TasksCreatingDynamicWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class AssignmentCompletionGraphWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.AssignmentCompletionGraphWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.AssignmentCompletionGraphWidgetParameters)this.InnerParameters;
          }
        }


        public AssignmentCompletionGraphWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class AssignmentCompletionDepartmentGraphWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.AssignmentCompletionDepartmentGraphWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.AssignmentCompletionDepartmentGraphWidgetParameters)this.InnerParameters;
          }
        }


        public AssignmentCompletionDepartmentGraphWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class AssignmentCompletionEmployeeGraphWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.AssignmentCompletionEmployeeGraphWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.AssignmentCompletionEmployeeGraphWidgetParameters)this.InnerParameters;
          }
        }


        public AssignmentCompletionEmployeeGraphWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

      public partial class MyTodayAssignmentsWidgetHandlers
      {
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        protected global::Sungero.Domain.Shared.WidgetParametersBase InnerParameters { get; private set; }

        private global::Sungero.Shell.Shared.MyTodayAssignmentsWidgetParameters _parameters
        {
          get
          {
            return (global::Sungero.Shell.Shared.MyTodayAssignmentsWidgetParameters)this.InnerParameters;
          }
        }


        public MyTodayAssignmentsWidgetHandlers(global::Sungero.Domain.Shared.WidgetParametersBase parameters)
        {
          this.InnerParameters = parameters;
        }
      }

}

// ==================================================================
// ModuleHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Shell.Client
{

  public partial class OnReviewFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnReviewFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnReviewFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnReviewValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnReviewFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnReviewFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnSigningFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnSigningFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnSigningFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnSigningValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnSigningFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnSigningFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnDocumentProcessingFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnDocumentProcessingFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnDocumentProcessingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnDocumentProcessingValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnDocumentProcessingFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnDocumentProcessingFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnApprovalFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnApprovalFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnApprovalFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnApprovalValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnApprovalFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnApprovalFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnChekingFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnChekingFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnChekingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnChekingValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnChekingFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnChekingFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnPrintFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnPrintFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnPrintFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnPrintValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnPrintFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnPrintFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnReworkFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnReworkFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnReworkFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnReworkValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnReworkFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnReworkFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnRegisterFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnRegisterFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnRegisterFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnRegisterValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnRegisterFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnRegisterFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class NoticesFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.INoticesFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.INoticesFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void NoticesValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public NoticesFolderHandlers(global::Sungero.Shell.FolderFilterState.INoticesFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class ApprovalFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IApprovalFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IApprovalFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ApprovalValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ApprovalFolderHandlers(global::Sungero.Shell.FolderFilterState.IApprovalFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class ExchangeDocumentProcessingFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IExchangeDocumentProcessingFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IExchangeDocumentProcessingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void ExchangeDocumentProcessingValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public ExchangeDocumentProcessingFolderHandlers(global::Sungero.Shell.FolderFilterState.IExchangeDocumentProcessingFilterState filter)
    {
      this.Filter = filter;
    }

  }

  public partial class OnVerificationFolderHandlers
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Shell.FolderFilterState.IOnVerificationFilterState Filter { get; private set; }

    private global::Sungero.Shell.FolderFilterState.IOnVerificationFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public virtual void OnVerificationValidateFilterPanel(global:: Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }

    public OnVerificationFolderHandlers(global::Sungero.Shell.FolderFilterState.IOnVerificationFilterState filter)
    {
      this.Filter = filter;
    }

  }

}
