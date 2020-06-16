using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
    public class SharpPizza : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharp Pizza");
            Tooltip.SetDefault("Pretty cool, huh?");
        }
        public override void SetDefaults()
        {
            item.damage = 28; //Increased to 28 from 17. I want this to rival the Bloody Toothbrush
            item.melee = true;
            item.width = 52;
            item.height = 50;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 3;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 1, 17, 0); //Was originally 1 gold 50 silver. Should match the price of the toothbrush, so I have changed it so.
            item.rare = -12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
    }
}
