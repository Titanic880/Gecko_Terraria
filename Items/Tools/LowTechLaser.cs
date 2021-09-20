using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Items.Tools
{
    public class LowTechLaser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Low Tech Laser");
            Tooltip.SetDefault("What did you expect?");
        }
        public override void SetDefaults()
        {
            Item.pick = 5;
            Item.axe = 11;
            Item.width = 14;
            Item.height = 14;
            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Ranged; 
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                //.AddIngredient(ItemID.ManaCrystal, 2)
                //.AddIngredient(ItemID.IronBar, 12)
                .AddIngredient(ItemID.DirtBlock, 1)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
