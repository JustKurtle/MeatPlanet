using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class BloodyToothbrush : ModItem
    {
       //Brain-drop 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Toothbrush");
            Tooltip.SetDefault("Probably used by the Mouth of Cthulhu.");
        }
        public override void SetDefaults()
        {
            item.damage = 6; //Lowered to 6 from 14. I wan't ~100 DPS
            item.melee = true;
            item.width = 32;
            item.height = 30;
            item.useTime = 7; //Raised to 7 from 5
            item.useAnimation = 7; //Raised from 5 to 7 to match above.
            item.useStyle = 3;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 1, 17, 0); //Was originally 1 gold 50 silver. Fuck 50 silver. I want 17.
            item.rare = -12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}
