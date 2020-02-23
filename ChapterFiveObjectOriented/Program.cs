using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFiveObjectOriented
{
    
    class Program
    {
        /// <summary>
        /// Sometimes, you want to define a field that only has one value that is shared across all instances. 
        /// These are called static members because fields are not the only members that can be static.
        /// 
        /// Each instance of BankAccount will have its own AccountName and Balance values, 
        /// but all instances will share a single InterestRate value.
        /// 
        /// :C is a format code that tells .NET to use the currency format for the numbers. 
        /// ex: WriteLine(format: "{0} earned {1:C} interest.",arg1,arg2);
        /// 
        /// Use read-only fields over the const fields for two important reasons: 
        /// the value can be calculated or loaded at runtime and can be expressed using any executable statement. So, a read-only field can be set using a constructor or a field assignment. 
        /// Every reference to the field is a live reference, so any future changes will be correctly reflected by calling code.
        /// </summary>
        public class BankAccount
        {
            public string AccountName; // instance member
            public decimal Balance; // instance member
            public static decimal InterestRate; // shared member
                                                
            // constants
            public const string Species = "Homo Sapien";

            /// <summary>
            /// These are optional, we can call this method with parameter or method without parameter as well.
            /// </summary>
            /// <param name="command"></param>
            /// <param name="number"></param>
            /// <param name="active"></param>
            /// <returns></returns>
            public string OptionalParameters(string command = "Run!",double number = 0.0, bool active = true)
            {
                return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                arg0: command, arg1: number, arg2: active);
            }
        }

    

    public enum WondersOfTheAncientWorld
        {
            GreatPyramidOfGiza,
            HangingGardensOfBabylon,
            StatueOfZeusAtOlympia,
            TempleOfArtemisAtEphesus,
            MausoleumAtHalicarnassus,
            ColossusOfRhodes,
            LighthouseOfAlexandria
        }

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public void  Method1() {
            Console.WriteLine("Public Method");
            Console.WriteLine(typeof(Program));

        }

        private void Method2()
        {
            Console.WriteLine("Private Method");
        }

        protected void Method3()
        {
            Console.WriteLine("Protected Method");
        }

        internal void Method4()
        {
            Console.WriteLine("internal Method");
        }

        static void Main(string[] args)
        {

      
            new Program().Method4();
            new Program().Method3();
            new Program().Method2();
            new Program().Method1();
            Console.ReadKey();
        }
    }

    class Program2  {
        public void methodCalls() {
            new Program().Method1();
            new Program().Method4();
            // new Program().Method3();
            //new Program().Method2();

            Program prog = new Program();
            
        }
        public static void fetchDetails()
        {
            AccessModifier accObj = new AccessModifier();
            //accObj.
            var x = accObj.privateVariable;
            var y = accObj.ProtectedFunction();
            var z = accObj.InternalFunction();


        }



    }



    /*
 * 
 *  Access Modifiers
 * 
 */

    public class AccessModifier
    {
        /// <summary>
        /// Available only to the container Class
        /// </summary>    
        private string privateVariable;

        /// <summary>
        /// Available in entire assembly across the classes 
        /// </summary>
        internal string internalVariable;

        /// <summary>
        /// Available in the container class and the derived class 
        /// </summary>    
        protected string protectedVariable;

        /// <summary>
        /// Available to the container class, entire assembly and to outside    
        /// </summary>
        public string publicVariable;

        /// <summary>
        /// Available to the derived class and entire assembly as well
        /// </summary>
        protected internal string protectedInternalVariable;

        /// <summary>
        /// Not accessible out side the class
        /// </summary>
        /// <returns></returns>
        private string PrivateFunction()
        {
            return privateVariable;
        }
        /// <summary>
        /// Not accessible out side the class
        /// </summary>
        /// <returns></returns>
        internal string InternalFunction()
        {
            return internalVariable;
        }

        /// <summary>
        /// Not accessible outside the namespace
        /// </summary>
        /// <returns></returns>
        protected string ProtectedFunction()
        {
            return protectedVariable;
        }

        /// <summary>
        /// Accessible
        /// </summary>
        /// <returns></returns>
        public string PublicFunction()
        {
            return publicVariable;
        }

        /// <summary>
        /// Accesible within assembly
        /// </summary>
        /// <returns>string as output</returns>
        protected internal string ProtectedInternalFunction()
        {
            return protectedInternalVariable;
        }


        public static void fetchDetails()
        {
            AccessModifier accObj = new AccessModifier();
            //accObj.
            var x = accObj.privateVariable;
            var y = accObj.ProtectedFunction();
            var z = accObj.InternalFunction();


        }
    }



}




namespace ExternalNameSpace {
    using ChapterFiveObjectOriented;
    class Program3 {
        public void methodCalls()
        {
            new Program().Method1();
            new Program().Method4();
            //new Program().Method3();
            //new Program().Method2();
        }

        public static void fetchDetails()
        {
            AccessModifier accObj = new AccessModifier();
            //accObj.
           // var x = accObj.privateVariable;
            //var y = accObj.ProtectedFunction();
            var z = accObj.InternalFunction();


        }
    }


    class TestAccessModifier
    {

        public static void fetchDetails()
        {
            AccessModifier accObj = new AccessModifier();
            //accObj.
            var x=accObj.protectedInternalVariable;
            

        }
    }


}







//Within NameSpace we can not access protected and private members.