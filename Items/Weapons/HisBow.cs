using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace Gecko.Items.Weapons
{
    public class HisBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HIS bow");
            Tooltip.SetDefault("Once owned by the unspeakable Man...");
        }
        public override void SetDefaults()
        {
            Item.damage = 6;
            Item.width = 12;
            Item.height = 24;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.value = 50;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.rare = ItemRarityID.Green;

            Item.knockBack = 0.5f;
            Item.shootSpeed = 7.5f;

            Item.DamageType = DamageClass.Ranged;
            Item.autoReuse = true;

            Item.useAmmo = AmmoID.Arrow;
            Item.UseSound = SoundID.Item5;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup("IronBar", 12)
                .AddRecipeGroup("Geckos:CopTin", 12)
                .AddRecipeGroup("Geckos:Bow", 1)
                .AddTile(TileID.Furnaces)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
