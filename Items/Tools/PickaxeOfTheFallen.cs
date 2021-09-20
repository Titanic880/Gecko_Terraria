using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Gecko.Items.Tools
{
    public class PickaxeOfTheFallen : ModItem
    {
        public override void SetStaticDefaults() //Sets the description of the Item
        {
            DisplayName.SetDefault("Pickaxe of the Fallen");
            Tooltip.SetDefault("The pick of a Fallen Hero");
        }
        public override void SetDefaults() //sets default stats/information of the Item
        {
            Item.damage = 9;
            Item.pick = 64;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Orange;
            Item.DamageType = DamageClass.Melee;
            Item.channel = true;
            Item.autoReuse = true;
            Item.value = Item.buyPrice(0, 20, 0, 0);
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes() //Sets the recipe of the given Item
        {
            CreateRecipe()
                .AddRecipeGroup("IronBar", 12)
                .AddRecipeGroup("Geckos:CopTin", 12)
                .AddIngredient(ItemID.GoldPickaxe, 1)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
