using UnrealBuildTool;

public class Wispers_In_The_MazeTarget : TargetRules
{
	public Wispers_In_The_MazeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Wispers_In_The_Maze");
	}
}
