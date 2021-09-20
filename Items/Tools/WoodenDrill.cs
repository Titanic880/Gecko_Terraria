using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class WoodenDrill : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wooden Drill");
            Tooltip.SetDefault("Its a drill made out of wood...");
        }
        public override void SetDefaults()
        {
            Item.pick = 35;
            Item.axe = 35;
            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup("Wood", 20)
                .AddTile(TileID.WorkBenches)
                .AddTile(TileID.Sawmill)
                .Register();
        }
    }
}
