using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class TheTube : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Tube");
            Tooltip.SetDefault("You can't tell that it's a tube, but, I assure you, it is.");
        }
        public override void SetDefaults()
        {
            item.damage = 55;
            item.melee = true;
            item.width = 34;
            item.height = 30;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 0;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
