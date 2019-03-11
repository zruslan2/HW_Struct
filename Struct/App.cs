using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class App
    {
        Worker[] w = new Worker[5];
        public void Print()
        {
            w[0] = new Worker(1, "John", "Male", "Manager", DateTime.Now, 3000);
            w[1] = new Worker(2, "Lenny", "Male", "Janitor", DateTime.Now, 500);
            w[2] = new Worker(3, "Maria", "Female", "Manager", DateTime.Now, 3000);
            w[3] = new Worker(4, "Nancy", "Female", "Director", DateTime.Now, 5000);
            w[4] = new Worker(5, "Bob", "Male", "Manager", DateTime.Now, 1000);
            for (int i = 0; i < 5; i++)
            {
                w[i].PrintInfo();
                Console.WriteLine("-----------------------------------------------");
            }
        }
        public void PrintWorker()
        {
            w[0] = new Worker(1, "John", "Male", "Manager", DateTime.Now, 3000);
            w[1] = new Worker(2, "Lenny", "Male", "Janitor", DateTime.Now, 500);
            w[2] = new Worker(3, "Maria", "Female", "Manager", DateTime.Now, 3000);
            w[3] = new Worker(4, "Nancy", "Female", "Director", DateTime.Now, 5000);
            w[4] = new Worker(5, "Bob", "Male", "Manager", DateTime.Now, 1000);
            Console.WriteLine("Выберите ID сотрудника: ");
            int workerId = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                w[i].PrintWorkerInfo(workerId);
            }
            Console.WriteLine("-----------------------------------------------");
        }
        public void PrintSex()
        {
            w[0] = new Worker(1, "John", "Male", "Manager", DateTime.Now, 3000);
            w[1] = new Worker(2, "Lenny", "Male", "Janitor", DateTime.Now, 500);
            w[2] = new Worker(3, "Maria", "Female", "Manager", DateTime.Now, 3000);
            w[3] = new Worker(4, "Nancy", "Female", "Director", DateTime.Now, 5000);
            w[4] = new Worker(5, "Bob", "Male", "Manager", DateTime.Now, 1000);
            Console.WriteLine("Работники определенного пола: ");
            Console.WriteLine("Выберите пол: (Male, Female)");
            string ch = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                w[i].PrintSexInfo(ch);
            }
        }
        public void ManagerInfo()
        {
            w[0] = new Worker(1, "John", "Male", "Manager", DateTime.Now, 3000);
            w[1] = new Worker(2, "Lenny", "Male", "Janitor", DateTime.Now, 500);
            w[2] = new Worker(3, "Maria", "Female", "Manager", DateTime.Now, 3000);
            w[3] = new Worker(4, "Nancy", "Female", "Director", DateTime.Now, 5000);
            w[4] = new Worker(5, "Bob", "Male", "Manager", DateTime.Now, 1000);
            Console.WriteLine("Менеджеры чьи зарплаты выше средней: ");
            double sumSalary = 0;
            for (int i = 0; i < 5; i++)
            {
                sumSalary += w[i].Salary;
                if ((w[i].Salary) > (sumSalary / 5))
                {
                    w[i].PrintManagerInfo();
                    Console.WriteLine("-----------------------------------------------");
                }
            }
            Console.WriteLine("Итого зарплаты по всем сотрудника: {0}\nСредняя зарплата: {1}", sumSalary, sumSalary / 5);
        }
    }
}
