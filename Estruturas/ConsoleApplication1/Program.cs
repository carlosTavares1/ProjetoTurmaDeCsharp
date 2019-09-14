using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //assinando a variável do tipo inteiro com zero

            Console.WriteLine("Digite um valor entre 20 e 30: ");   //escreve o texto entre aspas duplas
            num = Convert.ToInt32(Console.ReadLine());  //assinando a variável num com o valor digitado. o Convert.ToInt32 funciona como o int.Parse

            if (num > 20 && num < 30)   //a estrutura de decisão verifica se o valor digitado está entre o intervalo de 20 a 30. && é operador e e é verdadeiro somente quando ambas as condições são verdadeiras.
            {
                //condição verdadeira
                Console.WriteLine("O número está no intervalo!");   //a função WriteLine escreve o valor entre aspas no console. no corpo do if, somente se a condição for verdadeira
            }
            else
            {
                //condição falsa
                Console.WriteLine("Número inválido!");  //a função WriteLine escreve a frase entre aspas
            }
        }
    }
}
