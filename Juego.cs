using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1
{
    internal class Juego
    {
        private Player player;
        private Enemy enemy;
        public void Execute()
        {
            player = GetPlayer();
        }
        private Player GetPlayer()
        {
            int life;
            int damage;

            Console.WriteLine("cantidad de vida ?");
            life = int.Parse(Console.ReadLine());

            Console.WriteLine("cantidad de daño?");
            damage = int.Parse(Console.ReadLine());

            return player = new Player(life, damage);
        }
        private Enemy GetEnemy()
        {
            int life;
            int damage;

            life = 10;
            damage = 5;

            return enemy = new Enemy(life, damage);
        }
    }
}
