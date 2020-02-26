using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class MultiPicklistQuestion : PickListQuestion
    {
        protected override void PrintQuestion()
        {
            base.PrintQuestion();

            Console.Write("Please, select option numbers.");
            Console.WriteLine("Input numbers in format \"<num1>,<num2>,<num3>,...\"");
            Console.WriteLine("For example: 1, 3, 4");

        }

        protected override bool ValidateInput(string input, out string errorMessage)
        {
            var optionNumbers = input.Split(',');

            if (optionNumbers.Length > Options.Count)
            {
                errorMessage = "You select more options, than available.";
                return false;
            }
            var options = new List<int>();
            foreach (var textOption in optionNumbers)
            {
                int optionNumber;
                if (!int.TryParse(textOption, out optionNumber))
                {
                    errorMessage = "Incorrect format for option number.";
                    return false;
                }
                options.Add(optionNumber);
            }

            errorMessage = null;
            return true;
        }

        protected override Answer CreateAnswer(string validInput)
        {
            var optionNumbers = validInput.Split(',').Select(num => int.Parse(num.Trim())).ToList();
            var selectedOptions = optionNumbers.Select(choiceNumber => Options[choiceNumber - 1]).ToList();

            return new MultiPicklistAnswer { Options = selectedOptions, Question = this, Points = selectedOptions.Sum(op => op.Points) };
        }
    }



}
