using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.NPCs
{
    public class Botto : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Botto");
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 1500;
            npc.damage = 150;
            npc.defense = 50;
            npc.knockBackResist = -100;
            npc.width = 26;
            npc.height = 56;
            npc.aiStyle = 3;
            npc.noGravity = false;
            npc.friendly = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = Item.buyPrice(0, 0, 15, 0);
            banner = npc.type;
            bannerItem = mod.ItemType("BottoBanner");
        }

        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            if (Main.rand.NextBool(3))
            {
                player.AddBuff(mod.BuffType("badatcomputer"), 600, false);
            }
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(50) <= 1)
                Item.NewItem(npc.getRect(), ItemID.Sunglasses);
        }
    }
}