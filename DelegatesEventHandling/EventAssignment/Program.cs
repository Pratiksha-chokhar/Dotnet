using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();

            e1.Invalidempno += emp_function;
            e1.Invalidempno += emp_dept;
            e1.EmpNo = -1;
            e1.Dept = -1;
            //Console.ReadLine();
            //e1.EmpNo = 10;
            //Console.WriteLine(e1.EmpNo);
            try
            {


               // e1.Name = "";
                e1.basicsal = 2000;
            }
            catch( InvalidsalException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            //Console.WriteLine(e1.Name);
            //e1.basicsal = 30.0;
            //Console.WriteLine(e1.basicsal);
            //e1.Dept = 1;
            //Console.WriteLine(e1.Dept);

        }
        private static void emp_function(int InvalidValue)
        {
            Console.WriteLine(" empno event handled here");
            Console.WriteLine("INVALID VALUE  =" + InvalidValue);
        }
        private static void emp_dept(int InvalidValue)
        {
            Console.WriteLine(" deptno event handled here");
            Console.WriteLine("INVALID VALUE  =" + InvalidValue);
        }
        public class InvalidsalException : Exception
        {
            public InvalidsalException(string message) : base(message)
            {

            }

        }
        public delegate void InvalidempnoEventHandler(int InvalidValue);
        public class Employee
        {
            public event InvalidempnoEventHandler Invalidempno;
            #region Properties

            private int empno;
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
                        //raise the event
                        if (Invalidempno != null)
                            Invalidempno(value);
                    }
                }
                get
                {
                    return empno;
                }
            }

            // for Name Validation
            private String name;
            public String Name
            {
                set
                {
                    if (value != "")
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ApplicationException("name should not be empty");
                       // Console.WriteLine("name should not be empty");
                    }
                }
                get
                {
                    return name;
                }
            }
            //for basic salary
            private double sal;
            public double basicsal
            {
                set
                {
                    if (value > 1 && value < 1000)
                    {
                        sal = value;
                    }
                    else
                    {
                        throw new InvalidsalException("salary should be within the range");
                       // Console.WriteLine("Invalid salary");
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
                        //raise the event for deptno
                        if (Invalidempno != null)
                            Invalidempno(value);
                    }

                }
                get
                {
                    return deptno;
                }
            }
            #endregion
        }

    }
}
