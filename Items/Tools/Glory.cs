using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class Glory : ModItem
    {
        public override void SetStaticDefaults()  //Sets the description of the Item
        {
            DisplayName.SetDefault("True Glory");
            Tooltip.SetDefault("How did you....?");
        }
        public override void SetDefaults()  //sets default stats/information of the Item
        {
            Item.damage = 69;
            Item.pick = 64;
            Item.axe = 13;
            Item.useTime = 18;
            Item.useAnimation = 26;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.knockBack = 3f;
            Item.crit = 30;
            
            Item.DamageType = DamageClass.Melee;
            Item.channel = true;
            Item.noMelee = true;
            Item.autoReuse = true;
            Item.noUseGraphic = true;

            //Item.shoot = ProjectileID; //This
            Item.value = Item.buyPrice(0, 66, 66, 66);
            Item.UseSound = SoundID.Item69;
            
        }
        public override void AddRecipes()  //Sets the recipe of the given Item
        {
            CreateRecipe()
                .AddIngredient<Weapons.SwordOfTerror>()
                .AddIngredient<Weapons.YoyoOfDestiny>()
                .AddIngredient<Weapons.GoldenYoyo>()
                .AddIngredient<PickaxeOfTheFallen>()
                .AddIngredient<AxeOfFailure>()
                .AddTile(TileID.WorkBenches)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }

    }
}
