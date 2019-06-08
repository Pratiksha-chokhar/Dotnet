using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main1(string[] args)
        {
            Mypoint1 mp = new Mypoint1();
            mp.x = 100;
            mp.y = 200;
            Console.WriteLine(mp.x);
            Console.WriteLine(mp.y);

            Console.ReadLine();
            
        }

    }
    public struct Mypoint1
    {
        public int x, y;
        public Mypoint1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
namespace valuetype2
{
    class program
    {
        static void Main()
        {
            DisplayDrink(TypeofDrink.coffee);
            Console.ReadLine(  );
        }
        static void DisplayDrink(TypeofDrink t)
        {
            if (t == TypeofDrink.tea)
                Console.WriteLine("Good morning");
            else if (t == TypeofDrink.soda)
                Console.WriteLine("Good afternoon");
            else if (t == TypeofDrink.milk)
                Console.WriteLine("Good evening");
            else if (t == TypeofDrink.coffee)
                Console.WriteLine("Good night");
        }

    }
    public enum TypeofDrink:short

    {
        tea=10,
        coffee=20,
        milk,
        soda

            
    }
}
