using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PainAndGain.Items.Weapons.Melee
{
    public class Sanctus : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The sword of the very first Paladin\nIt pulses with a strange energy..."); //self explanatory, use n\ for new lines
        }
        
        public override void SetDefaults()
        {
            item.name = "Sanctus";              //display name
            item.damage = 50;                   //(placeholder) base damage
            item.melee = true;                  //melee or no
            item.width = 94;                    //hitbox width
            item.height = 92;                   //hitbox height
            item.useTime = 20;                  //(placeholder) speed weapon is used
            item.useAnimation = 20;             //(placeholder) speed of animation of weapon
            item.useStyle = 1;                  //style of use
            item.knockBack = 6;                 //(placeholder) knockback of weapon
            item.value = Item.buyPrice(0, 0, 10, 0) //cost of weapon
            item.rare = 3                       //item rarity -1 to 3 = prehardmode, 4 to 11 = hardmode
            item.UseSound = SoundID.Item1;      //item use sound
            item.autoReuse = true;              //autoswing or no
        }
    }
}
