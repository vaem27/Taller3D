using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2
{
    internal class Square : Rectangle
    {
        protected float l;

        public Square(string name, float l) : base(name, l, l)
        {
            this.l = l;
        }

        public override float GetArea()
        {
            return l * l ;
        }
        public override string GetData()
        {
            return $"{base.GetData()} - Lado: {l}";
        }
    }
}
