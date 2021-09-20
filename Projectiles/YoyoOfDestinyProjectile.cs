using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gecko.Projectiles
{
public class YoyoOfDestinyProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            //basic yoyo Projectile information
            Projectile.extraUpdates = 0;
            Projectile.Name = "Custom Yoyo";
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = 99;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.DamageType = DamageClass.Melee;

            //sets Yoyo Projectile information; duration, Range, Speed Respectively
            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 7.5f;
            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 440f;
            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 24f;

        }

        //used for particle effects
        public override void AI()
        {
            if (Main.rand.Next(2) == 0)
            {
               Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, 
                    Projectile.height, DustID.Fireworks, Projectile.velocity.X * 0.5f, Projectile.velocity.Y * 0.5f);
            }
        }
    }
}
