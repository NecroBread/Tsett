using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Weapons.Ammo
{
    public class SpectralsunBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectralsun Bullet");
            Tooltip.SetDefault("That bullet contain a god's wrath");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 9999;
            item.consumable = true;
            item.knockBack = 1.8f;
            item.value = Item.sellPrice(silver: 1);
            item.rare = ItemRarityID.Yellow;
            item.shoot = ModContent.ProjectileType<Projectiles.SpectralsunBullet>();
            item.shootSpeed = 14f;
            item.ammo = AmmoID.Bullet;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 100);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.Placeable.SpectralsunBar>());
            recipe.AddTile(134);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }*/
    }
}