using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class line
    {
        public points start;
        public points end;

        public line()
        {

        }

        public line(points start , points end)
        {
            this.start = start;
            this.end = end;
        }

        public void setStart(points atBegin)
        {
            this.start = atBegin;
        }
        public void setEnd(points end)
        {
            this.end = end;
        }
        public points getStart()
        {
            return start;
        }

        public points getEnd()
        {
            return end;
        }

        public double getGradient()
        {
            double x = end.x - start.x;
            double y = end.y - start.y;
            double gradient = y / x;
            return gradient;
        }

        public double length()
        {
            return start.ObjectDistance(end);
        }
    }

   

}
