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
            int n1, n2, temp;
            Console.Write("First Number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            //Temp variable is used to swap numbers
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + n1);
            Console.Write("\nSecond Number : " + n2);
            Console.Read();
        }
    }
}
