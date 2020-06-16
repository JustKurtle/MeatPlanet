using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Projectiles
{
    public class Toast : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toast");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.ranged = true;
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
            for(int i = 0;i < 5;i++) 
            {
                Dust.NewDust(projectile.position, 2, 2, DustID.Dirt, 0f, 0f, 0, default(Color), 1f);
            }
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            projectile.Kill();
            return false;
        }
    }
}