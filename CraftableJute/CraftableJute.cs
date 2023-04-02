using System;
using BepInEx;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;

namespace bonesbro
{
	[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
	[BepInDependency(Jotunn.Main.ModGuid)]
	internal class CraftableJute : BaseUnityPlugin
	{
		public const string PluginGUID = "bonesbro.val.craftablejute";
		public const string PluginName = "CraftableJute";
		public const string PluginVersion = "1.0.0";
		
		// Use this class to add your own localization to the game
		// https://valheim-modding.github.io/Jotunn/tutorials/localization.html
		public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

		private void Awake()
		{
			AddRecipes();
		}

		private void AddRecipes()
		{
			Jotunn.Logger.LogInfo("Setting up recipes");

			RecipeConfig redJute = new RecipeConfig
			{
				Item = "JuteRed",
				CraftingStation = "piece_artisanstation",
				Amount = 1
			};
			redJute.AddRequirement(new RequirementConfig("LinenThread", 3));
			redJute.AddRequirement(new RequirementConfig("Raspberry", 1));
			ItemManager.Instance.AddRecipe(new CustomRecipe(redJute));

			RecipeConfig blueJute = new RecipeConfig
			{
				Item = "JuteBlue",
				CraftingStation = "piece_artisanstation",
				Amount = 1
			};
			blueJute.AddRequirement(new RequirementConfig("LinenThread", 3));
			blueJute.AddRequirement(new RequirementConfig("MushroomMagecap", 1));
			ItemManager.Instance.AddRecipe(new CustomRecipe(blueJute));

			Jotunn.Logger.LogInfo("Finished adding recipes");
		}
	}
}