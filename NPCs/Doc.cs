using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.NPCs
{
	public class Doc : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Doc");
			Main.npcFrameCount[npc.type] = 14;
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 42;
			npc.aiStyle = 3;
			npc.damage = 75;
			npc.friendly = false;
			npc.dontTakeDamageFromHostiles = true;
			animationType = NPCID.Guide;
			aiType = NPCID.Zombie;
            npc.defense = 20;
            npc.lifeMax = 300;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
	        return SpawnCondition.SolarEclipse.Chance * 0.1f;
        }

        public override void NPCLoot()
        {
			if (Main.rand.Next(3) <= 1)
	        Item.NewItem(npc.getRect(), mod.ItemType("Switchblade"));
        }
    }
}