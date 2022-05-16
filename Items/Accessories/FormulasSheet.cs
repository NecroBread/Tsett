using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Accessories
{
    public class FormulasSheet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Formulas sheet");
            Tooltip.SetDefault("The sheet is scribbled with the basic formulas of trigonometry");
        }
        
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.accessory = true;
            item.rare = 5;
            item.value = Item.sellPrice(silver: 90);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magicDamage +=0.16f;
            player.statDefense +=4;
            player.statManaMax2 +=48;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Feather);
            recipe.AddIngredient(ItemID.BlackInk);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ClearSheet>());
            recipe.AddTile(14);
            recipe.AddTile(15);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}