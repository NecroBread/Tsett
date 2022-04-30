using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace Tsett.Items.Weapons
{
    public class SpectralsunBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectralsun Broadsword");
            Tooltip.SetDefault("Forged by the Spectral Sun God's personal smith, \nthis blade is capable of burning its wielder's enemies to ashes.");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 50;
            item.melee = true;
            item.damage = 145;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Projectiles.SpectralsunBWrocket>();
            item.shootSpeed = 6;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 600);
            target.AddBuff(BuffID.Confused, 150);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Materials.RepairedHilt>());
            recipe.AddIngredient(ModContent.ItemType<Materials.Placeable.SpectralsunBar>(), 18);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}