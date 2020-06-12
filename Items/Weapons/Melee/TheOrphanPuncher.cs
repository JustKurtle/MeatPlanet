using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Melee
{
    class TheOrphanPuncher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Orphan Puncher");
            Tooltip.SetDefault("The ultimate instrument for punching orphans.");
        }

        public override void SetDefaults()
        {
            item.damage = 84;
            item.crit = item.crit + 0;
            item.melee = true;
            item.width = 72;
            item.height = 72;
            item.useTime = 29;
            item.useAnimation = 29;
            item.useStyle = 1;
            item.knockBack = 22;
            item.value = Item.sellPrice(0, 4, 50, 0);
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ZombieArm);
            recipe.AddIngredient(ItemID.KOCannon);
            recipe.AddIngredient(ItemID.GolemFist);
            recipe.AddIngredient(ItemID.SlapHand, 1);
            recipe.AddIngredient(mod.ItemType("Boi"), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
