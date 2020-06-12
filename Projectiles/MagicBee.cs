using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Projectiles
{
    public class MagicBee : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bee");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = (int)byte.MaxValue;
            projectile.light = 0f;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 17);
            int bees = 5 + Main.rand.Next(10);
            for (int i = 0; i <= bees; i++)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, (float)(-1 + Main.rand.Next(2)) * 5, (float)(-1 + Main.rand.Next(2)) * 5, ProjectileID.Bee, (int)(projectile.damage * .75f), 0, projectile.owner);
            }
            return false;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 17);
            int bees = 5 + Main.rand.Next(10);
            for (int i = 0; i <= bees; i++)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, (float)(-1 + Main.rand.Next(2)) * 5, (float)(-1 + Main.rand.Next(2)) * 5, ProjectileID.Bee, (int)(projectile.damage * .75f), 0, projectile.owner);
            }
            projectile.Kill();
        }
    }
}