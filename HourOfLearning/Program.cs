using System;
using Assignment2 ;
using AssignmentOne;

namespace HourOfLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDataTypes();
            Addition.AdditionOfTwoNumbers(4,5);
            Subtraction.SubtractionOfTwoNumbers(4,5);

        }
        public static void PrintDataTypes()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Type    Byte(s) of memory               Min                            Max");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
           
            Console.ReadKey();
        }
    }
}

// Csharp tutorials
//https://jonskeet.uk/csharp/parameters.html
//https://csharpindepth.com/Articles/PropertiesMatter
