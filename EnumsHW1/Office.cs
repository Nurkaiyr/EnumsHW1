using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsHW1
{
    public class Office
    {
        private Employee[] employers;

        public Office()
        {
            employers = new Employee[] {
                new Employee("Bill", "Gates", 3, 1000000, new int[] { 4, 04, 1975 }), // Дата основания Microsoft
                new Employee("Vanya", "Shishkin", 0, 100000, new int[] { 9, 02, 2017 }),
                new Employee("Gabe", "Newell", 2, 500000, new int[] { 24, 02, 1996 }), // Valve
                new Employee("Scott", "Gatri", 1, 250000, new int[] { 14, 09, 2017 }),

            };
        }

        public void ShowAllWorkers()
        {
            foreach (var worker in employers)
            {
                worker.InfoAboutEmployees();
                Console.WriteLine();
            }
        }

        public void FindManagers()
        {
            List<Employee> managers = new List<Employee>();
            int clerkCount = 0;
            double clerkSalarySum = 0;
            double averageClerkSalary = 0;

            foreach (var worker in employers)
            {
                if (worker.Vacancy == Vacancies.Clerk)
                {
                    clerkSalarySum += worker.Salary;
                    clerkCount++;
                }
            }
            averageClerkSalary = clerkSalarySum / clerkCount;

            foreach (var worker in employers)
            {
                if (worker.Vacancy == Vacancies.Manager && worker.Salary > averageClerkSalary)
                    managers.Add(worker);
            }

            managers.Sort(SurnameSort);

            foreach (var worker in managers)
            {
                worker.InfoAboutEmployees();
                Console.WriteLine();
            }
        }

        // Сортировка фамилий
        private int SurnameSort(Employee worker1, Employee worker2)
        {
            return (worker1.SurName.CompareTo(worker2.SurName));
        }

        public void PrintAllEnteredAfterBoss()
        {
            List<Employee> workers = new List<Employee>();

            Employee boss = new Employee();

            foreach (var worker in employers)
                if (worker.Vacancy == Vacancies.Boss) boss = worker;

            foreach (var worker in employers)
                if (CompareDates(worker, boss)) workers.Add(worker);

            workers.Sort(SurnameSort);

            foreach (var worker in workers)
            {
                worker.InfoAboutEmployees();
                Console.WriteLine();
            }
        }

        private bool CompareDates(Employee worker1, Employee worker2)
        {
            if (worker1.EnterDate[2] > worker2.EnterDate[2])
                return true;
            else if (worker1.EnterDate[2] < worker2.EnterDate[2])
                return false;
            else if (worker1.EnterDate[2] == worker2.EnterDate[2])

                if (worker1.EnterDate[1] > worker2.EnterDate[1])
                    return true;
                else if (worker1.EnterDate[1] < worker2.EnterDate[1])
                    return false;
                else if (worker1.EnterDate[1] == worker2.EnterDate[1])

                    if (worker1.EnterDate[0] > worker2.EnterDate[0])
                        return true;
                    else if (worker1.EnterDate[0] < worker2.EnterDate[0])
                        return false;
                    else if (worker1.EnterDate[0] == worker2.EnterDate[0])
                        return false;

            return false;
        }
    }
}
