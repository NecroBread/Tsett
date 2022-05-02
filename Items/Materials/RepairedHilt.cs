using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Materials
{
    public class RepairedHilt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Repaired Hilt");
            Tooltip.SetDefault("Blade handle, repaired from the pieces");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.material = true;
            item.maxStack = 1;
            item.value = Item.sellPrice(silver: 67);
            item.rare = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient (ModContent.ItemType<Materials.PieceOfHilt>(), 2);
            recipe.AddIngredient (ItemID.LargeEmerald);
            recipe.AddRecipeGroup("Tsett:Evil Bar", 4);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}