﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Company.VisibilitySetting;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Company.Shared
{
  partial class VisibilitySettingFunctions
  {
    public virtual void SetRequiredProperties()
    {
      _obj.State.Properties.UnrestrictedRecipients.IsEnabled = _obj.NeedRestrictVisibility ?? false;
      _obj.State.Properties.HiddenRecipients.IsEnabled = _obj.NeedRestrictVisibility ?? false;
    }
  }
}