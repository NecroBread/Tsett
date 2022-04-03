using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Consumable
{
    public class RuneOfHarvest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rune of Jera");
            Tooltip.SetDefault("'Harvest'\nRight click to create plants and seeds");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.UseSound = SoundID.Item4;
            item.consumable = true;
            item.maxStack = 42;
            item.rare = ItemRarityID.LightPurple;
            item.value = Item.sellPrice(silver: 95);
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemID.Daybloom, 3);
            player.QuickSpawnItem(ItemID.Blinkroot, 3);
            player.QuickSpawnItem(ItemID.Moonglow, 3);
            player.QuickSpawnItem(ItemID.Shiverthorn, 3);
            player.QuickSpawnItem(ItemID.Waterleaf, 3);
            player.QuickSpawnItem(ItemID.Deathweed, 3);
            player.QuickSpawnItem(ItemID.Fireblossom, 3);
            player.QuickSpawnItem(ItemID.DaybloomSeeds, 6);
            player.QuickSpawnItem(ItemID.BlinkrootSeeds, 6);
            player.QuickSpawnItem(ItemID.MoonglowSeeds, 6);
            player.QuickSpawnItem(ItemID.ShiverthornSeeds, 6);
            player.QuickSpawnItem(ItemID.WaterleafSeeds, 6);
            player.QuickSpawnItem(ItemID.DeathweedSeeds, 6);
            player.QuickSpawnItem(ItemID.FireblossomSeeds, 6);
        }
    }
}