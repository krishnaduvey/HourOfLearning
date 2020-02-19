using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Excercise
{
    class Chapter2
    {

    }

    class Excercise2_1
    {
        string telephoneNumber; // Telephone numbers need to be stored as a text/string data type because they often begin with a 0 and if they were stored as an integer then the leading zero would be discounted.
        float height;//  A double variable can provide precision up to 15 to 16 decimal points as compared to float precision of 6 to 7 decimal digits. Both data types are suitable for storing height of a patient.
        byte age;  //we are sure, we won't have negative values. range is 0 to 255.
        decimal salary; //The DECIMAL data type allows you to specify the total number of digits as well as the number of digits after the decimal .
                        // decimal vs double 
                        /*
                            For money, always decimal. It's why it was created.
                            If numbers must add up correctly or balance, use decimal. This includes any financial storage or calculations, scores, or other numbers that people might do by hand.
                            If the exact value of numbers is not important, use double for speed. This includes graphics, physics or other physical sciences computations where there is already a "number of significant digits".

                         */

        string iSBN1; // 13 digit number from 2007
        Int64 iSBN2; //Int 64 can hold till 19 digits  OR  Represents a 64-bit signed integer.
        long isbn3; // internally its Int64 as per source code.

        /*
         I would use bigint because it needs only 8 bytes per value.
        decimal(12,0) needs 9 bytes and varchar or nvarchar even more (12 or 24 bytes respectively in case of storing 12 digits).
        Formatting numbers can be done in application. It's also much easier to change formatting in app in case of requirements change.
         */
        long population;





        public static void Numbers() {


            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number 
            // including 0
            int integerNumber = -23;

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check the three variables have the same value


            // both statements output true
            Console.WriteLine($"{decimalNotation == binaryNotation}");

            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            Console.WriteLine("Using doubles:");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine("Using decimals:");

            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }
        }

    }

    class Excercise2_2
    {

        // Arguements:

        public static void arguementsTest(string[] args)
        {

            Console.WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            if (args.Length < 4)
            {
                Console.WriteLine("You must specify two colors and dimensions, e.g.");
                Console.WriteLine("dotnet run red yellow 80 40");
                return; // stop running
            }


            ConsoleColor ForegroundColor = (ConsoleColor)Enum.Parse(
                          enumType: typeof(ConsoleColor),
                          value: args[0],
                          ignoreCase: true);
            ConsoleColor BackgroundColor = (ConsoleColor)Enum.Parse(
                          enumType: typeof(ConsoleColor),
                          value: args[1],
                          ignoreCase: true);
            try
            {
                int WindowWidth = int.Parse(args[2]);
                int WindowHeight = int.Parse(args[3]);
            }
            catch (PlatformNotSupportedException)
            {
                Console.WriteLine("The current platform does not support changing the size of a console window.");
            }
        }

    }

    class Excercise2_3
    {
        public static void printSizeOfEachDataTypeWithMaxAndMinRange() {

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Type    Byte(s) of memory               Min                            Max");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            Console.WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            Console.WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            Console.WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            Console.WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            Console.WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            Console.WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            Console.WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            Console.WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            Console.WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            Console.WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

    }
}


/*
 
    Note :
    var can only be used as local variable in a function. 
    dynamic type can be used for property, passed as method argument and method also can return dynamic type. 
    object variable need to cast to original type to use it and to perform desired operations because compiler does not has any information about its type.
     
     */
