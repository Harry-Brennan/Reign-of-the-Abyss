using UnrealBuildTool;

public class Reign_of_the_AbyssTarget : TargetRules
{
	public Reign_of_the_AbyssTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Reign_of_the_Abyss");
	}
}
