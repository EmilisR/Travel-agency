using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    public partial class Worker
    {
        public Worker(string name, string lastName, string position, int salary, int workingHoursPerWeek, ILogger loggerBox, ILogger loggerFile)
        {
            using (var db = new TravelAgencyContext())
            {
                Name = name;
                LastName = lastName;
                WorkingHoursPerWeek = workingHoursPerWeek;
                Salary = salary;
                Position = position;
                RegisterDate = DateTime.Now;
                WorkerNumber = db.Workers.OrderByDescending(x => x.WorkerNumber).FirstOrDefault().Key + 1;
                if (loggerBox != null)
                    loggerBox.WriteToLog(this, RegisterDate, "Created worker");
                if (loggerFile != null)
                    loggerFile.WriteToLog(this, RegisterDate, "Created worker");
            } 
        }

        public void AssignOrderToWorker(Order order)
        {
            WorkerOrders.Add(order);
        }

        public void PaySalary()
        {
            Budget.ReduceFromBudget(Salary);
        }

        public void RaiseSalary(int bonus)
        {
            Salary += bonus;
        }

        public void CutSalary(int penalty)
        {
            Salary -= penalty;
        }

        public override string ToString()
        {
            return "Worker number: " + WorkerNumber + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Last name: " + LastName + Environment.NewLine + "Position: " + Position + Environment.NewLine + "Salary: €" + Salary.ToString() + Environment.NewLine + "Working hours per week: " + WorkingHoursPerWeek.ToString() + Environment.NewLine + "Worker orders amount: " + WorkerOrders.Count + Environment.NewLine + "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}
