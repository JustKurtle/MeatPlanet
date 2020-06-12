using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Melee
{
    public class GiantGoodFork : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Giant Good Fork");
            Tooltip.SetDefault("Possibly the one and only hope left for the world.");
        }

        public override void SetDefaults()
        {
            item.damage = 55;
            item.melee = true;
            item.autoReuse = false;
            item.width = 90;
            item.height = 90;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 20);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 20);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
