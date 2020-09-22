using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class WoodenDrill : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wooden Drill");
            Tooltip.SetDefault("Its a drill made out of wood...");
        }
        public override void SetDefaults()
        {
            item.pick = 35;
            item.axe = 35;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            
            item.melee = false;
            item.ranged = false;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 20);

            recipe.AddTile(TileID.WorkBenches);
            recipe.AddTile(TileID.Sawmill);
            
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
