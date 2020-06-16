using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Materials
{
    public class Stick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stick");
            Tooltip.SetDefault("This is stick. That is all.");
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
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
