using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_3
{
    internal class Enemy:IDamageable
    {
        public float health;
        public Enemy(float health)
        {
            this.health = health;
        }
        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <=0)
            {
                Console.WriteLine("Ворога знищено");
            }
            else
            {
                Console.WriteLine($"Ворогу нанесено {damage} урона, залишилось {health} хп");
            }
        }
    }
}
