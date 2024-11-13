using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstprogram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hiiii");

            int year = 2023;
            string month = "oct";

            //concate

            Console.WriteLine("month=" + month + " Year=" + year);

            //using placeholder{}

            Console.WriteLine("month= {0} year={1}",month,year);


            //Check year is leep or not

            if (year % 4 == 0)
            {
                Console.WriteLine("This is leep year");
            }
            else {
                Console.WriteLine("This is not leep year");
                  }

            //positive or negative

            int num = -5;

            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num < 0) {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }


            //odd or even

            int num2 = 5;

            if (num2 % 2 == 0)
            {
                Console.WriteLine("Number is even");

            }
            else { 
            Console.WriteLine("Number id odd");
            }

            //user input
            Console.WriteLine("Enter number=");
            Console.ReadLine();

        }
    }
}
