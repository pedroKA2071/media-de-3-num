using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_de_3_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, divisao, soma;


            Console.WriteLine("Digite um numero:");
            
                a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite um numero:");

                b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite um numero:");

                c = int.Parse(Console.ReadLine());

            Console.WriteLine();

                soma = a + b + c;

            divisao = soma / 3;

                Console.WriteLine();

            Console.WriteLine("A media é:" +  divisao);

            Console.ReadKey();






        }
    }
}
