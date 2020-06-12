using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(1) <= 1)
            {
                if (npc.type == NPCID.Guide)
                {
                    Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"));
                }
            }
            if (Main.rand.Next(1) <= 1)
            {
                if (npc.type == NPCID.Merchant)
                {
                    Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"));
                }
            }
            if (Main.rand.Next(1) <= 1)
            {
                if (npc.type == NPCID.Nurse)
                {
                    Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"));
                }
            }
            if (Main.rand.Next(1) <= 1)
            {
                if (npc.type == NPCID.Demolitionist)
                {
                    Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"));
                }
            }
            if (Main.rand.Next(1) <= 1)
            {
                if (npc.type == NPCID.Guide)
                {
                    Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skin"));
                }
            }

            if (Main.expertMode)
            {
                if (Main.rand.Next(10000000) <= 6292018)
                {
                    if (npc.type == NPCID.BrainofCthulhu)
                    {
                        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodyToothBrush"));
                    }
                }
                if (Main.rand.Next(100) <= 4)
                {
                    if (npc.type == NPCID.Golem)
                    {
                        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CurtledMilk"));
                    }
                }
                if (Main.rand.Next(100) <= 4)
                {
                    if (npc.type == NPCID.DukeFishron)
                    {
                        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Dangtasm"));
                    }
                }
                if (Main.rand.Next(3) <= 1)
                {
                    if (npc.type == NPCID.DukeFishron)
                    {
                        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FireHydrantCannon"));
                    }
                }
                if (Main.rand.Next(2) <= 1)
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
                if (Main.rand.Next(20) <= 1)
                {
                    if (npc.type == NPCID.Lavabat)
                    {
                        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BatLauncher"));
                    }
                }
                if (Main.rand.Next(100) <= 1)
                {
                    if (npc.type == NPCID.Hellbat)
                    {
                        Terraria.Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BatLauncher"));
                    }
                }
            }
        }
    }
}
