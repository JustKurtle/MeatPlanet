using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Materials
{
    public class RefinedStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Refined Stick");
            Tooltip.SetDefault("A refined stick. Some may call it a rod.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 0;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Stick"), 1);
            recipe.AddTile(TileID.SharpeningStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
