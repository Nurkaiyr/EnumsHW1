using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsHW2
{
    public class Univercity
    {
        public List<Student> students;
        public List<Student> hostel;

        public Univercity()
        {
            students = new List<Student>();
            hostel = new List<Student>();

            Student[] newStudents =
            {
                new Student("Едиге", "Нуркайыр", Gender.Male, "ВТиПО", 5.0, Study.Очное, 100000),
                new Student("Дуйсембаев", "Райымбек",  Gender.Male, "МЧС", 4.5, Study.Заочное, 70000),
                new Student("Нургамитов", "Акжол", Gender.Male, "Теплоэнергетика", 4.0, Study.Очное, 650000),
            };

            foreach (var student in newStudents)
                students.Add(student);
        }

        public void HostelForming()
        {
            double minimalSalary = 40000;

            foreach (var student in students)
                if (student.Salary < minimalSalary) hostel.Add(student);

            students.Sort(ScoreComparer);

            foreach (var student in students)
                if (student.Salary >= minimalSalary) hostel.Add(student);

            int index = 1;
            foreach (var student in hostel)
            {
                Console.Write(index + ")"); index++;
                student.ShowInfo();
            }
        }

        private int ScoreComparer(Student student1, Student student2)
        {
            if (student1.AverageScore > student2.AverageScore) return -1;
            else if (student1.AverageScore < student2.AverageScore) return 1;

            return 0;
        }
    }
}
