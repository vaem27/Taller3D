using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Taller3D_Ejercicio1.Week1
{
    internal class Juego
    {
        private Player player;
        private Enemy enemy;
        public void Execute()
        {
            player = GetPlayer();
            enemy = GetEnemy();
            Turnos();
        }
        private Player GetPlayer()
        {
            int life;
            int damage;

            Console.WriteLine("cantidad de vida ?");
            life = int.Parse(Console.ReadLine());
            if (life >= 100)
            {
                Console.WriteLine("Intenta con otro numero");
                Execute();
            }

            Console.WriteLine("cantidad de daño?");
            damage = int.Parse(Console.ReadLine());
            if (damage >= 100)
            {
                Console.WriteLine("Intenta con otro numero");
                Execute();
            }

            return player = new Player(life, damage);
        }
        private Enemy GetEnemy()
        {
            int life;
            int damage;
            Console.WriteLine("Dificultad (1 = fácil, 2 = difícil)?");
            int dif = int.Parse(Console.ReadLine());

            if (dif == 1)
            {
                life = 5;
                damage = 3;
            }
            else
            {
                life = 15;
                damage = 6;
            }

            return new Enemy(life, damage);
        }


        private void Turnos()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Tu comienzas, Ataca con A");
                string option = Console.ReadLine();

                if (option == "A")
                {
                    enemy.TakeDamage(player.Damage);
                    enemy.ShowStatusEnemy();

                    if (enemy.Life <= 0)
                    {
                        Console.WriteLine("Victoria!!!");
                        Console.WriteLine("Quieres intentar de nuevo?");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. Salir");
                        string again = Console.ReadLine();
                        if (again == "1")
                        {
                            Execute();
                        }
                        else
                        {
                            continueFlag = false;
                            break;
                        }
                    }
                }

                Console.WriteLine("Turno del enemigo.");
                player.takeDamage(enemy.Damage);

                Console.WriteLine($"Aun tienes {player.Life} de vida restante.");

                if (player.Life <= 0)
                {
                    Console.WriteLine("Quieres intentar de nuevo?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. Salir");
                    string again = Console.ReadLine();
                    if (again == "1")
                    {
                        Execute();
                    }
                    else
                    {
                        continueFlag = false;
                        break;
                    }
                }
            }
        }
    }
}
