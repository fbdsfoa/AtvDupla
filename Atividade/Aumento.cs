using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Aumento
    {
        public double AumentoPorcent(double salario,double porcent )
        {
            return (salario * porcent/100)+salario;
        }
        public static double AumentoPorcent2(double salario, double porcent)
        {
            return (salario * porcent/100) + salario;
        }

    }
}
