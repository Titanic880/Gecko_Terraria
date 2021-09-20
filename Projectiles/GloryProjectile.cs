using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Projectiles
{
public class GloryProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            //basic yoyo Projectile information
            Projectile.extraUpdates = 0;
            Projectile.Name = "GLORIOUS!!";
            Projectile.width = 20;
            Projectile.height = 20;
            Projectile.aiStyle = 99;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.DamageType = DamageClass.Melee;

            //sets Yoyo Projectile information; duration, Range, Speed Respectively
            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 12f;
            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 600f;
            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 20f;

        }

        //used for particle effects
       public override void AI()
        {
            if (Main.rand.Next(3) == 0)
            {
               Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, 
                    Projectile.height, DustID.Fireworks, Projectile.velocity.X * 1f, Projectile.velocity.Y * 0.5f);
            }
        }
    }
}
