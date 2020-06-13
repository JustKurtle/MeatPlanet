using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Ranged
{
    public class Toaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toaster");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.crit = item.crit + 0;
            item.autoReuse = true;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 14;
            item.height = 11;
            item.shoot = mod.ProjectileType("Toast");
            item.useAmmo = mod.ItemType("Bread");
            item.UseSound = SoundID.Item11;
            item.damage = 18;
            item.shootSpeed = 10f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 2, 64, 0);
            item.rare = 5;
            item.knockBack = 5f;
            item.ranged = true;
        }
    }
}