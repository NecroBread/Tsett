using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Items.Weapons
{
    public class ComicallyLargeSpoon:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Comically Large Spoon");
            Tooltip.SetDefault("This spoon is too big to be used as a cutlery");
        }

        public override void SetDefaults()
        {
            item.width = 96;
            item.height = 96;
            item.melee = true;
            item.damage = 72;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;
            item.knockBack = 9;
            item.rare = 4;
            item.value = 8300;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
     }
}