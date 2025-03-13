using UnrealBuildTool;

public class Wispers_In_The_MazeEditorTarget : TargetRules
{
	public Wispers_In_The_MazeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Wispers_In_The_Maze");
	}
}
