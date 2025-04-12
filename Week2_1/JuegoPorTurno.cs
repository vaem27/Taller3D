using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2_1
{
    internal class JuegoPorTurno
    {
        private Player player;
        private EnemyMelee enemyMelee;
        private EnemyRange enemyRange;
        Random random = new Random();
        public void Execute()
        {
            player = GetPlayer();
            List<EnemyMelee> enemyMelee = GetEnemyMelee();
            List<EnemyRange> enemyRange = GetEnemyRange();
            Game(enemyMelee, enemyRange);
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
        public List<EnemyMelee> GetEnemyMelee()
        {
            int cantidad = random.Next(1, 4);

            Console.WriteLine("Cantidad de enemigos de Melee en esta Zona");
            List<EnemyMelee> enemys = new List<EnemyMelee>();

            for (int i = 0; i < cantidad; i++)
            {
                int life = random.Next(50, 101);
                int damage = random.Next(5, 16);

                EnemyMelee enemymelee = new EnemyMelee(life, damage);
                enemys.Add(enemymelee);
                enemymelee.ShowCountEnemys(i + 1);
            }

            return enemys;
        }
        public List<EnemyRange> GetEnemyRange()
        {
            int cantidad = random.Next(2, 6);

            Console.WriteLine("Cantidad de enemigos de RANGO en esta Zona");
            List<EnemyRange> enemys = new List<EnemyRange>();

            for (int i = 0; i < cantidad; i++)
            {
                int life = random.Next(50, 101);
                int damage = random.Next(3, 6);
                int bullets = random.Next(2, 5);

                EnemyRange enemyrange = new EnemyRange(life, damage, bullets);
                enemys.Add(enemyrange);
                enemyrange.ShowCountEnemys(i + 1);
            }

            return enemys;
        }
        private void Game(List<EnemyMelee> enemyMeleeList, List<EnemyRange> enemyRangeList)
        {
            List<Enemys> allEnemys = new List<Enemys>();
            allEnemys.AddRange(enemyMeleeList);
            allEnemys.AddRange(enemyRangeList);
            int currentEnemyTurn = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== TURNO DEL JUGADOR ===");
                Console.WriteLine("Tu vida: " + player.Life);
                Console.WriteLine("Elige a qué enemigo atacar:");

                for (int i = 0; i < allEnemys.Count; i++)
                {
                    var enemy = allEnemys[i];
                    string type = enemy is EnemyMelee ? "Melee" : "Rango";
                    string status = enemy.IsDead() ? "MUERTO" : $"Vida: {enemy.Life}";
                    string bullet = "";

                    if (enemy is EnemyRange rangedEnemy)
                    {
                        bullet = $"- Balas: {rangedEnemy.Bullets}";
                    }

                    Console.WriteLine($"{i + 1}. [{type}] - {status} {bullet}");
                }

                int choice = -1;
                while (choice < 1 || choice > allEnemys.Count || allEnemys[choice - 1].IsDead())
                {
                    Console.Write("Selecciona un enemigo: ");
                    int.TryParse(Console.ReadLine(), out choice);
                }

                var selectedEnemy = allEnemys[choice - 1];
                selectedEnemy.TakeDamage(player.Damage);
                Console.WriteLine($"¡Atacaste! Vida restante del enemigo: {selectedEnemy.Life}");

                if (selectedEnemy.IsDead())
                {
                    Console.WriteLine("El enemigo fue derrotado.");
                }

                if (allEnemys.All(e => e.IsDead()))
                {
                    Console.WriteLine("¡VICTORIA!");
                    break;
                }

                Console.WriteLine("TURNO DEL ENEMIGO");
                Enemys attacker = null;

                int totalEnemies = allEnemys.Count;
                int checkedEnemies = 0;

                while (checkedEnemies < totalEnemies)
                {
                    var candidate = allEnemys[currentEnemyTurn];

                    if (!candidate.IsDead())
                    {
                        if (candidate is EnemyRange ranged)
                        {
                            if (ranged.Bullets > 0)
                            {
                                attacker = ranged;
                                ranged.Ammon();
                                Console.WriteLine($"El enemigo de RANGO te ataca con una bala. Balas restantes: {ranged.Bullets}");
                            }
                            else
                            {
                                Console.WriteLine("Un enemigo de RANGO intentó atacar pero no tiene balas.");
                            }
                        }
                        else
                        {
                            attacker = candidate;
                            Console.WriteLine("El enemigo MELEE te ataca.");
                        }
                    }

                    currentEnemyTurn = (currentEnemyTurn + 1) % totalEnemies;
                    checkedEnemies++;

                    if (attacker != null)
                        break;
                }

                Console.WriteLine($"El enemigo te ataca y te hace {attacker.Damage} de daño.");
                    player.takeDamage(attacker.Damage);

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("¡DERROTA!");
                        break;
                    }

                    Console.WriteLine($"Tu vida restante: {player.Life}");
                    Console.WriteLine("Presiona Enter para seguir...");
                    Console.ReadLine();
             
            }
        }
    }
}
