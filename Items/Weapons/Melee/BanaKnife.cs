using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
  public class BanaKnife : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Bana-knife");
      Tooltip.SetDefault("Don't come to lunch tomorrow.");
    }
    
    public override void SetDefaults()
    {
      item.damage = 19;
      item.melee = true;
      item.width = 48;
      item.height = 52;
      item.useTime = 18;
      item.useAnimation = 18;
      item.crit = 0;
      item.useStyle = 3;
      item.knockBack = 15f;
      item.value = Item.sellPrice(0, 0, 1, 45);
      item.rare = 10;
      item.UseSound = SoundID.Item1;
      item.autoReuse = true;
    }

    public override void AddRecipes()
    {
      ModRecipe recipe = new ModRecipe(mod);
      recipe.AddIngredient(ItemID.JungleSpores, 10);
      recipe.AddTile(TileID.WorkBenches);
      recipe.SetResult(this);
      recipe.AddRecipe();
    }
	}
}
