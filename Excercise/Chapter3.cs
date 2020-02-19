using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Chapter3
    {

        public static void FizzBuzzProblem() {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else
                {
                    Console.Write(i);
                }

                // put a comma and space after every number except 100
                if (i < 100) Console.Write(", ");

                // write a carriage-return after every ten numbers
                if (i % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void CheckedAndUnChecckedBlockToSaveOurCodeToGetOverflowException() {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine($"Initial value: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The code overflowed but I caught the exception.");
            }

            unchecked
            {
                int y = int.MaxValue + 1;

                Console.WriteLine($"Initial value: {y}");
                y--;
                Console.WriteLine($"After decrementing: {y}");
                y--;
                Console.WriteLine($"After decrementing: {y}");
            }

            checked
            {
                try
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
                }
            }


        }

        public static void CastingAndConversion()
        {

            int a = 10;
            double b = a; // an int can be safely cast into a double
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d); // d is 9 losing the .8 part

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");

            // Understanding the default rounding rules

            double[] doubles = new[]
              { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (double n in doubles)
            {
                Console.WriteLine($"ToInt({n}) is { Convert.ToInt32(n)}");
            }

            // Taking control of rounding rules
            foreach (double n in doubles)
            {
                Console.WriteLine(format:
                  "Math.Round(value: {0}, digits: 0, mode: MidpointRounding.AwayFromZero) is {1}",
                  arg0: n,
                  arg1: Math.Round(value: n,
                    digits: 0,
                    mode: MidpointRounding.AwayFromZero));
            }

            // Converting from any type to a string

            int number = 12;
            Console.WriteLine(number.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            object me = new object();
            Console.WriteLine(me.ToString());

            // allocate array of 128 bytes 
            byte[] binaryObject = new byte[128];

            // populate array with random bytes 
            (new Random()).NextBytes(binaryObject);

            Console.WriteLine("Binary Object as bytes:");

            for (int index = 0; index < binaryObject.Length; index++)
            {
                Console.WriteLine($"{binaryObject[index]:X} ");
            }
            Console.WriteLine();

            // convert to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            Console.WriteLine($"Binary Object as Base64: {encoded}");

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");

            Console.WriteLine("How many eggs are there? ");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }



           

        }
    }
}

/*
 
Note : Excercise for switch case and lebel understanding
https://github.com/markjprice/cs8dotnetcore3/blob/master/Chapter03/SelectionStatements/Program.cs 

*/
