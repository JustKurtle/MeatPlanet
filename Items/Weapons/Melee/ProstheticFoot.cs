using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class ProstheticFoot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prosthetic Foot");
            Tooltip.SetDefault("This idea originated from a gun... don't ask.");
        }
        public override void SetDefaults()
        {
            item.damage = 55;
            item.melee = true;
            item.width = 34;
            item.height = 30;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 0;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}
