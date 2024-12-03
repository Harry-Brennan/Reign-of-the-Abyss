using UnrealBuildTool;

public class Reign_of_the_AbyssServerTarget : TargetRules
{
	public Reign_of_the_AbyssServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Reign_of_the_Abyss");
	}
}
