using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Gecko.Items.Tools
{
    public class PickaxeOfTheFallen : ModItem
    {
        public override void SetStaticDefaults() //Sets the description of the item
        {
            DisplayName.SetDefault("Pickaxe of the Fallen");
            Tooltip.SetDefault("The pick of a Fallen Hero");
        }
        public override void SetDefaults() //sets default stats/information of the item
        {
            item.damage = 9;
            item.pick = 64;
            item.width = 40;
            item.height = 40;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 6;
            item.rare = 3;
            item.melee = true;
            item.channel = true;
            item.autoReuse = true;
            item.value = Item.buyPrice(0, 20, 0, 0);
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes() //Sets the recipe of the given item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 12);
            recipe.AddRecipeGroup("Geckos:CopTin", 12);
            recipe.AddIngredient(ItemID.GoldPickaxe, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
