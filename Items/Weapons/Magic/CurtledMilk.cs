using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Magic
{
	public class CurtledMilk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Curtled Milk");
			Tooltip.SetDefault("A WOM dev weapon! Got milk?");
		}

		public override void SetDefaults()
		{
			item.damage = 51;
            item.magic = true;
            item.mana = 7;
			item.melee = false;
			item.width = 10;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 5; // 60 would be a second
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = -12;
            item.shoot = 126;
            item.shootSpeed = 25f;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
		}
	}
}
