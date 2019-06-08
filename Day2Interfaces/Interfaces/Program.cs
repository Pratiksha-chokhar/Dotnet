using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main1(string[] args)
        {
            DefineFunction df = new DefineFunction();
            df.delete();
            Console.ReadLine();

        }
    }

    public interface MyFunction
    {
        void insert();
        void update();
        void delete();

    }
    public class DefineFunction:MyFunction
    {
        public void Display()
        {
            Console.WriteLine("Define function display");
        }
        public void insert()
        {
            Console.WriteLine("Define function insert");
        }
        public void update()
        {
            Console.WriteLine("define function update");
        }
        public void delete()
        {
            Console.WriteLine("delete the myFunction def");
        }
    }
}
namespace interfaceExample
{
    class Program
    {
        static void Main2()
        {
            Class1 o = new Class1();
            MyFunction mf;
            mf = o;
            o.delete();

            MyClass mc;
            mc = o;
            o.delete();

            Console.ReadLine();




            

        }
    }

    public interface MyFunction
    {
        void insert();
        void update();
        void delete();

    }
    public interface MyClass
    {
        void open();
        void close();
        void delete();

    }
    public class Class1:MyFunction,MyClass
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display");

        }

        public void delete()
        {
            Console.WriteLine("class1 delet");
        }

       
public void insert()
        {
            Console.WriteLine("class1 insert");
        }

        public void update()
        {
            Console.WriteLine("class1 update");
        }

        void MyClass.open()
        {
            Console.WriteLine("Myclass open");
        }

        void MyClass.close()
        {
            Console.WriteLine("Myclass close");
        }

        void MyClass.delete()
        {
            Console.WriteLine("Myclass delete");
        }
    }
}

namespace newInheritance
{
    class program
    {
        static void Main()
        {

        }
    }


    public interface MyFunction
    {
        void insert();
        void update();
        void delete();

    }
    public class class1 : MyFunction
    {
        
        public void delete()
        {
            Console.WriteLine("class3  delete");
        }

        public void insert()
        {
            Console.WriteLine("class3  insert");
        }

        public void update()
        {
            Console.WriteLine("class3  update");
        }
    }
    public class class3 : MyFunction
    {
        public void show()
        {
            Console.WriteLine("class3 show");
        }
        public void delete()
        {
            Console.WriteLine("class3 delete");
        }

        public void insert()
        {
            Console.WriteLine("class3 insert");
        }

        public void update()
        {
            Console.WriteLine("class3 updatte");
        }
    }
}