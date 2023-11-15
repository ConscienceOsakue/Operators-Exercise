using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //For division create two integer variable called a and b

            var a = 17;
            var b = 4;
            var sum = a + b;
            var subtr = a - b;
            var multi = a * b;
            var quotient = a / b;
            var remainder = a % b;

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine($"{a} + {b} = {sum}, {a} - {b} = {subtr}, {a} * {b} = {multi}, {a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your cicle?");


            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCircle(radius));

            Console.WriteLine($"The value k = {k}.");
        }

        //define a method - which perform some functionality. That can be 
        // used over and over again.
        public static double AreaOfCircle(double radius)
        
        {
            //This is the scope of the method.
            var area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
        //var is 
    }
}