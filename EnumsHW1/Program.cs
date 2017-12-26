using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
           // SecondTask();
        }

        private static void SecondTask()
        {
            throw new NotImplementedException();
        }

        private static void FirstTask()
        {
            var office = new Office();
            office.ShowAllWorkers();
            Console.ReadLine();
            Console.Clear();
            office.FindManagers();
            Console.ReadLine();
            Console.Clear();
            office.PrintAllEnteredAfterBoss();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
