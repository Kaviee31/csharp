using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    // create paint application which draw different shapes

    public interface Idraw
    {
        void Draw();
    }
    class Rectangle : Idraw
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
    class Circle : Idraw
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    public class Square : Idraw
    {
        public void Draw()
        {
            Console.WriteLine("draw square");
        }
    }
    internal class Paint
        {
            public void Draw(Idraw shape)
            {
                shape.Draw();
            }
           
        }
    }

