using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Ammo
{
    public class Bat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bat");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 52;
            item.height = 52;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 3f;
            item.value = 0;
            item.shootSpeed = 3.5f;
            item.ammo = item.type;
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RefinedStick"), 1);
            recipe.AddTile(TileID.SharpeningStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }   
    }
}