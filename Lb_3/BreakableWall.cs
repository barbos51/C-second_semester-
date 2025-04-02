using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_3
{
    internal class BreakableWall:IDamageable
    {
        public float healthWall;
        public BreakableWall(float healthWall)
        {
            this.healthWall = healthWall;
        }
        public void TakeDamage(float damage)
        {
            healthWall -= damage;
            if(healthWall <= 0)
            {
                Console.WriteLine("Стіну знищено(Не відомо як, але ок)");
            }
            else
            {
                Console.WriteLine($"Стіну пошкоджено на {damage} урона, цілісність стіни {healthWall}");
            }
        }
    }
}
