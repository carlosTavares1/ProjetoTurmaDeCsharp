using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] { 1, 2, 3, 4, 5 };   //vetor assinado
            foreach (int elemento in numeros)   //estrutura de repeticação. a cada repeticação ele assina o valor da posição do vetor na variável
            {
                Console.WriteLine(elemento);    //imprime no console o valor da posição do vetor
            }
            Console.ReadKey();
        }
    }
}
