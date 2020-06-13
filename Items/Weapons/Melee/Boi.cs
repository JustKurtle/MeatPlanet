using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Weapons.Melee
{
    public class Boi : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BOI");
            Tooltip.SetDefault("*inhale*");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.autoReuse = false;
            item.width = 48;
            item.height = 44;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.scale = 1.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SkeletronHand);
            recipe.AddIngredient(mod.ItemType("Skin"), 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
