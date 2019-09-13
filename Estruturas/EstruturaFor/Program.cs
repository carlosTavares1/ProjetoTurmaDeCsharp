using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 0;  //inicializando a variável com valor zero
            Console.WriteLine("Informe o nome do aluno: ");     //escrevendo no console o texto entre aspas
            string nome = Console.ReadLine();   //assinando na variável nome o que foi digitado no console
            int[] nota = new int[4];    //declarando um vetor de quatro posições
            for(int i = 0; i < nota.Length; i++)    //iniciando a estrutura de repetição
            {
                Console.WriteLine($"Informe {i+1}ª avaliação: "); //usa o método WriteLine para escrever na tela o texto e a variável i indicando o número da avaliação
                nota[i] = int.Parse(Console.ReadLine());    //assinando um valor digitado em cada posição do vetor
                media = media + nota[i];    //soma dos valores digitados em cada posição do vetor
            }                                       //terminando a estrutura de repetição
            media = media / nota.Length; //cálculo da média
            Console.WriteLine($"O aluno {nome} possui média {media}");  //escrevendo o método através do método WriteLine
            Console.ReadKey();  //método faz a leitura de uma tecla apenas
        }
    }
}
