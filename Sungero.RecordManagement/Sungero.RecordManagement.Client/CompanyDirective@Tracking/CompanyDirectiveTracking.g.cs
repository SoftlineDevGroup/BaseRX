
// ==================================================================
// CompanyDirectiveTracking.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class CompanyDirectiveTracking :
    global::Sungero.RecordManagement.Client.OrderBaseTracking, global::Sungero.RecordManagement.ICompanyDirectiveTracking
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("96a79305-3ed5-4e36-9691-6bc1f8f463e5");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Client.CompanyDirectiveTracking.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.ICompanyDirectiveTracking, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.RecordManagement.ICompanyDirectiveTrackingState State
    {
      get
      {
        return (global::Sungero.RecordManagement.ICompanyDirectiveTrackingState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.CompanyDirectiveTrackingState(this);
    }

    public new global::Sungero.RecordManagement.ICompanyDirectiveTrackingInfo Info
    {
      get
      {
        return (global::Sungero.RecordManagement.ICompanyDirectiveTrackingInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors





    public CompanyDirectiveTracking()
    {








    }

    #endregion

  }
}
