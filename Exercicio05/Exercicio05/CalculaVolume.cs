using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal static class CalculaVolume
    {
        public static double CalculaVolumeLataOleo(int raio, int altura)
        {
            return Math.Round(((3.14159 * raio * raio * altura) /1000), 2);
        }
    }
}
