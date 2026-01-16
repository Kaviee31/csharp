using System;
using System.Collections.Generic;
using System.Text;

namespace kavi
{
    internal class Rectangle
    {
        int length;
        int width;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.length = height;
        }

        public int GetArea()
        {
            return length * width;
        }

        public int Length
        {
            get { return length; }
            set {  length = value; }
        }
        public int Width
        {
            get { return width; }   
            set { width = value; }
        }
    }
   
    
}

