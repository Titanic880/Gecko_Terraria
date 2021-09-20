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
            CreateRecipe()
                .AddRecipeGroup("Geckos:TitAdam", 6)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}
