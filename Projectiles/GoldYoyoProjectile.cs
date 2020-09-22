using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Projectiles
{
public class GoldYoyoProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            //basic yoyo projectile information
            projectile.extraUpdates = 0;
            projectile.Name = "Custom Gold Yoyo";
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;

            //sets Yoyo projectile information; duration, Range, Speed Respectively
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 7f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 400f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 16f;

        }
    }
}
