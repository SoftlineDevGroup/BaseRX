﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.ApprovalSigningAssignment;
using Sungero.Domain.Shared;

namespace Sungero.Docflow.Server
{
  partial class ApprovalSigningAssignmentFunctions
  {
    #region Контроль состояния
    
    /// <summary>
    /// Построить регламент.
    /// </summary>
    /// <returns>Регламент.</returns>
    [Remote(IsPure = true)]
    public Sungero.Core.StateView GetStagesStateView()
    {
      return PublicFunctions.ApprovalRuleBase.GetStagesStateView(_obj);
    }
    
    /// <summary>
    /// Построить сводку по документу.
    /// </summary>
    /// <returns>Сводка по документу.</returns>
    [Remote(IsPure = true)]
    public StateView GetDocumentSummary()
    {
      var document = _obj.DocumentGroup.OfficialDocuments.FirstOrDefault();
      return Docflow.PublicFunctions.Module.GetDocumentSummary(document);
    }
    
    #endregion
    
    [Remote(IsPure = true)]
    public StateView GetApprovalListState()
    {
      var document = _obj.DocumentGroup.OfficialDocuments.FirstOrDefault();
      return Functions.ApprovalReviewAssignment.CreateApprovalListStateView(document);
    }
    
    /// <summary>
    /// Получить все данные для валидации подписания одним запросом.
    /// </summary>
    /// <returns>Структура с данными валидации.</returns>
    [Remote(IsPure = true)]
    public Structures.ApprovalTask.BeforeSign ValidateBeforeSign()
    {
      var task = ApprovalTasks.As(_obj.Task);
      var currentEmployee = Company.Employees.Current;
      var document = _obj.DocumentGroup.OfficialDocuments.First();

      var errors = Functions.OfficialDocument.GetApprovalValidationErrors(document, false);
      var addendas = task.AddendaGroup.OfficialDocuments.Where(a => a.HasVersions).ToList();
      foreach (var addenda in addendas)
        errors.AddRange(Functions.OfficialDocument.GetDocumentLockErrors(addenda));

      var signatories = Functions.OfficialDocument.GetSignatories(document);
      var canApprove = document.AccessRights.CanApprove() && signatories.Any(s => currentEmployee != null && Equals(s.EmployeeId, currentEmployee.Id));
      var bodyChanged = Functions.ApprovalTask.DocumentHasBodyUpdateAfterLastView(document);
      return Structures.ApprovalTask.BeforeSign.Create(errors, canApprove, bodyChanged);
    }
  }
}