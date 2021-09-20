using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
    public class YoyoOfDestiny : ModItem
    {
        public override void SetStaticDefaults() //Sets the description of the Item
        {
            DisplayName.SetDefault("Yoyo of Destiny");
                Tooltip.SetDefault("It is Your Destiny...");
        }
        public override void SetDefaults()  //sets default stats/information of the Item
        {
            Item.damage = 20;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.knockBack = 2f;
            Item.crit = 10;
            Item.rare = ItemRarityID.Orange;
            
            Item.DamageType = DamageClass.Melee;
            Item.channel = true;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.autoReuse = false;

            //Item.shoot = ;
            
            Item.value = Item.buyPrice(0, 20, 25, 0);
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()  //Sets the recipe of the given Item
        {
            CreateRecipe()
                .AddRecipeGroup("Geckos:CopTin", 12)
                .AddRecipeGroup("Geckos:Yoyo", 1)
                .AddRecipeGroup("IronBar", 12)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
