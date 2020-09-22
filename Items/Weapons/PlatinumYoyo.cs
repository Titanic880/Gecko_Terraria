using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
   public class PlatinumYoyo : ModItem
    {
        public override void SetStaticDefaults() //Sets the description of the item
        {
            DisplayName.SetDefault("Platinum Yoyo");
            Tooltip.SetDefault("It Shines with Hope");
        }
        public override void SetDefaults()  //sets default stats/information of the item
        {
            item.damage = 15;
            item.crit = 5;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.knockBack = 1.5f;
            item.rare = 1;
            item.melee = true;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.channel = true;
            item.shoot = mod.ProjectileType("PlatinumYoyoProjectile");
            item.value = Item.buyPrice(0, 10, 20, 0);
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()  //Sets the recipe of the given item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBar, 12);
            recipe.AddIngredient(ItemID.WhiteString, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
