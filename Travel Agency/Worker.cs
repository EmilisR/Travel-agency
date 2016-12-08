using System;
using System.Collections.Generic;
using System.Linq;

namespace Travel_Agency
{
    [Serializable]
    class Worker
    {
        public DateTime RegisterDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int WorkingHoursPerWeek { get; set; }
        public double StartingSalary { get; set; }
        public int StartingWorkingHoursPerWeek { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public int WorkerNumber { get; set; }
        public virtual List<Order> WorkerOrders { get; set; }
        public Worker(string name, string lastName, string position, int salary, int workingHoursPerWeek, ILogger loggerBox, ILogger loggerFile)
        {
            Name = name;
            LastName = lastName;
            StartingSalary = salary;
            StartingWorkingHoursPerWeek = workingHoursPerWeek;
            WorkingHoursPerWeek = workingHoursPerWeek;
            Salary = salary;
            Position = position;
            RegisterDate = DateTime.Now;
            WorkerNumber = Program.allWorkers.OrderByDescending(x => x.Key).FirstOrDefault().Key + 1;
            if (loggerBox != null)
                loggerBox.WriteToLog(this, RegisterDate, "Created worker");
            if (loggerFile != null)
                loggerFile.WriteToLog(this, RegisterDate, "Created worker");
        }

        public Worker()
        {
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
            StartingSalary = Salary;
        }

        public void CutSalary(int penalty)
        {
            Salary -= penalty;
            StartingSalary = Salary;
        }

        public bool ChangeEstablishment(double postValue)
        {
            if (postValue == 0.25)
            {
                WorkingHoursPerWeek = StartingWorkingHoursPerWeek / 4;
                Salary = StartingSalary / 4;
                return true;
            }
            if (postValue == 0.5)
            {
                WorkingHoursPerWeek = StartingWorkingHoursPerWeek / 2;
                Salary = StartingSalary / 2;
                return true;
            }
            if (postValue == 0.75)
            {
                WorkingHoursPerWeek = StartingWorkingHoursPerWeek / 4 * 3;
                Salary = StartingSalary / 4 * 3;
                return true;
            }
            if (postValue == 1)
            {
                WorkingHoursPerWeek = StartingWorkingHoursPerWeek;
                Salary = StartingSalary;
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return "Worker number: " + WorkerNumber + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Last name: " + LastName + Environment.NewLine + "Position: " + Position + Environment.NewLine + "Salary: €" + Salary.ToString() + Environment.NewLine + "Working hours per week: " + WorkingHoursPerWeek.ToString() + Environment.NewLine + "Worker orders amount: " + WorkerOrders.Count + Environment.NewLine + "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}
