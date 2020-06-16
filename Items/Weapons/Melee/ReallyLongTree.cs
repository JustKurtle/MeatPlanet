using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
    public class ReallyLongTree : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("really really really really really really really really really really really really really really really really really really really really really long tree");
        }
        public override void SetDefaults()
        {
            item.damage = 5;
            item.melee = true;
            item.width = 76;
            item.height = 364;
            item.useTime = 100;
            item.useAnimation = 100;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
    }
}
