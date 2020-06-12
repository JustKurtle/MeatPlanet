using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Placeable
{
    public class TavernkeepBed : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's fine, he should still be alive.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 2000;
            item.createTile = mod.TileType("TavernkeepBed");
        }
    }
}