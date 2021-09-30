
// ==================================================================
// ActionItemExecutionTaskActionItemPartsState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ActionItemExecutionTaskActionItemPartsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsState
  {
    public ActionItemExecutionTaskActionItemPartsState(global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsPropertyStates(entity);
    }


  }


  public class ActionItemExecutionTaskActionItemPartsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemExecutionTask 
            {
              get { return this.InternalActionItemExecutionTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask> InternalActionItemExecutionTask
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemExecutionTask"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState ActionItemPart 
            {
              get { return this.GetDataPropertyState("ActionItemPart"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> Assignee 
            {
              get { return this.InternalAssignee; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> InternalAssignee
            {
              get { return this.GetPropertyState<global::Sungero.Company.IEmployee>("Assignee"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> Deadline 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("Deadline"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> Number 
            {
              get { return this.GetPropertyState<global::System.Int32?>("Number"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemPartExecutionTask 
            {
              get { return this.InternalActionItemPartExecutionTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask> InternalActionItemPartExecutionTask
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask>("ActionItemPartExecutionTask"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> AssignmentCreated 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("AssignmentCreated"); }
            }


    protected internal ActionItemExecutionTaskActionItemPartsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ActionItemExecutionTaskActionItemPartsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsCollectionPropertyState<T>
    where T : global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemParts
  {
    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal ActionItemExecutionTaskActionItemPartsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class ActionItemExecutionTaskActionItemPartsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ActionItemExecutionTask
        {
          get { return this.GetChildPropertySummaryState("ActionItemExecutionTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ActionItemPart
        {
          get { return this.GetChildPropertySummaryState("ActionItemPart"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Assignee
        {
          get { return this.GetChildPropertySummaryState("Assignee"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Deadline
        {
          get { return this.GetChildPropertySummaryState("Deadline"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Number
        {
          get { return this.GetChildPropertySummaryState("Number"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState ActionItemPartExecutionTask
        {
          get { return this.GetChildPropertySummaryState("ActionItemPartExecutionTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState AssignmentCreated
        {
          get { return this.GetChildPropertySummaryState("AssignmentCreated"); }
        }


    protected internal ActionItemExecutionTaskActionItemPartsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// ActionItemExecutionTaskActionItemPartsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{  
    public class ActionItemExecutionTaskActionItemPartsAssigneeChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.Company.IEmployee>
    {
      public ActionItemExecutionTaskActionItemPartsAssigneeChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Company.IEmployee> state, global::Sungero.Company.IEmployee newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }



    public class ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskChangedEventArgs : global::Sungero.Domain.Shared.PropertyChangedEventArgs<global::Sungero.RecordManagement.IActionItemExecutionTask>
    {
      public ActionItemExecutionTaskActionItemPartsActionItemPartExecutionTaskChangedEventArgs(global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IActionItemExecutionTask> state, global::Sungero.RecordManagement.IActionItemExecutionTask newValue, global::Sungero.Domain.Shared.IEntity entity): base(state, newValue, entity) { }
    }


}

// ==================================================================
// ActionItemExecutionTaskActionItemPartsInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class ActionItemExecutionTaskActionItemPartsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsInfo
  {
    public ActionItemExecutionTaskActionItemPartsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.ActionItemExecutionTaskActionItemPartsPropertiesInfo(entityType);
    }

  }

  public class ActionItemExecutionTaskActionItemPartsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.RecordManagement.IActionItemExecutionTaskActionItemPartsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IActionItemExecutionTaskInfo, global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemExecutionTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ActionItemExecutionTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IActionItemExecutionTaskInfo, global::Sungero.RecordManagement.IActionItemExecutionTask>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ITextPropertyInfo ActionItemPart 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("ActionItemPart");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee> Assignee 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Assignee");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Company.IEmployeeInfo, global::Sungero.Company.IEmployee>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo Deadline 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("Deadline");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
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
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IActionItemExecutionTaskInfo, global::Sungero.RecordManagement.IActionItemExecutionTask> ActionItemPartExecutionTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("ActionItemPartExecutionTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IActionItemExecutionTaskInfo, global::Sungero.RecordManagement.IActionItemExecutionTask>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo AssignmentCreated 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("AssignmentCreated");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }


    protected internal ActionItemExecutionTaskActionItemPartsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
