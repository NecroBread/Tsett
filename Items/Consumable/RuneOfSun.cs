using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Consumable
{
    public class RuneOfSun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rune of Sowilu");
            Tooltip.SetDefault("'Sun'\nPlayer shining, +4HP&Mana Regeneration, +40HP&Mana");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 24;
            item.useTime = 24;
            item.useTurn = true;
            item.UseSound = SoundID.Item4;
            item.consumable = true;
            item.maxStack = 42;
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(silver: 45);
            item.buffType = ModContent.BuffType<Buffs.RuneSun>();
            item.buffTime = 36000;
        }
    }
}