using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Ammo
{
    public class Bread : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bread");
            Tooltip.SetDefault("Operah loves it!");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 28;
            item.height = 23;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2.5f;
            item.value = Item.buyPrice(0, 0, 0, 10);
            item.shootSpeed = 4f;
            item.ammo = item.type;
        }
    }
}