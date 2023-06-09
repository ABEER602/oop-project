using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_7__challenge_1_.BL;

namespace week_7__challenge_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            fireTruck t = new fireTruck();
            Hosepipes h = new Hosepipes();
            t.setHose(h);

        }
    }
}
