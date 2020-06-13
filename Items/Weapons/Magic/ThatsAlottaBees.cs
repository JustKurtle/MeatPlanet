using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Magic
{
	public class ThatsAlottaBees : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("That's Alotta Bees");
			Tooltip.SetDefault("TOO MANY BEES");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
            item.magic = true;
            item.mana = 6;
			item.melee = false;
			item.width = 10;
			item.height = 20;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = Item.sellPrice(0, 4, 0, 0);
			item.rare = 4;
            item.shoot = mod.ProjectileType("MagicBee");
            item.shootSpeed = 20f;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LaserRifle, 1);
            recipe.AddIngredient(ItemID.BeeGun, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
