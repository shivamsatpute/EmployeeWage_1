using System;

namespace PracticeProblem
{       /*UC3.:- Add Part time 
                 Employee & Wage
                 - Assume Part time Hour is 8
        */
    class EmployeeWageComputationProblem
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;

            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employe Wage Per Day:- " + empWage);
        }
    }
}
