using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Desconto
    {
        public double DescontoPorcent(double salario, double porcent)
        {
            double desconto = porcent / 100;
            return salario-(salario * desconto);
        }
        public static double DescontoPorcent2(double salario, double porcent)
        {
            double desconto = porcent / 100;
            return salario - (salario * desconto);
        }
    }
}
