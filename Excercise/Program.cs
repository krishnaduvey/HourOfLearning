using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.ParseExact("2010-01-01 23:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss")
           DateTime dt = DateTime.Now;

           

            
        }
    }
}
