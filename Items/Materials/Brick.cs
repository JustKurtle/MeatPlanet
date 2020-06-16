using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Materials
{
	public class Brick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brick");
            Tooltip.SetDefault("It's fun.");
		}
		public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 0;
            item.rare = 0;
            item.maxStack = 999;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClayBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}
