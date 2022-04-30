using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Materials.Placeable
{
	public class SpectralsunBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectralsun Bar");
			/*ItemID.Sets.SortingPriorityMaterials[item.type] = 89;*/
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 9999;
			item.value = Item.sellPrice(gold: 2);
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.SpectralsunBar>();
			item.placeStyle = 0;
			item.rare = 8;
			item.material = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 1);
			recipe.AddTile(412);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}
