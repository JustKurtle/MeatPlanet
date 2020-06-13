using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Magic
{
    public class FireHydrantCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Hydrant Cannon");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.magic = true;
            item.mana = 26;
            item.autoReuse = false;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 68;
            item.height = 36;
            item.shoot = mod.ProjectileType("FireHydrant");
            item.UseSound = SoundID.Item67;
            item.damage = 75;
            item.shootSpeed = 24f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 6, 0, 0);
            item.rare = -12;
            item.knockBack = 9;
            item.ranged = true;
        }
    }
}
