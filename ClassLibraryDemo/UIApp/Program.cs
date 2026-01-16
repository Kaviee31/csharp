
using DemoLib;
namespace UIApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length= 10;
            rectangle.Width = 5;
            Console.WriteLine($"Area of rectangle {rectangle.GetArea()}");
        }
    }
}
