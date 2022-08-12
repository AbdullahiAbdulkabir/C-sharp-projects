using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;


using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {   
        string LastName;
        short Age;
        int Matric;
        int SSG_324, SSG_326;
        char Gender;

        // Constructor with parameters
        public Student(string ln, short ag, int mat, int grd1, int grd2, char gen)
        {
            LastName = ln;
            Age = ag;
            Matric = mat;
            SSG_324 = grd1;
            SSG_326 = grd2;
            Gender = gen;
           // Console.WriteLine("Parameterized Constructors");
        }

        //Default Constructor
        public Student()
            : this("Alaroye ", 20, 12345, 45, 20, 'F')
        {
            //Console.WriteLine("Default Constructor");
        }
        //Public Properties
        public string MyLastName
        {
            set { LastName = value; }
            get { return LastName; }
        }
        public short MyAge
        {
            set { Age = value; }
            get { return Age; }
        }
        public int MyMatric
        {
            set { Matric = value; }
            get { return Matric; }
        }
        public int MySSG_324
        {
            set { SSG_324 = value; }
            get { return SSG_324; }
        }
        public int MySSG_326
        {
            set { SSG_326 = value; }
            get { return SSG_326; }
        }
        public char MyGender
        {
            set { Gender = value; }
            get { return Gender; }
        }
        //compute the avg score of students
        public float Average()
        {
            float Avg = (MySSG_324 + MySSG_326) / 2;
            return Avg;
        }
        public static void Swap(ref Student S1, ref Student S2)
        {
            Student temp = new Student();
            temp = S1;
            S1 = S2;
            S2 = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name");
             string MLN = Console.ReadLine();
            Student[] MyStudent =//creating an instance of class student
            {
           

            new Student(MLN,18,12345,71,65,'M'),
            new Student("David", 18, 12356, 80, 99, 'M'),
            new Student("Fatima", 19, 12354, 20, 65, 'F'),
            new Student("Diola", 20, 12326, 55, 50, 'M'),
            new Student(), //automatic initialization for sixth student
            new Student(),
            new Student(),
            };
            //Regular field assignment with public properties
            MyStudent[6].MyLastName = "Ada";
            MyStudent[6].MyAge = 16;
            MyStudent[6].MyMatric = 12351;
            MyStudent[6].MySSG_324 = 90;
            MyStudent[6].MySSG_326 = 88;
            MyStudent[6].MyGender = 'F';
            Student.Swap(ref MyStudent[2], ref MyStudent[3]);
            Console.ReadKey();
            foreach (Student S in MyStudent)
            {
                Console.WriteLine("Student {0} scored an average of {1}", S.MyLastName, S.Average());
            }
            Console.ReadKey();

            if (MyStudent[0].Average() > MyStudent[1].Average())
            {
                Console.WriteLine("{0} is better than {1},.", MyStudent[0].MyLastName, MyStudent[1].MyLastName);
            }
            else if (MyStudent[1].Average() > MyStudent[0].Average())
            {
                Console.WriteLine("{0} is better than {1}", MyStudent[1].MyLastName, MyStudent[0].MyLastName);
            }
            else
            {
                Console.WriteLine("They both have the same score.");
            }
            Console.ReadKey();

        }
    }
}
