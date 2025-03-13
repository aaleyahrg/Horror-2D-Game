using UnrealBuildTool;

public class Wispers_In_The_MazeClientTarget : TargetRules
{
	public Wispers_In_The_MazeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Wispers_In_The_Maze");
	}
}
