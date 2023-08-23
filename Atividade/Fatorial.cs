using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Fatorial
    {
        public double Fat(double n) 
        {
            if (n == 0 || n == 1)
                return 1;

            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static double Fat2(double n)
        {
            if (n == 0 || n == 1)
                return 1;

            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
