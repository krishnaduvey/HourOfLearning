using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class DateQuestion : Question
    {
        const string DateFormat = "dd/mm/yyyy";
        private const string ParseFormat = "dd/MM/yyyy";

        protected override void PrintQuestion()
        {
            Console.WriteLine(Label);
            Console.WriteLine("Please, input data in following format: \"{0}\"", DateFormat);
        }

        protected override bool ValidateInput(string input, out string errorMessage)
        {
            if (input.Length > DateFormat.Length)
            {
                errorMessage = string.Format("Input text is too long. Expected input in format \"{0}\".", DateFormat);
                return false;
            }

            DateTime date;
            if (!DateTime.TryParseExact(input, ParseFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                errorMessage = "Incorrect format for date.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        protected override Answer CreateAnswer(string validInput)
        {
            return new DateAnswer { Date = DateTime.ParseExact(validInput, ParseFormat, CultureInfo.InvariantCulture), Question = this };
        }
    }
}
