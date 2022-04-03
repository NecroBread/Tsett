using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Accessoires
{
    public class SnakeBandana : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snake Bandana");
            Tooltip.SetDefault("Increased ranged damage and critical strike chance \n'Kept you waiting, huh?'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.accessory = true;
            item.rare = 7;
            item.value = Item.sellPrice(gold: 4);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedDamage += .95f;
            player.rangedCrit += 15;

        }
    }
}