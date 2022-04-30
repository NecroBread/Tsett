using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tsett.Tiles
{
	public class SpectralsunBar : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileShine[Type] = 1100; 
			Main.tileSolid[Type] = false;
			Main.tileSolidTop[Type] = true; 
			Main.tileFrameImportant[Type] = true; 

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true; 
			TileObjectData.newTile.LavaDeath = false; 
			TileObjectData.addTile(Type);

			AddMapEntry(new Color(200, 200, 200), Language.GetText("MapObject.MetalBar"));
		}

		public override bool Drop(int i, int j)
		{
			Tile t = Main.tile[i, j];
			int style = t.frameX / 18;
			if (style == 0) 
			{
				Item.NewItem(i * 16, j * 16, 16, 16, ModContent.ItemType<Items.Materials.Placeable.SpectralsunBar>());
			}
			return base.Drop(i, j);
		}
	}
}