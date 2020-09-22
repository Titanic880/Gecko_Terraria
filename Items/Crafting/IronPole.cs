using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace Gecko.Items.Crafting
{
    public class IronPole : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Metal Pole");
            Tooltip.SetDefault("Rudementary Metal Pole");
            Tooltip.SetDefault("Crafting Material");
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Geckos:TitAdam", 6);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
