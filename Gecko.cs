using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;

namespace Gecko
{
    public class Gecko : Mod
    {
        public Gecko() { }
        public override void AddRecipeGroups()
        {
            RecipeGroup Copper = new (() => Language.GetTextValue("LegacyMisc.37") + "Copper", new int[]
                {
                    ItemID.CopperBar,
                    ItemID.TinBar
                });
            RecipeGroup Gold = new (() => Language.GetTextValue("LegacyMisc.37") + "Gold", new int[]
                 {
                    ItemID.GoldBar,
                    ItemID.PlatinumBar
                 });
            RecipeGroup Titanium = new(() => Language.GetTextValue("LegacyMisc.37") + "Titanium", new int[]
                {
                    ItemID.TitaniumBar,
                    ItemID.AdamantiteBar
                });
            RecipeGroup GoPlYoyo = new (() => Language.GetTextValue("LegacyMisc.37") + "Gold/Plat Yoyo", new int[]
                {
                    ItemType<Items.Weapons.GoldenYoyo>(),
                    ItemType<Items.Weapons.PlatinumYoyo>()
                 });
            RecipeGroup GoPlBow = new (() => Language.GetTextValue("LegacyMisc.37") + "Gold/Plat Bow", new int[]
            {
                ItemID.GoldBow,
                ItemID.PlatinumBow
            });

            RecipeGroup.RegisterGroup("Geckos:CopTin", Copper);
            RecipeGroup.RegisterGroup("Geckos:GoldPlat", Gold);
            RecipeGroup.RegisterGroup("Geckos:TitAdam", Titanium);
            RecipeGroup.RegisterGroup("Geckos:Yoyo", GoPlYoyo);
            RecipeGroup.RegisterGroup("Geckos:Bow", GoPlBow);
        }
    }
}

