using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Materials
{
    public class MaskPiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mask Piece");
            Tooltip.SetDefault("Piece from a mask of unknown origin");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.Yellow;
            item.expert = true;
            item.expertOnly = true;
            item.maxStack = 1;
            item.material = true;
        }
    }
}