using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
  public class NotTheBees : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Not the Bees");
      Tooltip.SetDefault("Holy fucking shit."); // i like this one better
    }

    public override void SetDefaults()
    {
      item.width = 31;
      item.height = 31; // set the scale to 2x so it looks the correct size
      item.scale = 2;

      item.damage = 17;
      item.melee = true;
      item.useTime = 24; // upped use time so it is more on point with the BreakerBlade, haven't tested it yet
      item.useAnimation = 24;
      item.useStyle = 1;
      item.knockBack = 7;
      item.UseSound = SoundID.Item1;
      item.autoReuse = true;
      item.shoot = ProjectileID.BeeArrow;
      item.shootSpeed = 14f; // the arrows were incredibly slow upped from 1f

      item.value = Item.sellPrice(0, 6, 0, 0);
      item.rare = 4;
    }

    public override void AddRecipes()
    {
      ModRecipe recipe = new ModRecipe(mod);
      recipe.AddIngredient(ItemID.BreakerBlade, 1);
      recipe.AddIngredient(ItemID.BeeKeeper, 1);
      recipe.AddTile(TileID.TinkerersWorkbench);
      recipe.SetResult(this);
      recipe.AddRecipe();
    }
  }
}
