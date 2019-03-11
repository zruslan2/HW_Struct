using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Worker : IWorker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public DateTime EnterDate { get; set; }
        public double Salary { get; set; }
        public Worker(int id, string name, string sex, string position, DateTime enterDate, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Position = position;
            this.EnterDate = enterDate;
            this.Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nSex: {2}\nPosition: {3}\nEnter Date: {4}\nSalary: {5}", Id, Name, Sex, Position, EnterDate, Salary);
        }
        public void PrintManagerInfo()
        {
            if (Position == "Manager")
            {
                Console.WriteLine("ID: {0}\nName: {1}\nSex: {2}\nPosition: {3}\nEnter Date: {4}\nSalary: {5}", Id, Name, Sex, Position, EnterDate, Salary);
            }
        }
        public void PrintOnDateInfo(DateTime date)
        {
            if (EnterDate > date)
            {
                Console.WriteLine("ID: {0}\nName: {1}\nSex: {2}\nPosition: {3}\nEnter Date: {4}\nSalary: {5}", Id, Name, Sex, Position, EnterDate, Salary);
            }
        }
        public void PrintSexInfo(string sex)
        {
            if (this.Sex == sex)
            {
                Console.WriteLine("ID: {0}\nName: {1}\nSex: {2}\nPosition: {3}\nEnter Date: {4}\nSalary: {5}", Id, Name, Sex, Position, EnterDate, Salary);
            }
        }
        public void PrintWorkerInfo(int id)
        {
            if (this.Id == id)
            {
                Console.WriteLine("ID: {0}\nName: {1}\nSex: {2}\nPosition: {3}\nEnter Date: {4}\nSalary: {5}", Id, Name, Sex, Position, EnterDate, Salary);
            }
        }
    }
}
