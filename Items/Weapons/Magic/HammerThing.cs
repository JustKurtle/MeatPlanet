using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Magic
{
    public class HammerThing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hammer Thing");
            Tooltip.SetDefault("It's a hammer thing.");
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.magic = true;
            item.mana = 3;
            item.melee = false;
            item.width = 28;
            item.height = 30;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("MagicHammer");
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item67;
            item.autoReuse = true;
        }
    }
}