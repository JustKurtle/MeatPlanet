using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Melee
{
    public class GiantEvilSpoon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Giant Evil Spoon");
            Tooltip.SetDefault("Dear, God! The horror!");
        }

        public override void SetDefaults()
        {
            item.damage = 58;
            item.melee = true;
            item.autoReuse = false;
            item.width = 90;
            item.height = 90;
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
        }
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(100, 1000);
		
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
