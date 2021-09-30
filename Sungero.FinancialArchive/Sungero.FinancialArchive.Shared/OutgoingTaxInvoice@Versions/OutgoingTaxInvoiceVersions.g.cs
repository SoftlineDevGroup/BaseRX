
// ==================================================================
// OutgoingTaxInvoiceVersionsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared
{
  public class OutgoingTaxInvoiceVersionsState : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsState, global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsState
  {
    public OutgoingTaxInvoiceVersionsState(global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions entity) : base(entity) { }

    public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsPropertyStates Properties
    {
      get { return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceVersionsPropertyStates(entity);
    }


  }


  public class OutgoingTaxInvoiceVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsPropertyStates, global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.FinancialArchive.IOutgoingTaxInvoice> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.FinancialArchive.IOutgoingTaxInvoice>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.FinancialArchive.IOutgoingTaxInvoice>("ElectronicDocument"); }
            }


    protected internal OutgoingTaxInvoiceVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class OutgoingTaxInvoiceVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsCollectionPropertyState<T>, global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsCollectionPropertyState<T>
    where T : global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersions
  {
    public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal OutgoingTaxInvoiceVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class OutgoingTaxInvoiceVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsCollectionPropertyStates, global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsCollectionPropertyStates
  {

    protected internal OutgoingTaxInvoiceVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// OutgoingTaxInvoiceVersionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared
{  
}

// ==================================================================
// OutgoingTaxInvoiceVersionsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Shared
{
  public class OutgoingTaxInvoiceVersionsInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsInfo, global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsInfo
  {
    public OutgoingTaxInvoiceVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.FinancialArchive.Shared.OutgoingTaxInvoiceVersionsPropertiesInfo(entityType);
    }

  }

  public class OutgoingTaxInvoiceVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsPropertiesInfo, global::Sungero.FinancialArchive.IOutgoingTaxInvoiceVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.FinancialArchive.IOutgoingTaxInvoiceInfo, global::Sungero.FinancialArchive.IOutgoingTaxInvoice> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.FinancialArchive.IOutgoingTaxInvoiceInfo, global::Sungero.FinancialArchive.IOutgoingTaxInvoice>(propertyMetadata);
          }
        }


    protected internal OutgoingTaxInvoiceVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
