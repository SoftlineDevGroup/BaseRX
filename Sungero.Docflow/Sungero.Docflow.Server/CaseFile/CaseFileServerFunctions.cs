using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.CaseFile;

namespace Sungero.Docflow.Server
{
  partial class CaseFileFunctions
  {
    /// <summary>
    /// Отображение документов в деле.
    /// </summary>  
    /// <returns>Перечень документов в деле.</returns>
    [Remote]
    public IQueryable<IOfficialDocument> ShowCaseDocuments()
    {
      return OfficialDocuments.GetAll().Where(d => Equals(d.CaseFile, _obj));
    }
    
    /// <summary>
    /// Проверить индекс дела на уникальность в рамках нашей организации.
    /// </summary>
    /// <param name="caseFile">Дело.</param>
    /// <returns>True если индекс уникален, иначе false.</returns>
    public static bool CheckIndexForUniqueness(ICaseFile caseFile)
    {
      if (caseFile.Department == null || caseFile.Department.BusinessUnit == null || caseFile.Status.Value == CoreEntities.DatabookEntry.Status.Closed)
        return true;
      
      return !CaseFiles.GetAll().Any(f => !Equals(f, caseFile) &&
                                  f.Status.Value == CoreEntities.DatabookEntry.Status.Active &&
                                  f.Index == caseFile.Index &&
                                  f.Department != null &&
                                  f.Department.BusinessUnit != null &&
                                  f.Department.BusinessUnit == caseFile.Department.BusinessUnit);
    }
  }
}