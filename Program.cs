using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3_4
{     class Arrayss
      {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                int[,] arr = new int[3, 4];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        arr[i, j] = rnd.Next(0, 100);
                        Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
    }
}
