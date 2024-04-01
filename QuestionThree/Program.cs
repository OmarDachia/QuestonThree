using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2:-> Write a Promgram to input principal, rate, time & find the simple interest.
            //The formular for Simple interest is 
            //1. Interest = Principal × Rate × Time
            //2. Interest = (Principal × Rate × Time)/100

            int time = 0;
            double principal = 0, rate = 0, simple_interest = 0;

            Console.WriteLine("#2:-> Write a Promgram to input principal, rate, time & find the simple interest.");
            Console.WriteLine("=================================================================================");
            Console.WriteLine("User Inputs:->");
            Console.WriteLine("++++++++++++++");

            Console.WriteLine("Enter Principal");
            principal =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time");
            time = int.Parse(Console.ReadLine());

            simple_interest = principal * rate * time;
            //simple_interest = (principal * rate * time) / 100;

            Console.WriteLine("Result:->");
            Console.WriteLine("+++++++++");
            Console.WriteLine(string.Format("The Simple interest with Principal of {0} and Rate of {1} in the Time span of {2} is {3}",principal,rate,time,simple_interest));
            Console.ReadKey();


        }
    }
}
