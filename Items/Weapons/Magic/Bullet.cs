using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Magic
{
    public class Bullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bullet");
            Tooltip.SetDefault("I assure you, this is normal.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.magic = true;
            item.mana = 5;
            item.melee = false;
            item.width = 12;
            item.height = 12;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.knockBack = 2.5f;
            item.value = Item.buyPrice(0, 1, 75, 0); //Added 75 silver
            item.rare = 2;
            item.shoot = mod.ProjectileType("Handgun");
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
        }
    }
}
