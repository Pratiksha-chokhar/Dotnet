using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //class Program
    //{
    //    static void Main1(string[] args)
    //    {
    //    }
    //}
    //class derived:TestInheritance.BaseClass
    //{

    //    void display()
    //    {

    //    }

    //}
    
   
}
//constructor inheritance
namespace Inheritance1
{
    class program
    {
        static void Main1()
        {
            DerivedClass obj = new DerivedClass(10, 20);
            Console.ReadLine();

        }

    }
        public class BaseClass
        {
            private int i;
            public BaseClass()
            {
                i = 1;
                Console.WriteLine("base class no param cons");
            }
            public BaseClass(int i)
            {
                this.i = i;
                Console.WriteLine("base class int cons");
            }
        }
        public class DerivedClass : BaseClass
        {
            public int j;
            public DerivedClass()
            {
                j = 2;
                Console.WriteLine("derived class no param cons");

            }
            public DerivedClass(int i, int j) : base(i)
            {
                this.j = j;
                Console.WriteLine("derived class int cons");
            }
        }


}
namespace InheritanceExamples3
{
    class Prgram
    {
        static void Main()
        {
            DerivedClass obj;
            obj = new DerivedClass();
            obj.Display1();
            obj.Display1("sss");

            obj.Display2();
            obj.Display3();

            Console.ReadLine();


            //BaseClass obj;
            //obj = new BaseClass();
            //obj.Display2();
            //obj.Display3();

            //Console.WriteLine();


            //obj = new DerivedClass();
            //obj.Display1();

            //obj.Display2();
            //obj.Display3();

            //Console.WriteLine();


            //obj = new SubDerivedClass();
            //obj.Display2();
            //obj.Display3();

            //Console.WriteLine();

            //obj = new SubSubDerivedClass();
            //obj.Display2();
            //obj.Display3();

            //Console.WriteLine();

            //Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        //overload the base class method in the derived class
        public void Display1(string s)
        {
            Console.WriteLine("derived display1");
        }
        //hide the base class method in the derived class
        public new void Display2()
        {
            Console.WriteLine("derived display2");
        }
        //override the base class method in the derived class
        public override void Display3()
        {
            Console.WriteLine("derived display3");
        }

    }
    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("subderived display3");
        }
    }
    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("subsubderived display3");
        }

    }

}




