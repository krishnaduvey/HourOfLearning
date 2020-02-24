using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class SinglePickListQuestion : PickListQuestion
    {
        protected override void PrintQuestion()
        {
            base.PrintQuestion();

            Console.WriteLine("Please, select one option number.");
        }

        protected override bool ValidateInput(string input, out string errorMessage)
        {
            int number;
            if (!int.TryParse(input, out number))
            {
                errorMessage = "Incorrect format for option number.";
                return false;
            }

            if (number <= 0)
            {
                errorMessage = "Option number should be 1 or greater.";
                return false;
            }

            if (number > Options.Count)
            {
                errorMessage = "Option number should be {0} or less.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        protected override Answer CreateAnswer(string validInput)
        {
            var selectedOption = Options[int.Parse(validInput) - 1];
            return new SinglePicklistAnswer { PicklistOption = selectedOption, Question = this, Points = selectedOption.Points };
        }
    }

}
