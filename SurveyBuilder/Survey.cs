using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class Survey
    {
        public Survey(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }

        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        public Survey AddQuestion(Question question)
        {
            Questions.Add(question);
            return this;
        }

        public int GetScore(List<Answer> answers)
        {
            return answers.Sum(a => a.Points);
        }
    }
}
