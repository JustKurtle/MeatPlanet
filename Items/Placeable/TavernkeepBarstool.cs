using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Placeable
{
    public class TavernkeepBarstool : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Normal chair.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("TavernkeepBarstool");
        }
    }
}