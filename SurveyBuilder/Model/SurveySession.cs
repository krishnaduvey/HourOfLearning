using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class SurveySession
    {
        public Survey Survey { get; set; }

        public List<Answer> Answers { get; set; }

        public int Score { get; set; }
    }
}
