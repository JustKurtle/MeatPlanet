using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Ranged
{
    public class OPBucketGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Overpowered Bucket Gun");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.autoReuse = true;
            item.useAnimation = 3;
            item.useTime = 3;
            item.crit = item.crit + 100;
            item.width = 68;
            item.height = 36;
            item.shoot = mod.ProjectileType("StupidBucket");
            item.useAmmo = ItemID.EmptyBucket;
            item.UseSound = SoundID.Item11;
            item.damage = 500;
            item.shootSpeed = 99999f;
            item.noMelee = true;
            item.value = 0;
            item.rare = 10;
            item.knockBack = 300000f;
            item.ranged = true;
        }
    }
}
