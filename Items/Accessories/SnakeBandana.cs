using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Accessories
{
    public class SnakeBandana : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snake Bandana");
            Tooltip.SetDefault("Increased ranged damage and critical strike chance \n'Kept you waiting, huh?'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.accessory = true;
            item.rare = 5;
            item.value = Item.sellPrice(gold: 4);
            item.maxStack = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedDamage += .45f;
            player.rangedCrit += 15;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.BlackString);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}