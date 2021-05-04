using System;

namespace PracticeProblem
{       /* UC6.:- Calculate Wages till a condition of total working hours or days is reached for a month 
          - Assume 100 hours and 20 days
       */
    class EmployeeWageComputationProblem
    {
        public const int IS_FULL_TIME = 1;     //Constant variable
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;

        public static void Main(string[] args)      //Main method
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int workingDays = 1;
            Random random = new Random();       //Random Class
            while (hrs < MAX_WORKING_HRS && workingDays <= MAX_WORKING_DAYS)
            {
                workingDays++;
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

                empWage = EMP_RATE_PER_HOUR * empHrs; // Calculate empWage
                hrs += empHrs;
                totalEmpWage = totalEmpWage + empWage;
            }
                Console.WriteLine("Employe Wage Per Day:- " + empWage);     //Display empwage
            Console.WriteLine("Total Employe Month Wage :- " + totalEmpWage);
            Console.WriteLine("Employee wage for " + workingDays + " days " + totalEmpWage);
            Console.WriteLine("Working hours " + hrs);

        }
    }
}