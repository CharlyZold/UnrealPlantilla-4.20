using UnrealBuildTool;

public class UVRFPlaygroundTarget : TargetRules
{
	public UVRFPlaygroundTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("UVRFPlayground");
	}
}
