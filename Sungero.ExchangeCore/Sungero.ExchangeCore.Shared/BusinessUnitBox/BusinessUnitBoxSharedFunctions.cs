using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.ExchangeCore.BusinessUnitBox;

namespace Sungero.ExchangeCore.Shared
{
  partial class BusinessUnitBoxFunctions
  {
    public void SetBusinessUnitBoxName()
    {
      if (_obj.BusinessUnit != null && _obj.ExchangeService != null)
        _obj.Name = string.Format("{0} ({1})", _obj.BusinessUnit, _obj.ExchangeService);
      else
        _obj.Name = string.Empty;
    }
    
    public void ResetConnectionStatus()
    {
      // У закрытого справочника статуса нет.
      if (_obj.Status == CoreEntities.DatabookEntry.Status.Closed)
      {
        _obj.ConnectionStatus = null;
        return;
      }
      
      // Изменение данных, которые требуется перевалидировать.
      if (_obj.ConnectionStatus != ConnectionStatus.Waiting &&
          (_obj.State.Properties.BusinessUnit.IsChanged ||
           _obj.State.Properties.ExchangeService.IsChanged ||
           _obj.State.Properties.Login.IsChanged))
      {
        _obj.ConnectionStatus = ConnectionStatus.Waiting;
      }
    }
    
    [Public]
    public static string GetEncryptedData(string data)
    {
      return Functions.BusinessUnitBox.Remote.GetEncryptedDataRemote(data);
    }
    
    /// <summary>
    /// Получить основной ящик.
    /// </summary>
    /// <returns>Основной ящик.</returns>
    [Public]
    public override IBusinessUnitBox GetRootBox()
    {
      return _obj;
    }
    
    /// <summary>
    /// Проверить, что ящик действующий.
    /// </summary>
    /// <returns>Сообщение об ошибке, если ящик недействующий. Иначе пустая строка.</returns>
    public string CheckBusinessUnitBoxActive()
    {
      if (_obj.Status == Sungero.ExchangeCore.BusinessUnitBox.Status.Closed)
        return BusinessUnitBoxes.Resources.BusinessUnitBoxNotActive.ToString();
      
      return string.Empty;
    }
    
  }
}