using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Projectiles
{
    public class Wowgrape : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wowgrape");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
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
            int xOff = Main.rand.Next(-250, 251);
            int a = Projectile.NewProjectile(projectile.Center.X + xOff, projectile.Center.Y - 600, -(xOff / (600 / 16)), 20f, mod.ProjectileType("Skygrape"), (int)(projectile.damage * .75f), 0, projectile.owner);
            Main.projectile[a].aiStyle = 1;
            Main.projectile[a].tileCollide = true;
            for(int i = 0;i < 5;i++) 
            {
                Dust.NewDust(projectile.position, 2, 2, 179, 0f, 0f, 0, default(Color), 1f); //Dust ID 179 is "light purple particles"
            }
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            projectile.Kill();
            return false;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            int xOff = Main.rand.Next(-250, 251);
            int a = Projectile.NewProjectile(projectile.Center.X + xOff, projectile.Center.Y - 600, -(xOff / (600 / 16)), 20f, mod.ProjectileType("Skygrape"), (int)(projectile.damage * .75f), 0, projectile.owner);
            Main.projectile[a].aiStyle = 1;
            Main.projectile[a].tileCollide = true;
        }
    }
}