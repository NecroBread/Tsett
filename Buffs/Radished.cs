using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tsett.Buffs
{
    public class Radished : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Radished");
            Description.SetDefault("You're radished!\nGrants a minor boost to stats.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update (Player player, ref int buffIndex)
        {
            player.lifeRegenCount += 3;
            player.meleeDamage += 0.08f;
            player.meleeCrit += 4;
            player.meleeSpeed += 0.08f;
            player.rangedDamage += 0.08f;
            player.rangedCrit += 4;
            player.magicDamage += 0.08f;
            player.magicCrit += 4;
            player.minionDamage += 0.08f;
            player.statDefense += 4;
            player.manaRegenCount += 4;
            player.moveSpeed += 0.35f;
        }
    }
}