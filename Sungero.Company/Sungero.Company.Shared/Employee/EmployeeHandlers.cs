using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company.Employee;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Company
{
  partial class EmployeeSharedHandlers
  {

    public virtual void PersonChanged(Sungero.Company.Shared.EmployeePersonChangedEventArgs e)
    {
      Functions.Employee.UpdateName(_obj, e.NewValue);
    }

    public virtual void NeedNotifyNewAssignmentsChanged(Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e)
    {
      Sungero.Company.PublicFunctions.Employee.SetRequiredProperties(_obj);
    }

    public virtual void NeedNotifyExpiredAssignmentsChanged(Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e)
    {
      Sungero.Company.PublicFunctions.Employee.SetRequiredProperties(_obj);
    }
  }
}