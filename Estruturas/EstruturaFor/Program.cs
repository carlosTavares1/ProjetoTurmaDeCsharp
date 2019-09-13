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
            int media = 0;
            Console.WriteLine("Informe o nome do aluno: ");
            string nome = Console.ReadLine();
            int[] nota = new int[4];
            for(int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine($"Informe {i+1}ª avaliação: ");
                nota[i] = int.Parse(Console.ReadLine());
                media = media + nota[i];
            }
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
