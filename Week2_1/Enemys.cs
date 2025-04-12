using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D_Ejercicio1.Week2_1
{
    internal interface Enemys
    {
        int Life { get; }
        int Damage { get; }
        void TakeDamage(int dmg);
        bool IsDead();
    }
}
