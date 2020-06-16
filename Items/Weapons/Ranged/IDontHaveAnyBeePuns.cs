using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Ranged
{
  public class IDontHaveAnyBeePuns : ModItem
  {
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("I Don't Have Any Bee Puns");
    }
    public override void SetDefaults()
    {
      item.useStyle = 5;
      item.autoReuse = true;
      item.useAnimation = 46;
      item.useTime = 46;
      item.width = 68;
      item.height = 36;
      item.shoot = 1;
      item.useAmmo = AmmoID.Arrow;
      item.UseSound = SoundID.Item11;
      item.damage = 27;
      item.shootSpeed = 12f;
      item.noMelee = true;
      item.value = Item.sellPrice(0, 4, 25, 0);
      item.rare = 3;
      item.knockBack = 5f;
      item.ranged = true;
    }

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
      Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
      Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BeeArrow, damage, knockBack, player.whoAmI);
      return true;
    }

    public override void AddRecipes()
    {
      ModRecipe recipe = new ModRecipe(mod);
      recipe.AddIngredient(ItemID.BeesKnees, 1);
      recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
      recipe.AddTile(TileID.MythrilAnvil);
      recipe.SetResult(this);
      recipe.AddRecipe();
    }
  }
}
