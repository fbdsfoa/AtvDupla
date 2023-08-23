using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class IRRF
    {
        public double irrf1(double salario)
        {
            double desconto = 0;
            if (salario <= 1904)
            {
                desconto = 0;
            }
            if (salario > 1904 && salario < 2827)
            {
                desconto = 7.50;
            }
            if (salario > 2827 && salario < 3751)
            {
                desconto = 15;
            }
            if (salario > 3751 && salario < 4665)
            {
                desconto = 22.5;
            }
            if (salario > 4665)
            {
                desconto = 27.5;
            }
            return salario - (salario *(desconto/100));
        }
        public static double irrf2(double salario)
        {
            double desconto = 0;
            if (salario <= 1904)
            {
                desconto = 0;
            }
            if (salario > 1904 && salario < 2827)
            {
                desconto = 7.50;
            }
            if (salario > 2827 && salario < 3751)
            {
                desconto = 15;
            }
            if (salario > 3751 && salario < 4665)
            {
                desconto = 22.5;
            }
            if (salario > 4665)
            {
                desconto = 27.5;
            }
            return salario - (salario * (desconto / 100));
        }
    }
}
