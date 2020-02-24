using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public abstract class Answer
    {
        public Question Question { get; set; }
        public int Points { get; set; }
    }
}
