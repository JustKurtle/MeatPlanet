using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Magic
{
    public class MushroomGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MushroomGunMushroomGunMushroomGun");
            Tooltip.SetDefault("MASHROOOOOOOOOM");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.crit = item.crit + 0;
            item.magic = true;
            item.mana = 5;
            item.melee = false;
            item.width = 10;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = Item.buyPrice(0, 70, 0, 0);
            item.rare = 3;
            item.shoot = mod.ProjectileType("Mushroom");
            item.shootSpeed = 20f;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
        }
    }
}
