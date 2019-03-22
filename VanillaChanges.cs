using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PainAndGain
{
    public class VanillaChanges : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Dryad:  //change Dryad whith what NPC you want

                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("BowName"));  //this is an example of how to add your item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.LunarBar);    //this is an example of how to add a terraria item
                        nextSlot++;
                    }
                    else
                    {    //This make that the npc will always sell this
                        shop.item[nextSlot].SetDefaults(mod.ItemType("DualUseWeapon"));   //this is an example of how to add your item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("ItemName"));   //this is an example of how to add your item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.IvyWhip);     //this is an example of how to add a terraria item
                        nextSlot++;
                    }
                    if (Main.player[Main.myPlayer].ZoneJungle)//if the player is in jungle the npc will sell whis.  Change ZoneJungle with what zone you want: ZoneCorrupt for Corupption, ZoneCrimson for Crimson, ZoneDesert for Desert, ZoneDungeon for Dungeon, ZoneGlowshroom for Glowing Mushroom biome, ZoneHoly for The Hallow, ZoneJungle for Jungle, ZoneMeteor for Meteorite biome, ZoneSnow for Snow biome.
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.Abeemination); //this is an example of how to add a terraria item
                        nextSlot++;
                    }

                    break;
            }
        }
    }
}
