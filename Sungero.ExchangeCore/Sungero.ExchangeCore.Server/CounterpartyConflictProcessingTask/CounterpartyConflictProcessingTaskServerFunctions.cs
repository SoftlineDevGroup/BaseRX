﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.ExchangeCore.CounterpartyConflictProcessingTask;

namespace Sungero.ExchangeCore.Server
{
  partial class CounterpartyConflictProcessingTaskFunctions
  {
    public static ICounterpartyConflictProcessingTask Create(IBusinessUnitBox box, 
                                                             NpoComputer.DCX.Common.Organization party, List<Parties.ICounterparty> parties)
    {
      var task = CounterpartyConflictProcessingTasks.Create();
      var dateWithUTC = Sungero.Docflow.PublicFunctions.Module.GetDateWithUTCLabel(Calendar.Now);
      var subject = 
        CounterpartyConflictProcessingTasks.Resources.ConflictTaskSubjectFormat(box.BusinessUnit.Name, box.ExchangeService.Name, dateWithUTC);
      task.Subject = Exchange.PublicFunctions.Module.CutText(subject, task.Info.Properties.Subject.Length);
      task.ThreadSubject = CounterpartyConflictProcessingTasks.Resources.ConflictTaskThreadSubject;
      task.Assignee = box.Responsible;
      task.MaxDeadline = Calendar.Today.AddWorkingDays(task.Assignee, 2);
      
      if (parties.Count == 1)
      {
        task.ActiveText = 
          CounterpartyConflictProcessingTasks.Resources.ConflictTaskSingleFormat(Hyperlinks.Get(parties.Single()), party.Name, party.Inn, party.Kpp);
        if (!string.IsNullOrWhiteSpace(party.Ogrn))
          task.ActiveText += CounterpartyConflictProcessingTasks.Resources.ConflictTaskSingleOgrnFormat(Environment.NewLine, party.Ogrn);
      }
      else
      {
        task.ActiveText = CounterpartyConflictProcessingTasks.Resources.ConflictTaskMany;
        foreach (var attach in parties)
          task.ActiveText += string.Format("{0}{1}{2}", Environment.NewLine, Constants.BusinessUnitBox.Delimiter, Hyperlinks.Get(attach));
      }
      
      foreach (var attach in parties)
        task.Attachments.Add(attach);
      
      task.Save();
      return task;
    }
  }
}