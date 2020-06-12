using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Magic
{
    public class Beef : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beef :)");
            Tooltip.SetDefault("Beeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef");
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.magic = true;
            item.mana = 3;
            item.melee = false;
            item.width = 28;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("Beef");
            item.shootSpeed = 1f;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
        }
    }
}
