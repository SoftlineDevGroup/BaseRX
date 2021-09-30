using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Contracts.ContractualDocument;
using Sungero.Core;
using Sungero.CoreEntities;

namespace Sungero.Contracts.Client
{
  partial class ContractualDocumentCollectionActions
  {

    public virtual bool CanExportFinancialDocument(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      if (e.FormType == Sungero.Domain.Shared.FormType.Collection)
        return true;
      
      return _objs.Any() && _objs.All(d => !d.State.IsChanged);
    }

    public virtual void ExportFinancialDocument(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      Docflow.PublicFunctions.AccountingDocumentBase.ExportFinancialDocumentDialog(_objs.ToList<Docflow.IOfficialDocument>());
    }
  }

  partial class ContractualDocumentActions
  {

    public virtual void CreateCoverLetter(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      var letter = Docflow.PublicFunctions.Module.CreateCoverLetter(_obj);
      letter.Show();
    }

    public virtual bool CanCreateCoverLetter(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return !_obj.State.IsInserted && !_obj.State.IsChanged;
    }

    public virtual void ShowDuplicates(Sungero.Domain.Client.ExecuteActionArgs e)
    {

    }

    public virtual bool CanShowDuplicates(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

  }

}