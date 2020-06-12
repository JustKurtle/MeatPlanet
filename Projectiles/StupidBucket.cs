using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Projectiles
{
    public class StupidBucket : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mach Nine Bucket");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 1000;
            projectile.height = 1000;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.ranged = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 600;
            projectile.alpha = (int)byte.MaxValue;
            projectile.light = 200f;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            int xOff = Main.rand.Next(-250, 251);
            int a = Projectile.NewProjectile(projectile.Center.X + xOff, projectile.Center.Y - 600, -(xOff / (600 / 16)), 20f, ProjectileID.HallowStar, (int)(projectile.damage * 200f), 0, projectile.owner);
            Main.projectile[a].aiStyle = 1;
            Main.projectile[a].tileCollide = true;
            projectile.Kill();
            return false;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 60000);
            target.AddBuff(BuffID.OnFire, 60000);
            target.AddBuff(BuffID.Poisoned, 60000);
            target.AddBuff(BuffID.Venom, 60000);
            target.AddBuff(BuffID.Ichor, 60000);
            target.AddBuff(BuffID.CursedInferno, 60000);
            target.AddBuff(BuffID.Midas, 60000);
            target.AddBuff(BuffID.Confused, 60000);
            target.AddBuff(BuffID.ShadowFlame, 60000);
            target.AddBuff(BuffID.Stoned, 600000);
            target.AddBuff(BuffID.BrokenArmor, 600000);
            target.AddBuff(BuffID.Bleeding, 60000);
            int xOff = Main.rand.Next(-250, 251);
            int a = Projectile.NewProjectile(projectile.Center.X + xOff, projectile.Center.Y - 600, -(xOff / (600 / 16)), 20f, ProjectileID.HallowStar, (int)(projectile.damage * .75f), 0, projectile.owner);
            Main.projectile[a].aiStyle = 1;
            Main.projectile[a].tileCollide = true;
            projectile.Kill();
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
            for (int k = 0; k < projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
                Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
                spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
            }
            return true;
        }
    }
}