using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Tsett.Items.Tools
{
    public class SpectralsunPickaxe : ModItem
    {
        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Spectralsun Pickaxe");
            Tooltip.SetDefault("This pickaxe was forged in the heat of the sun");
            /*ItemID.Sets.SortingPriorityMaterials[item.type] = 99;*/
        }

        public override void SetDefaults() 
        {
            item.damage = 36;
            item.width = 32;
            item.height = 32;
            item.melee = true;
            item.useTime = 9;
            item.useAnimation = 15;
            item.pick = 220;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 6;
            item.value = 90200;
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.tileBoost += 3;
        }

        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Materials.Placeable.SpectralsunBar>(), 18);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}