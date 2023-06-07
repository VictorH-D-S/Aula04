using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Leitura
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            string snome;
            int idade;
            
            

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            
            snome = Console.ReadLine();
            Console.WriteLine($"\nSeja bem-viado, {nome} {snome}!");

            // Transformando o texto digitado em número
            Console.WriteLine("\nDigite sua idade: ");
            idade = Int32.Parse(Console.ReadLine());

            
           /* Console.WriteLine($"A pessoa de nome {nome} {snome} tem {idade} anos.");
            Console.WriteLine($"Em 5 anos você terá {idade + 5} anos");


            Console.WriteLine($"Você nasceu no ano de: {2023 - idade} ");
           */


            Console.ReadKey();
        }

       static void Revisao()
        {
            float lanche = 8.0f;
            float salsicha = 1.50f;
            float burge = 2.00f;
            float requeijao = 1.50f;
            float bacon = 2.00f;
            float xtudo = lanche + burge + bacon + salsicha;
            float hotdawg = lanche + (salsicha * 2) + requeijao;
            float casa = lanche + salsicha + burge + requeijao + bacon;
            float COMBO = xtudo + hotdawg + casa;

            Console.WriteLine("Cardápio do Miltom LanXes\n");
            Console.WriteLine("Valores:\n");
            Console.WriteLine($"X-Tude: Burge, beickom e salsicha - R${xtudo}");
            Console.WriteLine($"Hot Dawg = Duas salsichas e requeijão - R${hotdawg}");
            Console.WriteLine($"Do Jeito do Miltom: salsicha, hamburger, requeijão e bacon - R${casa}\n");
            Console.WriteLine($"COMBO: X-TUDO + HOTDAWG + Jeito do Miltom - R${COMBO}");
            
            Console.ReadKey();
        }

    }
}
