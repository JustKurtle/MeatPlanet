using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MeatPlanet.NPCs
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
<<<<<<< HEAD
                    break;
=======
>>>>>>> 38f38c3283779591317eaacb1b805a9c9328d2a0

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
}