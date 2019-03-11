using Struct.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Работники, 2-Студенты");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                App a = new App();
                Console.WriteLine("1. Инфо о всех сотрудника\n2. Инфо о конкретных сотрудниках\n3. Инфо о менеджерах\n4. Инфо по полу сотрудника\n5. Выход");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                    a.Print();
                else if (ch == 2)
                    a.PrintWorker();
                else if (ch == 3)
                    a.ManagerInfo();
                else if (ch == 4)
                    a.PrintSex();
                else if (ch == 5)
                    System.Environment.Exit(1);
            }
            else if (choice == 2)
            {
                App1 a1 = new App1();
                a1.Print();
            }
        }
    }
}
