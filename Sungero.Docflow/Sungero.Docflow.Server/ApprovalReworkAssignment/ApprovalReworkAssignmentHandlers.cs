using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.ApprovalReworkAssignment;

namespace Sungero.Docflow
{
  partial class ApprovalReworkAssignmentForwardPerformerPropertyFilteringServerHandler<T>
  {

    public virtual IQueryable<T> ForwardPerformerFiltering(IQueryable<T> query, Sungero.Domain.PropertyFilteringEventArgs e)
    {
      query = query.Where(p => !Equals(p, _obj.Performer));
      return query;
    }
  }

  partial class ApprovalReworkAssignmentExchangeServicePropertyFilteringServerHandler<T>
  {

    public virtual IQueryable<T> ExchangeServiceFiltering(IQueryable<T> query, Sungero.Domain.PropertyFilteringEventArgs e)
    {
      var services = Functions.ApprovalTask.GetExchangeServices(ApprovalTasks.As(_obj.Task)).Services;
      query = query.Where(s => services.Contains(s));
      return query;
    }
  }

  partial class ApprovalReworkAssignmentServerHandlers
  {

    public override void BeforeSaveHistory(Sungero.Domain.HistoryEventArgs e)
    {
      base.BeforeSaveHistory(e);
      
      if (_obj.State.Properties.Deadline.IsChanged && !_obj.State.IsInserted)
      {
        e.Operation = new Enumeration(Constants.ApprovalReworkAssignment.Operation.DeadlineExtend);
      }
    }

    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      var deletedApprovers = _obj.State.Properties.Approvers.Deleted;
      var addedApprovers = _obj.State.Properties.Approvers.Added;
      var changedApprovers = _obj.State.Properties.Approvers.Changed;
      
      var createFromSchema = false;
      e.Params.TryGetValue(Constants.ApprovalTask.CreateFromSchema, out createFromSchema);
      if (!createFromSchema)
      {
        // Запрещено изменять действие, если результат согласования отрицателен.
        if (_obj.Approvers.Any(a => a.Approved == Sungero.Docflow.ApprovalReworkAssignmentApprovers.Approved.NotApproved &&
                               a.Action != Sungero.Docflow.ApprovalReworkAssignmentApprovers.Action.SendForApproval))
          e.AddError(ApprovalReworkAssignments.Resources.CannotChangeAction);

        // Запрещено удалять обязательных согласующих.
        if (deletedApprovers.Any(app => app.IsRequiredApprover == true))
          e.AddError(ApprovalReworkAssignments.Resources.CannotDeleteRequiredApprovers);
        
        var task = ApprovalTasks.As(_obj.Task);

        // Запрещено добавлять согласующих, если нет этапа согласования с дополнительными согласующими.
        if (addedApprovers.Any(a => a.IsRequiredApprover != true) &&
            !Functions.ApprovalRuleBase.GetStages(task.ApprovalRule, _obj.DocumentGroup.OfficialDocuments.FirstOrDefault(), task)
            .Stages.Any(s => s.StageType == Docflow.ApprovalStage.StageType.Approvers && s.Stage.AllowAdditionalApprovers == true))
          e.AddError(ApprovalReworkAssignments.Resources.CannotAddApproversIfNoAdditionalInRule);
      }
      else
        e.Params.Remove(Constants.ApprovalTask.CreateFromSchema);
      
      // Синхронизация грида согласующих со списком доп. согласующих.
      foreach (var deletedApprover in deletedApprovers)
      {
        var deleted = _obj.AddApprovers.Where(a => Equals(a.Approver, deletedApprover.Approver)).FirstOrDefault();
        _obj.AddApprovers.Remove(deleted);
      }
      
      if (addedApprovers.Any(a => a.IsRequiredApprover != true) || changedApprovers.Any(a => a.IsRequiredApprover != true))
      {
        _obj.AddApprovers.Clear();
        foreach (var approver in _obj.Approvers.Where(a => a.IsRequiredApprover != true))
        {
          var newApprover = _obj.AddApprovers.AddNew();
          newApprover.Approver = approver.Approver;
        }
      }
    }

    public override void BeforeComplete(Sungero.Workflow.Server.BeforeCompleteEventArgs e)
    {
      // Обязательность полей могла измениться.
      var document = _obj.DocumentGroup.OfficialDocuments.FirstOrDefault();
      var stages = Functions.ApprovalTask.GetStages(ApprovalTasks.As(_obj.Task)).Stages;
      var hasSignStage = Functions.ApprovalRuleBase.HasApprovalStage(_obj.ApprovalRule, Docflow.ApprovalStage.StageType.Sign, document, stages);
      
      _obj.State.Properties.Signatory.IsVisible = hasSignStage;
      _obj.State.Properties.Signatory.IsRequired = hasSignStage;
      
      // Проверить, имеет ли право подписывающий на подпись.
      if (hasSignStage &&
          !Functions.ApprovalTask.CheckSignatory(ApprovalTasks.As(_obj.Task), _obj.Signatory, stages))
      {
        e.AddError(_obj.Info.Properties.Signatory, ApprovalTasks.Resources.IncorrectSignatory);
      }
      
      if (_obj.Result == Result.ForReapproving)
        e.Result = ApprovalTasks.Resources.ForReapproving;
      else if (_obj.Result == Result.Forward)
        e.Result = FreeApprovalTasks.Resources.ForwardedFormat(Company.PublicFunctions.Employee.GetShortName(_obj.ForwardPerformer, DeclensionCase.Dative, true));
      else
        e.Result = ApprovalTasks.Resources.AbortApproving;
    }
  }

  partial class ApprovalReworkAssignmentSignatoryPropertyFilteringServerHandler<T>
  {

    public virtual IQueryable<T> SignatoryFiltering(IQueryable<T> query, Sungero.Domain.PropertyFilteringEventArgs e)
    {
      e.DisableUiFiltering = true;
      var document = _obj.DocumentGroup.OfficialDocuments.FirstOrDefault();
      var signatories = Functions.OfficialDocument.GetSignatories(document).Select(s => s.EmployeeId).Distinct().ToList();
      
      return query.Where(s => signatories.Contains(s.Id));
    }
  }
}