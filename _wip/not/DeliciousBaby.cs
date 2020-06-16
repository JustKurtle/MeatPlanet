using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Magic
{
    public class DeliciousBaby : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Delicious Baby");
            Tooltip.SetDefault("This is a delicious baby. There is nothing else to explain. \nThis item is currently unobtainable. Have fun!");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.crit = item.crit + 0;
            item.magic = true;
            item.mana = 14;
            item.width = 30;
            item.height = 18;
            item.useTime = 35;
            item.useAnimation = 35;
            item.consumable = true;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 0;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}
