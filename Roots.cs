using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthQuestion
{
    class Roots
    {
        public double x1, x2, a, b, c, delta;
        
        void calculateroots()
        {
            
            x1 = -b + Math.Pow(b*b-4*a*c, 0.5)/2*a;
            x2 = -b - Math.Pow(b*b-4*a*c, 0.5) / 2 * a;
        }
        public double firstRoot()
        {
            calculateroots();
            return x1;
        }
        public double secondroot()
        {
            calculateroots();
            return x2;
        }
       

    }
}
