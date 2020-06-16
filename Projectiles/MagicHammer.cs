using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace WorldOfMeat.Projectiles
{
    public class MagicHammer : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hammer");
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
            projectile.magic = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.alpha = (int)byte.MaxValue;
            projectile.light = 2;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
        }
    }
}