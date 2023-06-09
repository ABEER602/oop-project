using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_lab.BL
{
    class Cylinder : circle
    {
        private double height = 1.0;
        

        public Cylinder() : base()
        {

        }
        public Cylinder(double radius) : base(radius)
        {
          
        }
        public Cylinder(double radius, string color) : base (radius,color)
        {
         
        }
        public Cylinder(double radius, double height, string color) : base (radius,color)
        {
            this.height = height;   
        }

        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            double volume = ( Math.PI * Math.Pow(getRadius(),2) * height);
            return volume;
        }
        public new string toString()
        {
            return ("Radius: " + radius + " Color: " + color + " Area :" + getArea() + " Volume" + getVolume());
        }
    }
}
