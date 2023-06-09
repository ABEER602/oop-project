using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class points
    {
        public int x;
        public int y;
        
        public points(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public points()
        {

        }

        public int forX()
        {
            return x;
        }

        public int forY()
        {
            return y;
        }

        public void Xvalue(int x)
        {
            this.x = x;

        }

        public void Yvalue(int y)
        {
            this.y = y;
        }

        public double CordsDistance(int x, int y)
        {
            double x1 = Math.Pow(2, (this.x - x));

            double y1 = Math.Pow(2, (this.y - y));

            double distance = Math.Sqrt(x1 + y1);
            
            return distance;
        }
        public double ObjectDistance(points obj)
        {
            return CordsDistance(obj.x, obj.y);
        }
        public double distanceFromZero()
        {

            return CordsDistance(0, 0);
        }
    }
}
