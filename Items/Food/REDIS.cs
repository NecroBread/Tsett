using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Food
{
    public class RADISH : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Radish");
            Tooltip.SetDefault("'Ah yes, the REDISKA'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 12;
            item.useTime = 12;
            item.useTurn = true;
            item.UseSound = SoundID.Item2;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(silver: 10);
            item.buffType = ModContent.BuffType<Buffs.Radished>();
            item.buffTime = 54000;
        }
    }
}