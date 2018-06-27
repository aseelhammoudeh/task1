using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Triangle:Shape
    {
        private double base_of_triangle;
        private double height_of_triangle;


        public Triangle(double base_of_triangle, double height_of_triangle)
        {
            this.base_of_triangle = base_of_triangle ;
            this.height_of_triangle = height_of_triangle;
        }

        public void setBase(double base_of_triangle)
        {
            if (validity(base_of_triangle))
            {
                this.base_of_triangle = base_of_triangle;
            }
        }

        public void setHeight(double height_of_triangle)
        {
            if (validity(height_of_triangle))
            {
                this.height_of_triangle = height_of_triangle;
            }
        }

        public double getBase()
        {
            return base_of_triangle;
        }

        public double getHeight()
        {
            return height_of_triangle;
        }


        public override double calculateArea()
        {
            double area = (base_of_triangle * height_of_triangle) / 2;

            return area;

        }
       
    }
}
