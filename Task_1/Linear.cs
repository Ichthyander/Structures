using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct Linear
    {
        double k;
        double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public double Root()
        {
            if (k == 0)
            {
                return double.NaN;
            }
            else
            {
                return -b / k;
            }
        }
    }
}
