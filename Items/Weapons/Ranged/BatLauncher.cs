using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Ranged
{
    public class BatLauncher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bat Launcher");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.autoReuse = true;
            item.useAnimation = 33;
            item.useTime = 33;
            item.width = 68;
            item.height = 36;
            item.shoot = mod.ProjectileType("Bat");
            item.useAmmo = mod.ItemType("Bat");
            item.UseSound = SoundID.Item11;
            item.damage = 50;
            item.shootSpeed = 24f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 5;
            item.knockBack = 9;
            item.ranged = true;
        }
    }
}
