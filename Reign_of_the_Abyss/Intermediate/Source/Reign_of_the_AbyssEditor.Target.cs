using UnrealBuildTool;

public class Reign_of_the_AbyssEditorTarget : TargetRules
{
	public Reign_of_the_AbyssEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Reign_of_the_Abyss");
	}
}
