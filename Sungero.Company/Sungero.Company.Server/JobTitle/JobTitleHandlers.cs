using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company.JobTitle;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Company
{
  partial class JobTitleServerHandlers
  {
    
    public override void BeforeSave(Sungero.Domain.BeforeSaveEventArgs e)
    {
      _obj.Name = _obj.Name.Trim();
      
      if (JobTitles.GetAll().Any(p => Equals(p.Name, _obj.Name) && !Equals(p, _obj)))
        e.AddError(JobTitles.Resources.JobTitleNameAlreadyExists);
    }
  }
}