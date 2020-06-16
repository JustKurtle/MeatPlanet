using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Ammo
{
    public class LagArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lag Arrow");
            Tooltip.SetDefault("My ping is 28346.");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.ranged = true;
            item.width = 28;
            item.height = 23;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2.5f;
            item.value = Item.buyPrice(0, 0, 0, 10);
            item.shootSpeed = .0004f;
            item.ammo = AmmoID.Arrow;
        }
    }
}