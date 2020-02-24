using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public abstract class PickListQuestion : Question
    {
        public List<PicklistOption> Options { get; set; }

        protected override void PrintQuestion()
        {
            Console.WriteLine(Label);

            int optionNumber = 1;
            foreach (var choice in Options)
            {
                Console.WriteLine("[{0}] {1}", optionNumber, choice.Text);
                optionNumber++;
            }
        }
    }
}
