using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
    public class Octagon : ModItem
    {
        public override void SetStaticDefaults()  //Sets the description of the Item
        {
            DisplayName.SetDefault("Octagon");
            Tooltip.SetDefault("8 Fantastic Sides");
            
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Crafting.SignShard>(8)
                .AddRecipeGroup("IronBar", 4)
                .AddTile(TileID.AdamantiteForge)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
