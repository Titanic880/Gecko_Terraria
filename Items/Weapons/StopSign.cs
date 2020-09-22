using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Weapons
{
    public class StopSign : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stop Sign");
            Tooltip.SetDefault("Its an Octagon!");
        }
        public override void SetDefaults()
        {/*                         Values TBD
            item.damage = ;
            item.crit = ;
			item.width = ;
			item.height = ;
			item.useTime = ;
			item.useAnimation = ;
			item.useStyle = 1;
			item.knockBack = ;
			item.value = ;*/
            item.rare = 3;
            item.melee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 4);
            recipe.AddIngredient(mod, "Octagon", 8);
            recipe.AddIngredient(mod, "IronPole",1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
