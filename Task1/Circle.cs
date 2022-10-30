using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        public static double GetLengthCircle(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double GetSquareCircle(double r)
        {
            return Math.PI * r * r;
        }

        public static bool GetInCircle(double r, double x0, double y0, double x, double y)
        {
            if (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(r,2))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }


    }
}
