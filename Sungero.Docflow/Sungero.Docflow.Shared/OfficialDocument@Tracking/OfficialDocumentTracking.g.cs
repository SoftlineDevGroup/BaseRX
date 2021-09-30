
// ==================================================================
// OfficialDocumentTrackingState.g.cs
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
  public class OfficialDocumentTrackingState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.Docflow.IOfficialDocumentTrackingState
  {
    public OfficialDocumentTrackingState(global::Sungero.Docflow.IOfficialDocumentTracking entity) : base(entity) { }

    public new global::Sungero.Docflow.IOfficialDocumentTrackingPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IOfficialDocumentTrackingPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.OfficialDocumentTrackingPropertyStates(entity);
    }


  }


  public class OfficialDocumentTrackingPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.Docflow.IOfficialDocumentTrackingPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> OfficialDocument 
            {
              get { return this.InternalOfficialDocument; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.IOfficialDocument> InternalOfficialDocument
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.IOfficialDocument>("OfficialDocument"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> Action 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("Action"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> DeliveredTo 
            {
              get { return this.InternalDeliveredTo; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalDeliveredTo
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("DeliveredTo"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsOriginal 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsOriginal"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> ReturnDeadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("ReturnDeadline"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> ReturnDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("ReturnDate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> DeliveryDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("DeliveryDate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Core.Enumeration?> ReturnResult 
            {
              get { return this.GetPropertyState<global::Sungero.Core.Enumeration?>("ReturnResult"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Note 
            {
              get { return this.GetPropertyState<global::System.String>("Note"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> ReturnTask 
            {
              get { return this.InternalReturnTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> InternalReturnTask
            {
              get { return this.GetPropertyState<global::Sungero.Workflow.ITask>("ReturnTask"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> Iteration 
            {
              get { return this.GetPropertyState<global::System.Int32?>("Iteration"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> ExternalLinkId 
            {
              get { return this.GetPropertyState<global::System.Int32?>("ExternalLinkId"); }
            }


    protected internal OfficialDocumentTrackingPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class OfficialDocumentTrackingCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<T>
    where T : global::Sungero.Docflow.IOfficialDocumentTracking
  {
    public new global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.OfficialDocumentTrackingCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal OfficialDocumentTrackingCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class OfficialDocumentTrackingCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState OfficialDocument
        {
          get { return this.GetChildPropertySummaryState("OfficialDocument"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Action
        {
          get { return this.GetChildPropertySummaryState("Action"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DeliveredTo
        {
          get { return this.GetChildPropertySummaryState("DeliveredTo"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState IsOriginal
        {
          get { return this.GetChildPropertySummaryState("IsOriginal"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ReturnDeadline
        {
          get { return this.GetChildPropertySummaryState("ReturnDeadline"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ReturnDate
        {
          get { return this.GetChildPropertySummaryState("ReturnDate"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DeliveryDate
        {
          get { return this.GetChildPropertySummaryState("DeliveryDate"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ReturnResult
        {
          get { return this.GetChildPropertySummaryState("ReturnResult"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Note
        {
          get { return this.GetChildPropertySummaryState("Note"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ReturnTask
        {
          get { return this.GetChildPropertySummaryState("ReturnTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Iteration
        {
          get { return this.GetChildPropertySummaryState("Iteration"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ExternalLinkId
        {
          get { return this.GetChildPropertySummaryState("ExternalLinkId"); }
        }


    protected internal OfficialDocumentTrackingCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// OfficialDocumentTrackingEventArgs.g.cs
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
    public class OfficialDocumentTrackingDeliveredToChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public OfficialDocumentTrackingDeliveredToChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }







    public class OfficialDocumentTrackingReturnTaskChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Workflow.ITask>
    {
      public OfficialDocumentTrackingReturnTaskChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> state, global::Sungero.Workflow.ITask newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }



}

// ==================================================================
// OfficialDocumentTrackingInfo.g.cs
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
  public class OfficialDocumentTrackingInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.Docflow.IOfficialDocumentTrackingInfo
  {
    public OfficialDocumentTrackingInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IOfficialDocumentTrackingPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IOfficialDocumentTrackingPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.OfficialDocumentTrackingPropertiesInfo(entityType);
    }

  }

  public class OfficialDocumentTrackingPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.Docflow.IOfficialDocumentTrackingPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.IOfficialDocumentInfo, global::Sungero.Docflow.IOfficialDocument> OfficialDocument 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("OfficialDocument");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.IOfficialDocumentInfo, global::Sungero.Docflow.IOfficialDocument>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo Action 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("Action");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> DeliveredTo 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DeliveredTo");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsOriginal 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsOriginal");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo ReturnDeadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("ReturnDeadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo ReturnDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("ReturnDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo DeliveryDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("DeliveryDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IEnumPropertyInfo ReturnResult 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.EnumPropertyMetadata>("ReturnResult");
             return new global::Sungero.Domain.Shared.EnumPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Note 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Note");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Workflow.ITaskInfo, global::Sungero.Workflow.ITask> ReturnTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ReturnTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Workflow.ITaskInfo, global::Sungero.Workflow.ITask>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo Iteration 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("Iteration");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo ExternalLinkId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("ExternalLinkId");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }


    protected internal OfficialDocumentTrackingPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
