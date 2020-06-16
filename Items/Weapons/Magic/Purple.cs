using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Magic
{
    public class Purple : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple");
            Tooltip.SetDefault("Shoots some purple.");
        }

        public override void SetDefaults()
        {
            item.damage = 9; //was originally 24. I want some the DPS to be a bit higher than the Vilethorn
            item.magic = true;
            item.mana = 7; //Increased from 3 to 7
            item.melee = false;
            item.width = 28;
            item.height = 30;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.knockBack = 0.5f;
            item.value = 0;
            item.rare = 3;
            item.shoot = mod.ProjectileType("Purple");
            item.shootSpeed = 10f; //Was originally 25f. Lowered to 10f.
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
        }
    }
}
