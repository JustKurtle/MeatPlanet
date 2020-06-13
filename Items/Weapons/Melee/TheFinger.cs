using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class TheFinger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Big Finger");
            Tooltip.SetDefault("Large frick you!");
        }

        public override void SetDefaults()
        {
            item.damage = 43;
            item.melee = true;
            item.autoReuse = false;
            item.width = 72;
            item.height = 72;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;
            item.knockBack = 15;
            item.value = Item.sellPrice(0, 3, 50, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
        }
    }
}
