using UnrealBuildTool;

public class Wispers_In_The_MazeServerTarget : TargetRules
{
	public Wispers_In_The_MazeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Wispers_In_The_Maze");
	}
}
