using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
	public class Dong : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dong");
			Tooltip.SetDefault("This is a bell.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 35;
			item.crit = item.crit + 0;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 15f;
			item.value = Item.sellPrice(0, 1, 65, 0); //was originally 60 silver. Changed to 1 gold 65 silver.
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bell, 1);
            recipe.AddIngredient(ItemID.Wood, 10);
						recipe.AddIngredient(ItemID.PixieDust, 15); //Added Pixie Dust and Souls of Light so it's not so easy to get
						recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
