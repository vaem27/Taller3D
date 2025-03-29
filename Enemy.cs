using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1
{
    internal class Enemy
    {
        private int life;
        private int damage;
        public int Life { get { return life; } }
        public int Damage { get { return damage; } }
    }
    public Enemy(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }
        public string GetData()
        {
            return $"Vida: {life}";
        }
        private void ChangeLife(int value)
        {
            life += value;
            if (life <= 0)
            {
                life = 0;
            }
        }
        public void takeDamage(int value)
        {
            ChangeLife(-value);
        }
    }
}
