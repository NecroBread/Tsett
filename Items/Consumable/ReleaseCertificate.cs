using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Consumable
{
    public class ReleaseCertificate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Release Certificate");
            Tooltip.SetDefault("Congratulations everyone on the release!\nRight Click to extract items(works only if you beat Moon Lord)");
        }
        
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.UseSound = SoundID.Item4;
            item.consumable = true;
            item.maxStack = 1;
            item.rare = 11;
            item.value = Item.sellPrice(0);
        }

        public override bool CanRightClick()
        {
            if (NPC.downedMoonlord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void RightClick (Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<Items.Consumable.RuneOfSun>(), 42);
            player.QuickSpawnItem(ModContent.ItemType<Items.Food.RADISH>(), 30);
            player.QuickSpawnItem(ModContent.ItemType<Items.Consumable.RuneOfHarvest>(), 42);
            player.QuickSpawnItem(ModContent.ItemType<Items.Materials.MaskPiece>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Materials.StrangeEye>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Materials.Placeable.SpectralsunBar>(), 99);
            player.QuickSpawnItem(ModContent.ItemType<Items.Tools.SpectralsunHamaxe>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Tools.SpectralsunPickaxe>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.ObsidianSword>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.SpectralsunBroadsword>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Weapons.SpectralsunShortsword>());
            player.QuickSpawnItem(ModContent.ItemType<Items.Materials.PieceOfHilt>(), 4);
            player.QuickSpawnItem(ModContent.ItemType<Items.Materials.RepairedHilt>(), 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}