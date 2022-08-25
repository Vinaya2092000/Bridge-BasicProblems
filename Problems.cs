using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems_A
{
    public class Problems
    {
        public void UseCaseProblem()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            while (year < 1000 || year > 9999)    //should have four digits
            {
                Console.WriteLine("Enter a 4 digit year: ");
                year = Convert.ToInt32(Console.ReadLine());
            }

            // Divisible by 400 but not 100
            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}
