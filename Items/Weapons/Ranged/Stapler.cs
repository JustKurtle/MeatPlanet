using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Ranged
{
    public class Stapler : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stapler");
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
            item.shoot = mod.ProjectileType("Staple");
            item.useAmmo = mod.ItemType("Staple");
            item.UseSound = SoundID.Item11;
            item.damage = 20;
            item.shootSpeed = 10f;
            item.noMelee = true;
            item.value = 0;
            item.rare = 2;
            item.knockBack = 5f;
            item.ranged = true;
        }
    }
}