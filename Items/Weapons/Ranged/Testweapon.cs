using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Ranged
{
    public class Testweapon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Weapon");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.autoReuse = true;
            item.useAnimation = 46;
            item.useTime = 46;
            item.width = 68;
            item.height = 36;
            item.shoot = 517;
            item.UseSound = SoundID.Item11;
            item.damage = 27;
            item.shootSpeed = 12f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 3;
            item.knockBack = 5f;
            item.ranged = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 50;
            float rotation = MathHelper.ToRadians(15);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeesKnees, 1);
            recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
