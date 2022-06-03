using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items
{
    public class BurntList : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Burnt Sheet");
            Tooltip.SetDefault("And _he ____n__ w_ll ___e from t__ _sh__");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.rare = 11;
            item.value = Item.sellPrice(0);
            item.useTime = 15;
            item.useAnimation = 15;
        }
    }
}