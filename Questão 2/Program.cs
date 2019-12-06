using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para mostrar classificação de um produto

            int x;

            Console.WriteLine("1 - Alimento não perecível \n" +
                "2, 3, 4 - Alimento perecível \n" +
                "5 e 6 - Vestuário \n" +
                "7 - Higiene Pessoal \n" +
                "8 até 15 - Limpeza e Utensílios domésticos \n");

            Console.WriteLine("Digite o código do produto ");
            x = Int32.Parse(Console.ReadLine());
                       
                if (x == 1)
                {
                    Console.WriteLine("Alimento não perecível");                    
                }
                else if (x > 1 && x < 5)
                {
                    Console.WriteLine("Alimento perecível");              
                }
                else if (x > 4 && x < 7 )
                {
                    Console.WriteLine("Vestuário");                 
                }
                else if (x == 7 )
                {
                    Console.WriteLine("Higiene Pessoal");                    
                }
            else if (x > 7 && x < 16)
            {
                Console.WriteLine("Limpeza e Utensílios domésticos");
            }
            else
            {
                Console.WriteLine("Código inválido");
            }            
            Console.ReadLine();
        }
    }
}
