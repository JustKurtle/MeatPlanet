using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class WeaponizedDoor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Weaponized Door");
            Tooltip.SetDefault("You really don't need some sort of special door to use as a weapon. \n This is just a normal door, but you've gone and chosen that you're going to hit people with it. \n It's not different at all.");
        }
        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 28;
            item.height = 48;
            item.useTime = 11;
            item.useAnimation = 11;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
    }
}
