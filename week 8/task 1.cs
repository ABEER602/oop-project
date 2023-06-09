using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_8_lab.BL;

namespace week_8_lab
{
    class Program
    {
       static void Main(string[] args)
        {
             Console.WriteLine("Enter height");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter color");
            string c = (Console.ReadLine());
            Cylinder s1 = new Cylinder();
            Cylinder s2 = new Cylinder(r);
            Cylinder s3 = new Cylinder(r,c);
            Cylinder s4 = new Cylinder(r,h,c);
            s1.setRadius(r);
            s1.setHeight(h);
            s1.setColor(c);
            s1.getVolume();
            s1.getArea();
            string a = s1.toString();
            Console.WriteLine(a);
            Console.ReadKey();
        }

    }
}
