using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class Program
    {
        static void Main1(string[] args)
        {
            Student[] arr = new Student[2];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Student();
                Console.WriteLine("Enter the student details{0}", i);
                arr[i].Rollno = Convert.ToInt32(Console.ReadLine());
                arr[i].Name = Console.ReadLine();
                arr[i].Subject1 = Convert.ToDecimal(Console.ReadLine());
                arr[i].Subject2 = Convert.ToDecimal(Console.ReadLine());

            }
            foreach (Student o in arr)
            {
                o.display();
            }




            Console.ReadLine();
        }

        static void Main()
        {
            List<Student> student1 = new List<Student>();
            student1.Add(new Student { Rollno = 1, Name = "a", Subject1 = 50, Subject2 = 60 });
            student1.Add(new Student { Rollno = 2, Name = "a", Subject1 = 50, Subject2 = 60 });
            student1.Add(new Student { Rollno = 3, Name = "a", Subject1 = 50, Subject2 = 60 });
            student1.Add(new Student { Rollno = 4, Name = "a", Subject1 = 50, Subject2 = 60 });
            foreach (Student e in student1)
            {
                e.display();

            }
            
            Console.WriteLine("Enter Roll no to delete details");
            int trn = Convert.ToInt32(Console.ReadLine());
            Student s = null;
            foreach (Student e in student1)
            {
                if (e.Rollno == trn)
                {
                    s = e;
                }
            }

            student1.Remove(s);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("after deleting {0}", trn);
            foreach (Student e in student1)
            {
                e.display();
            }

            
            Console.ReadLine();

        }
    }
    

    class Student
    {
        private int rollno;// RollNo
        private string name; //Name - no blank strings
        private decimal subject1;  //Subject1 - 0 to 100
        private decimal subject2; //Subject2 - 0 to 100

        public decimal GetPercentage(Student obj)
        {
            decimal percent = (obj.Subject1 + obj.Subject2) / 2;
            return percent;
        }

        public void display()
        {
            Console.WriteLine(Rollno + " " + Name + " " + subject1 + " " + subject2+" "+ GetPercentage(this));
        }

        #region validation
        public int Rollno
        {
            get { return rollno; }
            set
            {
                if (value > 0)
                    rollno = value;
                else
                    Console.WriteLine("enter valid roll number");
            }
        }
        public string Name
        {
           get { return name; }
            
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Enter Name ");
            }
        }
        public decimal Subject1
        {
            get { return subject1; }
            set
            {
                if (value > 0 && value < 100)
                    subject1 = value;
                else
                    Console.WriteLine("Enter valid Marks 0-100");
            }
        }
        public decimal Subject2
        {
            get => subject2;
            set
            {
                if (value > 0 && value < 100)
                    subject2 = value;
                else
                    Console.WriteLine("Enter valid Marks 0-100");
            }
        }

        #endregion

    }

}
