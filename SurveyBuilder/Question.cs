using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public abstract class Question
    {
        public string Label { get; set; }

        public Answer Ask()
        {
            PrintQuestion();

            while (true)
            {
                var input = Console.ReadLine();
                string errorMessage;
                if (!ValidateInput(input, out errorMessage))
                {
                    Console.WriteLine(errorMessage);
                    Console.WriteLine("Please, correct your input.");
                    continue;
                }

                return CreateAnswer(input);
            }
        }

        protected virtual void PrintQuestion()
        {
            Console.WriteLine(Label);
        }


        protected abstract bool ValidateInput(string input, out string errorMessage);
        protected abstract Answer CreateAnswer(string validInput);
    }
}
