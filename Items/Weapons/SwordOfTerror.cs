using Terraria.ID;
using Terraria.ModLoader;
namespace Gecko.Items.Weapons
{
	public class SwordOfTerror : ModItem
	{
		public override void SetStaticDefaults()  //Sets the description of the Item
        {
            DisplayName.SetDefault("The Sword of Terror");
                Tooltip.SetDefault("The Broadsword");
		}

		public override void SetDefaults() //sets default stats/information of the Item
        {
			Item.damage = 20;
            Item.crit = 10;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true;
			Item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()  //Sets the recipe of the given Item
        {
			CreateRecipe()
				.AddRecipeGroup("IronBar", 12)
				.AddRecipeGroup("Geckos:CopTin", 12)
				.AddIngredient(ItemID.GoldBroadsword, 1)
				.AddTile(TileID.Furnaces)
				.AddTile(TileID.Anvils)
				.Register();
        }
	}
}