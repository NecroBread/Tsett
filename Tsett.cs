using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Tsett
{
	public class Tsett : Mod
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup goldplatbroad = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Gold Broadsword", new int[]
			{
		ItemID.GoldBroadsword,
		ItemID.PlatinumBroadsword
			});
			RecipeGroup.RegisterGroup("Tsett:Gold Broadsword", goldplatbroad);

			RecipeGroup demonicrimt = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Evil Bar", new int[]
			{
		ItemID.DemoniteBar,
		ItemID.CrimtaneBar
			});
			RecipeGroup.RegisterGroup("Tsett:Evil Bar", demonicrimt);

		}

		class MyGlobalNPC : GlobalNPC
		{
			public class TreasureBags : GlobalItem
			{


				public override void OpenVanillaBag(string context, Player player, int arg)
				{
					if (context == "bossBag" && arg == ItemID.EaterOfWorldsBossBag)
					{
						player.QuickSpawnItem(ModContent.ItemType<Items.Materials.PieceOfHilt>());
					}

					if (context == "bossBag" && arg == ItemID.BrainOfCthulhuBossBag)
                    {
						player.QuickSpawnItem(ModContent.ItemType<Items.Materials.PieceOfHilt>());
					}
				}
			}

			public override void NPCLoot(NPC npc)
			{
				if (npc.type == NPCID.SkeletronHead)
				{
					Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Materials.StrangeEye>());
				}


			}

			public override void SetupShop(int type, Chest shop, ref int nextSlot)
            {
				if (type == NPCID.Dryad && NPC.downedQueenBee)
                {
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Food.RADISH>());
					shop.item[nextSlot].shopCustomPrice = 10000;
					nextSlot++;
                }

				if (type == NPCID.WitchDoctor && NPC.downedBoss3)
                {
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Consumable.RuneOfSun>());
                    shop.item[nextSlot].shopCustomPrice = 20000;
					nextSlot++;
                }

				if(type == NPCID.WitchDoctor && Main.hardMode)
                {
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Consumable.RuneOfHarvest>());
					shop.item[nextSlot].shopCustomPrice = 60606;
					nextSlot++;
                }

				if(type == NPCID.Clothier && NPC.downedGolemBoss)
                {
					shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Materials.MaskPiece>());
					shop.item[nextSlot].shopCustomPrice = 450000;
					nextSlot++;
                }
            }
		}
	}
}