using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MinersLamp : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = mod.TileType("MinersLampTile");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Miners Lamp");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 1);
			recipe.AddIngredient(null, "SteelBar", 4);
			recipe.AddIngredient(null, "Charcoal", 4);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
