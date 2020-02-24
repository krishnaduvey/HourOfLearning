using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class TextQuestion : Question
    {
        private const int MaxUserInputTextLength = 128;

        protected override bool ValidateInput(string input, out string errorMessage)
        {
            if (input.Length > MaxUserInputTextLength)
            {
                errorMessage = string.Format("Input text is too long. Expected {0} or less characters.", MaxUserInputTextLength);
                return false;
            }

            errorMessage = null;
            return true;
        }

        protected override Answer CreateAnswer(string validInput)
        {
            return new TextAnswer { Text = validInput, Question = this };
        }
    }
}
