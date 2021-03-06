using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.SmartProcessingSetting;
using MessageTypes = Sungero.Docflow.Constants.SmartProcessingSetting.SettingsValidationMessageTypes;

namespace Sungero.Docflow.Client
{
  partial class SmartProcessingSettingActions
  {
    public virtual void ForceSave(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      e.Params.AddOrUpdate(Constants.SmartProcessingSetting.ForceSaveParamName, true);
      _obj.Save();
    }

    public virtual bool CanForceSave(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

    public virtual void CheckConnection(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      // Проверка адреса сервиса Ario.
      var arioUrlValidationMessage = Functions.SmartProcessingSetting.ValidateArioUrl(_obj);
      if (arioUrlValidationMessage != null)
      {
        if (arioUrlValidationMessage.Type == MessageTypes.Error)
          e.AddError(arioUrlValidationMessage.Text);
        
        if (arioUrlValidationMessage.Type == MessageTypes.SoftError)
          e.AddWarning(arioUrlValidationMessage.Text);
        
        return;
      }
      
      Dialogs.NotifyMessage(SmartProcessingSettings.Resources.ArioConnectionEstablished);
      
      // Проверка классификаторов.
      var classifiersValidationMessage = Functions.SmartProcessingSetting.ValidateClassifiers(_obj);
      if (classifiersValidationMessage != null)
        e.AddWarning(classifiersValidationMessage.Text);
    }
    
    public virtual bool CanCheckConnection(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.AccessRights.CanUpdate();
    }

  }

}