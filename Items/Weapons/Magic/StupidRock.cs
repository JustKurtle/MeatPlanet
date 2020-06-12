using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Magic
{
    public class StupidRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stupid Rock");
            Tooltip.SetDefault("it are dumB");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.magic = true;
            item.mana = 1;
            item.melee = false;
            item.width = 6;
            item.height = 6;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;
            item.knockBack = 0f;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("StupidRock");
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
        }
    }
}
