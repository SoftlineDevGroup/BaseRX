
// ==================================================================
// Module.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Client
{
  public partial class SmartProcessingModule : global::Sungero.Domain.Shared.ModuleBase
  {
    public override global::System.Guid Id
    {
      get { return global::System.Guid.Parse("bb685d97-a673-42ea-8605-66889967467f"); }
    }

    public override string Name
    {
      get { return "Sungero.SmartProcessing"; }
    }

    public override void RegisterTypes()
    {
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("668418c4-bd08-4aeb-94d7-d0c30869c1a0"), new Sungero.SmartProcessing.Shared.BlobInfo(typeof(global::Sungero.SmartProcessing.IBlob)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Client.IBlobClientPublicFunctions, global::Sungero.SmartProcessing.Client.BlobClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Shared.IBlobSharedPublicFunctions, global::Sungero.SmartProcessing.Shared.BlobSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("1e9415ec-6ba8-46b5-b864-94b4385ffb52"), new Sungero.SmartProcessing.Shared.BlobPackageInfo(typeof(global::Sungero.SmartProcessing.IBlobPackage)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Client.IBlobPackageClientPublicFunctions, global::Sungero.SmartProcessing.Client.BlobPackageClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Shared.IBlobPackageSharedPublicFunctions, global::Sungero.SmartProcessing.Shared.BlobPackageSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("77013bb4-1692-40fd-a4da-f8b31bd4f7a6"), new Sungero.SmartProcessing.Shared.BlobPackageBlobsInfo(typeof(global::Sungero.SmartProcessing.IBlobPackageBlobs)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("d3cf4768-738c-40dd-bfa3-cacc88c93909"), new Sungero.SmartProcessing.Shared.BlobPackageCCInfo(typeof(global::Sungero.SmartProcessing.IBlobPackageCC)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("6b16e807-26cd-4c4b-aadf-b2a255609cc6"), new Sungero.SmartProcessing.Shared.BlobPackageToInfo(typeof(global::Sungero.SmartProcessing.IBlobPackageTo)));
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("e825fc6a-c82b-4b89-a9fc-33fb181cb161"), new Sungero.SmartProcessing.Shared.VerificationAssignmentInfo(typeof(global::Sungero.SmartProcessing.IVerificationAssignment)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Client.IVerificationAssignmentClientPublicFunctions, global::Sungero.SmartProcessing.Client.VerificationAssignmentClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Shared.IVerificationAssignmentSharedPublicFunctions, global::Sungero.SmartProcessing.Shared.VerificationAssignmentSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("999a5ae0-17ec-4735-bc90-d85c7fe08dd3"), new Sungero.SmartProcessing.Shared.VerificationTaskInfo(typeof(global::Sungero.SmartProcessing.IVerificationTask)));
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Client.IVerificationTaskClientPublicFunctions, global::Sungero.SmartProcessing.Client.VerificationTaskClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Shared.IVerificationTaskSharedPublicFunctions, global::Sungero.SmartProcessing.Shared.VerificationTaskSharedPublicFunctions>();
      global::Sungero.Domain.Shared.EntityInfoRegister.RegisterEntityInfo(new global::System.Guid("f28f5ffb-a17a-4269-8fcb-24aff53ad560"), new Sungero.SmartProcessing.Shared.VerificationTaskObserversInfo(typeof(global::Sungero.SmartProcessing.IVerificationTaskObservers)));


      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.IBlobFilterState, global::Sungero.SmartProcessing.Shared.Blob.BlobFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.IBlobPackageFilterState, global::Sungero.SmartProcessing.Shared.BlobPackage.BlobPackageFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.IVerificationAssignmentFilterState, global::Sungero.SmartProcessing.Shared.VerificationAssignment.VerificationAssignmentFilterState>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.IVerificationTaskFilterState, global::Sungero.SmartProcessing.Shared.VerificationTask.VerificationTaskFilterState>();



      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Client.IModuleClientPublicFunctions, global::Sungero.SmartProcessing.Client.ModuleClientPublicFunctions>();
      global::Sungero.Domain.Shared.ModuleManager.Instance.Container.RegisterType<global::Sungero.SmartProcessing.Shared.IModuleSharedPublicFunctions, global::Sungero.SmartProcessing.Shared.ModuleSharedPublicFunctions>();
    }
  }
}
