using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class NumberQuestion : Question
    {
        private const int IntegerMaxTextLength = 10;

        protected override bool ValidateInput(string input, out string errorMessage)
        {
            if (input.Length > IntegerMaxTextLength)
            {
                errorMessage = string.Format("Input text is too long. Expected {0} or less characters.", IntegerMaxTextLength);
                return false;
            }

            int value;
            if (!int.TryParse(input, out value))
            {
                errorMessage = "Incorrect format for number.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        protected override Answer CreateAnswer(string validInput)
        {
            return new NumberAnswer { Number = int.Parse(validInput), Question = this };
        }
    }
}
