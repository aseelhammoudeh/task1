using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Rectangle:Shape
    {
        private double width;
        private double length;


        public Rectangle()
        {
            

        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;


        }
        
        public void setWidth(double width)
        {
            if (validity(width))
            {
                this.width = width;
            }
     
            
        }

        public void setLength(double length)
        {
            if (validity(length))
            {
                this.length = length;
            }
        }

        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
                
        public override double calculateArea()
        {
            double area = length * width;

            return area;
        }
        // when create it , check if it's valid or not , can't be zero , or negative width and length 
      

     
    }
}
