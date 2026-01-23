using System.Threading;

namespace Thread_Async_TPL_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Thread newThread = new Thread(PrintWorkerNumbers);
            newThread.Start();
            Thread.Sleep(100);
            Thread newThread2 = new Thread(() => PrintWorkerNumbersParam(10));
            newThread.Join();
            newThread2.Join();
            Console.WriteLine("Main method ended");
        }
        static void PrintWorkerNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Worker Thread: {i}, Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000);
            }
        }
            static void PrintWorkerNumbersParam( int count)


            {
                for (int i = 0; i < (count); i++)
                {
                    Console.WriteLine($"Worker Thread: {i}, Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(2000);
                }

            }
    }
}