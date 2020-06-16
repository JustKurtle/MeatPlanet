using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Ammo
{
	public class Lightbulb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightbulb");
		}

		public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 2);
            recipe.AddIngredient(ItemID.Glass, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 2);
            recipe.AddIngredient(ItemID.Glass, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}
