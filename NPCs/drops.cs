using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.NPCs
{
  public class ModGlobalNPC : GlobalNPC
  {
    public override void NPCLoot(NPC npc)
    {
      if (npc.type == NPCID.Guide ||
          npc.type == NPCID.Merchant ||
          npc.type == NPCID.Demolitionist ||
          npc.type == NPCID.Guide)
      {
        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"));
      }

      if (Main.expertMode)
      {
        if (Main.rand.Next(10) <= 6/29/18)
        {
          if (npc.type == NPCID.BrainofCthulhu)
          {
            Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodyToothBrush"));
          }
        }
        if (Main.rand.Next(4) <= 1)
        {
          if (npc.type == NPCID.WallofFlesh)
          {
            Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheFinger"));
          }
        }
        if (Main.rand.Next(3) <= 1)
        {
          if (npc.type == NPCID.KingSlime)
          {
            Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Toaster"));
          }
        }
      }

      if (Main.hardMode)
      {
        if ((Main.rand.Next(20) <= 1 && npc.type == NPCID.Lavabat) ||
            (Main.rand.Next(100) <= 1 && npc.type == NPCID.Hellbat))
        {
          Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BatLauncher"));
        }
      }
    }
  }
}
