
// ==================================================================
// UniversalTransferDocumentTracking.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.FinancialArchive.Client
{
  public class UniversalTransferDocumentTracking :
    global::Sungero.Docflow.Client.AccountingDocumentBaseTracking, global::Sungero.FinancialArchive.IUniversalTransferDocumentTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("edffd4a9-b71c-43e1-aaf8-0d537258a027");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.FinancialArchive.Client.UniversalTransferDocumentTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.FinancialArchive.IUniversalTransferDocumentTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.FinancialArchive.IUniversalTransferDocumentTrackingState State
    {
      get
      {
        return (global::Sungero.FinancialArchive.IUniversalTransferDocumentTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.FinancialArchive.Shared.UniversalTransferDocumentTrackingState(this);
    }

    public new global::Sungero.FinancialArchive.IUniversalTransferDocumentTrackingInfo Info
    {
      get
      {
        return (global::Sungero.FinancialArchive.IUniversalTransferDocumentTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public UniversalTransferDocumentTracking()
    {








    }

    #endregion

  }
}
