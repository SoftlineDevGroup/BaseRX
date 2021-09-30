using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.SmartProcessingSetting;
using MessageTypes = Sungero.Docflow.Constants.SmartProcessingSetting.SettingsValidationMessageTypes;
using SettingsValidationMessageStructure = Sungero.Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage;

namespace Sungero.Docflow.Server
{
  partial class SmartProcessingSettingFunctions
  {
    /// <summary>
    /// Создать настройки интеллектуальной обработки документов.
    /// </summary>
    [Remote, Public]
    public static void CreateSettings()
    {
      var smartProcessingSettings = SmartProcessingSettings.Create();
      
      // Заполнить из Docflow_Params, если ранее настройки хранились там.
      var arioUrlKey = Docflow.PublicFunctions.Module.GetDocflowParamsValue(Sungero.Docflow.PublicConstants.Module.ArioUrlKey);
      if (arioUrlKey != null)
        smartProcessingSettings.ArioUrl = arioUrlKey.ToString();
      
      var minFactProbability = Functions.Module.GetDocflowParamsNumbericValue(Sungero.Docflow.PublicConstants.Module.MinFactProbabilityKey);
      if (minFactProbability != 0)
        smartProcessingSettings.LowerConfidenceLimit = (int)minFactProbability;
      
      var trustedFactProbability = Functions.Module.GetDocflowParamsNumbericValue(Sungero.Docflow.PublicConstants.Module.TrustedFactProbabilityKey);
      if (trustedFactProbability != 0)
        smartProcessingSettings.UpperConfidenceLimit = (int)trustedFactProbability;
      
      smartProcessingSettings.Save();
      
      // Удалить параметры с настройками из Docflow_Params.
      Docflow.PublicFunctions.Module.ExecuteSQLCommand(Queries.SmartProcessingSetting.DeleteSmartSettingsFromDocflowParams);
    }
    
    /// <summary>
    /// Получить список классификаторов из Арио.
    /// </summary>
    /// <returns>Список классификаторов.</returns>
    [Remote(IsPure = true)]
    public virtual List<Structures.SmartProcessingSetting.ClassifierForDialog> GetArioClassifiers()
    {
      // TODO Rassokhina : убрать после починки передачи публичных структур с сервера на клиент Bug 71754, 67240.
      var classifiers = new List<Structures.SmartProcessingSetting.ClassifierForDialog>();
      foreach (var classifier in this.GetArioClassifiersPublic())
        classifiers.Add(Structures.SmartProcessingSetting.ClassifierForDialog.Create(classifier.Id, classifier.Name));
      return classifiers;
    }
    
    /// <summary>
    /// Проверить наличие классификаторов в Ario по точному соответствию наименования и ИД.
    /// </summary>
    /// <returns>True, если классификаторы существуют, иначе - False.</returns>
    [Remote(IsPure = true)]
    public virtual bool IsArioClassifiersExist()
    {
      var classifiers = this.GetArioClassifiersPublic();
      
      var firstPageClassifier = classifiers
        .Where(a => a.Id == _obj.FirstPageClassifierId.Value && a.Name == _obj.FirstPageClassifierName)
        .FirstOrDefault();
      var typeClassifier = classifiers
        .Where(a => a.Id == _obj.TypeClassifierId.Value && a.Name == _obj.TypeClassifierName)
        .FirstOrDefault();
      return firstPageClassifier != null && typeClassifier != null;
    }
    
    /// <summary>
    /// Получить список классификаторов из Арио.
    /// </summary>
    /// <returns>Список классификаторов.</returns>
    [Public]
    public virtual List<Docflow.Structures.SmartProcessingSetting.IClassifier> GetArioClassifiersPublic()
    {
      var classifiers = new List<Docflow.Structures.SmartProcessingSetting.IClassifier>();
      try
      {
        var arioConnector = new ArioExtensions.ArioConnector(_obj.ArioUrl);
        classifiers = arioConnector.GetClassifiers()
          .Select(x => Docflow.Structures.SmartProcessingSetting.Classifier.Create(x.Id, x.Name)).ToList();
      }
      catch (Exception e)
      {
        Logger.Error(e.Message);
      }
      return classifiers;
    }
    
    /// <summary>
    /// Установить основные параметры захвата.
    /// </summary>
    /// <param name="arioUrl">Адрес Арио.</param>
    /// <param name="lowerConfidenceLimit">Нижняя граница доверия извлеченным фактам.</param>
    /// <param name="upperConfidenceLimit">Верхняя граница доверия извлеченным фактам.</param>
    /// <param name="firstPageClassifierName">Имя классификатора первых страниц.</param>
    /// <param name="typeClassifierName">Имя классификатора по типам документов.</param>
    /// <returns>Ошибка, если заполнить настройки не удалось.</returns>
    [Remote]
    public static Docflow.Structures.SmartProcessingSetting.SettingsValidationMessage SetSettings(string arioUrl,
                                                                                                  string lowerConfidenceLimit,
                                                                                                  string upperConfidenceLimit,
                                                                                                  string firstPageClassifierName,
                                                                                                  string typeClassifierName)
    {
      var smartProcessingSettings = Functions.SmartProcessingSetting.GetSettings();
      
      // Адрес.
      smartProcessingSettings.ArioUrl = arioUrl;
      var arioUrlValidationMessage = Functions.SmartProcessingSetting.ValidateArioUrl(smartProcessingSettings);
      if (arioUrlValidationMessage != null)
        return arioUrlValidationMessage;
      
      // Границы.
      int lowerLimit;
      int upperLimit;
      smartProcessingSettings.LowerConfidenceLimit = int.TryParse(lowerConfidenceLimit, out lowerLimit) ? lowerLimit : -1;
      smartProcessingSettings.UpperConfidenceLimit = int.TryParse(upperConfidenceLimit, out upperLimit) ? upperLimit : -1;
      var confidenceLimitsValidationMessage = Functions.SmartProcessingSetting.ValidateConfidenceLimits(smartProcessingSettings);
      if (confidenceLimitsValidationMessage != null)
        return confidenceLimitsValidationMessage;
      
      // Классификаторы.
      var classifiers = Functions.SmartProcessingSetting.GetArioClassifiers(smartProcessingSettings);
      var firstPageClassifier = classifiers.Where(a => a.Name == firstPageClassifierName).FirstOrDefault();
      var typeClassifier = classifiers.Where(a => a.Name == typeClassifierName).FirstOrDefault();
      
      if (firstPageClassifier == null || typeClassifier == null)
        return SettingsValidationMessageStructure.Create(MessageTypes.Error,
                                                         SmartProcessingSettings.Resources.SetCorrectClassifiers);
      
      smartProcessingSettings.FirstPageClassifierName = firstPageClassifier.Name;
      smartProcessingSettings.FirstPageClassifierId = firstPageClassifier.Id;
      smartProcessingSettings.TypeClassifierName = typeClassifier.Name;
      smartProcessingSettings.TypeClassifierId = typeClassifier.Id;
      
      smartProcessingSettings.Save();
      
      // Предупредить, что выбраны одинаковые классификаторы.
      if (firstPageClassifierName == typeClassifierName)
        return SettingsValidationMessageStructure.Create(MessageTypes.Warning,
                                                         SmartProcessingSettings.Resources.SetCorrectClassifiers);
      return null;
    }
    
    /// <summary>
    /// Проверить подключение к Ario.
    /// </summary>
    /// <returns>True, если сервис работает, иначе - False.</returns>
    /// <remarks>Проверка должна обязательно быть на сервере, т.к. с клиента может быть залочен доступ.</remarks>
    [Public, Remote]
    public virtual bool CheckConnection()
    {
      var arioConnector = new ArioExtensions.ArioConnector(_obj.ArioUrl);
      ArioExtensions.Models.ArioInfo serviceInfo = null;
      
      try
      {
        serviceInfo = arioConnector.GetInfo();
      }
      catch (Exception e)
      {
        Logger.Error(e.Message);
      }
      
      return serviceInfo != null &&
        serviceInfo.State == Constants.SmartProcessingSetting.ArioConnectionSuccessMessage;
    }
  }
}