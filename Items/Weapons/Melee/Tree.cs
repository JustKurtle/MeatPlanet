using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Melee
{
    class Tree : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree");
            Tooltip.SetDefault("Ever wanted to hit something with a tree?");
        }

        public override void SetDefaults()
        {
            item.damage = 57;
            item.crit = item.crit + 0;
            item.melee = true;
            item.width = 72;
            item.height = 72;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;
            item.knockBack = 20;
            item.value = Item.sellPrice(0, 4, 50, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Acorn, 99);
            recipe.AddIngredient(ItemID.Wood, 90);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
