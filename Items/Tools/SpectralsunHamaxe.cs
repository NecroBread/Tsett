using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Tsett.Items.Tools
{
    public class SpectralsunHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectralsun Hamaxe");
            Tooltip.SetDefault("Great hamaxe, created by a very remarkable smith");
            /*ItemID.Sets.SortingPriorityMaterials[item.type] = 98;*/
        }

        public override void SetDefaults() 
        {
            item.damage = 64;
            item.width = 32;
            item.height = 32;
            item.melee = true;
            item.useTime = 7;
            item.useAnimation = 18;
            item.axe = 24;
            item.hammer = 100;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 6;
            item.value = 68200;
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