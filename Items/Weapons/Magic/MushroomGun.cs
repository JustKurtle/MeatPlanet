using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Magic
{
    public class MushroomGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MushroomMushroomMushroomMushroom");
            Tooltip.SetDefault("MASHROOOOOOOOOM");
        }

        public override void SetDefaults()
        {
            item.damage = 23; //Changed from 45 to 23. I want post-Plantera DPS levels. Probably make it have less DPS than the Nettle Burst
            item.crit = item.crit + 0;
            item.magic = true;
            item.mana = 3; //Changed from 5 to 3
            item.melee = false;
            item.width = 10;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = Item.buyPrice(0, 70, 0, 0); //WHY IS IT 70 GOLD?!
            item.rare = 3;
            item.shoot = mod.ProjectileType("Mushroom");
            item.shootSpeed = 20f;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
        }
    }
}
