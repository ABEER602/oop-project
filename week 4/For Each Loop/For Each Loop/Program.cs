using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Each_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var i in Numbers)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
