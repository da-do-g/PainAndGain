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
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Sanctus"));  //the modded item that will be sold
                        nextSlot++;
                        //shop.item[nextSlot].SetDefaults(ItemID.LunarBar);    //this adds vanilla items, won't be used for now
                        //nextSlot++;
                    }
                    else
                    {    //This make that the npc will always sell this
                    }
                    if (Main.player[Main.myPlayer].ZoneJungle)//if the player is in jungle the npc will sell whis.  Change ZoneJungle with what zone you want: ZoneCorrupt for Corupption, ZoneCrimson for Crimson, ZoneDesert for Desert, ZoneDungeon for Dungeon, ZoneGlowshroom for Glowing Mushroom biome, ZoneHoly for The Hallow, ZoneJungle for Jungle, ZoneMeteor for Meteorite biome, ZoneSnow for Snow biome.
                    {
                    }

                    break;
            }
        }
    }
}
