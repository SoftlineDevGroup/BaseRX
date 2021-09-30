using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Docflow.DocumentTemplate;
using Sungero.Domain.Shared;

namespace Sungero.Docflow
{
  partial class DocumentTemplateServerHandlers
  {

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      _obj.Status = Docflow.DocumentTemplate.Status.Active;
    }
  }

  partial class DocumentTemplateFilteringServerHandler<T>
  {

    public override IQueryable<T> Filtering(IQueryable<T> query, Sungero.Domain.FilteringEventArgs e)
    {
      // Фильтр при создании документа из шаблона.
      if (_createFromTemplateContext != null)
      {
        // Фильтр по состоянию.
        query = query.Where(d => d.Status == Status.Active);
        
        // Фильтр по критериям.
        if (Docflow.OfficialDocuments.Is(_createFromTemplateContext))
        {
          var document = Docflow.OfficialDocuments.As(_createFromTemplateContext);
          query = (IQueryable<T>)Functions.DocumentTemplate.FilterTemplatesByCriteria(query,
                                                                                      document,
                                                                                      document.DocumentKind,
                                                                                      document.BusinessUnit,
                                                                                      document.Department,
                                                                                      true);
        }
      }
      else if (_filter != null)
      {
        // Фильтр в списке.
        // Фильтр по состоянию.
        if (_filter.Active != _filter.Closed)
          query = query.Where(d => _filter.Active && d.Status == Status.Active ||
                              _filter.Closed && d.Status == Status.Closed);
        
        // Фильтр по критериям.
        query = (IQueryable<T>)Functions.DocumentTemplate.FilterTemplatesByCriteria(query,
                                                                                    null,
                                                                                    _filter.DocumentKind,
                                                                                    _filter.BusinessUnit,
                                                                                    _filter.Department,
                                                                                    false);
      }
      
      return query;
    }
  }

  partial class DocumentTemplateDocumentKindsDocumentKindPropertyFilteringServerHandler<T>
  {

    public virtual IQueryable<T> DocumentKindsDocumentKindFiltering(IQueryable<T> query, Sungero.Domain.PropertyFilteringEventArgs e)
    {
      if (_root.DocumentType == null ||
          string.Equals(_root.DocumentType.ToString(), Docflow.PublicConstants.DocumentTemplate.AllDocumentTypeGuid, StringComparison.InvariantCultureIgnoreCase))
        return query;
      
      return query.Where(x => x.DocumentType.DocumentTypeGuid == _root.DocumentType.ToString());
    }
  }
}