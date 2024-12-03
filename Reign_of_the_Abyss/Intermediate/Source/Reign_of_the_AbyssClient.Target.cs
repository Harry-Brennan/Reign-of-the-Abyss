using UnrealBuildTool;

public class Reign_of_the_AbyssClientTarget : TargetRules
{
	public Reign_of_the_AbyssClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Reign_of_the_Abyss");
	}
}
