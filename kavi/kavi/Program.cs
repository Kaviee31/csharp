using System.Linq.Expressions;

namespace kavi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string name;
            //Console.WriteLine("Enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine("hi "+name);

            
            //Console.WriteLine("enter 2 numbers");
          
            //int numa = Convert.ToInt32(Console.ReadLine());
            //int numb = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(numa + numb);
            
            Rectangle rectangle = new Rectangle(5, 7);
            int ans = rectangle.GetArea();
            Console.WriteLine(ans);
            Console.ReadLine();

        }
    }
}
