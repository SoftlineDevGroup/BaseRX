
// ==================================================================
// MinutesVersions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Meetings.Client
{
  public class MinutesVersions :
    global::Sungero.Docflow.Client.MinutesBaseVersions, global::Sungero.Meetings.IMinutesVersions
  {
    #region Fields and properties

    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("c48ebf2d-dca8-4efd-bf1b-8c21302666ba");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Meetings.Client.MinutesVersions.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Meetings.IMinutesVersions, Sungero.Domain.Interfaces"; }
    }

    public new global::Sungero.Meetings.IMinutesVersionsState State
    {
      get
      {
        return (global::Sungero.Meetings.IMinutesVersionsState)base.State;
      }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Meetings.Shared.MinutesVersionsState(this);
    }

    public new global::Sungero.Meetings.IMinutesVersionsInfo Info
    {
      get
      {
        return (global::Sungero.Meetings.IMinutesVersionsInfo)base.Info;
      }
    }










    #endregion

    #region Methods

    #endregion

    #region Framework events





    #endregion

    #region Constructors







    public MinutesVersions()
    {








    }

    #endregion

  }
}
