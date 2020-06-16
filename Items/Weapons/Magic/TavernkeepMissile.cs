using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Magic
{
    public class TavernkeepMissile : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tavernkeep Missile");
            Tooltip.SetDefault("It's a bird! It's a plane! It's the Tavernkeep! \n No. \n It's god.");
            // Imagine being fisted by God;
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.magic = true;
            item.mana = 10;
            item.melee = false;
            item.width = 6;
            item.height = 6;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;
            item.knockBack = 0f;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("TavernkeepMissile");
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
        }
    }
}