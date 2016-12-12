using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class Worker
    {
        public Worker() { }
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
                if (db.Workers.Count() > 0)
                {
                    WorkerNumber = (from w in db.Workers
                                 select w.WorkerNumber).Max() + 1;
                }
                else WorkerNumber = 1;
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
            string workerOrdersAmount = WorkerOrders == null ? "0" : WorkerOrders.Count.ToString();
                return "Worker number: " + WorkerNumber + Environment.NewLine + 
                        "Name: " + Name + Environment.NewLine + 
                        "Last name: " + LastName + Environment.NewLine + 
                        "Position: " + Position + Environment.NewLine + 
                        "Salary: €" + Salary.ToString() + Environment.NewLine + 
                        "Working hours per week: " + WorkingHoursPerWeek.ToString() + Environment.NewLine + 
                        "Worker orders amount: " + workerOrdersAmount + Environment.NewLine + 
                        "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}
