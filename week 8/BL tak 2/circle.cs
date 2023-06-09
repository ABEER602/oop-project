using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_8_lab.BL
{
    class circle
    {
        protected double radius = 1.0;
        protected string color = "red";
        

        public circle()
        {


        }
        public circle(double radius)
        {
            this.radius = radius;
        }
        public circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
     
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getcolor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            double Area = (Math.PI * Math.Pow(getRadius(), 2));
            return Area;
        }
        public string toString()
        {
            return ("Radius: " + radius + "Color: " + color + "Area :" + getArea());
        }
        
     

    }
}
