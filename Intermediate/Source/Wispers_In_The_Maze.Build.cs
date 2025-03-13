using UnrealBuildTool;

public class Wispers_In_The_Maze : ModuleRules
{
	public Wispers_In_The_Maze(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
