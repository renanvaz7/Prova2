using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que receb 2 números e executa as operações listadas

            int a, b, r, média, diferença, produto, divisão, menu;

            Console.WriteLine("Digite um número");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite outro número \n");
            b = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Escolha uma operação: \n" +
                "1 - Média entre os 2 valores \n" +
                "2 - Diferença entre os valores \n" +
                "3 - Produtos entre os valores \n" +
                "4 - Divisão do maior pelo menor");
            menu = Int32.Parse(Console.ReadLine());                    
            
            if (menu == 1)
            {
                média = (a + b)/ 2;
                Console.WriteLine("A média entre os 2 valores é: " + média);
            }
            else if (menu == 2)
            {
                diferença = (a - b);
                Console.WriteLine("A diferença entre os 2 valores é: " + diferença);
            }
            else if (menu == 3)
            {
                produto = (a * b);
                Console.WriteLine("O produto entre os 2 valores é: " + produto);
            }
            else
            {
                if (a > b )
                {
                    divisão = a / b;
                    Console.WriteLine("A divisão entre os 2 valores é: " + divisão);
                }
                else if (b > a)
                {
                    divisão = b / a;
                    Console.WriteLine("A divisão entre os 2 valores é: " + divisão);
                }
            }
            Console.ReadLine();
        }
    }
}
