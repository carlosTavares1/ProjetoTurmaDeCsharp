using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturaDeDecisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, multiplicacao;   //declaração de variáveis na mesma linha pois são do mesmo tipo. Só pode quando são do mesmo e não são inicializadas.
            Console.WriteLine("Informe o primeiro valor: ");    //método para escrever na tela do console
            num1 = double.Parse(Console.ReadLine());    //atribuição do valor escrito no console. Feito a conversão do valor digitado porque ele é recuperado como string e a variável é double, então deve converter.
            Console.WriteLine("Informe o segundo valor: ");     //método para escrever na tela do console
            num2 = double.Parse(Console.ReadLine());    //atribuição do valor escrito no console. Feito a conversão do valor digitado porque ele é recuperado como string e a variável é double, então deve converter.
            multiplicacao = num1 * num2;    //multiplicação dos valores recuperados e atribuídos à variável multiplicação
            Console.WriteLine("O produto do primeiro pelo segundo é: " + multiplicacao);    //Método retorna a string seguida do resultado da variável.
        }
    }
}
