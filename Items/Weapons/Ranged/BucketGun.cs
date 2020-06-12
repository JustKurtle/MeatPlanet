using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Ranged
{
    public class BucketGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bucket Gun ");
            Tooltip.SetDefault("Shoots Buckets. Blame Dang. \nThis item is currently unobtainable. Have fun with this ridiculous thing!");
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
            item.shoot = mod.ProjectileType("SmartBucket");
            item.useAmmo = ItemID.EmptyBucket;
            item.UseSound = SoundID.Item11;
            item.damage = 40;
            item.shootSpeed = 10f;
            item.noMelee = true;
            item.value = 0;
            item.rare = 5;
            item.knockBack = 300000f;
            item.ranged = true;
        }
    }
}