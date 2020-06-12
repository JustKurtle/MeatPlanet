using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Melee
{
    public class BButtonBloodType : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("B Button Blood Type");
        }
        public override void SetDefaults()
        {
            item.damage = 17;
            item.melee = true;
            item.width = 52;
            item.height = 50;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 3;
            item.knockBack = 6;
            item.value = 0;
            item.rare = -12;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BButtonBloodType");
            item.autoReuse = false;
        }
    }
}
