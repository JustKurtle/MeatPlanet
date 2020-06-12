using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Ranged
{
    public class Lamp : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lamp");
        }

        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.crit = item.crit + 0;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.width = 14;
            item.height = 11;
            item.shoot = mod.ProjectileType("Lightbulb");
            item.useAmmo = mod.ItemType("Lightbulb");
            item.UseSound = SoundID.Item11;
            item.damage = 27;
            item.shootSpeed = 15f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 55, 0);
            item.rare = 3;
            item.knockBack = 2f;
            item.ranged = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Lightbulb"), 1);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
