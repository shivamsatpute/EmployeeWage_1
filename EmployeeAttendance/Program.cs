using System;

namespace EmployeeAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (EmpCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee Is Present");

            }
            else
            {
                Console.WriteLine("Employe Is Absent");
            }

        }
    }
}
