using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Ranged
{
	public class Dangtasm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dangtasm");
			Tooltip.SetDefault("A WOM dev weapon! Lechuga! (that means \"never give up\" in Spanish)");
		}

		public override void SetDefaults()
		{
            item.useStyle = 5;
            item.useAnimation = 10;
		 	item.useTime = 10;
            item.width = 12;
            item.height = 28;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.UseSound = SoundID.Item5;
            item.damage = 30;
            item.shootSpeed = 12f;
            item.noMelee = true;
			item.rare = -12;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.ranged = true;
			item.autoReuse = true;
		}
	}
}
