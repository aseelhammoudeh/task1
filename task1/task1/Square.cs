using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Square:Shape
    {
        private double side;


        public Square(double side)
        {
           this.side = side;
         
        }

        public void setSide(double side)
        {
            if (validity(side))
            {
                this.side = side;
            }
        }

        public double getSide()
        {
            return side;
        }

        public override double calculateArea()
        {
            double area = side * side;
            return area;

        }

      
    }
}
