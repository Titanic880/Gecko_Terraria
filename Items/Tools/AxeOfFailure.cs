using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class AxeOfFailure : ModItem
    {
        public override void SetStaticDefaults()  //Sets the description of the Item
        {
            DisplayName.SetDefault("Axe of Failure");
            Tooltip.SetDefault("Demonite+ Axe");

        }
        public override void SetDefaults() //sets default stats/information of the Item
        {

            Item.axe = 13;
            Item.damage = 9;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 15;
            Item.knockBack = 6;
            Item.useAnimation = 15;
            Item.rare = ItemRarityID.Orange;
            Item.useStyle = ItemUseStyleID.Swing;

            Item.DamageType = DamageClass.Melee;
            Item.channel = true;
            Item.autoReuse = true;

            Item.value = Item.buyPrice(0, 20, 0, 0);
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup("Geckos:CopTin", 12)
                .AddRecipeGroup(ItemID.Wood, 12)
                .AddIngredient(ItemID.GoldAxe, 1)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
