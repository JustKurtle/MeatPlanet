using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class ExterminatorHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Exterminator Helmet");
            Tooltip.SetDefault("Break into houses!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 10;
            item.defense = 25;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage *= 3f;
            player.thrownDamage *= 3f;
            player.rangedDamage *= 3f;
            player.magicDamage *= 3f;
            player.minionDamage *= 3f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}