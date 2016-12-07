using System;
using System.Collections.Generic;
using System.Linq;

namespace Travel_Agency
{
    [Serializable]
    class Worker : User
    {
        public List<int> OrdersNumbers { get; set; }
        public int WorkingHoursPerWeek { get; set; }
        public double StartingSalary { get; set; }
        public int StartingWorkingHoursPerWeek { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public int WorkerNumber { get; set; }
        private Lazy<List<Order>> _orders = new Lazy<List<Order>>();
        public Worker(string name, string lastName, string position, int salary, int workingHoursPerWeek, ILogger loggerBox, ILogger loggerFile)
        {
            OrdersNumbers = new List<int>();
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
            OrdersNumbers = new List<int>();
        }

        public void AssignOrderToWorker(Order order)
        {
            OrdersNumbers.Add(order.OrderNumber);
            if (_orders.IsValueCreated)
            {
                _orders.Value.Add(order);
            }
        }

        public void ClearListOfOrders()
        {
            _orders.Value.Clear();
        }

        public void PaySalary()
        {
            Budget.ReduceFromBudget(Salary);
        }
        public List<Order> GetWorkerOrdersList()
        {
            if (!_orders.IsValueCreated || _orders.Value.Count == 0)
            {
                foreach (int item in OrdersNumbers)
                {
                    _orders.Value.Add(Program.allOrders[item]);
                }
            }
            return _orders.Value;
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
            return "Worker number: " + WorkerNumber + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Last name: " + LastName + Environment.NewLine + "Position: " + Position + Environment.NewLine + "Salary: €" + Salary.ToString() + Environment.NewLine + "Working hours per week: " + WorkingHoursPerWeek.ToString() + Environment.NewLine + "Worker orders amount: " + OrdersNumbers.Count + Environment.NewLine + "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}
