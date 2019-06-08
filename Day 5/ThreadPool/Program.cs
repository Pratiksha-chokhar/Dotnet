using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread o1 = new Thread(Func1);
            Thread o2 = new Thread(new ThreadStart(Func2));
            o1.Start();
            o1.IsBackground = true;
            Console.WriteLine(o1.IsThreadPoolThread);
            o1.Join();
            //o2.Start();
            if (o1.ThreadState == ThreadState.Stopped)
                Console.WriteLine("t1 over");
            o1.Join();
            Console.ReadLine();

            for (int i=0;i<10;i++)
            {
                Console.WriteLine("Main Thread is running" +i.ToString());
            }
            
        }

        static void Func1()
        {
            for (int i=0;i<10;i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine("Thread is" +i.ToString());

            }
        }
        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine("Thread2 is" + i.ToString());

            }
        }
    }
}
