// yeet
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using PainAndGain.Items.Accessories;

namespace PainAndGain.Items.Accessories
{
    public class SuperCrown : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It shimmers with a kind energy");
            DisplayName.SetDefault("Super Crown");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = 20000;
            item.rare = 4;
            item.accessory = true;
            item.defense = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            {
                player.male = false; //may break some stuff, not entirely sure
                player.GetModPlayer<MyPlayer>(mod).SuperCrown = true;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(264, 1); //golden crown
            recipe.AddIngredient(501, 20); //pixie dust
            recipe.AddIngredient(526, 2); //unicorn horn
            recipe.AddIngredient(2756, 1); //gender change potion
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
