using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
    public class YoyoOfDestiny : ModItem
    {
        public override void SetStaticDefaults() //Sets the description of the item
        {
            DisplayName.SetDefault("Yoyo of Destiny");
                Tooltip.SetDefault("It is Your Destiny...");
        }
        public override void SetDefaults()  //sets default stats/information of the item
        {
            item.damage = 20;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.knockBack = 2f;
            item.crit = 10;
            item.rare = 3;
            
            item.melee = true;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = false;
            
            item.shoot = mod.ProjectileType("YoyoOfDestinyProjectile");
            
            item.value = Item.buyPrice(0, 20, 25, 0);
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()  //Sets the recipe of the given item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 12);
            recipe.AddRecipeGroup("Geckos:CopTin", 12);
            recipe.AddRecipeGroup("Geckos:Yoyo", 1);
            
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
