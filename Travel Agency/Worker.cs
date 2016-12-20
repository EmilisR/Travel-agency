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
        public Worker()
        {
            WorkerOrders = new List<Order>();
        }
        public Worker(string name, string lastName, string position, int salary, int workingHoursPerWeek, List<ILogger> logs)
        {
            Name = name;
            LastName = lastName;
            WorkingHoursPerWeek = workingHoursPerWeek;
            Salary = salary;
            Position = position;
            RegisterDate = DateTime.Now;
            List<Worker> list = DatabaseMethods.SelectWorkers();
            if (list.Count() > 0)
            {
                WorkerNumber = (from w in list
                                select w.WorkerNumber).Max() + 1;
            }
            else WorkerNumber = 1;
            foreach (ILogger log in logs)
            {
                if (log != null) log.WriteToLog(this, RegisterDate, "Created worker");
            }
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
            List<Order> list = DatabaseMethods.SelectWorkerOrders(this);
            string workerOrdersAmount = list == null ? "0" : list.Count.ToString();
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
