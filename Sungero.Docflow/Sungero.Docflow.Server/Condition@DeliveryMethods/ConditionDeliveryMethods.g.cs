
// ==================================================================
// ConditionDeliveryMethods.g.cs
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


  public class ConditionDeliveryMethods :
    global::Sungero.Docflow.Server.ConditionBaseDeliveryMethods, global::Sungero.Docflow.IConditionDeliveryMethods
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("64123db7-d49f-4da6-ae43-3a3310ca335c");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.ConditionDeliveryMethods.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IConditionDeliveryMethods, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Docflow.IConditionDeliveryMethodsState State
    {
      get { return (global::Sungero.Docflow.IConditionDeliveryMethodsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.ConditionDeliveryMethodsState(this);
    }

    public new virtual global::Sungero.Docflow.IConditionDeliveryMethodsInfo Info
    {
      get { return (global::Sungero.Docflow.IConditionDeliveryMethodsInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public ConditionDeliveryMethods()
    {
    }

  }
}

// ==================================================================
// ConditionDeliveryMethodsHandlers.g.cs
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

}

// ==================================================================
// ConditionDeliveryMethodsEventArgs.g.cs
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
