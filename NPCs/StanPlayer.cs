using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.NPCs
{
    public class StanPlayer : ModPlayer
    {
        public bool badatcomputer;

        public override void ResetEffects()
        {
            badatcomputer = false;
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if ((proj.minion || ProjectileID.Sets.MinionShot[proj.type]) && badatcomputer && !proj.noEnchantments)
            {
                target.AddBuff(BuffID.Frostburn, 60 * Main.rand.Next(5, 15), false);
            }
        }
    }
    // namespace Items.Armor
    // {
    // 	// Assigning multiple EquipType/Animation textures is easily done.
    // 	[AutoloadEquip(EquipType.Neck, EquipType.Balloon)]
    // 	internal class SimpleAccessory : ModItem
    // 	{
    // 		public override void SetDefaults() {
    // 			item.width = 34;
    // 			item.height = 34;
    // 			item.accessory = true;
    // 			item.value = 150000;
    // 			item.rare = 5;
    // 		}

    // 		public override void UpdateAccessory(Player player, bool hideVisual) {
    // 			// To assign the player the frostBurnSummon effect, we can't do player.frostBurnSummon = true because Player doesn't have frostBurnSummon. Be sure to remember to call the GetModPlayer method to retrieve the ModPlayer instance attached to the specified Player.
    // 			player.GetModPlayer<StanPlayer>().FrostBurnSummon = true;
    // 		}
    // 	}
    // }
}
