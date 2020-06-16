using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Ranged
{
    public class fop : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("fopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfopfop");
            Tooltip.SetDefault("I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John I am Rock John ");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.autoReuse = true;
            item.useAnimation = 12;
            item.useTime = 0;
            item.crit = item.crit + 1000;
            item.width = 20;
            item.height = 416;
            item.shoot = ProjectileID.BeeArrow;
            item.UseSound = SoundID.Item11;
            item.damage = 800;
            item.shootSpeed = 99999f;
            item.noMelee = true;
            item.value = 999999999;
            item.rare = 10;
            item.knockBack = 2000000f;
            item.ranged = true;
        }
    }
}
