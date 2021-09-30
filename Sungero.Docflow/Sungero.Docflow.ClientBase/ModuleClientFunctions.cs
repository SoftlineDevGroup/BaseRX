using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sungero.Content;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Domain.Client;
using Sungero.Reporting;
using Sungero.Workflow;

namespace Sungero.Docflow.Client
{
  public class ModuleFunctions
  {
    #region Замещение
    
    /// <summary>
    /// Имеет ли доступ по замещению.
    /// </summary>
    /// <param name="e">Аргументы карточки.</param>
    /// <param name="registrationGroup">Группа регистрации.</param>
    /// <param name="calculateIsSubstitute">Признак замещения.</param>
    /// <param name="calculateIsAdministrator">Признак администратора.</param>
    /// <param name="calculateIsUsed">Признак использования.</param>
    /// <param name="calculateHasDocuments">Признак наличия зарегистрированных документов.</param>
    /// <param name="documentRegister">Журнал.</param>
    /// <returns>True, если доступ имеется.</returns>
    public static bool CalculateParams(Sungero.Presentation.FormRefreshEventArgs e, IRegistrationGroup registrationGroup,
                                       bool calculateIsSubstitute, bool calculateIsAdministrator, bool calculateIsUsed, bool calculateHasDocuments,
                                       IDocumentRegister documentRegister)
    {
      var isSubstituteParamName = Constants.Module.IsSubstituteResponsibleEmployeeParamName;
      var isAdministratorParamName = Constants.Module.IsAdministratorParamName;
      var isUsedParamName = Constants.Module.IsUsedParamName;
      var hasDocumentsParamName = Constants.Module.HasRegisteredDocumentsParamName;
      bool isSubstituteParamValue;
      bool isAdministratorParamValue;
      var isSubstituteParamHasValue = e.Params.TryGetValue(isSubstituteParamName, out isSubstituteParamValue);
      var isAdministratorParamHasValue = e.Params.TryGetValue(isAdministratorParamName, out isAdministratorParamValue);

      // Получить старое значение параметра.
      if (calculateIsSubstitute && isSubstituteParamHasValue &&
          calculateIsAdministrator && isAdministratorParamHasValue)
        return isSubstituteParamValue || isAdministratorParamValue;
      
      if (calculateIsSubstitute && isSubstituteParamHasValue)
        return isSubstituteParamValue;
      
      if (calculateIsAdministrator && isAdministratorParamHasValue)
        return isAdministratorParamValue;
      
      bool isUsedParamValue;
      if (calculateIsUsed && e.Params.TryGetValue(isUsedParamName, out isUsedParamValue))
        return isUsedParamValue;
      
      bool hasDocumentsParamValue;
      if (calculateHasDocuments && e.Params.TryGetValue(hasDocumentsParamName, out hasDocumentsParamValue))
        return hasDocumentsParamValue;
      
      // Вычислить доступность на сервере, чтобы был один запрос.
      var result = Functions.Module.Remote.CalculateParams(registrationGroup, documentRegister);
      var access = Functions.Module.UnboxDictionary(result);
      var isSubstitute = access[isSubstituteParamName];
      var isAdministrator = access[isAdministratorParamName];
      var isUsed = access[isUsedParamName];
      var hasDocuments = access[hasDocumentsParamName];
      e.Params.AddOrUpdate(isSubstituteParamName, isSubstitute);
      e.Params.AddOrUpdate(isAdministratorParamName, isAdministrator);
      e.Params.AddOrUpdate(isUsedParamName, isUsed);
      e.Params.AddOrUpdate(hasDocumentsParamName, hasDocuments);
      
      if (calculateIsSubstitute && calculateIsAdministrator)
        return isSubstitute || isAdministrator;
      
      if (calculateIsSubstitute)
        return isSubstitute;
      
      if (calculateIsAdministrator)
        return isAdministrator;
      
      if (calculateIsUsed)
        return isUsed;
      
      if (calculateHasDocuments)
        return hasDocuments;
      
      return false;
    }
    
    /// <summary>
    /// Имеет ли доступ по замещению.
    /// </summary>
    /// <param name="e">Аргумент доступности.</param>
    /// <param name="documentRegister">Журнал.</param>
    /// <param name="calculateIsAdministrator">Признак администратора.</param>
    /// <returns>True, если доступ имеется.</returns>
    public static bool CalculateParams(Sungero.Domain.Client.CanExecuteActionArgs e, IDocumentRegister documentRegister, bool calculateIsAdministrator)
    {
      var isSubstituteParamName = Constants.Module.IsSubstituteResponsibleEmployeeParamName;
      var isAdministratorParamName = Constants.Module.IsAdministratorParamName;
      var isUsedParamName = Constants.Module.IsUsedParamName;
      var hasDocumentsParamName = Constants.Module.HasRegisteredDocumentsParamName;
      
      // Получить старое значение параметра.
      bool isSubstituteParamValue;
      bool isAdministratorParamValue;
      var isSubstituteParamHasValue = e.Params.TryGetValue(isSubstituteParamName, out isSubstituteParamValue);
      var isAdministratorParamHasValue = e.Params.TryGetValue(isAdministratorParamName, out isAdministratorParamValue);
      if (isSubstituteParamHasValue &&
          calculateIsAdministrator && isAdministratorParamHasValue)
        return isSubstituteParamValue || isAdministratorParamValue;
      
      // Вычислить доступность на сервере, чтобы был один запрос.
      var result = Functions.Module.Remote.CalculateParams(documentRegister.RegistrationGroup, documentRegister);
      var access = Functions.Module.UnboxDictionary(result);
      var isSubstitute = access[isSubstituteParamName];
      var isAdministrator = access[isAdministratorParamName];
      var isUsed = access[isUsedParamName];
      var hasDocuments = access[hasDocumentsParamName];
      e.Params.AddOrUpdate(isSubstituteParamName, isSubstitute);
      e.Params.AddOrUpdate(isAdministratorParamName, isAdministrator);
      e.Params.AddOrUpdate(isUsedParamName, isUsed);
      e.Params.AddOrUpdate(hasDocumentsParamName, hasDocuments);
      
      if (calculateIsAdministrator)
        return isSubstitute || isAdministrator;
      
      return isSubstitute;
    }
    
    #endregion
    
    #region Диалог выдачи прав на вложения ShowDialogGrantAccessRightsFromTask и ShowDialogGrantAccessRightsFromAssignment
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="attachments">Вложения.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool? ShowDialogGrantAccessRights(IAssignmentBase assignment,
                                                    List<Domain.Shared.IEntity> attachments)
    {
      if (!attachments.Any() || assignment == null)
        return null;
      
      return ShowDialogGrantAccessRights(assignment.Task, attachments, new List<IRecipient>());
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения для определенного действия.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(IAssignmentBase assignment,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         Domain.Shared.IActionInfo action)
    {
      return ShowDialogGrantAccessRightsWithConfirmationDialog(assignment.Task, attachments, new List<IRecipient>(), action);
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения для определенного действия.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <param name="dialogID">ИД диалога подтверждения.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(IAssignmentBase assignment,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         Domain.Shared.IActionInfo action,
                                                                         string dialogID)
    {
      return ShowDialogGrantAccessRightsWithConfirmationDialog(assignment.Task, attachments, new List<IRecipient>(), action, dialogID);
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения для соисполнителей.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="additionalAssignees">Список соисполнителей.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool? ShowDialogGrantAccessRights(IAssignmentBase assignment,
                                                    List<Domain.Shared.IEntity> attachments,
                                                    List<IRecipient> additionalAssignees)
    {
      if (!attachments.Any() || assignment == null)
        return null;
      
      return ShowDialogGrantAccessRights(assignment.Task, attachments, additionalAssignees);
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения на определенное действие для соисполнителей.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="additionalAssignees">Соисполнители.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(IAssignmentBase assignment,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         List<IRecipient> additionalAssignees,
                                                                         Domain.Shared.IActionInfo action)
    {
      return ShowDialogGrantAccessRightsWithConfirmationDialog(assignment.Task, attachments, additionalAssignees, action);
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения на определенное действие для соисполнителей.
    /// </summary>
    /// <param name="assignment">Задание.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="additionalAssignees">Соисполнители.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <param name="dialogID">ИД диалога подтверждения.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(IAssignmentBase assignment,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         List<IRecipient> additionalAssignees,
                                                                         Domain.Shared.IActionInfo action,
                                                                         string dialogID)
    {
      return ShowDialogGrantAccessRightsWithConfirmationDialog(assignment.Task,
                                                               attachments,
                                                               additionalAssignees,
                                                               action,
                                                               dialogID);
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения.
    /// </summary>
    /// <param name="task">Задача.</param>
    /// <param name="attachments">Вложения.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool? ShowDialogGrantAccessRights(ITask task, List<Domain.Shared.IEntity> attachments)
    {
      return ShowDialogGrantAccessRights(task, attachments, new List<IRecipient>());
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения для определенного действия.
    /// </summary>
    /// <param name="task">Задача.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(ITask task,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         Domain.Shared.IActionInfo action)
    {
      return ShowDialogGrantAccessRightsWithConfirmationDialog(task, attachments, null, action);
    }
    
    /// <summary>
    /// Создать диалог выдачи прав на вложения для определенного действия.
    /// </summary>
    /// <param name="task">Задача.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <param name="dialogID">ИД диалога подтверждения.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(ITask task,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         Domain.Shared.IActionInfo action,
                                                                         string dialogID)
    {
      return ShowDialogGrantAccessRightsWithConfirmationDialog(task, attachments, null, action, dialogID);
    }
    
    /// <summary>
    /// Показать диалог выдачи прав на вложения с запросом подтверждения.
    /// </summary>
    /// <param name="task">Задача.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="additionalAssignees">Дополнительные согласующие.</param>
    /// <param name="action">Действие, текст утверждения которого будет показан.</param>
    /// <param name="dialogID">ИД диалога подтверждения.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.</returns>
    [Public]
    public static bool ShowDialogGrantAccessRightsWithConfirmationDialog(ITask task,
                                                                         List<Domain.Shared.IEntity> attachments,
                                                                         List<IRecipient> additionalAssignees,
                                                                         Domain.Shared.IActionInfo action,
                                                                         string dialogID = "")
    {
      var giveRights = ShowDialogGrantAccessRights(task, attachments, additionalAssignees);
      
      // Если явно не нажата отмена, то либо доп. прав не нужно (диалога не было), либо права назначены через диалог.
      if (action == null)
        return giveRights != false;
      
      // Замена стандартного диалога подтверждения выполнения действия.
      if (giveRights == null)
        return ShowConfirmationDialog(action.ConfirmationMessage, null, null, dialogID);
      
      return giveRights.Value;
    }
    
    /// <summary>
    /// Показать диалог выдачи прав на вложения.
    /// </summary>
    /// <param name="task">Задача.</param>
    /// <param name="attachments">Вложения.</param>
    /// <param name="additionalAssignees">Дополнительные согласующие.</param>
    /// <returns>True, если был показан диалог (и не была нажата отмена).
    /// False, если была нажата отмена.
    /// Null, если диалог показан не был.</returns>
    [Public]
    public static bool? ShowDialogGrantAccessRights(ITask task,
                                                    List<Domain.Shared.IEntity> attachments,
                                                    List<IRecipient> additionalAssignees)
    {
      if (!attachments.Any() || task == null)
        return null;
      
      var participants = Functions.Module.Remote.GetTaskAssignees(task).ToList();
      if (!participants.Any())
        return null;
      
      if (additionalAssignees != null && additionalAssignees.Any())
        participants.AddRange(additionalAssignees);

      // Получаем только вложения, принадлежащие текущему заданию.
      // На остальные вложения проверять права не надо, т.к. скорее всего их добавил не текущий пользователь.
      var attachmentsWithoutAccessRights = Functions.Module.Remote.GetAttachmentsWithoutAccessRights(participants, attachments);
      if (attachmentsWithoutAccessRights.Any())
      {
        return Workflow.Client.ModuleFunctions.ShowDialogGrantAccessRights(participants, attachmentsWithoutAccessRights);
      }
      
      return null;
    }

    #endregion
    
    #region Вызов функций делопроизводства без явных зависимостей
    
    // Вызов remote функций в таком виде позволяет отказаться от зависимостей, оставив при этом работоспособность.
    
    /// <summary>
    /// Создать сопроводительное письмо.
    /// </summary>
    /// <param name="document">Документ, к которому создается сопроводительное письмо.</param>
    /// <returns>Письмо.</returns>
    [Public]
    public static IOfficialDocument CreateCoverLetter(IOfficialDocument document)
    {
      var letter = RecordManagement.PublicFunctions.OutgoingLetter.Remote.CreateCoverLetter(document);
      
      // Указать связь документов.
      letter.Relations.AddFrom(Constants.Module.CorrespondenceRelationName, document);
      return letter;
    }
    
    /// <summary>
    /// Создать поручение.
    /// </summary>
    /// <param name="document">Документ, по которому создается поручение.</param>
    /// <returns>Поручение.</returns>
    [Public]
    public static ITask CreateActionItemExecution(IOfficialDocument document)
    {
      return RecordManagement.PublicFunctions.Module.Remote.CreateActionItemExecution(document);
    }
    
    /// <summary>
    /// Создать поручение.
    /// </summary>
    /// <param name="document">Документ, по которому создается поручение.</param>
    /// <param name="parentAssignmentId">Id задания от которого создается поручение.</param>
    /// <returns>Поручение.</returns>
    public static ITask CreateActionItemExecution(IOfficialDocument document, int parentAssignmentId)
    {
      return RecordManagement.PublicFunctions.Module.Remote.CreateActionItemExecution(document, parentAssignmentId);
    }
    
    /// <summary>
    /// Создать поручение.
    /// </summary>
    /// <param name="document">Документ, по которому создается поручение.</param>
    /// <param name="parentAssignmentId">Id задания от которого создается поручение.</param>
    /// <param name="resolution">Текст резолюции.</param>
    /// <param name="assignedBy">Пользователь - автор резолюции.</param>
    /// <returns>Поручение.</returns>
    public static ITask CreateActionItemExecutionWithResolution(IOfficialDocument document, int parentAssignmentId, string resolution, Sungero.Company.IEmployee assignedBy)
    {
      return RecordManagement.PublicFunctions.Module.Remote.CreateActionItemExecutionWithResolution(document, parentAssignmentId, resolution, assignedBy);
    }
    
    /// <summary>
    /// Создать задачу на рассмотрение документа.
    /// </summary>
    /// <param name="document">Входящий документ.</param>
    /// <returns>Рассмотрение.</returns>
    public static ITask CreateDocumentReview(IOfficialDocument document)
    {
      return RecordManagement.PublicFunctions.Module.Remote.CreateDocumentReview(document);
    }
    
    #endregion
    
    #region Интеллектуальная обработка
    
    /// <summary>
    /// Показать настройки интеллектуальной обработки документов.
    /// </summary>
    public virtual void ShowSmartProcessingSettings()
    {
      var smartProcessingSettings = PublicFunctions.SmartProcessingSetting.GetSettings();
      smartProcessingSettings.Show();
    }
    
    /// <summary>
    /// Удалить параметр NeedValidateRegisterFormat.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <param name="e">Аргумент действия.</param>
    public static void RemoveNeedValidateRegisterFormatParameter(IOfficialDocument document,
                                                                 Sungero.Domain.Client.ExecuteActionArgs e)
    {
      // Если документ в процессе верификации, то игнорировать изменение полей регистрационных данных.
      if (document.VerificationState == OfficialDocument.VerificationState.InProcess)
        e.Params.Remove(Constants.OfficialDocument.NeedValidateRegisterFormat);
    }
    
    #endregion
    
    /// <summary>
    /// Показать окно мониторинга и анализа.
    /// </summary>
    public virtual void ShowCharts()
    {
      var isAdministratorOrAdvisor = Users.Current.IncludedIn(Roles.Administrators) || Users.Current.IncludedIn(Roles.Auditors);
      
      if (isAdministratorOrAdvisor)
      {
        var properties = new Sungero.Charts.WidgetProperties.AdviserProperties();
        ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.Run", properties);
        return;
      }
      
      ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.Run");
    }
    
    #region Мониторинг и анализ для виджетов
    
    /// <summary>
    /// Вызвать исполнительскую дисциплину в Мониторинге и анализе.
    /// </summary>
    /// <param name="performer">Объект.</param>
    /// <param name="period">Период.</param>
    [Public]
    public virtual void EmployeeDiscipline(Enumeration performer, Enumeration period)
    {
      var properties = new Charts.WidgetProperties.AssignmentCompletion();
      
      if (performer == Shell.Widgets.AssignmentCompletionGraph.Performer.My)
        properties.EmployeeId = Company.Employees.Current.Id;
      if (performer == Shell.Widgets.AssignmentCompletionGraph.Performer.MyDepartment)
        properties.Filter.Department = Company.Employees.Current.Department;
      if (performer == Shell.Widgets.AssignmentCompletionGraph.Performer.All)
        properties.Filter.Department = null;
      
      var periodBegin = Calendar.Today;
      if (period == Shell.Widgets.AssignmentCompletionGraph.Period.Last30days)
        periodBegin = periodBegin.AddDays(-30);
      if (period == Shell.Widgets.AssignmentCompletionGraph.Period.Last90days)
        periodBegin = periodBegin.AddDays(-90);
      
      properties.Filter.PeriodBegin = periodBegin;
      properties.Filter.PeriodEnd = Calendar.Now;
      
      ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.RunDiscipline", properties);
    }
    
    /// <summary>
    /// Вызвать исполнительскую дисциплину в Мониторинге и анализе по конкретному сотруднику.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="period">Период.</param>
    /// <param name="department">В рамках моего подразделения.</param>
    [Public]
    public virtual void EmployeeDiscipline(Sungero.Company.IEmployee employee, Enumeration period, bool department)
    {
      var properties = new Charts.WidgetProperties.AssignmentCompletion();
      var periodBegin = Calendar.Today;
      
      if (period == Shell.Widgets.AssignmentCompletionGraph.Period.Last30days)
        periodBegin = periodBegin.AddDays(-30);
      if (period == Shell.Widgets.AssignmentCompletionGraph.Period.Last90days)
        periodBegin = periodBegin.AddDays(-90);
      
      properties.Filter.PeriodBegin = periodBegin;
      properties.Filter.PeriodEnd = Sungero.Core.Calendar.Now;
      properties.EmployeeId = employee.Id;
      properties.Filter.Department = department ? employee.Department : null;
      
      ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.RunDiscipline", properties);
      
    }
    
    /// <summary>
    /// Перегрузка для исполнительской дисциплины подразделений.
    /// </summary>
    /// <param name="period">Период.</param>
    /// <param name="department">Подразделение.</param>
    [Public]
    public virtual void EmployeeDiscipline(Enumeration period, Sungero.Company.IDepartment department)
    {
      var properties = new Charts.WidgetProperties.AssignmentCompletion();
      var periodBegin = Calendar.Today;
      var periodEnd = Calendar.Now;
      
      if (period == Shell.Widgets.AssignmentCompletionDepartmentGraph.Period.Last30days)
        periodBegin = periodBegin.AddDays(-30);
      if (period == Shell.Widgets.AssignmentCompletionDepartmentGraph.Period.Last90days)
        periodBegin = periodBegin.AddDays(-90);
      
      properties.Filter.PeriodBegin = periodBegin;
      properties.Filter.PeriodEnd = periodEnd;
      properties.Filter.Department = department;
      
      ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.RunDiscipline", properties);
    }

    /// <summary>
    /// Запустить в Мониторинге и анализе топ загруженных сотрудников по выбранному сотруднику.
    /// </summary>
    /// <param name="employee">Сотрудник.</param>
    /// <param name="overdue">Признак просрочки.</param>
    /// <param name="period">Период.</param>
    /// <param name="department">В рамках моего подразделения.</param>
    [Public]
    public virtual void EmployeeAssignmentPage(Sungero.Company.IEmployee employee, bool overdue, Enumeration period, bool department)
    {
      var periodDays = period == Shell.Widgets.TopLoadedPerformersGraph.Period.Last30Days ? 30 : 90;
      
      var properties = new Charts.WidgetProperties.TopLoaded();
      
      properties.EmployeeId = employee.Id;
      properties.Overdue = overdue;
      properties.IsEmployeeChecked = true;
      properties.Filter.Department = department ? employee.Department : null;
      properties.Filter.PeriodBegin = Sungero.Core.Calendar.Today.AddDays(-periodDays);
      properties.Filter.PeriodEnd = Sungero.Core.Calendar.Now;
      
      ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.RunEmployeeAssignments", properties);
    }
    
    /// <summary>
    /// Запустить в Мониторинге и анализе топ загруженных сотрудников по выбранному подразделению.
    /// </summary>
    /// <param name="department">Подразделение.</param>
    /// <param name="overdue">Признак просрочки.</param>
    /// <param name="period">Период.</param>
    [Public]
    public virtual void EmployeeAssignmentPage(Sungero.Company.IDepartment department, bool overdue, Enumeration period)
    {
      var periodDays = period == Shell.Widgets.TopLoadedPerformersGraph.Period.Last30Days ? 30 : 90;
      
      var properties = new Charts.WidgetProperties.TopLoaded();
      
      properties.DepartmentId = department.Id;
      properties.Overdue = overdue;
      properties.IsEmployeeChecked = false;
      properties.Filter.PeriodBegin = Sungero.Core.Calendar.Today.AddDays(-periodDays);
      properties.Filter.PeriodEnd = Sungero.Core.Calendar.Now;
      properties.Filter.Department = null;
      
      ExternalLibraryInvoker.Invoke("Sungero.Charts", "Sungero.Charts.Monitoring.RunEmployeeAssignments", properties);
    }
    
    #endregion
    
    #region Проверка параметров диалогов
    
    /// <summary>
    /// Проверить даты диалога отчета.
    /// </summary>
    /// <param name="args">Аргументы.</param>
    /// <param name="dialogPeriodBegin">Параметр даты начала.</param>
    /// <param name="dialogPeriodEnd">Параметр даты конца.</param>
    [Public]
    public static void CheckReportDialogPeriod(CommonLibrary.InputDialogButtonClickEventArgs args,
                                               CommonLibrary.IDateDialogValue dialogPeriodBegin,
                                               CommonLibrary.IDateDialogValue dialogPeriodEnd)
    {
      var periodBegin = dialogPeriodBegin.Value;
      var periodEnd = dialogPeriodEnd.Value;
      
      CheckDialogPeriod(args, dialogPeriodBegin, dialogPeriodEnd, Sungero.Docflow.Resources.WrongPeriodReport);
      
      // Проверить даты на наличие календаря рабочего времени.
      var periodBeginNoCalendarError = Sungero.Docflow.PublicFunctions.Module.CheckDateByWorkCalendar(periodBegin);
      if (periodBegin.HasValue && !string.IsNullOrWhiteSpace(periodBeginNoCalendarError))
        args.AddError(periodBeginNoCalendarError, dialogPeriodBegin);
      
      var periodEndNoCalendarError = Sungero.Docflow.PublicFunctions.Module.CheckDateByWorkCalendar(periodEnd);
      if (periodEnd.HasValue && !string.IsNullOrWhiteSpace(periodEndNoCalendarError))
        args.AddError(periodEndNoCalendarError, dialogPeriodEnd);
    }
    
    /// <summary>
    /// Проверить даты диалога.
    /// </summary>
    /// <param name="args">Аргументы.</param>
    /// <param name="dialogPeriodBegin">Параметр даты начала.</param>
    /// <param name="dialogPeriodEnd">Параметр даты конца.</param>
    [Public]
    public static void CheckDialogPeriod(CommonLibrary.InputDialogButtonClickEventArgs args,
                                         CommonLibrary.IDateDialogValue dialogPeriodBegin,
                                         CommonLibrary.IDateDialogValue dialogPeriodEnd)
    {
      CheckDialogPeriod(args, dialogPeriodBegin, dialogPeriodEnd, Sungero.Docflow.Resources.WrongPeriod);
    }
    
    private static void CheckDialogPeriod(CommonLibrary.InputDialogButtonClickEventArgs args,
                                          CommonLibrary.IDateDialogValue dialogPeriodBegin,
                                          CommonLibrary.IDateDialogValue dialogPeriodEnd,
                                          CommonLibrary.LocalizedString wrongPeriodError)
    {
      var periodBegin = dialogPeriodBegin.Value;
      var periodEnd = dialogPeriodEnd.Value;
      
      if (periodBegin.HasValue && periodEnd.HasValue &&
          periodEnd.Value < periodBegin.Value)
      {
        // Выделить оба поля в диалоге с одним текстом ошибки. Ошибки с одинаковыми текстами схлапываются в одну.
        args.AddError(wrongPeriodError, dialogPeriodBegin);
        args.AddError(wrongPeriodError, dialogPeriodEnd);
      }
    }
    
    /// <summary>
    /// Валидация даты по рабочему календарю.
    /// </summary>
    /// <param name="date">Дата.</param>
    /// <returns>Сообщения валидации, пустая строка при их отсутствии.</returns>
    [Public]
    public static string CheckDateByWorkCalendar(DateTime? date)
    {
      if (date == null)
        return string.Empty;
      
      if (!WorkingTime.GetAllCachedByYear(date.Value.Year).Any(c => c.Year == date.Value.Year))
        return Docflow.Resources.EmptyWorkingCalendarFormat(date.Value.Year);
      
      return string.Empty;
    }
    
    #endregion
    
    /// <summary>
    /// Валидация срока по рабочему календарю.
    /// </summary>
    /// <param name="deadline">Срок.</param>
    /// <returns>Сообщения валидации, пустая строка при их отсутствии.</returns>
    [Public]
    public static string CheckDeadlineByWorkCalendar(DateTime? deadline)
    {
      return CheckDeadlineByWorkCalendar(Users.Current, deadline);
    }
    
    /// <summary>
    /// Валидация срока по рабочему календарю конкретного пользователя.
    /// </summary>
    /// <param name="user">Пользователь.</param>
    /// <param name="deadline">Срок.</param>
    /// <returns>Сообщения валидации, пустая строка при их отсутствии.</returns>
    [Public]
    public static string CheckDeadlineByWorkCalendar(IUser user, DateTime? deadline)
    {
      if (deadline == null)
        return string.Empty;
      
      var checkDateError = CheckDateByWorkCalendar(deadline);
      if (!string.IsNullOrWhiteSpace(checkDateError))
        return checkDateError;
      
      // Срок задания дб рабочим днем.
      if (!deadline.Value.IsWorkingDay(user))
        return Docflow.Resources.ImpossibleSpecifyDeadlineToNotWorkingDay;
      
      // Срок задания дб рабочим временем.
      if (deadline.Value.HasTime() && !deadline.Value.IsWorkingTime(user))
        return Docflow.Resources.ImpossibleSpecifyDeadlineToNotWorkingTime;
      
      return string.Empty;
    }
    
    /// <summary>
    /// Создать задачу на ознакомление.
    /// </summary>
    /// <param name="document">Документ, который отправляется на ознакомление.</param>
    /// <returns>Задача на ознакомление.</returns>
    [Public]
    public static ITask CreateAcquaintanceTask(IOfficialDocument document)
    {
      return RecordManagement.PublicFunctions.Module.Remote.CreateAcquaintanceTask(document);
    }
    
    /// <summary>
    /// Показать диалог подтверждения выполнения без создания поручений.
    /// </summary>
    /// <param name="assignment">Задание, которое выполняется.</param>
    /// <param name="document">Документ.</param>
    /// <param name="e">Аргументы.</param>
    /// <returns>True, если диалог был, иначе false.</returns>
    public static bool ShowConfirmationDialogCreationActionItem(IAssignment assignment, IOfficialDocument document, Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var documentApprovalTask = ApprovalTasks.As(assignment.Task);
      var hasSubActionItem = Functions.Module.HasSubActionItems(assignment.Task, Workflow.Task.Status.InProcess, documentApprovalTask.Addressee);
      if (hasSubActionItem)
        return false;
      
      var isExecutionAssignment = ApprovalExecutionAssignments.Is(assignment);
      var dialogText = isExecutionAssignment ? Resources.ExecuteWithoutCreatingActionItemFromAddressee : Resources.ExecuteWithoutCreatingActionItem;
      var dialog = Dialogs.CreateTaskDialog(dialogText, MessageType.Question);
      dialog.Buttons.AddYes();
      dialog.Buttons.Default = DialogButtons.Yes;
      var createActionItemButton = dialog.Buttons.AddCustom(Resources.CreateActionItem);
      dialog.Buttons.AddNo();
      
      var result = dialog.Show();
      if (result == DialogButtons.Yes)
        return true;
      
      if (result == DialogButtons.No || result == DialogButtons.Cancel)
        e.Cancel();
      
      var stages = Functions.ApprovalRuleBase.Remote.GetStages(documentApprovalTask.ApprovalRule, document, documentApprovalTask).Stages;
      var assignedBy = Sungero.Company.Employees.Null;
      
      // Автором резолюции вычислить адресата, либо подписывающего.
      if (stages.Any(s => s.StageType == Docflow.ApprovalRuleBaseStages.StageType.Review))
        assignedBy = documentApprovalTask.Addressee;
      else if (stages.Any(s => s.StageType == Docflow.ApprovalRuleBaseStages.StageType.Sign))
        assignedBy = documentApprovalTask.Signatory;
      
      var resolution = assignment.ActiveText;
      if (isExecutionAssignment)
        resolution = ApprovalExecutionAssignments.As(assignment).ResolutionText;
      
      assignment.Save();
      
      var actionItem = CreateActionItemExecutionWithResolution(document, assignment.Id, resolution, assignedBy);
      actionItem.ShowModal();
      hasSubActionItem = Functions.Module.HasSubActionItems(assignment.Task, Workflow.Task.Status.InProcess, assignedBy);
      if (hasSubActionItem)
        return true;
      
      var hasDraftSubActionItem = Functions.Module.HasSubActionItems(assignment.Task, Workflow.Task.Status.Draft, assignedBy);
      e.AddError(hasDraftSubActionItem ? Resources.AllCreatedActionItemsShouldBeStarted : Resources.CreatedActionItemExecutionNeeded);
      e.Cancel();
      return true;
    }
    
    /// <summary>
    /// Показать диалог подтверждения выполнения без отправки документа.
    /// </summary>
    /// <param name="assignment">Задание, которое выполняется.</param>
    /// <param name="collapsed">Схлопнутые типы заданий.</param>
    /// <param name="e">Аргументы.</param>
    /// <returns>True, если диалог был, иначе false.</returns>
    public static bool ShowConfirmationDialogSendToCounterparty(IAssignment assignment, System.Collections.Generic.IEnumerable<Enumeration?> collapsed,
                                                                Sungero.Workflow.Client.ExecuteResultActionArgs e)
    {
      var task = ApprovalTasks.As(assignment.Task);
      var document = task.DocumentGroup.OfficialDocuments.FirstOrDefault();
      
      var canSend = Functions.ApprovalSendingAssignment.CanSendToCounterparty(document);
      if (!canSend ||
          task.DeliveryMethod == null ||
          task.DeliveryMethod.Sid != Constants.MailDeliveryMethod.Exchange ||
          (collapsed != null && !collapsed.Any(c => c == ApprovalPrintingAssignmentCollapsedStagesTypesPr.StageType.Sending)) ||
          Exchange.PublicFunctions.ExchangeDocumentInfo.Remote.LastVersionSended(document))
        return false;
      
      var dialog = Dialogs.CreateTaskDialog(Resources.ExecuteWithoutSendToCounterparty, MessageType.Warning);
      dialog.Buttons.AddYes();
      dialog.Buttons.Default = DialogButtons.Yes;
      var send = dialog.Buttons.AddCustom(ApprovalSendingAssignments.Info.Actions.SendViaExchangeService.LocalizedName);
      dialog.Buttons.AddNo();
      
      var result = dialog.Show();
      if (result == DialogButtons.Yes)
        return true;
      
      if (result == DialogButtons.No || result == DialogButtons.Cancel)
        e.Cancel();
      
      // Открываем диалог отправки.
      Functions.ApprovalSendingAssignment.SendToCounterparty(document, task);
      
      // Если отправка так и не была выполнена - отменяем выполнение.
      if (!Exchange.PublicFunctions.ExchangeDocumentInfo.Remote.LastVersionSended(document))
        e.Cancel();
      
      return true;
    }
    
    /// <summary>
    /// Показать диалог подтверждения выполнения.
    /// </summary>
    /// <param name="text">Текст.</param>
    /// <param name="description">Дополнительный текст.</param>
    /// <param name="title">Заголовок.</param>
    /// <param name="dialogID">ИД диалога подтверждения.</param>
    /// <returns>True, если запрос был подтвержден.</returns>
    /// <remarks>При указании dialogID в диалоге появляется флажок "Больше не спрашивать".</remarks>
    [Public]
    public static bool ShowConfirmationDialog(string text, string description, string title, string dialogID)
    {
      var confirmationDialog = Dialogs.CreateConfirmDialog(text, description, title);
      
      if (!string.IsNullOrWhiteSpace(dialogID))
        confirmationDialog.WithDontAskAgain(dialogID);
      return confirmationDialog.Show();
    }
    
    /// <summary>
    /// Проверка заблокированности сущности другими пользователями.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <returns>True, если сущность заблокирована.
    /// False, если сущность не заблокирована (или заблокирована пользователем, который выполняет действие).</returns>
    [Public]
    public static bool IsLockedByOther(Domain.Shared.IEntity entity)
    {
      var lockInfo = entity != null ? Locks.GetLockInfo(entity) : null;
      return lockInfo != null && lockInfo.IsLockedByOther;
    }
    
    /// <summary>
    /// Проверка заблокированности сущности.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <returns>True, если сущность заблокирована.</returns>
    [Public]
    public static bool IsLocked(Domain.Shared.IEntity entity)
    {
      var lockInfo = entity != null ? Locks.GetLockInfo(entity) : null;
      return lockInfo != null && lockInfo.IsLocked;
    }
    
    /// <summary>
    /// Проверка заблокированности сущности, с добавлением ошибки, если сущность заблокирована.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <param name="e">Аргументы события, в котором проверяется доступность сущности.</param>
    /// <returns>True, если сущность заблокирована.
    /// False, если сущность не заблокирована (или заблокирована пользователем, который выполняет действие).</returns>
    public static bool IsLockedByOther(Domain.Shared.IEntity entity, Domain.Client.ExecuteActionArgs e)
    {
      var lockInfo = entity != null ? Locks.GetLockInfo(entity) : null;
      var isLockedByOther = lockInfo != null && lockInfo.IsLockedByOther;
      
      if (isLockedByOther)
        e.AddError(lockInfo.LockedMessage);
      
      e.ClearMessageAfterAction = true;
      return isLockedByOther;
    }
    
    /// <summary>
    /// Проверка заблокированности любой версии.
    /// </summary>
    /// <param name="versions">Список версий документа.</param>
    /// <returns>True, если заблокирована хотя бы одна версия.</returns>
    [Public]
    public static bool VersionIsLocked(List<Sungero.Content.IElectronicDocumentVersions> versions)
    {
      foreach (var version in versions)
      {
        var lockInfo = version.Body != null ? Locks.GetLockInfo(version.Body) : null;
        var isLockedByOther = lockInfo != null && lockInfo.IsLocked;
        
        if (isLockedByOther)
          return true;
      }
      
      return false;
    }
    
    /// <summary>
    /// Показать список всех отчетов.
    /// </summary>
    public virtual void ShowAllReports()
    {
      Reports.ShowAll();
    }

    /// <summary>
    /// Показать настройки текущего пользователя.
    /// </summary>
    public virtual void ShowCurrentPersonalSettings()
    {
      var personalSettings = Docflow.PublicFunctions.PersonalSetting.GetPersonalSettings(null);
      if (personalSettings != null)
        personalSettings.Show();
      else
      {
        if (Sungero.Company.Employees.Current == null)
          Dialogs.ShowMessage(Resources.FailedGetSettingsForNonEmployee, MessageType.Error);
        else
          Dialogs.ShowMessage(Resources.FailedGetSettings, MessageType.Error);
      }
    }
    
    /// <summary>
    /// Запустить отчет "Лист согласования".
    /// </summary>
    /// <param name="document">Документ.</param>
    public virtual void RunApprovalSheetReport(IOfficialDocument document)
    {
      var hasSignatures = Functions.OfficialDocument.Remote.HasSignatureForApprovalSheetReport(document);
      if (!hasSignatures)
      {
        Dialogs.NotifyMessage(OfficialDocuments.Resources.DocumentIsNotSigned);
        return;
      }
      
      var report = Reports.GetApprovalSheetReport();
      report.Document = document;
      report.Open();
    }
    
    /// <summary>
    /// Запустить отчёт "Протокол эл. обмена".
    /// </summary>
    /// <param name="document">Документ.</param>
    public virtual void RunExchangeOrderReport(IOfficialDocument document)
    {
      var report = Reports.GetExchangeOrderReport();
      report.Entity = document;
      report.Open();
    }
    
    #region Подписание документа
    
    /// <summary>
    /// Утвердить документ.
    /// </summary>
    /// <param name="assignment">Задание с документом.</param>
    /// <param name="needStrongSign">Требуется квалифицированная электронная подпись.</param>
    /// <param name="eventArgs">Аргумент обработчика вызова.</param>
    public virtual void ApproveDocument(IAssignment assignment, bool needStrongSign, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      var task = ApprovalTasks.As(assignment.Task);
      if (task == null)
        return;
      
      var document = task.DocumentGroup.OfficialDocuments.Single();
      var addendas = task.AddendaGroup.OfficialDocuments.ToList();
      var performer = Company.Employees.As(assignment.Performer);
      var comment = string.IsNullOrWhiteSpace(assignment.ActiveText) ? string.Empty : assignment.ActiveText;
      
      this.ApproveDocument(document, addendas, performer, needStrongSign, comment, eventArgs);
    }
    
    /// <summary>
    /// Утвердить документ.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <param name="addendas">Приложения.</param>
    /// <param name="substituted">За кого выполняется утверждение.</param>
    /// <param name="needStrongSign">Требуется квалифицированная электронная подпись.</param>
    /// <param name="comment">Комментарий.</param>
    /// <param name="eventArgs">Аргумент обработчика вызова.</param>
    public virtual void ApproveDocument(IOfficialDocument document, List<IOfficialDocument> addendas, Company.IEmployee substituted, bool needStrongSign, string comment, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      var signatories = Functions.OfficialDocument.Remote.GetSignatories(document);
      var currentEmployee = Company.Employees.Current;
      var signatory = signatories.Any(s => Equals(s.EmployeeId, substituted.Id)) && signatories.Any(s => currentEmployee != null && Equals(s.EmployeeId, currentEmployee.Id)) ? substituted : currentEmployee;

      try
      {
        if (!Functions.Module.ApproveWithAddenda(document, addendas, null, signatory, false, needStrongSign, comment))
          eventArgs.AddError(ApprovalTasks.Resources.ToPerformNeedSignDocument);
      }
      catch (CommonLibrary.Exceptions.PlatformException ex)
      {
        if (!ex.IsInternal)
        {
          var message = ex.Message.Trim().EndsWith(".") ? ex.Message : string.Format("{0}.", ex.Message);
          eventArgs.AddError(message);
        }
        else
          throw;
      }
    }
    
    /// <summary>
    /// Согласовать документ.
    /// </summary>
    /// <param name="assignment">Задание с документом.</param>
    /// <param name="endorse">Признак согласования документа, true - согласовать документ, false - не согласовывать.</param>
    /// <param name="needStrongSign">Требуется квалифицированная электронная подпись.</param>
    /// <param name="eventArgs">Аргумент обработчика вызова.</param>
    public virtual void EndorseDocument(IAssignment assignment, bool endorse, bool needStrongSign, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      var approvalTask = ApprovalTasks.As(assignment.Task);
      var freeApprovalTask = FreeApprovalTasks.As(assignment.Task);
      
      if (approvalTask == null && freeApprovalTask == null)
        return;
      
      var performer = Company.Employees.As(assignment.Performer);
      // Добавить в комментарий ЭП результат выполнения задания, если пользователь ничего не указал.
      var comment = string.IsNullOrWhiteSpace(assignment.ActiveText) ? string.Empty : assignment.ActiveText;
      
      var document = approvalTask != null ? ElectronicDocuments.As(approvalTask.DocumentGroup.OfficialDocuments.Single()) : freeApprovalTask.ForApprovalGroup.ElectronicDocuments.Single();
      var addendas = approvalTask != null ? approvalTask.AddendaGroup.OfficialDocuments.ToList<IElectronicDocument>() : freeApprovalTask.AddendaGroup.ElectronicDocuments.ToList();

      this.EndorseDocument(document, addendas, performer, endorse, needStrongSign, comment, eventArgs);
    }
    
    /// <summary>
    /// Согласовать документ.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <param name="addendas">Приложения.</param>
    /// <param name="substituted">За кого выполняется утверждение.</param>
    /// <param name="endorse">Признак согласования документа, true - согласовать документ, false - не согласовывать.</param>
    /// <param name="needStrongSign">Требуется квалифицированная электронная подпись.</param>
    /// <param name="comment">Комментарий.</param>
    /// <param name="eventArgs">Аргумент обработчика вызова.</param>
    public virtual void EndorseDocument(IElectronicDocument document, List<IElectronicDocument> addendas, Company.IEmployee substituted, bool endorse, bool needStrongSign, string comment, Sungero.Domain.Client.ExecuteActionArgs eventArgs)
    {
      if (!document.HasVersions && !endorse)
        return;
      
      try
      {
        var isSigned = endorse ?
          this.EndorseWithAddenda(document, addendas, null, substituted, needStrongSign, comment) :
          Signatures.NotEndorse(document.LastVersion, null, comment, substituted);
        
        if (!isSigned)
          eventArgs.AddError(ApprovalTasks.Resources.ToPerformNeedSignDocument);
      }
      catch (CommonLibrary.Exceptions.PlatformException ex)
      {
        if (!ex.IsInternal)
        {
          var message = ex.Message.EndsWith(".") ? ex.Message : string.Format("{0}.", ex.Message);
          eventArgs.AddError(message);
        }
        else
          throw;
      }
    }
    
    /// <summary>
    /// Утвердить документ с приложениями.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <param name="addenda">Приложения.</param>
    /// <param name="certificate">Сертификат (не передавать, чтобы оставить выбор пользователю).</param>
    /// <param name="substituted">За кого выполняется утверждение (не передавать, чтобы утвердить под текущим пользователем).</param>
    /// <param name="endorseWhenApproveFailed">Согласовать документ, если не удается выполнить утверждение.</param>
    /// <param name="needStrongSign">Требуется квалифицированная электронная подпись.</param>
    /// <param name="comment">Комментарий.</param>
    /// <returns>True, если сам документ был утверждён или не имеет версий. Факт подписания приложений неважен.</returns>
    [Public]
    public virtual bool ApproveWithAddenda(IOfficialDocument document, List<IOfficialDocument> addenda, ICertificate certificate, Company.IEmployee substituted, bool endorseWhenApproveFailed, bool needStrongSign, string comment)
    {
      var addendaHasVersions = addenda != null && addenda.Any(a => a.HasVersions);
      if (!document.HasVersions && !addendaHasVersions)
        return true;
      
      if (certificate == null && needStrongSign)
      {
        if (!this.TryGetUserCertificate(document, out certificate))
          return false;
      }
      
      try
      {
        var result = !document.HasVersions;
        if (document.HasVersions)
        {
          var canApprove = !Functions.OfficialDocument.Remote.GetApprovalValidationErrors(document, true).Any();
          if (canApprove)
          {
            var accountingDocument = AccountingDocumentBases.As(document);
            if (accountingDocument != null && accountingDocument.IsFormalized == true)
            {
              Functions.AccountingDocumentBase.GenerateDefaultSellerTitle(accountingDocument);
              Functions.AccountingDocumentBase.GenerateDefaultBuyerTitle(accountingDocument);
            }
            result = Signatures.Approve(document.LastVersion, certificate, comment, substituted);
          }
          else if (endorseWhenApproveFailed)
            result = Signatures.Endorse(document.LastVersion, certificate, comment, substituted);
        }
        
        // Если не удалось утвердить основной документ или приложений нет - приложения не трогаем.
        if (!result || addenda == null || !addenda.Any())
          return result;
        
        var addendaWithVersion = addenda.Where(a => a.HasVersions).ToList();
        if (!addendaWithVersion.Any())
          return result;
        
        var canBeApproved = new List<IOfficialDocument>();
        var canBeEndorsed = new List<IOfficialDocument>();
        foreach (var addendaDocument in addendaWithVersion)
        {
          var canApprove = !Functions.OfficialDocument.Remote.GetApprovalValidationErrors(addendaDocument, true).Any();
          if (canApprove)
            canBeApproved.Add(addendaDocument);
          else
            canBeEndorsed.Add(addendaDocument);
        }
        foreach (var addendaDocument in canBeApproved)
        {
          var addendaAccountingDocument = AccountingDocumentBases.As(addendaDocument);
          if (addendaAccountingDocument != null && addendaAccountingDocument.IsFormalized == true)
          {
            Functions.AccountingDocumentBase.GenerateDefaultSellerTitle(addendaAccountingDocument);
            Functions.AccountingDocumentBase.GenerateDefaultBuyerTitle(addendaAccountingDocument);
          }
        }
        if (canBeApproved.Any())
          Signatures.Approve(canBeApproved.Select(a => a.LastVersion), certificate, comment, substituted);
        if (canBeEndorsed.Any())
          Signatures.Endorse(canBeEndorsed.Select(a => a.LastVersion), certificate, comment, substituted);
        return result;
      }
      catch (Sungero.Domain.Shared.Exceptions.ChildEntityNotFoundException ex)
      {
        throw AppliedCodeException.Create(OfficialDocuments.Resources.SigningVersionWasDeleted, ex);
      }
    }
    
    /// <summary>
    /// Согласовать документ с приложениями.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <param name="addenda">Приложения.</param>
    /// <param name="certificate">Сертификат (не передавать, чтобы оставить выбор пользователю).</param>
    /// <param name="substituted">За кого выполняется утверждение (не передавать, чтобы утвердить под текущим пользователем).</param>
    /// <param name="needStrongSign">Требуется квалифицированная электронная подпись.</param>
    /// <param name="comment">Комментарий.</param>
    /// <returns>True, если сам документ был согласован или не имеет версий. Факт согласования приложений неважен.</returns>
    [Public]
    public virtual bool EndorseWithAddenda(IElectronicDocument document, List<IElectronicDocument> addenda, ICertificate certificate, IUser substituted, bool needStrongSign, string comment)
    {
      var addendaHasVersions = addenda != null && addenda.Any(a => a.HasVersions);
      if (!document.HasVersions && !addendaHasVersions)
        return true;
      
      if (certificate == null && needStrongSign)
      {
        var officialDocument = OfficialDocuments.As(document);
        
        if (!this.TryGetUserCertificate(officialDocument, out certificate))
          return false;
      }
      
      try
      {
        var result = !document.HasVersions;
        if (document.HasVersions)
        {
          result = Signatures.Endorse(document.LastVersion, certificate, comment, substituted);
        }
        
        // Если не удалось согласовать основной документ или приложений нет - приложения не трогаем.
        if (!result || addenda == null || !addenda.Any())
          return result;
        
        var addendaWithVersion = addenda.Where(a => a.HasVersions).ToList();
        if (!addendaWithVersion.Any())
          return result;
        
        Signatures.Endorse(addendaWithVersion.Select(a => a.LastVersion), certificate, comment, substituted);
        return result;
      }
      catch (Sungero.Domain.Shared.Exceptions.ChildEntityNotFoundException ex)
      {
        throw AppliedCodeException.Create(OfficialDocuments.Resources.SigningVersionWasDeleted, ex);
      }
    }
    
    /// <summary>
    /// Получить сертификат пользователя для подписания.
    /// </summary>
    /// <param name="document">Документ.</param>
    /// <param name="certificate">Сертификат для подписания.</param>
    /// <returns>True, если выбор произведен, false в случае отмены.</returns>
    private bool TryGetUserCertificate(IOfficialDocument document, out ICertificate certificate)
    {
      certificate = null;
      var certificates = PublicFunctions.Module.Remote.GetCertificates(document);
      
      if (certificates.Any())
      {
        var selectedCertificate = certificates.Count() > 1 ?
          certificates.ShowSelectCertificate() :
          certificates.First();
        if (selectedCertificate == null)
          return false;
        certificate = selectedCertificate;
      }
      return true;
    }
    
    #endregion
    
    #region Диалог добавления приложений из файлов.

    /// <summary>
    /// Получить сообщение об успешном создании приложений из файлов.
    /// </summary>
    /// <param name="countAddendums">Количество приложений.</param>
    /// <returns>Сообщение об успешном создании приложений из файлов.</returns>
    public virtual string GetManyAddendumDialogSuccessfulNotify(int countAddendums)
    {
      var addendumName = Sungero.Docflow.Resources.AddendumNameForOneDocument;
      if (countAddendums > 1 && countAddendums < 5)
        addendumName = Sungero.Docflow.Resources.AddendumNameLessFiveDocument;
      else if (countAddendums >= 5)
        addendumName = Sungero.Docflow.Resources.AddendumNameForManyDocument;
      
      return Sungero.Docflow.OfficialDocuments.Resources.AddendaCreatedSuccesfullyFormat(countAddendums, addendumName);
    }
    
    /// <summary>
    /// Создать приложение к документу.
    /// </summary>
    /// <param name="addendumName">Имя документа.</param>
    /// <param name="leadingDocument">Ведущий документ.</param>
    /// <param name="addendumContent">Тело документа.</param>
    public virtual void CreateAddendum(string addendumName, IOfficialDocument leadingDocument, byte[] addendumContent)
    {
      var addendum = Functions.Addendum.Remote.Create();
      addendum.LeadingDocument = leadingDocument;
      if (addendum.State.Properties.Name.IsEnabled)
        addendum.Name = System.IO.Path.GetFileNameWithoutExtension(addendumName);
      else
        addendum.Subject = System.IO.Path.GetFileNameWithoutExtension(addendumName);
      if (addendum.DocumentKind == null)
        addendum.DocumentKind = Functions.DocumentKind.GetAvailableDocumentKinds(typeof(Docflow.IAddendum)).FirstOrDefault();
      
      using (var fileStream = new System.IO.MemoryStream(addendumContent))
      {
        addendum.CreateVersionFrom(fileStream, System.IO.Path.GetExtension(addendumName));
        addendum.Save();
      }
      return;
    }
    
    /// <summary>
    /// Диалог массового добавления приложений из файлов.
    /// </summary>
    /// <param name="document">Документ, для которого создаются приложения.</param>
    public virtual void AddManyAddendumDialog(IOfficialDocument document)
    {
      var dialog = Dialogs.CreateInputDialog(Sungero.Docflow.OfficialDocuments.Resources.ManyAddendumDialogTitle);
      dialog.Text = Sungero.Docflow.OfficialDocuments.Resources.ManyAddendumDialogText;
      if (ClientApplication.ApplicationType == ApplicationType.Web)
        dialog.Width = 400;
      
      var fileSelectors = new List<CommonLibrary.IFileSelectDialogValue>();
      for (int i = 0; i < Constants.Module.ManyAddendumDialogLimit; i++)
      {
        var fileSelector = dialog.AddFileSelect(string.Format("{0}.", i + 1), false);
        fileSelector.IsVisible = i == 0;
        fileSelector.MaxFileSize(Constants.Module.ManyAddendumDialogMaxFileSize);
        fileSelectors.Add(fileSelector);
      }
      var import = dialog.Buttons.AddCustom(Sungero.Docflow.OfficialDocuments.Resources.AddendumAddFiles);
      var cancel = dialog.Buttons.AddCustom(Sungero.Docflow.Resources.Dialog_Close);
      
      var isImportAddendums = false;
      var isSuccessfullyCreateAddendums = true;
      var countSuccessfullyCreateAddendums = 0;
      var errorList = new List<string>();
      var errorFileSelectors = new List<CommonLibrary.IFileSelectDialogValue>();
      
      Action<CommonLibrary.InputDialogRefreshEventArgs> refresh = (b) =>
      {
        if (isImportAddendums)
        {
          import.IsVisible = false;
          cancel.Name = Sungero.Docflow.Resources.Dialog_Close;
          foreach (var fileSelector in fileSelectors)
          {
            fileSelector.IsEnabled = false;
            if (fileSelector.Value == null || fileSelector.Value.Name == string.Empty)
              fileSelector.IsVisible = false;
          }
        }
        else
        {
          cancel.Name = AccountingDocumentBases.Resources.ExportDialog_Cancel;
          var lastVisibleFileSelector = fileSelectors.Last(f => f.IsVisible);
          if (lastVisibleFileSelector.Value != null &&
              lastVisibleFileSelector.Value.Name != string.Empty &&
              fileSelectors.Any(f => !f.IsVisible))
            fileSelectors.FirstOrDefault(f => !f.IsVisible).IsVisible = true;
          
          foreach (var fileSelector in fileSelectors.Where(f => f.Value != null && f.Value.Name != string.Empty))
          {
            var equalFileSelectors = fileSelectors.Where(f => f.Value != null && f.Value.Name != string.Empty)
              .Where(f => !Equals(f, fileSelector) && Equals(f.Value.Name, fileSelector.Value.Name)).ToList();
            if (equalFileSelectors.Any())
            {
              equalFileSelectors.Add(fileSelector);
              b.AddError(Sungero.Docflow.Resources.ErrorEqualsFileAddManyAddendums, equalFileSelectors.ToArray());
            }
          }
          
          if (!fileSelectors.Any(f => f.Value != null && f.Value.Name != string.Empty))
            import.IsEnabled = false;
          else
            import.IsEnabled = true;
        }
        
      };
      dialog.SetOnRefresh(refresh);
      dialog.SetOnButtonClick(b =>
                              {
                                if (b.Button == cancel)
                                  return;
                                if (b.Button == import && b.IsValid)
                                {
                                  try
                                  {
                                    if (isImportAddendums)
                                      return;

                                    if (!b.IsValid)
                                      return;
                                    
                                    isImportAddendums = true;
                                    
                                    foreach (var fileSelector in fileSelectors.Where(f => f.Value != null && f.Value.Name != string.Empty))
                                    {
                                      try
                                      {
                                        CreateAddendum(fileSelector.Value.Name, document, fileSelector.Value.Content);
                                        countSuccessfullyCreateAddendums++;
                                      }
                                      catch (AppliedCodeException ae)
                                      {
                                        errorFileSelectors.Add(fileSelector);
                                        errorList.Add(ae.Message);
                                        isSuccessfullyCreateAddendums = false;
                                      }
                                      catch (Sungero.Domain.Shared.Validation.ValidationException ex)
                                      {
                                        Logger.Error(ex.Message, ex);
                                        errorFileSelectors.Add(fileSelector);
                                        errorList.Add(ex.Message);
                                        isSuccessfullyCreateAddendums = false;
                                      }
                                      catch (Exception ex)
                                      {
                                        Logger.Error(ex.Message, ex);
                                        errorFileSelectors.Add(fileSelector);
                                        errorList.Add(Sungero.Docflow.Resources.InternalServerError);
                                        isSuccessfullyCreateAddendums = false;
                                      }
                                    }
                                    
                                    if (isSuccessfullyCreateAddendums && countSuccessfullyCreateAddendums > 0)
                                      Dialogs.NotifyMessage(Functions.Module.GetManyAddendumDialogSuccessfulNotify(countSuccessfullyCreateAddendums));
                                    else
                                    {
                                      var errorMessage = string.Empty;
                                      if (countSuccessfullyCreateAddendums > 0)
                                        errorMessage += Functions.Module.GetManyAddendumDialogSuccessfulNotify(countSuccessfullyCreateAddendums);

                                      errorMessage += Sungero.Docflow.Resources.ErrorAddManyAddendumsFormat(countSuccessfullyCreateAddendums > 0 ?
                                                                                                            Sungero.Docflow.Resources.ErrorAddManyAddendumsOther : string.Empty);
                                      foreach (var error in errorList.Distinct())
                                      {
                                        errorMessage += string.Format(Sungero.Docflow.Resources.ErrorList, error);
                                      }
                                      b.AddError(errorMessage, errorFileSelectors.ToArray());
                                      refresh.Invoke(null);
                                    }
                                  }
                                  catch (AppliedCodeException ae)
                                  {
                                    b.AddError(ae.Message);
                                  }
                                  catch (Exception ex)
                                  {
                                    Logger.Error(ex.Message, ex);
                                    b.AddError(Sungero.Docflow.Resources.InternalServerError);
                                  }
                                }
                              });
      dialog.Show();
    }
    
    #endregion
       
  }
}