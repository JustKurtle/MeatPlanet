using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Magic
{
    public class BrickStorm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brick Storm");
            Tooltip.SetDefault("Where are they coming from?");
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.magic = true;
            item.mana = 3;
            item.melee = false;
            item.width = 28;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("Brick");
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3 + Main.rand.Next(2); // 3 or 4 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                int xOff = Main.rand.Next(-250, 251);
                Vector2 perturbedSpeed = new Vector2(-(xOff / (600 / 16)), 20f);
                int a = Projectile.NewProjectile(Main.MouseWorld.X + xOff + player.velocity.X, Main.MouseWorld.Y - ((Main.MouseWorld.Y - position.Y) + 600) + player.velocity.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("Brick"), (int)(damage * .75f), item.knockBack, player.whoAmI);
                Main.projectile[a].aiStyle = 1;
                Main.projectile[a].tileCollide = true;
            }
            return false;
        }
    }
}
