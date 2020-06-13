using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Magic
{
    public class PeopleShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("People Shooter"); //Plantera drop?
            Tooltip.SetDefault("It shoots people, duh.");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.magic = true;
            item.crit = item.crit + 0;
            item.autoReuse = true;
            item.useAnimation = 36;
            item.useTime = 36;
            item.width = 68;
            item.height = 36;
            item.shoot = mod.ProjectileType("People");
            item.mana = 5;
            item.UseSound = SoundID.Item11; //Make Roblox death noise?
            item.damage = 55;
            item.shootSpeed = 15f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 5;
            item.knockBack = 4f;
        }
    }
}