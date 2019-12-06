using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = new int[6];

            for (int i = 0; i < 6; i++)
            {
                A[i] = 1;
                A[i] = 0;
                A[i] = 5;
                A[i] = -2;
                A[i] = -5;
                A[i] = 7;                                
            }
            Console.WriteLine(A);
            Console.ReadLine();
        }
    }
}
