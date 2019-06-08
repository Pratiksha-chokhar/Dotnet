using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.i = 100;
            o.j = 101;
           // DoHere(o);
            //DoHere2(o);
            DoHere3(ref o);
            Console.WriteLine(o.i);
            Console.WriteLine(o.j);
            Console.ReadLine();

        }
        static void DoHere(Class1 obj)//changes are reflectecting
        {
            obj.i = 200;
        }
        static void DoHere2(Class1 obj)//memory get reallocated,original variable does not change
        {
            obj = new Class1();
            obj.i = 200;
        }
        static void DoHere3( ref Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }

    }
    public class Class1
    {
        public int i;
        public int j;

    }
}
