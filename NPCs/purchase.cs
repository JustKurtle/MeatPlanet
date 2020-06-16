using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.NPCs
{
  public class VanillaNPCShop : GlobalNPC
  {
    public override void SetupShop(int type, Chest shop, ref int nextSlot)
    {
      switch (type)
      {
        case NPCID.PartyGirl:

          if (Main.hardMode)
          {
              shop.item[nextSlot].SetDefaults(mod.ItemType("BeachBallGun"));
              nextSlot++;
          }
          else
          {
              shop.item[nextSlot].SetDefaults(mod.ItemType("BeachBallGun"));
              nextSlot++;
          }
          break;

        case NPCID.Merchant:
          if (Main.hardMode)
          {
              shop.item[nextSlot].SetDefaults(mod.ItemType("Bread"));
              nextSlot++;
          }
          else
          {
              shop.item[nextSlot].SetDefaults(mod.ItemType("Bread"));
              nextSlot++;
          }
          break;
      }
    }
  }
}
