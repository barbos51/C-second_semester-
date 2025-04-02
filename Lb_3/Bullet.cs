using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_3
{
    internal class Bullet : Projectile
    {
        public Bullet(float damage) : base(damage)
        {

        }
        public override void HitTarget(IDamageable damageable)
        {
            damageable.TakeDamage(damage); 
        }
    }
}
