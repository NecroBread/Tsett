using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Tsett.Items.Weapons
{
	public class ObsidianSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Obsidian Broadsword");
			Tooltip.SetDefault("Really good for crush that skeleton.");
		}

		public override void SetDefaults()
		{ 
			item.damage = 56;
			item.melee = true;
			item.width = 45;
			item.height = 45;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.sellPrice(silver: 30);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			target.AddBuff(BuffID.Bleeding, 600);
			target.AddBuff(BuffID.BrokenArmor, 450);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Tsett:Gold Broadsword");
			recipe.AddIngredient(ItemID.Obsidian, 25);
			recipe.AddRecipeGroup("Tsett:Evil Bar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}