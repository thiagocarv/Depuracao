using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Depuracao
{
    class Program

    {
        static int Mudar(int n)
        {
            n = n + 1;
            return n;
        }

        static float Dividir(int n, int d)
        {

            return n / d;
        }
        
        static void Main(string[] args)
        {
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero escolhido e: {0}", numero);
            numero = Mudar(numero);
            Console.WriteLine("O numero modificado e: {0}", numero);

            int denominador = 0;
            denominador = int.Parse(Console.ReadLine());
            if (denominador == 0)
                Console.WriteLine("O denominador é zero");
            else
            Console.WriteLine("O quociente entre {0} e {1} é: {2}", numero, denominador, Dividir(numero, denominador));

            Console.Read();
        }
    }
}
