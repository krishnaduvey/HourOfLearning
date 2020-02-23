using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class LambdaInfo
    {
        /*
         Key to Remember :
         1. Anonymous Function :
                       *a: doesn’t contain any name 
                       b: C# 2.0 
                       c: wants to create an inline method and also wants to pass parameter
                       *d: An Anonymous method is defined using the delegate keyword and the user can assign this method to a variable of the delegate type.
        
          
         2. Difference that in Lambda expressions you don’t need to specify the type of the value that you input thus making it more flexible to use.
            The ‘=>’{ Lambda declaration Operator } is the lambda operator which is used in all lambda expressions.
            and Use to separate the lambda's parameter list from its body.

            You can use lambda expressions in any code that requires instances of delegate types or expression trees,


            The following rules apply to variable scope in lambda expressions:

                A variable that is captured will not be garbage-collected until the delegate that references it becomes eligible for garbage collection.

                Variables introduced within a lambda expression are not visible in the enclosing method.

                A lambda expression cannot directly capture an in, ref, or out parameter from the enclosing method.

                A return statement in a lambda expression doesn't cause the enclosing method to return.

                A lambda expression cannot contain a goto, break, or continue statement if the target of that jump statement is outside the lambda expression block. 
                It's also an error to have a jump statement outside the lambda expression block if the target is inside the block.




            */

        public delegate void PetAnimal(string pet); // Create delegate
        public static void CallAnonymous() {
            PetAnimal petAnimal = delegate (string petName)
            {
                Console.WriteLine(petName);
            };
            petAnimal("Hello");
        }

     

        public delegate void NumberCount(int count); // Create delegate
        public static void CallAnonymousToCheckImplicitConversion()
        {
            NumberCount count = delegate (int counts)
            {
                Console.WriteLine(counts);
            };
            count(45);
        }


        /// <summary>
        ///  In the code given below, we have a list of integer numbers. 
        ///  The first lambda expression evaluates every element’s square { x => x*x } 
        ///  and the second is used to find which values are divisible by 3 { x => (x % 3) == 0 }.
        ///  And the foreach loops are used for displaying.
        /// </summary>
        public static void LambdaFunction() {

            List<int> list = new List<int>() { 2, 4, 6, 2, 45 };
            var square = list.Select(x=>x*x);
            var divisible = list.FindAll(x=>(x%3)==0);

        }





        public int rollNo
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// Lambda expressions can also be used with user-defined classes. 
        /// The code given below shows how to sort through a list based on an attribute of the class that the list is defined upon.
        /// </summary>
        public static void LambdaFunction2()
        {

            List<LambdaInfo> details = new List<LambdaInfo>() {
            new LambdaInfo{ rollNo = 1, name = "Liza" },
                new LambdaInfo{ rollNo = 2, name = "Stewart" },
                new LambdaInfo{ rollNo = 3, name = "Tina" },
                new LambdaInfo{ rollNo = 4, name = "Stefani" },
                new LambdaInfo { rollNo = 5, name = "Trish" }
            };

            // To sort the details list  
            // based on name of student 
            // in acsending order 
            var newDetails = details.OrderBy(x => x.name);



            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            // Expression Tress Conversion of Lambda Expression :

            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);


            int[] arr = new int[] { 2,4,6,2};
            var reverse = arr.Select(x=> x.CompareTo(x)).Reverse();
            foreach (var val in reverse)
                Console.WriteLine(val);


        }


        public static void ReverseStringInLambda() {

            string str = "Hello World";
            char[] chars = str.ToCharArray();
            var reverseString = chars.Select(x => x).Reverse();
        }

        public static void StatementLambda() {

            Action<string> nameGreet = greet =>
              {
                  string greeting = $"Hello {greet}";
                  Console.Write(greeting);
              };
            nameGreet("Krishna");
        }


        public static void LambdaWithTouple() {

            Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
            var numbers = (2, 3, 4);
            var doubledNumbers = doubleThem(numbers);
            Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");
        }

       

    }
}
