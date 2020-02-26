using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var survey = new Survey("How much are you Programer?")
                    .AddQuestion(new SinglePickListQuestion
                    {
                        Label = "Do you like programming?",
                        Options = new List<PicklistOption>
                        {
                        new PicklistOption {Text = "Yes", Points = 20},
                        new PicklistOption {Text = "No", Points = 10},
                        }
                    })
                    .AddQuestion(new MultiPicklistQuestion
                    {
                        Label = "What programming languages do u know?",
                        Options = new List<PicklistOption>
                        {
                        new PicklistOption {Text = "C#", Points = 10},
                        new PicklistOption {Text = "Ada", Points = 10},
                        new PicklistOption {Text = "Pascal", Points = 10}
                        }
                    })
                    .AddQuestion(new SinglePickListQuestion
                    {
                        Label = "How much Open Source project, where did you take part?",
                        Options = new List<PicklistOption>
                        {
                        new PicklistOption {Text = "0", Points = 10},
                        new PicklistOption {Text = "1 - 2", Points = 20},
                        new PicklistOption {Text = "3 - 5", Points = 30},
                        new PicklistOption {Text = "more than 5", Points = 40},
                        }
                    });

                Console.WriteLine("Hello! Let's determine how much you are programer.");
                var session = new SurveySession
                {
                    Survey = survey,
                    Answers = new List<Answer>()
                };

                foreach (var question in survey.Questions)
                {
                    var answer = question.Ask();
                    session.Answers.Add(answer);
                }

                session.Score = survey.GetScore(session.Answers);

                Console.WriteLine("Thank you, for participating in our survey!");
                Console.WriteLine("Your score is {0}.", session.Score);
            }

        }
    }


   

}
