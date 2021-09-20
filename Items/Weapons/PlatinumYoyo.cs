using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
   public class PlatinumYoyo : ModItem
    {
        public override void SetStaticDefaults() //Sets the description of the Item
        {
            DisplayName.SetDefault("Platinum Yoyo");
            Tooltip.SetDefault("It Shines with Hope");
        }
        public override void SetDefaults()  //sets default stats/information of the Item
        {
            Item.damage = 15;
            Item.crit = 5;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.knockBack = 1.5f;
            Item.rare = ItemRarityID.Blue;
            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.channel = true;
            //Item.shoot = mod.ProjectileType("PlatinumYoyoProjectile"); //NEED TO FIGURE THIS OUT
            Item.value = Item.buyPrice(0, 10, 20, 0);
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()  //Sets the recipe of the given Item
        {
            CreateRecipe()
                .AddIngredient(ItemID.PlatinumBar, 12)
                .AddIngredient(ItemID.WhiteString, 1)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
