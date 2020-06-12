using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HeadBrick : ModItem
	{
		public override void SetDefaults()
        {
			item.width = 20;
			item.height = 10;
			item.rare = 1;
			item.vanity = true;
		}

		public override bool DrawHead()
        {
			return false;
		}
	}
}