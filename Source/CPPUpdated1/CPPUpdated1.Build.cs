// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CPPUpdated1 : ModuleRules
{
	public CPPUpdated1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CPPUpdated1",
			"CPPUpdated1/Variant_Platforming",
			"CPPUpdated1/Variant_Platforming/Animation",
			"CPPUpdated1/Variant_Combat",
			"CPPUpdated1/Variant_Combat/AI",
			"CPPUpdated1/Variant_Combat/Animation",
			"CPPUpdated1/Variant_Combat/Gameplay",
			"CPPUpdated1/Variant_Combat/Interfaces",
			"CPPUpdated1/Variant_Combat/UI",
			"CPPUpdated1/Variant_SideScrolling",
			"CPPUpdated1/Variant_SideScrolling/AI",
			"CPPUpdated1/Variant_SideScrolling/Gameplay",
			"CPPUpdated1/Variant_SideScrolling/Interfaces",
			"CPPUpdated1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
