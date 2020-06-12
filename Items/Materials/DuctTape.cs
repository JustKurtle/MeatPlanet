using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Materials
{
	public class DuctTape : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duct Tape");
		}

		public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 3, 0);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddIngredient(ItemID.PinkGel, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
