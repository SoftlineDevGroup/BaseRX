using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.ExchangeCore.IncomingInvitationTask;

namespace Sungero.ExchangeCore.Server
{
  partial class IncomingInvitationTaskFunctions
  {
    public static IIncomingInvitationTask Create(Parties.ICounterparty counterparty, IBusinessUnitBox box, string organizationId, string comment)
    {
      var counterpartyBox = counterparty.ExchangeBoxes.Where(x => Equals(x.OrganizationId, organizationId)).Select(o => o.CounterpartyBox).FirstOrDefault();
      var invitationTask = IncomingInvitationTasks.Create();
      var subject = IncomingInvitationTasks.Resources.TaskSubjectFormat(counterparty.Name, box.BusinessUnit.Name, box.ExchangeService.Name);
      invitationTask.Subject = Exchange.PublicFunctions.Module.CutText(subject, invitationTask.Info.Properties.Subject.Length);
      invitationTask.ActiveText = IncomingInvitationTasks.Resources.TaskActiveTextFormat(counterparty.Name, box.BusinessUnit.Name, box.ExchangeService.Name);
      
      if (!string.IsNullOrWhiteSpace(counterpartyBox))
      {
        invitationTask.ActiveText += Environment.NewLine;
        invitationTask.ActiveText += Environment.NewLine;
        invitationTask.ActiveText += IncomingInvitationTasks.Resources.CounterpartyBox;
        invitationTask.ActiveText += Environment.NewLine + counterpartyBox;
      }      
      
      if (!string.IsNullOrWhiteSpace(comment))
      {
        invitationTask.ActiveText += Environment.NewLine;
        invitationTask.ActiveText += Environment.NewLine;
        invitationTask.ActiveText += IncomingInvitationTasks.Resources.AssignmentComment;
        invitationTask.ActiveText += Environment.NewLine + comment;
      }
      invitationTask.Box = box;
      invitationTask.Counterparty = counterparty;
      invitationTask.Assignee = box.Responsible;
      invitationTask.MaxDeadline = Calendar.Now.AddWorkingDays(invitationTask.Assignee, 2);
      invitationTask.Attachments.Add(counterparty);
      invitationTask.OrganizationId = organizationId;
      invitationTask.Save();
      invitationTask.Start();
      return invitationTask;
    }
  }
}