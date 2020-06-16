using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Projectiles
{
    public class LagArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lag Arrow");
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
            projectile.penetrate = 10;
            projectile.timeLeft = 6000;
            projectile.alpha = (int)byte.MaxValue;
            projectile.light = 0f;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.WoodenArrowFriendly;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            for (int i = 0; i < 5; i++)
            {
                Dust.NewDust(projectile.position, 2, 2, 214, 0f, 0f, 0, default(Color), 1f); //Dust ID 214 is "thin pale brown material"
            }
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 10);
            projectile.Kill();
            return false;
        }
    }
}