
// ==================================================================
// IncomingInvoiceVersionsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class IncomingInvoiceVersionsState : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsState, global::Sungero.Contracts.IIncomingInvoiceVersionsState
  {
    public IncomingInvoiceVersionsState(global::Sungero.Contracts.IIncomingInvoiceVersions entity) : base(entity) { }

    public new global::Sungero.Contracts.IIncomingInvoiceVersionsPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IIncomingInvoiceVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoiceVersionsPropertyStates(entity);
    }


  }


  public class IncomingInvoiceVersionsPropertyStates : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsPropertyStates, global::Sungero.Contracts.IIncomingInvoiceVersionsPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IIncomingInvoice> ElectronicDocument
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Contracts.IIncomingInvoice>)base.ElectronicDocument; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Content.IElectronicDocument> InternalElectronicDocument
            {
              get { return this.GetPropertyState<global::Sungero.Contracts.IIncomingInvoice>("ElectronicDocument"); }
            }


    protected internal IncomingInvoiceVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class IncomingInvoiceVersionsCollectionPropertyState<T> :
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsCollectionPropertyState<T>, global::Sungero.Contracts.IIncomingInvoiceVersionsCollectionPropertyState<T>
    where T : global::Sungero.Contracts.IIncomingInvoiceVersions
  {
    public new global::Sungero.Contracts.IIncomingInvoiceVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Contracts.IIncomingInvoiceVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoiceVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal IncomingInvoiceVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class IncomingInvoiceVersionsCollectionPropertyStates :
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsCollectionPropertyStates, global::Sungero.Contracts.IIncomingInvoiceVersionsCollectionPropertyStates
  {

    protected internal IncomingInvoiceVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// IncomingInvoiceVersionsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{  
}

// ==================================================================
// IncomingInvoiceVersionsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Contracts.Shared
{
  public class IncomingInvoiceVersionsInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsInfo, global::Sungero.Contracts.IIncomingInvoiceVersionsInfo
  {
    public IncomingInvoiceVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Contracts.IIncomingInvoiceVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.Contracts.IIncomingInvoiceVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Contracts.Shared.IncomingInvoiceVersionsPropertiesInfo(entityType);
    }

  }

  public class IncomingInvoiceVersionsPropertiesInfo : 
    global::Sungero.Docflow.Shared.AccountingDocumentBaseVersionsPropertiesInfo, global::Sungero.Contracts.IIncomingInvoiceVersionsPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Contracts.IIncomingInvoiceInfo, global::Sungero.Contracts.IIncomingInvoice> ElectronicDocument
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ElectronicDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Contracts.IIncomingInvoiceInfo, global::Sungero.Contracts.IIncomingInvoice>(propertyMetadata);
          }
        }


    protected internal IncomingInvoiceVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}