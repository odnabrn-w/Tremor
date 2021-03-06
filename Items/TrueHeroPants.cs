using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class TrueHeroPants : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 18;
			item.value = 25000;

			item.rare = 0;
			item.defense = 20;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hero Pants");
			Tooltip.SetDefault("Gives one of three true blades");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].overrideColor = new Color(238, 194, 73);
		}

		public override void UpdateEquip(Player player)
		{
			player.AddBuff(mod.BuffType("ThirdTrueBlade"), 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(249, 1);
			recipe.AddIngredient(null, "GiantShell", 1);
			recipe.AddIngredient(null, "BrokenHeroArmorplate", 1);
			recipe.AddIngredient(null, "TrueEssense", 3);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
