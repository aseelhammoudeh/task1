using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    abstract class Shape
    {
        abstract public double calculateArea();
        public bool validity(double num)
        {
            bool valid = (num > 0 ? false : num <= 0);
            return valid;

        }
    }
}
