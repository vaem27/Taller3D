using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2_1
{
    internal class EnemyMelee : Enemys
    {
        private int life;
        private int damage;
        public int Life { get { return life; } }
        public int Damage { get { return damage; } }

        public EnemyMelee(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }
        private void ChangeLife(int value)
        {
            life += value;
            if (life <= 0)
            {
                life = 0;
            }
        }
        public void TakeDamage(int value)
        {
            ChangeLife(-value);
        }
        public void ShowStatusEnemy()
        {
            if (Life > 0)
            {
                Console.WriteLine("Aun ta vivo");
            }
            else
            {
                Console.WriteLine("Morido");
            }
        }
        public bool IsDead() => Life <= 0;

        public void ShowCountEnemys(int index)
        {
            Console.WriteLine($"Enemigo {index}: Vida = {Life}, Daño = {Damage}");
        }
    }
}
