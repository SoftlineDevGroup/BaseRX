using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Integration1C.Shared
{
  public class ModuleFunctions
  {
    /// <summary>
    /// Получить сущности измененные с момента последней синхронизации.
    /// </summary>
    /// <param name="entityTypeGuids">Список гуидов типов сущностей.</param>
    /// <param name="processedEntitiesCount">Количество обработанных записей.</param>
    /// <param name="entitiesCountForProcessing">Размер пакета.</param>
    /// <param name="extEntityType">Тип записи внешней системы.</param>
    /// <param name="systemId">Ид системы 1С.</param>
    /// <returns>Список сущностей.</returns>
    [Public]
    public List<Sungero.Domain.Shared.IEntity> GetChangedEntitiesFromSyncDate(List<Guid> entityTypeGuids,
                                                                              int processedEntitiesCount,
                                                                              int entitiesCountForProcessing,
                                                                              string extEntityType,
                                                                              string systemId)
    {
      return Functions.Module.Remote.GetChangedEntitiesFromSyncDateRemote(entityTypeGuids, processedEntitiesCount, entitiesCountForProcessing, extEntityType, systemId);
    }
    
    /// <summary>
    /// Получить количество сущностей измененных с момента последней синхронизации.
    /// </summary>
    /// <param name="entityTypeGuids">Список гуидов типов сущностей.</param>
    /// <param name="extEntityType">Тип записи внешней системы.</param>
    /// <param name="systemId">Ид системы 1С.</param>
    /// <returns>Количество сущностей.</returns>
    [Public]
    public int GetChangedEntitiesFromSyncDateCount(List<Guid> entityTypeGuids,
                                                   string extEntityType,
                                                   string systemId)
    {
      return Functions.Module.Remote.GetChangedEntitiesFromSyncDateRemoteCount(entityTypeGuids, extEntityType, systemId);
    }
    
    [Public]
    public Docflow.ISimpleDocument GetTodayDocument(bool fileExist)
    {
      return Functions.Module.Remote.GetTodayDocumentRemote(fileExist);
    }
    
    [Public]
    public bool IsSummaryProtocolExist()
    {
      return Functions.Module.Remote.IsSummaryProtocolExistRemote();
    }
    
    [Public]
    public void SendNotificationBySimpleTaskRemote(string title, string text)
    {
      Functions.Module.Remote.SendNotificationBySimpleTask(title, text);
    }
    
    [Public]
    public void UpdateLastNotificationDateRemote(DateTime date, string systemId)
    {
      Functions.Module.Remote.UpdateLastNotificationDate(date, systemId);
    }
    
    [Public]
    public string GetLastNotificationDateRemote(string systemId)
    {
      return Functions.Module.Remote.GetLastNotificationDate(systemId);
    }
  }
}