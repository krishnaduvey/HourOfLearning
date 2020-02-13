using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    /*
    What type would you choose for the following "numbers"?

    A person's telephone number.
    A person's height.
    A person's age.
    A person's salary.
    A book's ISBN.
    A book's price. decimal
    A book's shipping weight. double
    A country's population.
    The number of stars in the universe.

 */
    class Excercise2Dot1
    {
        string telephone; // Telephone numbers need to be stored as a text/string data type because they often begin with a 0 and if they were stored as an integer then the leading zero would be discounted.
        float height;//  A double variable can provide precision up to 15 to 16 decimal points as compared to float precision of 6 to 7 decimal digits. Both data types are suitable for storing height of a patient.
        byte age;  //we are sure, we won't have negative values. range is 0 to 255.
        decimal salary; //The DECIMAL data type allows you to specify the total number of digits as well as the number of digits after the decimal .
                        // decimal vs double 
                        /*
                            For money, always decimal. It's why it was created.
                            If numbers must add up correctly or balance, use decimal. This includes any financial storage or calculations, scores, or other numbers that people might do by hand.
                            If the exact value of numbers is not important, use double for speed. This includes graphics, physics or other physical sciences computations where there is already a "number of significant digits".

                         */

        string iSBN1; // 13 digit number from 2007
        Int64 iSBN2; //Int 64 can hold till 19 digits  OR  Represents a 64-bit signed integer.
        long isbn3; // internally its Int64 as per source code.

        /*
         I would use bigint because it needs only 8 bytes per value.
        decimal(12,0) needs 9 bytes and varchar or nvarchar even more (12 or 24 bytes respectively in case of storing 12 digits).
        Formatting numbers can be done in application. It's also much easier to change formatting in app in case of requirements change.
         */



    }
}
