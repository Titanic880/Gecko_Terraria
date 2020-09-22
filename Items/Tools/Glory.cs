using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class Glory : ModItem
    {
        public override void SetStaticDefaults()  //Sets the description of the item
        {
            DisplayName.SetDefault("True Glory");
            Tooltip.SetDefault("How did you....?");
        }
        public override void SetDefaults()  //sets default stats/information of the item
        {
            item.damage = 69;
            item.pick = 64;
            item.axe = 13;
            item.useTime = 18;
            item.useAnimation = 26;
            item.useStyle = 5;
            item.knockBack = 3f;
            item.crit = 30;
            
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.noUseGraphic = true;
            
            item.shoot = mod.ProjectileType("GloryProjectile");
            
            item.value = Item.buyPrice(0, 66, 66, 66);
            item.UseSound = SoundID.Item69;
            
        }
        public override void AddRecipes()  //Sets the recipe of the given item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SwordOfTerror", 1);
            recipe.AddIngredient(mod, "GoldenYoyo", 1);
            recipe.AddIngredient(mod, "PickaxeOfTheFallen", 1);
            recipe.AddIngredient(mod, "YoyoOfDestiny", 1);
            recipe.AddIngredient(mod, "AxeOfFailure", 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
