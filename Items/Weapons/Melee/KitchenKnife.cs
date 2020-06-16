using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
    public class KitchenKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kitchen Knife");
            Tooltip.SetDefault("Just your average, everyday kitchen knife.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.melee = true;
            item.width = 52;
            item.height = 52;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 3;
            item.knockBack = 1;
            item.value = 0;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBar, 2);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenBar, 2);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
