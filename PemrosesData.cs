using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal5_103022300147
{
    internal class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic tempA = (dynamic)a;
            dynamic tempB = (dynamic)b;
            dynamic tempC = (dynamic)c;
            var high = tempA;
            if (tempA < tempB) 
            {
                high = tempB;
            }
            if (tempB < tempC)
            {
                high = tempC;
            }
            return high;
        }
    }
}






