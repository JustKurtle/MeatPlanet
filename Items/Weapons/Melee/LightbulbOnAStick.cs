using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
	public class LightbulbOnAStick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightbulb On a Stick");
			Tooltip.SetDefault("It's a modern torch!");
		}

		public override void SetDefaults()
		{
			item.damage = 23;
			item.crit = item.crit + 0;
            item.magic = true;
            item.mana = 15;
			item.melee = false;
			item.width = 10;
			item.height = 20;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.sellPrice(0, 0, 55, 0);
			item.rare = 3;
            item.shoot = 126;
            item.shootSpeed = 20f;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Lightbulb"), 1);
            recipe.AddIngredient(mod.ItemType("RefinedStick"), 1);
			recipe.AddIngredient(mod.ItemType("DuctTape"), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
