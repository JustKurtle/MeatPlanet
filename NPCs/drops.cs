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
        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"), Main.rand.Next(2)+1);
      }

      if (Main.expertMode)
      {
        if (Main.rand.Next(10) <= 6/29/18 && npc.type == NPCID.BrainofCthulhu)
        {
          Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodyToothBrush"));
        }
        if (Main.rand.Next(4) <= 1 && npc.type == NPCID.WallofFlesh)
        {
          Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheFinger"));
        }
        if (Main.rand.Next(3) <= 1 && npc.type == NPCID.KingSlime)
        {
          Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Toaster"));
        }
      }

      if (Main.hardMode) //.5% from prehardmode bats, 1% from hardmode bats, 2% from lava bats and vampires
      {
        if ((Main.rand.Next(200) <= 1 && (npc.type == NPCID.Hellbat ||
                                          npc.type == NPCID.CaveBat ||
                                          npc.type == NPCID.IlluminantBat ||
                                          npc.type == NPCID.IceBat ||
                                          npc.type == NPCID.JungleBat)) ||
            (Main.rand.Next(100) <= 1 && npc.type == NPCID.GiantBat) ||
            (Main.rand.Next(50) <= 1 && (npc.type == NPCID.Lavabat ||
                                         npc.type == NPCID.Vampire)))
        {
          Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BatLauncher"));
        }
      }
    }
  }
}
