using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2
{
    internal class Figuras
    {
        private List<Shape> shapes;

        public void Execute()
        {
            Elegir();
        }

        public Figuras()
        {
            shapes = new List<Shape>();
        }

        public void Elegir()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Elige una figura");
                Console.WriteLine("1.Circulo");
                Console.WriteLine("2.Rectangulo");
                Console.WriteLine("3.Cuadrado");
                Console.WriteLine("4.Triangulo");
                Console.WriteLine("5.Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        shapes.Add(GetCircle());
                        foreach (Shape shape in shapes)
                        {
                            Console.WriteLine(shape.GetData());
                            Console.WriteLine(shape.GetArea());
                        }
                        break;
                    case "2":
                        shapes.Add(GetRectangle());
                        foreach (Shape shape in shapes)
                        {
                            Console.WriteLine(shape.GetData());
                            Console.WriteLine(shape.GetArea());
                        }
                        break;
                    case "3":
                        shapes.Add(GetSquare());
                        foreach (Shape shape in shapes)
                        {
                            Console.WriteLine(shape.GetData());
                            Console.WriteLine(shape.GetArea());
                        }
                        break;
                    case "4":
                        shapes.Add(GetTriangle());
                        foreach (Shape shape in shapes)
                        {
                            Console.WriteLine(shape.GetData());
                            Console.WriteLine(shape.GetArea());
                        }
                        break;
                    case "5":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            }
        }
        private Circle GetCircle()
        {
            string name;
            float radius;
            Circle circle;

            Console.WriteLine("Introduce el Nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce el Radio");
            radius = float.Parse(Console.ReadLine());
            circle = new Circle(name, radius);

            return circle;

        }
        private Triangle GetTriangle()
        {
            string name;
            float b;
            float h;
            Triangle triangle;

            Console.WriteLine("Introduce el Nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la Base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la Altura");
            h = float.Parse(Console.ReadLine());
            triangle = new Triangle(name, b, h);

            return triangle;

        }
        private Square GetSquare()
        {
            string name;
            float l;
            Square square;

            Console.WriteLine("Introduce el Nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce el Lado");
            l = float.Parse(Console.ReadLine());
            square = new Square(name, l);

            return square;

        }

        private Rectangle GetRectangle()
        {
            string name;
            float b;
            float h;
            Rectangle r;

            Console.WriteLine("Introduce el Nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la Base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la Altura");
            h = float.Parse(Console.ReadLine());
            r = new Rectangle(name, b, h);

            return r;

        }
    }
}
