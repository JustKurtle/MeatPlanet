using Terraria.ModLoader;

namespace WorldOfMeat.Items.Placeable
{
    public class TestWall : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 7;
            item.useStyle = 1;
            item.consumable = true;
            item.createWall = mod.WallType("TestWall");
        }
    }
}