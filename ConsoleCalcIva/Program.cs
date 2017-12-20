using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCalcIva
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalSemIva = 0;
            double valorIva = 0.23;
            double totalComIva = 0;
            const double percentagemIva = 0.23;
            Console.Write("Digite o valor a calcular: ");
            totalSemIva = double.Parse(Console.ReadLine());

            valorIva = totalSemIva * percentagemIva;
            totalComIva = totalSemIva + valorIva;
            Console.Write("O valor com Iva é: " + totalComIva);
            Console.Read();

            /*Final da listagem
            Código criado por Buno Gonçalves 
            @Dezembro 2017*/
        }
    }
}
