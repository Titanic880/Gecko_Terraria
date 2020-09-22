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
            //basic yoyo projectile information
            projectile.extraUpdates = 0;
            projectile.Name = "GLORIOUS!!";
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;

            //sets Yoyo projectile information; duration, Range, Speed Respectively
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 12f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 600f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 20f;

        }

        //used for particle effects
       public override void AI()
        {
            if (Main.rand.Next(3) == 0)
            {
               Dust.NewDust(projectile.position + projectile.velocity, projectile.width, 
                    projectile.height, DustID.Fireworks, projectile.velocity.X * 1f, projectile.velocity.Y * 0.5f);
            }
        }
    }
}
