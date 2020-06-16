using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Projectiles
{
	public class Brick : ModProjectile
	{
		public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
			projectile.magic = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.alpha = (int)byte.MaxValue;
            projectile.light = 0f;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
        }
		public override bool OnTileCollide(Vector2 oldVelocity)
        {
            for(int i = 0;i < 5;i++) 
            {
                Dust.NewDust(projectile.position, 2, 2, 22, 0f, 0f, 0, default(Color), 1f); //Dust ID 22 is "brown clay"
            }
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            projectile.Kill();
            return false;
        }
	}
}