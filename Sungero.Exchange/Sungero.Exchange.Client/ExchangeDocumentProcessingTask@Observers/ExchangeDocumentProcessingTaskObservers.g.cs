
// ==================================================================
// ExchangeDocumentProcessingTaskObservers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Exchange.Client
{
  public class ExchangeDocumentProcessingTaskObservers :
    global::Sungero.Workflow.Client.TaskObservers, global::Sungero.Exchange.IExchangeDocumentProcessingTaskObservers
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4b78f549-6d32-45f4-80ab-4acc76d46af8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Exchange.Client.ExchangeDocumentProcessingTaskObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Exchange.IExchangeDocumentProcessingTaskObservers, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversState State
    {
      get
      {
        return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Exchange.Shared.ExchangeDocumentProcessingTaskObserversState(this);
    }

    public new global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversInfo Info
    {
      get
      {
        return (global::Sungero.Exchange.IExchangeDocumentProcessingTaskObserversInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors




    public ExchangeDocumentProcessingTaskObservers()
    {








    }

    #endregion

  }
}
