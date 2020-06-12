using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Ammo
{
	public class Staple : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Staple");
		}

		public override void SetDefaults()
        {
            item.damage = 4;
            item.ranged = true;
            item.width = 9;
            item.height = 4;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2.5f;
            item.value = Item.buyPrice(0, 0, 0, 1);
            item.shootSpeed = 4f;
            item.ammo = item.type;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
