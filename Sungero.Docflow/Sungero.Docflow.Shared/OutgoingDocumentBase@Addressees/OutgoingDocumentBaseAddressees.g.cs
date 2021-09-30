
// ==================================================================
// OutgoingDocumentBaseAddresseesState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class OutgoingDocumentBaseAddresseesState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesState
  {
    public OutgoingDocumentBaseAddresseesState(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees entity) : base(entity) { }

    public new global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesPropertyStates(entity);
    }


  }


  public class OutgoingDocumentBaseAddresseesPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOutgoingDocumentBase> OutgoingDocumentBase 
            {
              get { return this.InternalOutgoingDocumentBase; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOutgoingDocumentBase> InternalOutgoingDocumentBase
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IOutgoingDocumentBase>("OutgoingDocumentBase"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> Correspondent 
            {
              get { return this.InternalCorrespondent; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> InternalCorrespondent
            {
              get { return this.GetPropertyState<global::Sungero.Parties.ICounterparty>("Correspondent"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> Addressee 
            {
              get { return this.InternalAddressee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> InternalAddressee
            {
              get { return this.GetPropertyState<global::Sungero.Parties.IContact>("Addressee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> DeliveryMethod 
            {
              get { return this.InternalDeliveryMethod; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> InternalDeliveryMethod
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IMailDeliveryMethod>("DeliveryMethod"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> Number 
            {
              get { return this.GetPropertyState<global::System.Int32?>("Number"); }
            }


    protected internal OutgoingDocumentBaseAddresseesPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class OutgoingDocumentBaseAddresseesCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IOutgoingDocumentBaseAddressees
  {
    public new global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal OutgoingDocumentBaseAddresseesCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class OutgoingDocumentBaseAddresseesCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState OutgoingDocumentBase
        {
          get { return this.GetChildPropertySummaryState("OutgoingDocumentBase"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Correspondent
        {
          get { return this.GetChildPropertySummaryState("Correspondent"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Addressee
        {
          get { return this.GetChildPropertySummaryState("Addressee"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DeliveryMethod
        {
          get { return this.GetChildPropertySummaryState("DeliveryMethod"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Number
        {
          get { return this.GetChildPropertySummaryState("Number"); }
        }


    protected internal OutgoingDocumentBaseAddresseesCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// OutgoingDocumentBaseAddresseesEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{  
    public class OutgoingDocumentBaseAddresseesCorrespondentChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Parties.ICounterparty>
    {
      public OutgoingDocumentBaseAddresseesCorrespondentChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.ICounterparty> state, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class OutgoingDocumentBaseAddresseesAddresseeChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Parties.IContact>
    {
      public OutgoingDocumentBaseAddresseesAddresseeChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Parties.IContact> state, global::Sungero.Parties.IContact newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }

    public class OutgoingDocumentBaseAddresseesDeliveryMethodChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Docflow.IMailDeliveryMethod>
    {
      public OutgoingDocumentBaseAddresseesDeliveryMethodChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IMailDeliveryMethod> state, global::Sungero.Docflow.IMailDeliveryMethod newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }


}

// ==================================================================
// OutgoingDocumentBaseAddresseesInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class OutgoingDocumentBaseAddresseesInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesInfo
  {
    public OutgoingDocumentBaseAddresseesInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.OutgoingDocumentBaseAddresseesPropertiesInfo(entityType);
    }

  }

  public class OutgoingDocumentBaseAddresseesPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IOutgoingDocumentBaseAddresseesPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IOutgoingDocumentBaseInfo, global::Sungero.Docflow.IOutgoingDocumentBase> OutgoingDocumentBase 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OutgoingDocumentBase");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IOutgoingDocumentBaseInfo, global::Sungero.Docflow.IOutgoingDocumentBase>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty> Correspondent 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Correspondent");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.ICounterpartyInfo, global::Sungero.Parties.ICounterparty>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Parties.IContactInfo, global::Sungero.Parties.IContact> Addressee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Addressee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Parties.IContactInfo, global::Sungero.Parties.IContact>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IMailDeliveryMethodInfo, global::Sungero.Docflow.IMailDeliveryMethod> DeliveryMethod 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DeliveryMethod");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IMailDeliveryMethodInfo, global::Sungero.Docflow.IMailDeliveryMethod>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo Number 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("Number");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }


    protected internal OutgoingDocumentBaseAddresseesPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
