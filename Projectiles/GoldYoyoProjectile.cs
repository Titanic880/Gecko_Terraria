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
            //basic yoyo Projectile information
            Projectile.extraUpdates = 0;
            Projectile.Name = "Custom Gold Yoyo";
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = 99;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.DamageType = DamageClass.Melee;

            //sets Yoyo Projectile information; duration, Range, Speed Respectively
            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 7f;
            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 400f;
            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 16f;
            
        }
    }
}
