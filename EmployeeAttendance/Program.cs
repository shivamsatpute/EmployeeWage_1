using System;

namespace PracticeProblem
{      /* UC4.:- Solving using 
                 Switch Case Statement
       */
    class EmployeeWageComputationProblem
    {
        public const int IS_FULL_TIME = 1;     //Constant variable
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void Main(string[] args)      //Main method
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();       //Random Class
            int empCheck = random.Next(0, 3);      //Random Generate 0 ,1,2
            switch (empCheck)          //Switch case Statment
            {
                case IS_FULL_TIME:         //Employee is FullTime=1
                    empHrs = 8;
                    break;
                case IS_PART_TIME:          //Employee is FullTime=2
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = EMP_RATE_PER_HOUR * empHrs;       // Calculate empWage
            Console.WriteLine("Employe Wage Per Day:- " + empWage);     //Display empwage
        }
    }
}