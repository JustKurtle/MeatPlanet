using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
    public class Switchblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Switchblade");
        }
        public override void SetDefaults()
        {
            item.damage = 17;
            item.melee = true;
            item.width = 52;
            item.height = 50;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 3;
            item.knockBack = 6;
            item.value = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("Pineapple");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 1;
            for (int i = 0; i < numberProjectiles; i++)
            {
                int xOff = Main.rand.Next(-250, 251);
                Vector2 perturbedSpeed = new Vector2(-(xOff / (600 / 16)), 20f);
                int a = Projectile.NewProjectile(Main.MouseWorld.X + xOff + player.velocity.X, Main.MouseWorld.Y - ((Main.MouseWorld.Y - position.Y) + 600) + player.velocity.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("Pineapple"), (int)(damage * .75f), item.knockBack, player.whoAmI);
                Main.projectile[a].aiStyle = 1;
                Main.projectile[a].tileCollide = true;
            }
            return false;
        }
    }
}
