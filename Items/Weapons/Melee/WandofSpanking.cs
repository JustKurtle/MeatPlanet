using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
    public class WandofSpanking : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wand of Spanking");
            Tooltip.SetDefault("Please don't tell me that I'm the only person that has made this mistake before.");
        }

        public override void SetDefaults()
        {
            item.damage = 37; //Reduced to 37 from 50. Once you get the Slap Hand, there's nothing making this hard to get.
            item.crit = item.crit + 0;
            item.melee = true; //Is there a way we can make this cost mana to use, like the Wand of Sparking?
            item.width = 58;
            item.height = 62;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 1;
            item.knockBack = 21;
            item.value = Item.sellPrice(0, 5, 0, 9);
            item.rare = 4;
            item.shoot = ProjectileID.Spark;
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking, 1);
            recipe.AddIngredient(ItemID.SlapHand, 1);
            recipe.AddIngredient(mod.ItemType("DuctTape"), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
