using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Materials
{
    public class ClearSheet: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clear Sheet");
            Tooltip.SetDefault("This sheet of paper is really useful");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.rare = 2;
            item.maxStack = 48;
            item.value = Item.sellPrice(copper: 15);
            item.material = true;
        }
    }
}