﻿using System;
using System.Collections.Generic;
using System.Linq;
using CommonLibrary;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Docflow.Structures.Module
{

  /// <summary>
  /// Результаты почтовой рассылки.
  /// </summary>
  partial class MailSendingResult
  {
    public bool IsSuccess { get; set; }
    
    public bool AnyMailSended { get; set; }
  }
  
  /// <summary>
  /// Строчка отчета.
  /// </summary>
  partial class EnvelopeReportTableLine
  {
    public string ReportSessionId { get; set; }
    
    public int Id { get; set; }
    
    public string ToName { get; set; }
    
    public string FromName { get; set; }
    
    public string ToZipCode { get; set; }

    public string FromZipCode { get; set; }
    
    public string ToPlace { get; set; }
    
    public string FromPlace { get; set; }
  }

  /// <summary>
  /// Отсортированный список этапов, подходящих по условиям.
  /// </summary>
  partial class DefinedApprovalStages
  {
    public List<Sungero.Docflow.Structures.Module.DefinedApprovalStageLite> Stages { get; set; }
    
    public bool IsConditionsDefined { get; set; }
    
    public string ErrorMessage { get; set; }
  }
  
  partial class DefinedApprovalStageLite
  {
    public Sungero.Docflow.IApprovalStage Stage { get; set; }
    
    public int? Number { get; set; }
    
    public Sungero.Core.Enumeration? StageType { get; set; }
  }
  
  /// <summary>
  /// Получатель и отправитель для конвертов.
  /// </summary>
  partial class AddresseeAndSender
  {
    public Sungero.Parties.ICounterparty Addresse { get; set; }
    
    public Sungero.Company.IBusinessUnit Sender { get; set; }
  }

  /// <summary>
  /// Индекс и адрес без индекса.
  /// </summary>
  partial class ZipCodeAndAddress
  {
    public string ZipCode { get; set; }
    
    public string Address { get; set; }
  }

  /// <summary>
  /// Даты итераций задачи.
  /// </summary>
  partial class TaskIterations
  {
    public DateTime Date { get; set; }
    
    public bool IsRework { get; set; }
    
    public bool IsRestart { get; set; }
  }
  
  /// <summary>
  /// Атрибуты содержания издателя сертификата.
  /// </summary>
  partial class IssuerSubject
  {
    public string Name { get; set; }
  }
  
  /// <summary>
  /// Атрибуты содержания сертификата.
  /// </summary>
  [Public]
  partial class CertificateSubject
  {
    public string CounterpartyName { get; set; }
    
    public string Country { get; set; }
    
    public string State { get; set; }
    
    public string Locality { get; set; }
    
    public string Street { get; set; }
    
    public string Department { get; set; }
    
    public string Surname { get; set; }
    
    public string GivenName { get; set; }
    
    public string JobTitle { get; set; }
    
    public string OrganizationName { get; set; }
    
    public string Email { get; set; }
    
    public string TIN { get; set; }
  }
  
  [Public]
  partial class ByteArray
  {
    public byte[] Bytes { get; set; }
  }
  
  #region Интеллектуальная обработка
  
  /// <summary>
  /// Параметры отображения фокусировки подсветки в предпросмотре.
  /// </summary>
  [Public]
  partial class HighlightActivationStyle
  {
    public string UseBorder { get; set; }
    
    public string BorderColor { get; set; }
    
    public double BorderWidth { get; set; }
    
    public string UseFilling { get; set; }
    
    public string FillingColor { get; set; }
  }
  
  #endregion
  
  /// <summary>
  /// Параметры отправки уведомлений о истечении срока документов.
  /// </summary>
  [Public]
  partial class ExpiringDocsNotificationParams
  {
    // Дата последнего уведомления.
    public DateTime LastNotification { get; set; }
    
    // Дата последнего уведомления с резервом.
    public DateTime LastNotificationReserve { get; set; }
    
    // Дата сегодня.
    public DateTime Today { get; set; }
    
    // Дата сегодня с резервом.
    public DateTime TodayReserve { get; set; }
    
    // Количество обрабатываемых за один раз документов.
    public int BatchCount { get; set; }
    
    // Имя таблицы БД с информацией об уведомлениях.
    public string ExpiringDocTableName { get; set; }
    
    // Имя параметра в Sungero_Docflow_Params с датой последнего уведомления.
    public string LastNotificationParamName { get; set; }
    
    // Параметры задачи о истечении срока документа.
    public Sungero.Docflow.Structures.Module.IExpiringNotificationTaskParams TaskParams { get; set; }
  }
  
  /// <summary>
  /// Параметры отправки задачи о истечении срока документа.
  /// </summary>
  [Public]
  partial class ExpiringNotificationTaskParams
  {
    // Тема.
    public string Subject { get; set; }
    
    // Текст.
    public string ActiveText { get; set; }
    
    // Документ, по которому создается уведомление.
    public IOfficialDocument Document { get; set; }
    
    // Исполнители.
    public List<IUser> Performers { get; set; }
    
    // Вложения.
    public List<Sungero.Content.IElectronicDocument> Attachments { get; set; }
  }
  
  /// <summary>
  /// Соответствие документа и хранилища для хранения его содержимого.
  /// </summary>
  partial class DocumentToSetStorage
  {
    public int DocumentId { get; set; }

    public int StorageId { get; set; }

  }
}