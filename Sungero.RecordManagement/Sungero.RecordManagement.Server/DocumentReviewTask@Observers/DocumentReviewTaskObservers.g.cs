
// ==================================================================
// DocumentReviewTaskObservers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{


  public class DocumentReviewTaskObservers :
    global::Sungero.Workflow.Server.TaskObservers, global::Sungero.RecordManagement.IDocumentReviewTaskObservers
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("420873fa-33fe-4759-ba41-f803b40d11b8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.RecordManagement.Server.DocumentReviewTaskObservers.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.RecordManagement.IDocumentReviewTaskObservers, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.RecordManagement.IDocumentReviewTaskObserversState State
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskObserversState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskObserversState(this);
    }

    public new virtual global::Sungero.RecordManagement.IDocumentReviewTaskObserversInfo Info
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskObserversInfo)base.Info; }
    }










    #region Framework events



    #endregion


    public DocumentReviewTaskObservers()
    {
    }

  }
}

// ==================================================================
// DocumentReviewTaskObserversHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement
{

}

// ==================================================================
// DocumentReviewTaskObserversEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Server
{
}
