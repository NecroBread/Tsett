using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace Tsett.Items.Weapons
{
    public class SpectralsunShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectralsun Shortsword");
            Tooltip.SetDefault("A dagger forged in the sunlight");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.melee = true;
            item.damage = 150;
            item.useTime = 13;
            item.useAnimation = 13;
            item.knockBack = 7;
            item.rare = ItemRarityID.Red;
            item.value = Item.sellPrice(gold: 16);
            item.UseSound = SoundID.Item1;
            item.useStyle = 3;
            item.shoot = ModContent.ProjectileType<Projectiles.SpectralsunSSword>();
            item.shootSpeed = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Materials.Placeable.SpectralsunBar>(), 12);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}