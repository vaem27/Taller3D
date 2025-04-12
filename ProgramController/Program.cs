using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller3D_Ejercicio1.Week1;
using Taller3D_Ejercicio1.Week2;
using Taller3D_Ejercicio1.Week2_1;
using static System.Net.Mime.MediaTypeNames;


namespace Taller3D_Ejercicio1.week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Que Semana Quieres Ver?");
                Console.WriteLine("1. Tarea Semana 1");
                Console.WriteLine("2. Ejercicio Semana 2");
                Console.WriteLine("3. Tarea Semana 2");
                int s = int.Parse(Console.ReadLine());

                if (s == 1)
                {
                    Juego juego = new Juego();
                    juego.Execute();
                }
                if (s == 2)
                {
                    Figuras figuras = new Figuras();
                    figuras.Execute();
                }
                if (s == 3)
                {
                    JuegoPorTurno juego = new JuegoPorTurno();
                    juego.Execute();
                }
                else
                {
                    Console.WriteLine("No se encontro la clase");
                }
            }
        }
    }    
}
