using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace Tsett.Buffs
{
    public class RuneSun : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Rune of Sowilu");
            Description.SetDefault("Your body is blessed by Sunlight");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update (Player player, ref int buffIndex)
        {
            Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 3f, 3f, 3f);
            player.statLifeMax2 += 40;
            player.lifeRegenCount += 4;
            player.manaRegenCount +=6;
            player.fireWalk = true;
            player.statManaMax2 += 60;
        }
    }
}