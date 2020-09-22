using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
    public class Octagon : ModItem
    {
        public override void SetStaticDefaults()  //Sets the description of the item
        {
            DisplayName.SetDefault("Octagon");
            Tooltip.SetDefault("8 Fantastic Sides");
            
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 4);
            recipe.AddIngredient(mod, "SignShard", 8);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
