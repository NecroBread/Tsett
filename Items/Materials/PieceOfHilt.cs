using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Materials
{
    public class PieceOfHilt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Piece of hilt");
            Tooltip.SetDefault("Part of something that vaguely resembles a hilt");
        }

        public override void SetDefaults()
        {
            item.height = 16;
            item.width = 16;
            item.rare = 3;
            item.value = Item.sellPrice(silver: 1);
            item.material = true;
            item.consumable = true;
            item.maxStack = 99;
        }
    }
}