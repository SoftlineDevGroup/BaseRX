
// ==================================================================
// ApprovalRole.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalRole :
    global::Sungero.Docflow.Client.ApprovalRoleBase, global::Sungero.Docflow.IApprovalRole
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("9f5b8596-f73a-498f-b1b1-219ed77bb031");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Client.ApprovalRole.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IApprovalRole, Sungero.Domain.Interfaces"; }
    }

      public override string DisplayValue
      {
        get { return this.Name; }
        set { this.Name = value; }
      }

      public override string DisplayPropertyName
      {
        get { return "Name"; }
      }


    public new global::Sungero.Docflow.IApprovalRoleState State
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRoleState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRoleState(this);
    }

    public new global::Sungero.Docflow.IApprovalRoleInfo Info
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRoleInfo)base.Info;
      }
    }

    public new global::Sungero.Docflow.IApprovalRoleAccessRights AccessRights
    {
      get
      {
        return (global::Sungero.Docflow.IApprovalRoleAccessRights)base.AccessRights;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Client.ApprovalRoleAccessRights(this);
    }










    #endregion

    #region Methods

    protected override object CreateActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRoleActions(this);
    }

    protected override object CreateCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRoleCollectionActions();
    }

    protected override object CreateAnyChildEntityActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRoleAnyChildEntityActions();
    }

    protected override object CreateAnyChildEntityCollectionActionsHandlers()
    {
      return new global::Sungero.Docflow.Client.ApprovalRoleAnyChildEntityCollectionActions();
    }


    protected override global::Sungero.Domain.Client.EntityFunctions CreateClientFunctions()
    {
      return new global::Sungero.Docflow.Client.ApprovalRoleFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.ApprovalRoleFunctions(this);
    }
    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.ApprovalRoleClientHandlers(this);
    }
    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.ApprovalRoleSharedHandlers(this);
    }

    #endregion

    #region Framework events





    #endregion

    #region Constructors



    public ApprovalRole()
    {








    }

    #endregion

  }
}

// ==================================================================
// ApprovalRolePresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalRolePresenter<T> :
    global::Sungero.Docflow.Client.ApprovalRoleBasePresenter<T>
    where T : class, global::Sungero.Docflow.IApprovalRole
  {
    #region Fields and properties




    #endregion

    #region Methods

    #endregion

    #region Framework events

    protected override void EntityPropertyChangedEventHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.EntityPropertyChangedEventHandler(sender, e);
    }

    #endregion



    #region Constructors

    private void Init()
    {

    }

    public ApprovalRolePresenter()
    {
      this.Init();
    }

    #endregion
  }
}

// ==================================================================
// ApprovalRoleCollectionPresenter.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalRoleCollectionPresenter<T> : 
    global::Sungero.Docflow.Client.ApprovalRoleBaseCollectionPresenter<T>
    where T: class, global::Sungero.Docflow.IApprovalRole
  {
    #region Actions



    #endregion

    #region Methods


    #endregion

    public ApprovalRoleCollectionPresenter(global::System.Linq.IQueryable<T> query, OnLookup onLookup)
      : base(query, onLookup)
    {
    }

    public ApprovalRoleCollectionPresenter(global::System.Linq.IQueryable<T> query)
      : this(query, null) { }

    public ApprovalRoleCollectionPresenter(OnLookup onLookup)
      : this(null, onLookup) { }

    public ApprovalRoleCollectionPresenter()
      : this(null, null) { }
  }
}

// ==================================================================
// ApprovalRoleRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class ApprovalRoleRepositoryImplementer<T> : 
      global::Sungero.Docflow.Client.ApprovalRoleBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IApprovalRoleRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IApprovalRole
    {
       public new global::Sungero.Docflow.IApprovalRoleAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IApprovalRoleAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IApprovalRoleInfo Info
       {
          get { return (global::Sungero.Docflow.IApprovalRoleInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Client.ApprovalRoleTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ApprovalRoleAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class ApprovalRoleAccessRights : 
    Sungero.Docflow.Client.ApprovalRoleBaseAccessRights, Sungero.Docflow.IApprovalRoleAccessRights
  {

    public ApprovalRoleAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ApprovalRoleTypeAccessRights : 
    Sungero.Docflow.Client.ApprovalRoleBaseTypeAccessRights, Sungero.Docflow.IApprovalRoleAccessRights
  {

    public ApprovalRoleTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}
