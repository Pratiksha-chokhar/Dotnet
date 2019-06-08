using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
         //    e1.EmpNo = 10;
            Console.WriteLine(e1.EmpNo);
             e1.Name = "cdac";
            Console.WriteLine(e1.Name);
              e1.basicsal = 300;
            Console.WriteLine(e1.basicsal);
            e1.Dept = 1;
            Console.WriteLine(e1.Dept);

            Employee o1 = new Employee("vikram",300,20);
            //Console.WriteLine(o1.EmpNo);
            Employee o2 = new Employee("Vikram", 100);
            //Console.WriteLine(o2.EmpNo);
            Employee o3 = new Employee("Vikram");
            //Console.WriteLine(o3.EmpNo);
            Employee o4 = new Employee();
            //Console.WriteLine(o4.EmpNo);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            Console.WriteLine(o4);

            Console.ReadLine();



        }

    }
    public class Employee
    {
        //private string name { get; set; }
        //public int empno { get; set; }
        //public short deptno { get; set; }
        //public double sal { get; set; }
        private int Empid;
        public Employee()
        {
            empno = empno + 1;
            Empid = empno;
        }

        public Employee( string name, decimal sal=0, short deptno=0)
        {
            empno = empno + 1;
            Empid = empno;
            //this.EmpNo = empno;
           
            this.Name = name;
            this.basicsal = sal;
            this.Dept = deptno;
        }
        //public Employee(string name, double sal)
        //{
        //    empno = empno + 1;
        //    Empid = empno;
        //    this.Name = name;
        //    this.basicsal = sal;
           
            
        //}
        //public Employee(string name)
        //{
        //    empno = empno + 1;
        //    Empid = empno;
        //    this.Name = name;
            

        //}


        //for empno validation
        #region Properties

        private static int empno;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                {
                    empno = value;
                }
                else
                {
                    Console.WriteLine("Invalid login");
                }
            }
            get
            {
                return Empid;
            }
        }

        // for Name Validation
        private String name;
        public String Name
        {
            set {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("name should not be empty");
                }
            }
            get
            {
                return name;
            }
        }
        //for basic salary
        private decimal sal;
        public decimal basicsal
        {
            set
            {
                if (value > 1 && value < 1000)
                {
                    sal = value;
                }
                else
                {
                    Console.WriteLine("Invalid salary");
                }
            }
            get
            {
                return sal;
            }
        }
        //for deptno
        private short deptno;
        public short Dept
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("Enter valid DeptId");
                }

            }
            get
            {
                return deptno;
            }
        }

        public override string ToString()
        {
            return this.EmpNo +" "+this.Name+" "+this.sal+" "+this.Dept;
        }





        #endregion


    }

}
    

        
    



