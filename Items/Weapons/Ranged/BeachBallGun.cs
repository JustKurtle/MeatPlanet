using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Ranged
{
    public class BeachBallGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beach Ball Gun");
            Tooltip.SetDefault("Probably the dumbest thing I've ever made.\nWARNING: Do not aim at eyes. \nThis item is currently unobtainable. Have fun with this ridiculous thing!");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.autoReuse = true;
            item.useAnimation = 5;
            item.useTime = 5;
            item.width = 28;
            item.height = 11;
            item.shoot = ProjectileID.BeachBall;
            item.useAmmo = ItemID.BeachBall;
            item.UseSound = SoundID.Item11;
            item.shootSpeed = 24f;
            item.noMelee = true;
            item.value = Item.buyPrice(0, 5, 0, 0); //Buy price is five times higher than sell price. Bought for five gold, sold for one.
            item.rare = 1;
        }
    }
}
