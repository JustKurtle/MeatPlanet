using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Placeable
{
    internal class TavernkeepLamp : ModItem
    {
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 99;
            item.consumable = true;
            item.createTile = mod.TileType("TavernkeepLamp");
            item.width = 10;
            item.height = 24;
            item.value = 500;
        }
    }
}