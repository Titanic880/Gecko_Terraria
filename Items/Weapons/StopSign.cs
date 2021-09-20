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
            Item.damage = ;
            Item.crit = ;
			Item.width = ;
			Item.height = ;
			Item.useTime = ;
			Item.useAnimation = ;
			Item.useStyle = 1;
			Item.knockBack = ;
			Item.value = ;*/
            Item.rare = ItemRarityID.Orange;
            Item.DamageType = DamageClass.Melee;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Chain, 4)
                .AddIngredient<Crafting.IronPole>()
                .AddIngredient<Octagon>()
                .AddTile(TileID.AdamantiteForge)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
