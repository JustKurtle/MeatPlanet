using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Projectiles
{
    public class Purple : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple");
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
            projectile.timeLeft = 30; //Was originally 600, which I think is 10 seconds?? I think 30 is half a second, which I want because it flies completely straight.
            projectile.alpha = (int)byte.MaxValue;
            projectile.light = 0f;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
        }
        public override void AI()
        {
            int num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 8, 8, 173, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
            Main.dust[num309].velocity *= 2f; //Amount of dust
            num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 8, 8, 173, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
            Main.dust[num309].velocity *= 2f;
            Main.dust[num309].position -= projectile.velocity * 0.5f;
        }
    }
}