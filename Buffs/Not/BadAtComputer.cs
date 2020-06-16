using WorldOfMeat.NPCs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Buffs.Not
{
    public class BadAtComputer : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("bad at computer. bad at computer!");
            Description.SetDefault("I AM NOT GOOD WITH COMPUTER");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.defense -= 1;
            npc.AddBuff(BuffID.Confused, 2, true);
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 1;
            player.AddBuff(BuffID.Confused, 60, true);
        }
    }
}