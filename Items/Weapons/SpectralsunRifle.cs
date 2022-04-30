using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Weapons
{
    public class SpectralsunRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectralsun Rifle");
            Tooltip.SetDefault("Rifle, created by the best smith of Spectralsun God. \n42.69% chanse to not consume ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 42;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 7;
            item.useAnimation = 7;
            item.noMelee = true;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = Item.sellPrice(gold: 3, silver: 54);
            item.rare = ItemRarityID.Cyan;
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Bullet;
            item.autoReuse = true;
            item.UseSound = SoundID.Item11;
            item.shoot = 10;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .4269f;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.Placeable.SpectralsunBar>(), 14);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}