using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive =
            {
                -2, 45, 5, -12, 10
            };
            Console.WriteLine(string.Join(", ", massive));
            Squaring(massive);
            Sorting(massive);
            Console.WriteLine(string.Join(", ", massive));
            Console.ReadKey();
        }
        static void Squaring(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = massive[i] * massive[i];
            }
        }
        static void Sorting(int[] massive)
        {
            int temp = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                for (int k = 0; k < massive.Length - 1; k++)
                {
                    if (massive[k] > massive[k + 1])
                    {
                        temp = massive[k];
                        massive[k] = massive[k + 1];
                        massive[k + 1] = temp;
                    }
                }
            }
        }
    }
}
