using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2
{
    internal class Shape
    {
        protected string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual float GetArea()
        {
            return 0;
        }

        public virtual string GetData()
        {
            return $"Name: {name}";
        }
    }
}
