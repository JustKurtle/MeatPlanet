using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class ExterminatorGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Exterminator Greaves");
            Tooltip.SetDefault("Break into houses!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 10;
            item.defense = 30;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage *= 4f;
            player.thrownDamage *= 4f;
            player.rangedDamage *= 4f;
            player.magicDamage *= 4f;
            player.minionDamage *= 4f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 30);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}