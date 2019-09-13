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
                Console.WriteLine($"Informe {i+1}ª avaliação: ");
                nota[i] = int.Parse(Console.ReadLine());
                media = media + nota[i];
            }                                       //terminando a estrutura de repetição
            media = media / nota.Length;
            Console.WriteLine($"O aluno {nome} possui média {media}");
            Console.ReadKey();
        }


        public int nome;
        public void PegaMedia()
        {
            PegaMedia = nota1 + nota2;
        }


    }
}
