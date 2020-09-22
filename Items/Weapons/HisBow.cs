using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace Gecko.Items.Weapons
{
    public class HisBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HIS bow");
            Tooltip.SetDefault("Once owned by the unspeakable Man...");
        }
        public override void SetDefaults()
        {
            item.damage = 6;
            item.width = 12;
            item.height = 24;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.value = 50;
            item.shoot = 1;
            item.rare = 2;

            item.knockBack = 0.5f;
            item.shootSpeed = 7.5f;
            
            item.melee = false;
            item.ranged = true;
            item.autoReuse = true;
            
            item.useAmmo = AmmoID.Arrow;
            item.UseSound = SoundID.Item5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 12);
            recipe.AddRecipeGroup("Geckos:CopTin", 12);
            recipe.AddRecipeGroup("Geckos:Bow", 1);

            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
