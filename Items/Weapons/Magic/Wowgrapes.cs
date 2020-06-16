using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Magic
{
    public class Wowgrapes : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wowgrapes");
            Tooltip.SetDefault("Wowgrapes");
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
            item.shoot = mod.ProjectileType("Wowgrape");
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
        }
    }
}
