using ObjCRuntime;

[assembly: LinkWith ("libSTPopup.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]
