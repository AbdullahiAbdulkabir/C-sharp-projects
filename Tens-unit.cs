using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Put your input");
           // string num =  Console.ReadLine();
            Console.WriteLine("Input 2 digits number");

            decimal num1 = int.Parse( Console.ReadLine());
            int tens = (int) Math.Floor(num1 / 10);
            int unit =(int) num1 %10;
            Console.WriteLine("The tenth unit is {0} and the unit is {1}",tens,unit);
            //Console.WriteLine("The tenth unit is {0} and the unit is {1}",num[0],num[1]);
            int[, ,] firstArray= new int[1,3,4];
            
            Console.WriteLine(firstArray);
            Console.ReadLine();

        }
    }
}
