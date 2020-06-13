using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    class BigTree : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Tree");
            Tooltip.SetDefault("This time the tree chops back!\nThis item is currently unobtainable. Have fun!");
        }

        public override void SetDefaults()
        {
            item.damage = 888;
            item.melee = true;
            item.width = 98;
            item.height = 98;
            item.useTime = 45;
            item.useAnimation = 9;
            item.useStyle = 1;
            item.knockBack = 12;
            item.value = 0;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}
