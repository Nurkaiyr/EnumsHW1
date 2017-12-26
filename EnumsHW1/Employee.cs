using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsHW1
{
    public class Employee
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public Vacancies Vacancy { get; set; }

        public int Salary { get; set; }

        public int[] EnterDate { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string surName, int vacancy, int salary, int[] enterDate)
        {
            Name = name;

            SurName = surName;

            Vacancy = (Vacancies)vacancy;

            Salary = salary;

            EnterDate = new int[3];

            for (int i = 0; i < EnterDate.Length; i++)
                EnterDate[i] = enterDate[i];
        }

        public void InfoAboutEmployees()
        {
            Console.Write($"\n{Name} {SurName}\n" + $"Должность: {Vacancy}\n" + $"Зарплата: {Salary} тг\n" + $"Дата приема на работу: ");

            foreach (var number in EnterDate)
                Console.Write(number);

            Console.WriteLine();
        }
    }
}
