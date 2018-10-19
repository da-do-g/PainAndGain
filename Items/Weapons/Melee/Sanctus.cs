using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PainAndGain.Items.Weapons.Melee
{
    public class Sanctus : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The sword of the very first Paladin\nIt pulses with a strange energy...");
        }
        
        public override void SetDefaults()
        {
            item.name = "Sanctus";              //display name
            item.damage = 50;                   //(placeholder) base damage
            item.melee = true;                  //melee or no
            item.width = 94;                    //hitbox width
            item.height = 92;                   //hitbox height
            item.tooltip = "";                  //self explanatory
            item.useTime = 20;                  //(placeholder) speed weapon is used
            item.useAnimation = 20;             //(placeholder) speed of animation of weapon
            item.useStyle = 1;                  //style of use
            item.knockBack = 6;                 //(placeholder) knockback of weapon
            item.value = Item.buyPrice(0, 0, 10, 0) //cost of weapon
            item.rare = 
        }
    }
}
