
// ==================================================================
// CheckReturnTaskObserversState.g.cs
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
  public class CheckReturnTaskObserversState : 
    global::Sungero.Workflow.Shared.TaskObserversState, global::Sungero.Docflow.ICheckReturnTaskObserversState
  {
    public CheckReturnTaskObserversState(global::Sungero.Docflow.ICheckReturnTaskObservers entity) : base(entity) { }

    public new global::Sungero.Docflow.ICheckReturnTaskObserversPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ICheckReturnTaskObserversPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnTaskObserversPropertyStates(entity);
    }


  }


  public class CheckReturnTaskObserversPropertyStates : 
    global::Sungero.Workflow.Shared.TaskObserversPropertyStates, global::Sungero.Docflow.ICheckReturnTaskObserversPropertyStates
  {
            public new global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ICheckReturnTask> Task
            {
              get { return (global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Docflow.ICheckReturnTask>)base.Task; }
            }

            protected override global::Sungero.Domain.Shared.IPropertyState<global::Sungero.Workflow.ITask> InternalTask
            {
              get { return this.GetPropertyState<global::Sungero.Docflow.ICheckReturnTask>("Task"); }
            }


    protected internal CheckReturnTaskObserversPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class CheckReturnTaskObserversCollectionPropertyState<T> :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyState<T>, global::Sungero.Docflow.ICheckReturnTaskObserversCollectionPropertyState<T>
    where T : global::Sungero.Docflow.ICheckReturnTaskObservers
  {
    public new global::Sungero.Docflow.ICheckReturnTaskObserversCollectionPropertyStates Properties
    {
      get { return (global::Sungero.Docflow.ICheckReturnTaskObserversCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.Docflow.Shared.CheckReturnTaskObserversCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal CheckReturnTaskObserversCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class CheckReturnTaskObserversCollectionPropertyStates :
    global::Sungero.Workflow.Shared.TaskObserversCollectionPropertyStates, global::Sungero.Docflow.ICheckReturnTaskObserversCollectionPropertyStates
  {

    protected internal CheckReturnTaskObserversCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// CheckReturnTaskObserversEventArgs.g.cs
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
}

// ==================================================================
// CheckReturnTaskObserversInfo.g.cs
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
  public class CheckReturnTaskObserversInfo : 
    global::Sungero.Workflow.Shared.TaskObserversInfo, global::Sungero.Docflow.ICheckReturnTaskObserversInfo
  {
    public CheckReturnTaskObserversInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.ICheckReturnTaskObserversPropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.ICheckReturnTaskObserversPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.CheckReturnTaskObserversPropertiesInfo(entityType);
    }

  }

  public class CheckReturnTaskObserversPropertiesInfo : 
    global::Sungero.Workflow.Shared.TaskObserversPropertiesInfo, global::Sungero.Docflow.ICheckReturnTaskObserversPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.Docflow.ICheckReturnTaskInfo, global::Sungero.Docflow.ICheckReturnTask> Task
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("Task");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.Docflow.ICheckReturnTaskInfo, global::Sungero.Docflow.ICheckReturnTask>(propertyMetadata);
          }
        }


    protected internal CheckReturnTaskObserversPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
