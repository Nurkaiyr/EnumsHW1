using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsHW2
{
    public class Student
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public Gender Sex { get; private set; }

        public string Group { get; private set; }
        public double AverageScore { get; private set; }
        public Study Study { get; private set; }

        public double Salary { get; set; }

        public Student(string name, string surName,
            Gender sex, string group, double averageScore, Study study, double salary)
        {
            Name = name;
            SurName = surName;
            Sex = sex;

            Group = group;
            AverageScore = averageScore;
            Study = study;

            Salary = salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"------------------\nФИО: {SurName} {Name} \n" +
                $"Пол: {Sex}\t|Зарплата: {Salary} тг\n" +
                $"Группа: {Group}\n" +
                $"Средний балл: _{AverageScore}_\nВид обучения: {Study}\n");
        }
    }
}
