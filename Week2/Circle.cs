using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2
{
    internal class Circle : Shape
    {
        protected float radius;
        protected float pi = 3.14f;

        public Circle(string name, float radius) : base(name)
        {
            this.radius = radius;
        }

        public override float GetArea()
        {
            return radius * radius * pi;
        }
        public override string GetData()
        {
            return $"{base.GetData()} - Radio: {radius}";
        }
    }
}
