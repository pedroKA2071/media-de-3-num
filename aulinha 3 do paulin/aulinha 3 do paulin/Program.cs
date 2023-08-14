using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulinha_3_do_paulin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, resultado;

            Console.Write("Digite um numero :");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite um numero :");

            c = int.Parse(Console.ReadLine());

            resultado = Math.Pow(a, c);

           Console.Write("O Resultado = " + resultado );

            Console.WriteLine();

            Console.Write("Digite outro numero: ");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            resultado = Math.Sqrt(b);

            Console.WriteLine("A Raiz quadrada é " + resultado);
            


            











            Console.ReadKey();  
        }
    }
}
