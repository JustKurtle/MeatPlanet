using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Ammo
{
    public class CopperShortsword : GlobalItem
    {
        public override void SetDefaults(Terraria.Item item)
        {
            if (item.type == ItemID.EmptyBucket)
            {
                item.ammo = ItemID.EmptyBucket;
                item.maxStack = 99;
                item.consumable = true;
            }
            if (item.type == ItemID.BottledHoney)
            {
                item.ammo = ItemID.BottledHoney;
                item.maxStack = 30;
                item.consumable = true;
            }
            if (item.type == ItemID.BeachBall)
            {
                item.ammo = ItemID.BeachBall;
                item.maxStack = 99;
                item.consumable = true;
            }
        }
    }
}

