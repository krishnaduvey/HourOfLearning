using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder
{
    public class MultiPicklistAnswer : Answer
    {
        public List<PicklistOption> Options { get; set; }
    }
}
