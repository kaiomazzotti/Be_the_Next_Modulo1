using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public static class Conversao
    {
        public static double ConverteGrauCpF(int celsius)
        {
            return Math.Round((9.0 * celsius + 160) / 5, 1);
        }
    }
}
