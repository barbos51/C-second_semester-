using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_3
{
    internal abstract class Projectile
    {
        public float damage;
        public Projectile(float damage)
        {
            this.damage = damage;
        }
        public abstract void HitTarget(IDamageable damageable);
        
    }
}
