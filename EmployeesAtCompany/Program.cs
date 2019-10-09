using System;

namespace EmployeesAtCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company rubberDucksInc = new Company("Rubber Ducks, Inc.", DateTime.Now);
            // Create three employees
            Employee andy = new Employee();
            andy.FirstName = "Andy";
            andy.LastName = "Collins";
            andy.Title = "Inventor of C#";
            andy.StartDate = DateTime.Now;

            Employee steve = new Employee();
            steve.FirstName = "Steve";
            steve.LastName = "Brownlee";
            steve.Title = "Senior Maker of Dad Jokes";
            steve.StartDate = DateTime.Now;

            Employee bryan = new Employee();
            bryan.FirstName = "Bryan";
            bryan.LastName = "Nilsen";
            bryan.Title = "Chief High-Fiver (CHF)";
            bryan.StartDate = DateTime.Now;

            // Assign the employees to the company
            rubberDucksInc.currentEmployees.Add(andy);
            rubberDucksInc.currentEmployees.Add(steve);
            rubberDucksInc.currentEmployees.Add(bryan);

            /*
                Iterate the company's employee list and generate the
                report
            */
            Console.WriteLine("----------------------------");
            Console.WriteLine("Current Employees");
            Console.WriteLine("----------------------------");
            
            foreach (Employee employee in rubberDucksInc.currentEmployees)
            {
                rubberDucksInc.ListEmployees(employee);
            }
        }
    }
}
