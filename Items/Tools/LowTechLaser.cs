using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class LowTechLaser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Low Tech Laser");
            Tooltip.SetDefault("What did you expect?");
        }
        public override void SetDefaults()
        {
            item.pick = 55;
            item.axe = 11;
            item.width = 14;
            item.height = 14;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;

            item.melee = true;
            item.ranged = false;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.ManaCrystal, 2);
            //recipe.AddRecipeGroup("IronBar", 12);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
