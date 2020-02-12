using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDataTypes();
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
