using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] l = new int[20];
            for (int i = 0; i < 100; i++)
            {
                l[i] = rnd.Next(20, 50);

                Console.Write(l[i]);
            }
            Console.ReadKey();
        }
    }
}
