using Terraria.ID;
using Terraria.ModLoader;
namespace Gecko.Items.Weapons
{
	public class SwordOfTerror : ModItem
	{
		public override void SetStaticDefaults()  //Sets the description of the item
        {
            DisplayName.SetDefault("The Sword of Terror");
                Tooltip.SetDefault("The Broadsword");
		}

		public override void SetDefaults() //sets default stats/information of the item
        {
			item.damage = 20;
            item.crit = 10;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10;
			item.rare = 2;
			item.melee = true;
            item.autoReuse = true;
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()  //Sets the recipe of the given item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 12);
            recipe.AddRecipeGroup("Geckos:CopTin", 12);
            recipe.AddIngredient(ItemID.GoldBroadsword, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}