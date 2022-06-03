using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items
{
    public class bread : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("bread");
            Tooltip.SetDefault("Doing something... \nPerhaps we should combine it with the Phoenix ash? \n \nWhile you holding it, you feeling like you someone special");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 24;
            item.UseSound = SoundID.Item4;
            item.rare = 11;
            item.useTime = 20;
            item.useAnimation = 20;
            item.value = Item.sellPrice(0);
        }
    }
}