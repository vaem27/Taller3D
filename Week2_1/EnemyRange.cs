using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2_1
{
    internal class EnemyRange : Enemys
    {
        private int life;
        private int damage;
        private int bullets;
        public int Life { get { return life; } }
        public int Damage { get { return damage; } }
        public int Bullets { get { return bullets; } }


        public EnemyRange(int life, int damage, int bullets)
        {
            this.life = life;
            this.damage = damage;
            this.bullets = bullets;
        }
        public void Ammon()
        {
            bullets--;
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
