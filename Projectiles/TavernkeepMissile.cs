using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Projectiles
{
    public class TavernkeepMissile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tavernkeep Missile");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }
        public override void SetDefaults()
        {
            projectile.width = 9;
            projectile.height = 4;
            projectile.aiStyle = 9;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.light = 0f;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            for (int i = 0; i < 5; i++)
            {
                Dust.NewDust(projectile.position, 2, 2, DustID.Stone);
            }
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 118);
            projectile.Kill();
            return false;
        }
    }
}