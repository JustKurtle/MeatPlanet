using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Magic
{
    public class Purple : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple");
            Tooltip.SetDefault("Shoots some purple.");
        }

        public override void SetDefaults()
        {
            item.damage = 24;
            item.magic = true;
            item.mana = 3;
            item.melee = false;
            item.width = 28;
            item.height = 30;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.knockBack = 0.5f;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("Purple");
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
        }
    }
}
