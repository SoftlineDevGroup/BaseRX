
// ==================================================================
// AcquaintanceTaskAcquaintanceVersionsState.g.cs
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
  public class AcquaintanceTaskAcquaintanceVersionsState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsState
  {
    public AcquaintanceTaskAcquaintanceVersionsState(global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersions entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskAcquaintanceVersionsPropertyStates(entity);
    }


  }


  public class AcquaintanceTaskAcquaintanceVersionsPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IAcquaintanceTask> AcquaintanceTask 
            {
              get { return this.InternalAcquaintanceTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IAcquaintanceTask> InternalAcquaintanceTask
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IAcquaintanceTask>("AcquaintanceTask"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> Number 
            {
              get { return this.GetPropertyState<global::System.Int32?>("Number"); }
            }
            public global::Sungero.Domain.Shared.IDataPropertyState Hash 
            {
              get { return this.GetDataPropertyState("Hash"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> IsMainDocument 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("IsMainDocument"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int32?> DocumentId 
            {
              get { return this.GetPropertyState<global::System.Int32?>("DocumentId"); }
            }


    protected internal AcquaintanceTaskAcquaintanceVersionsPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class AcquaintanceTaskAcquaintanceVersionsCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsCollectionPropertyState<T>
    where T : global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersions
  {
    public new global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsCollectionPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskAcquaintanceVersionsCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal AcquaintanceTaskAcquaintanceVersionsCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class AcquaintanceTaskAcquaintanceVersionsCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState AcquaintanceTask
        {
          get { return this.GetChildPropertySummaryState("AcquaintanceTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Number
        {
          get { return this.GetChildPropertySummaryState("Number"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Hash
        {
          get { return this.GetChildPropertySummaryState("Hash"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState IsMainDocument
        {
          get { return this.GetChildPropertySummaryState("IsMainDocument"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentId
        {
          get { return this.GetChildPropertySummaryState("DocumentId"); }
        }


    protected internal AcquaintanceTaskAcquaintanceVersionsCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// AcquaintanceTaskAcquaintanceVersionsEventArgs.g.cs
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
}

// ==================================================================
// AcquaintanceTaskAcquaintanceVersionsInfo.g.cs
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
  public class AcquaintanceTaskAcquaintanceVersionsInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsInfo
  {
    public AcquaintanceTaskAcquaintanceVersionsInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.AcquaintanceTaskAcquaintanceVersionsPropertiesInfo(entityType);
    }

  }

  public class AcquaintanceTaskAcquaintanceVersionsPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.RecordManagement.IAcquaintanceTaskAcquaintanceVersionsPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IAcquaintanceTaskInfo, global::Sungero.RecordManagement.IAcquaintanceTask> AcquaintanceTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("AcquaintanceTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IAcquaintanceTaskInfo, global::Sungero.RecordManagement.IAcquaintanceTask>(propertyMetadata);
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
        public global::Sungero.Domain.Shared.ITextPropertyInfo Hash 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.TextPropertyMetadata>("Hash");
             return new global::Sungero.Domain.Shared.TextPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo IsMainDocument 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("IsMainDocument");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IIntegerPropertyInfo DocumentId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.IntegerPropertyMetadata>("DocumentId");
             return new global::Sungero.Domain.Shared.IntegerPropertyInfo(propertyMetadata);
          }
        }


    protected internal AcquaintanceTaskAcquaintanceVersionsPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
