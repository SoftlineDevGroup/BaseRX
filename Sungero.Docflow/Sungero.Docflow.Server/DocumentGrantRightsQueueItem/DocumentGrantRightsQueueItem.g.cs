
// ==================================================================
// DocumentGrantRightsQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class DocumentGrantRightsQueueItemFilter<T> :
      global::Sungero.ExchangeCore.Server.QueueItemBaseFilter<T>
      where T : class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
    {
      private global::Sungero.Docflow.IDocumentGrantRightsQueueItemFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IDocumentGrantRightsQueueItemFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public DocumentGrantRightsQueueItemFilter(global::Sungero.Docflow.IDocumentGrantRightsQueueItemFilterState filter)
      : base(filter)
      {
      }

      protected DocumentGrantRightsQueueItemFilter()
      {
      }
    }
      public class DocumentGrantRightsQueueItemUiFilter<T> :
        global::Sungero.ExchangeCore.Server.QueueItemBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class DocumentGrantRightsQueueItemSearchDialogModel : global::Sungero.ExchangeCore.Server.QueueItemBaseSearchDialogModel
        {
                  public override global::System.Int32? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String ExternalId { get; protected set; }
                  public override global::System.Int32? Retries { get; protected set; }
                  public override global::System.String Note { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBoxBase> Box { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> LastUpdate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBusinessUnitBox> RootBox { get; protected set; }


                  public virtual global::System.Int32? DocumentId { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Docflow.IAccessRightsRule> AccessRightsRule { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ChangedEntityType { get; protected set; }


        }




  public class DocumentGrantRightsQueueItemFilterForAccessRightsRule<TQueryEntity, TSourceEntity>
    : global::Sungero.Domain.EntityPropertyFilterBase<TQueryEntity, TSourceEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IAccessRightsRule
    where TSourceEntity : class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      var result = new global::Sungero.Docflow.DocumentGrantRightsQueueItemAccessRightsRulePropertyFilteringServerHandler<TQueryEntity>(sourceEntity).AccessRightsRuleFiltering(query, args);
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentGrantRightsQueueItemFilterForAccessRightsRule(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class DocumentGrantRightsQueueItemSearchFilterForAccessRightsRule<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.Docflow.IAccessRightsRule
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      var result = new global::Sungero.Docflow.DocumentGrantRightsQueueItemAccessRightsRuleSearchPropertyFilteringServerHandler<TQueryEntity>().AccessRightsRuleSearchDialogFiltering(query, args);
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public DocumentGrantRightsQueueItemSearchFilterForAccessRightsRule(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemFilter<global::Sungero.Docflow.IDocumentGrantRightsQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemUiFilter<global::Sungero.Docflow.IDocumentGrantRightsQueueItem>))]
  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemFilterForAccessRightsRule<global::Sungero.Docflow.IAccessRightsRule, global::Sungero.Docflow.IDocumentGrantRightsQueueItem>), "AccessRightsRule")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemSearchFilterForAccessRightsRule<global::Sungero.Docflow.IAccessRightsRule>), "AccessRightsRule")]


  public class DocumentGrantRightsQueueItem :
    global::Sungero.ExchangeCore.Server.QueueItemBase, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("de73a02c-c1bf-4edf-bee4-bf2705d282b8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.DocumentGrantRightsQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IDocumentGrantRightsQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IDocumentGrantRightsQueueItemState State
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.DocumentGrantRightsQueueItemState(this);
    }

    public new virtual global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo Info
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.DocumentGrantRightsQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.DocumentGrantRightsQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers(this);
    }

    private global::System.Int32? _DocumentId;
    public virtual global::System.Int32? DocumentId
    {
      get
      {
        return this._DocumentId;
      }

      set
      {
        this.SetPropertyValue("DocumentId", this._DocumentId, value, (propertyValue) => { this._DocumentId = propertyValue; }, this.DocumentIdChangedHandler);
      }
    }






    private static global::Sungero.Domain.Shared.EnumerationItems _ChangedEntityTypeItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.Docflow.DocumentGrantRightsQueueItem.ChangedEntityType),
      typeof(global::Sungero.Docflow.Server.DocumentGrantRightsQueueItem),
      "ChangedEntityType");

    public static global::Sungero.Domain.Shared.EnumerationItems ChangedEntityTypeItems
    {
      get { return global::Sungero.Docflow.Server.DocumentGrantRightsQueueItem._ChangedEntityTypeItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems ChangedEntityTypeAllowedItems
    {
      get { return global::Sungero.Docflow.Server.DocumentGrantRightsQueueItem.ChangedEntityTypeItems; }
    }

    private global::Sungero.Core.Enumeration? _ChangedEntityType;

    public virtual global::Sungero.Core.Enumeration? ChangedEntityType
    {
      get { return this._ChangedEntityType; }
      set { this.SetEnumPropertyValue("ChangedEntityType", this._ChangedEntityType, value, (propertyValue) => { this._ChangedEntityType = propertyValue; }, this.ChangedEntityTypeChangedHandler, this.ChangedEntityTypeAllowedItems); }
    }


    private global::Sungero.Docflow.IAccessRightsRule _AccessRightsRule;
    public virtual global::Sungero.Docflow.IAccessRightsRule AccessRightsRule
    {
      get
      {
        return this._AccessRightsRule;
      }

      set
      {
        this.SetPropertyValue("AccessRightsRule", this._AccessRightsRule, value, (propertyValue) => { this._AccessRightsRule = propertyValue; }, this.AccessRightsRuleChangedHandler);
      }
    }




    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      return new global::Sungero.Docflow.DocumentGrantRightsQueueItemCreatingFromServerHandler((global::Sungero.Docflow.IDocumentGrantRightsQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }

    protected void AccessRightsRuleChangedHandler()
    {
      var args = new global::Sungero.Docflow.Shared.DocumentGrantRightsQueueItemAccessRightsRuleChangedEventArgs(this.State.Properties.AccessRightsRule, this.AccessRightsRule, this);
     ((global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers)this.SharedHandlers).AccessRightsRuleChanged(args);
    }

    protected void ChangedEntityTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ChangedEntityType, this.ChangedEntityType, this);
     ((global::Sungero.Docflow.DocumentGrantRightsQueueItemSharedHandlers)this.SharedHandlers).ChangedEntityTypeChanged(args);
    }



    #endregion


    public DocumentGrantRightsQueueItem()
    {
    }

  }
}

// ==================================================================
// DocumentGrantRightsQueueItemHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{
  public partial class DocumentGrantRightsQueueItemAccessRightsRulePropertyFilteringServerHandler<T>
    : global::Sungero.Domain.EntityPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IAccessRightsRule
  {
    private global::Sungero.Docflow.IDocumentGrantRightsQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItem)this.Entity; }
    }

    public virtual global::System.Linq.IQueryable<T> AccessRightsRuleFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertyFilteringEventArgs e)
    {
      return query;
    }

    public DocumentGrantRightsQueueItemAccessRightsRulePropertyFilteringServerHandler(global::Sungero.Docflow.IDocumentGrantRightsQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class DocumentGrantRightsQueueItemAccessRightsRuleSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.Docflow.IAccessRightsRule
  {

    public virtual global::System.Linq.IQueryable<T> AccessRightsRuleSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public DocumentGrantRightsQueueItemAccessRightsRuleSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



  public partial class DocumentGrantRightsQueueItemFilteringServerHandler<T>
    : global::Sungero.ExchangeCore.QueueItemBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    private global::Sungero.Docflow.IDocumentGrantRightsQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IDocumentGrantRightsQueueItemFilterState)this.Filter;
      }
    }

    public DocumentGrantRightsQueueItemFilteringServerHandler(global::Sungero.Docflow.IDocumentGrantRightsQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected DocumentGrantRightsQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class DocumentGrantRightsQueueItemUiFilteringServerHandler<T>
    : global::Sungero.ExchangeCore.QueueItemBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IDocumentGrantRightsQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class DocumentGrantRightsQueueItemSearchDialogServerHandler : global::Sungero.ExchangeCore.QueueItemBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public DocumentGrantRightsQueueItemSearchDialogServerHandler(global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class DocumentGrantRightsQueueItemServerHandlers : global::Sungero.ExchangeCore.QueueItemBaseServerHandlers
  {
    private global::Sungero.Docflow.IDocumentGrantRightsQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItem)this.Entity; }
    }

    public DocumentGrantRightsQueueItemServerHandlers(global::Sungero.Docflow.IDocumentGrantRightsQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class DocumentGrantRightsQueueItemCreatingFromServerHandler : global::Sungero.ExchangeCore.QueueItemBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IDocumentGrantRightsQueueItem _source
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItem)this.Source; }
    }

    private global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo _info
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo)this._Info; }
    }

    public DocumentGrantRightsQueueItemCreatingFromServerHandler(global::Sungero.Docflow.IDocumentGrantRightsQueueItem source, global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// DocumentGrantRightsQueueItemEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// DocumentGrantRightsQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class DocumentGrantRightsQueueItemAccessRights : 
    Sungero.ExchangeCore.Server.QueueItemBaseAccessRights, Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights
  {

    public DocumentGrantRightsQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class DocumentGrantRightsQueueItemTypeAccessRights : 
    Sungero.ExchangeCore.Server.QueueItemBaseTypeAccessRights, Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights
  {

    public DocumentGrantRightsQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// DocumentGrantRightsQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class DocumentGrantRightsQueueItemRepositoryImplementer<T> : 
      global::Sungero.ExchangeCore.Server.QueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IDocumentGrantRightsQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDocumentGrantRightsQueueItem 
    {
       public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo Info
       {
          get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.DocumentGrantRightsQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// DocumentGrantRightsQueueItemPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// DocumentGrantRightsQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class DocumentGrantRightsQueueItemFunctions : global::Sungero.ExchangeCore.Server.QueueItemBaseFunctions
  {
    private global::Sungero.Docflow.IDocumentGrantRightsQueueItem _obj
    {
      get { return (global::Sungero.Docflow.IDocumentGrantRightsQueueItem)this.Entity; }
    }

    public DocumentGrantRightsQueueItemFunctions(global::Sungero.Docflow.IDocumentGrantRightsQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// DocumentGrantRightsQueueItemFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class DocumentGrantRightsQueueItem
  {
  }
}

// ==================================================================
// DocumentGrantRightsQueueItemServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class DocumentGrantRightsQueueItemServerPublicFunctions : global::Sungero.Docflow.Server.IDocumentGrantRightsQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// DocumentGrantRightsQueueItemQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class DocumentGrantRightsQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.DocumentGrantRightsQueueItem.DocumentGrantRightsQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}