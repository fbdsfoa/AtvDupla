using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade

// Calcula Aumento
//Fatoriais de 1 até 10 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Aumento aumento = new Aumento();
            double salario = 1000;
            double porcent = 10;
            double salreajus = aumento.AumentoPorcent(salario, porcent);
            Console.WriteLine($"O salario inicial era {salario},com o aumento de {porcent}% foi para {salreajus}");
            
            double salario2 = 2000;
            double porcent2 = 30;
            double salreajus2 = Aumento.AumentoPorcent2(salario2, porcent2);
            Console.WriteLine($"O salario inicial era {salario2},com o aumento de {porcent2}% foi para {salreajus2}");
            



            double num = 10;
            Fatorial fatorial = new Fatorial();
            double fatresult = fatorial.Fat(num);
            Console.WriteLine($"O fatorial de {num} é : {fatresult}");

            double num2 = 5;
            double fatresult2 =Fatorial.Fat2(num2);
            Console.WriteLine($"O fatorial de {num2} é : {fatresult2}");
            */


            /*
            Desconto desconto = new Desconto();
            Console.WriteLine("Digite o valor que recebera o desconto");
            double salario3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos % de desconto");
            double porcent3 = double.Parse(Console.ReadLine());
            double salreajus3 = desconto.DescontoPorcent(salario3, porcent3);
            Console.WriteLine($"O salario inicial era {salario3},com o desconto de {porcent3}% foi para {salreajus3}");

            Console.WriteLine("Digite o valor que recebera o desconto");
            double salario4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos % de desconto");
            double porcent4 = double.Parse(Console.ReadLine());
            double salreajus4 = Desconto.DescontoPorcent2(salario4, porcent4);
            Console.WriteLine($"O salario inicial era {salario4},com o desconto de {porcent4}% foi para {salreajus4}");
            */



            IRRF irrf = new IRRF();
            Console.WriteLine("Digite o valor do Salario1 IRRF");
            double salarioa = double.Parse(Console.ReadLine());
            double leao = irrf.irrf1(salarioa);
            Console.WriteLine($"O salario de {salarioa} após o desconto do imposto será: {leao}");

            Console.WriteLine("Digite o valor do Salario2 IRRF");
            double salariob = double.Parse(Console.ReadLine());
            double leao2 = IRRF.irrf2(salariob);
            Console.WriteLine($"O salario de {salariob} após o desconto do imposto será: {leao2}");

        }

    }
}
