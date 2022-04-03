using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Tsett.Items.Materials
{
    public class StrangeEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A strange eye that faintly pulsates with a weak but pleasant force");
        }

        public override void SetDefaults() 
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.Green;
            item.expert = true;
            item.expertOnly = true; 
            item.maxStack = 1;
            item.material = true;
        }
        
    }
}
