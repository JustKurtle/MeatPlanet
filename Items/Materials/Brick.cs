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
      item.height = 10;
      item.value = Item.sellPrice(0, 0, 0, 10); // gave it a sell proice and fixed the hitbox
      item.rare = 0; //? could we make this rainbow, i think it would be pretty funny
      item.maxStack = 999;
    }
    public override void AddRecipes()
    {
      ModRecipe recipe = new ModRecipe(mod);
      recipe.AddIngredient(ItemID.ClayBlock, 1);
      recipe.AddTile(TileID.WorkBenches);
      recipe.SetResult(this, 4); // set output to 4 bricks
      recipe.AddRecipe();
    }
  }
}
