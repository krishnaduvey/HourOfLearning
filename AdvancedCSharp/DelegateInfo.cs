using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class DelegateInfo
    {

      

    // A way to pass a function as arguement which we are doing via lambda. so we can say lambda uses delegates internally
    /*
     Note :
     Delegated are the OO equivalent of function pointers. Unlike function pointers, delegates are object oriented, type safe and secure. and are declared in the form of classes.
     Delegates shall have a base type of System.Delegate.
     Delegates are there under-the-hood every time you use a lambda in LINQ (=>) or a Func<T>/Action<T> to make your code more functional. 
     But how do they actually work and what’s going in the CLR when you use them?



        Methods that are created in this way are technically know as EEImpl methods (i.e. implemented by the ‘Execution Engine’), 
        EEImpl Delegate methods whose implementation is provided by the runtime (Invoke, BeginInvoke, EndInvoke)



        .Net supports two kinds of delegates: Open delegates and closed delegates.

        When you create a delegate that points to an instance method, the instance that you created it from is stored in the delegate’s Target property.  
        This property is passed as the first parameter to the method that the delegate points to.  
        For instance methods, this is the implicit this parameter; for static methods, it's the method's first parameter.  
        These are called closed delegates, because they close over the first parameter and bring it into the delegate instance.

        It is also possible to create open delegates which do not pass a first parameter.  
        Open delegates do not use the Target property; instead, all of the target method’s parameters are passed from the delegate’s formal parameter list, including the first parameter.  
        Therefore, an open delegate pointing to a given method must have one parameter more than a closed delegate pointing to the same method.  
        Open delegates are usually used to point to static methods.  
        When you make a delegate pointing to a static method, you (generally) don't want the delegate to hold a first parameter for the method. 



     */

    public delegate string SimpleDelegate(int x);
        public delegate int SimpleDelegate2(int x, int y);

        //It starts by wiring up the delegate constructor (ctor)
        // Creation of the delegate Invoke() method

        public string DelegateInfoClasssMethod(int x)
        {
            Console.WriteLine("Call be Delegate");
            return "Call be Delegate";

        }

        public int DelegateInfoClasssMethod(int x, int y)
        {
            Console.WriteLine("Call be Delegate");
            return x + y;

        }

        public static void DelegationStart()
        {

            DelegateInfo dlInfo = new DelegateInfo();
            SimpleDelegate sDelegate = new SimpleDelegate(dlInfo.DelegateInfoClasssMethod);
            string result = sDelegate(10);

            //SimpleDelegate2 sDelegate2 = new SimpleDelegate2(dlInfo.DelegateInfoClasssMethod);
            //int result2 = sDelegate2(10,20);
            //int sum = sDelegate(10,20);

            //Open Delegate
            //An open delegate pointing to this instance method would take a single string parameter, and call the method on that parameter.
            // As a concrete example, consider the String.ToUpperInvariant() method.  
            //Ordinarily, this method takes no parameters, and operates on the string it’s called on.  


            Func<string> closed = new Func<string>("hello".ToUpperInvariant);
            Func<string, string> open = (Func<string, string>)
                Delegate.CreateDelegate(typeof(Func<string, string>), typeof(string).GetMethod("ToUpperInvariant"));

            closed();
            open("abc");

        }


        public delegate void Print(int? value);


        public static void AnotherWayToCallByDelegates()
        {
            PrintHelper(PrintNumber, null);
            PrintHelper(PrintMoney, null);
            PrintHelper(PrintSalary, 20);

        }



        public static void PrintHelper(Print delegateFunc, int? x)
        {
            delegateFunc(x);
        }
        public static void PrintNumber(int? num)
        {
            Console.WriteLine($"Number : {0}", num);
        }
        public static void PrintMoney(int? money)
        {
            Console.WriteLine($"Money : {0}", money);
        }


        public static void PrintSalary(int? Salary)
        {
            Console.WriteLine("Current Salary : {0}", Salary);
        }

    }
}

namespace Delegates
{
    public delegate void MyDelegate();
    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Inside Method1...");
        }

        public static void Method2()
        {
            Console.WriteLine("Inside Method2...");
        }

        static void Hello()
        {
            MyDelegate d = null;
            d += Method1;
            d += Method2;
            d.Invoke();
            Console.ReadLine();
        }

    }

}






/*
 
    Difference between Lambda and Delegates :
    
    They are actually two very different things. "Delegate" is actually the name for a variable that holds a reference to a method or a lambda, and a lambda is a method without a permanent name.

Lambdas are very much like other methods, except for a couple subtle differences.

A normal method is defined in a "statement" and tied to a permanent name, whereas a lambda is defined "on the fly" in an "expression" and has no permanent name.
Some lambdas can be used with .NET expression trees, whereas methods cannot.
A delegate is defined like this:

delegate Int32 BinaryIntOp(Int32 x, Int32 y);
A variable of type BinaryIntOp can have either a method or a labmda assigned to it, as long as the signature is the same: two Int32 arguments, and an Int32 return.

A lambda might be defined like this:

BinaryIntOp sumOfSquares = (a, b) => a*a + b*b;
Another thing to note is that although the generic Func and Action types are often considered "lambda types", they are just like any other delegates. 
The nice thing about them is that they essentially define a name for any type of delegate you might need (up to 4 parameters, though you can certainly add more of your own). 
So if you are using a wide variety of delegate types, but none more than once, you can avoid cluttering your code with delegate declarations by using Func and Action.

Here is an illustration of how Func and Action are "not just for lambdas":

Int32 DiffOfSquares(Int32 x, Int32 y)
{
  return x*x - y*y;
}

Func<Int32, Int32, Int32> funcPtr = DiffOfSquares;
Another useful thing to know is that delegate types (not methods themselves) with the same signature but different names will not be implicitly casted to each other. 
This includes the Func and Action delegates. However if the signature is identical, you can explicitly cast between them.

Going the extra mile.... In C# functions are flexible, with the use of lambdas and delegates. But C# does not have "first-class functions". 
You can use a function's name assigned to a delegate variable to essentially create an object representing that function. But it's really a compiler trick. 
If you start a statement by writing the function name followed by a dot (i.e. try to do member access on the function itself) you'll find there are no members there to reference. 
Not even the ones from Object. This prevents the programmer from doing useful (and potentially dangerous of course) things such as adding extension methods that can be called on any function. 
The best you can do is extend the Delegate class itself, which is surely also useful, but not quite as much.


    Open Cloesed delegates :
    https://blog.slaks.net/2011/06/open-delegates-vs-closed-delegates.html

     
     */


/*
 Working of Delegate :
 The signature of a delegate looks like this:
delegate result-type identifier ([parameters])

The following statement shows how you can declare a delegate.
public delegate void MyDelegate(string text);

    As you can see in the above statement, the delegate name is "MyDelegate" can it has a return type of "void" and it accepts a string object as argument. 
    This implies that the delegate MyDelegate can point to a method that has identical signature. This is just a declaration though -- you should always instantiate a delegate before you can use it. The statement given next shows how you can instantiate the delegate declared above.

MyDelegate d = new MyDelegate(ShowText);

Once you have declared and instantiated the delegate, you can invoke the method that the delegate points to easily.

d("Hello World...");

Here, d is the delegate instance
You can also invoke the method that the delegate instance points to using the Invoke() method on the delegate instance as shown below.

d.Invoke("Hello World...");

If you have a method that accepts two numbers and you want to add them and return the sum of the two numbers, you can use a delegate to store the return value of the method as shown in the code snippet given below.
int result = d(12, 15);


    Note :
    Delegates are ideally suited to implement event driven programming. 
    A delegate doesn't need to know the class of the object to which it needs to refer to. 
    All it needs to know is the signature of the method to which it would point. 
    Proper usage of delegates can promote code re-usability and flexibility in your designs

    1) Delegate is a function pointer. It is reference type data type.
        Syntax: public delegate void <function name>(<parameters>)
    2) A method that is going to assign to delegate must have same signature as delegate.
    3) Delegates can be invoke like a normal function or Invoke() method.
    4) Multiple methods can be assigned to the delegate using "+" operator. It is called multicast delegate.

 */
