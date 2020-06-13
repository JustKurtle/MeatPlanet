using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Throwing
{
	public class Bouncything : ModItem
	{
		public override void SetDefaults()
        {
			item.shootSpeed = 50f;
			item.damage = 45;
			item.knockBack = 1f;
			item.useStyle = 1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = 1;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("Bouncything");
		}
	}
}