using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public interface IWorker
    {
        int Id { get; set; }
        string Name { get; set; }
        string Sex { get; set; }
        string Position { get; set; }
        DateTime EnterDate { get; set; }
        double Salary { get; set; }
        void PrintInfo();
        void PrintWorkerInfo(int id);
        void PrintManagerInfo();
        void PrintOnDateInfo(DateTime date);
        void PrintSexInfo(string sex);
    }
}
