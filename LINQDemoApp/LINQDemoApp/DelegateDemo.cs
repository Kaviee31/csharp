using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{

    public delegate int MathsDelegate(int a, int b);// 2. Define delegate
    public delegate void MultiCastDelegate(int a, int b);
    internal class DelegateDemo
    {
        static int AddNum(int x, int y)
        {
            return x + y;

        }
        static void Addnumbers(int x, int y)
        {
            Console.WriteLine($"Addition ={x + y}");
        }
        static void SubtractNum(int x, int y)
        {
            Console.WriteLine($"Subtraction ={x - y}");
        }
        static int MultiplyNum(int x, int y)
        {
            return x * y;
        }           
        static void Main (string[] args)
        { // 1. Declare delegate
            MathsDelegate mathDel = new MathsDelegate(AddNum); // 3. Instantiate delegate
            mathDel += MultiplyNum;
            int result = mathDel(10, 20); // 4. Call delegate
            Console.WriteLine(result);
            Console.WriteLine("--------------------------------------------------");
            MultiCastDelegate multiDel = new MultiCastDelegate(Addnumbers);
            multiDel += SubtractNum;
            multiDel(50, 20);


            MathsDelegate mathsDelegate1 = delegate (int a, int b)
            {
                return a + b;
            };
            result = mathsDelegate1(100, 200);
            Console.WriteLine("Result " +result);

            MathsDelegate mathsDelegate2 = (a, b) => a + b;
            result = mathsDelegate2(10, 20);
            Console.WriteLine(" LambdaResult " + result);

            MultiCastDelegate multiCastDelegate1 = (a, b) =>
            {
                Console.WriteLine($" Lambda Addition ={a + b}");
                Console.WriteLine($" Lambda Subtraction ={a - b}");
            };
            multiCastDelegate1(500, 200);

            Action<int, int> actionDel = (a, b) =>
            {
                Console.WriteLine($" Action Addition ={a + b}");
                Console.WriteLine($" Action Subtraction ={a - b}");
            };
            actionDel(700, 300);
            Predicate<int> predicateDel = (a) =>
            {
                return a % 2 == 0;
            };  
            bool isEven = predicateDel(10); 
            
            Func<int, int, int> funcDel = (a, b) => a + b;
            int funcResult = funcDel(20, 30);
               
            
         
        }
    }
}
