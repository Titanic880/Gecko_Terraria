using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Projectiles
{
public class YoyoOfDestinyProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            //basic yoyo projectile information
            projectile.extraUpdates = 0;
            projectile.Name = "Custom Yoyo";
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;

            //sets Yoyo projectile information; duration, Range, Speed Respectively
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 7.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 440f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 24f;

        }

        //used for particle effects
        public override void AI()
        {
            if (Main.rand.Next(2) == 0)
            {
               Dust.NewDust(projectile.position + projectile.velocity, projectile.width, 
                    projectile.height, DustID.Fireworks, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
    }
}
