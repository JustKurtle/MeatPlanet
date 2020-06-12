using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Melee
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
            item.damage = 14;
            item.melee = true;
            item.width = 32;
            item.height = 30;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 3;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = -12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}
