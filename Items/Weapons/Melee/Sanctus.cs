using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PainAndGain.Items.Weapons.Melee
{
    public class Sanctus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanctus");
            Tooltip.SetDefault("The sword of the very first Crusader\nIt pulses with a [c/4AEEFF:radiant ]energy..."); //self explanatory, use n\ for new lines
        }
        
        public override void SetDefaults()
        {
            item.damage = 45;                   //(placeholder) base damage
            item.melee = true;                  //melee or no
            item.width = 94;                    //hitbox width
            item.height = 92;                   //hitbox height
            item.useTime = 40;                  //(placeholder) speed weapon is used
            item.useAnimation = 40;             //(placeholder) speed of animation of weapon
            item.useStyle = 1;                  //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 9;                 //(placeholder) knockback of weapon. 20 maximum
            item.value = 100000;                // weapon value, might be wrong code
            item.rare = 3;                      //item rarity -1 to 3 = prehardmode, 4 to 11 = hardmode, 12 = expert, 13 = quest
            item.UseSound = SoundID.Item1;      //item use sound. i dont know them all but 1 is definitely a sword
            item.autoReuse = false;              //autoswing or no
	    item.shoot = mod.ProjectileType("HolyBubble");
	    item.shootSpeed = 1.75f
        }
        
        
        /*public override void MeleeEffects(Player player, Rectangle hitbox)
	{
		if (Main.rand.Next(3) == 0)
		{
			//Emit dusts when swing the sword
			Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));  //VERY IMPORTANT TO CHANGE. NOT AN ACTUAL DUST TYPE, BUT WILL BE ADDED IN THE FUTURE.
		}
	}*/
    }
}
