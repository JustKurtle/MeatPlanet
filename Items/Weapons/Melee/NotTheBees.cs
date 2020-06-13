using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class NotTheBees : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Not the Bees");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 21;
            item.height = 21;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 3;
            item.scale = 2;
            item.knockBack = 7;
            item.value = Item.sellPrice(0, 6, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = ProjectileID.Bee;
            item.shootSpeed = 1f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 5;
			float rotation = MathHelper.ToRadians(15);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
				Projectile.NewProjectile(player.position.X, player.position.Y + 20, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BreakerBlade, 1);
            recipe.AddIngredient(ItemID.BeeKeeper, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
