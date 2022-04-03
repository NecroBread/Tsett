using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tsett.Items.Weapons
{
    public class UMELEEW : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ULTIMATE MELEE WEAPON");
            Tooltip.SetDefault("YEEEEEEEEES GODDAMIT");
        }

        public override void SetDefaults()
        {
            item.width = 256;
            item.height = 256;
            item.melee = true;
            item.rare = ItemRarityID.Purple;
            item.damage = 666000000;
            item.useTime = 2;
            item.useAnimation = 2;
            item.UseSound = SoundID.Item1;
            item.knockBack = 100;
            item.autoReuse = true;
            item.value = Item.sellPrice(copper: 0);
            item.useStyle = ItemUseStyleID.SwingThrow;
        }
    }
}