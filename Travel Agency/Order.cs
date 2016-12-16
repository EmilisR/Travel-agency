using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    public partial class Order : IComparable<Order>
    {
        public static event MainForm.EmailSendEventHandler<Order> EmailSend;

        public Order() { }
        public Order(int offerNumber, int clientNumber, int workerNumber, int orderClientsAmount, DateTime travelStartDate, ILogger loggerBox, ILogger loggerFile, ILogger loggerMail)
        {
            using (var db = new TravelAgencyContext())
            {
                TravelOfferNumber = offerNumber;
                ServiceWorkerNumber = workerNumber;
                OrderClientNumber = clientNumber;
                OrderRegisterDate = DateTime.Now;
                TravelStartDate = travelStartDate;
                if (db.Orders.Count() > 0)
                {
                    OrderNumber = (from o in db.Orders
                                   select o.OrderNumber).Max() + 1;
                }
                else OrderNumber = 1;
                OrderClientsAmount = orderClientsAmount;
                OrderPrice = db.Offers.Where(x => x.OfferNumber == TravelOfferNumber).First().Price * orderClientsAmount;
                AddOrderPriceToBudget(OrderPrice);
                string email = db.Clients.Where(x => x.ClientNumber == OrderClientNumber).First().Email;
                if (loggerBox != null)
                    loggerBox.WriteToLog(this, OrderRegisterDate, "Created order", email);
                if (loggerFile != null)
                    loggerFile.WriteToLog(this, OrderRegisterDate, "Created order", email);
                if (loggerMail != null)
                {
                    EmailSend?.Invoke(this, new EmailSendEventArgs(email, "Created order", OrderRegisterDate, loggerMail));
                }
            }
        }

        public void AddOrderPriceToBudget(int orderPrice)
        {
            Budget.AddToBudget(orderPrice);
        }

        public void ReduceOrderPriceFromBudget(int orderPrice)
        {
            Budget.ReduceFromBudget(orderPrice);
        }

        public int CompareTo(Order other)
        {
            if (TravelStartDate > other.TravelStartDate) return 1;
            else if (TravelStartDate < other.TravelStartDate) return -1;
            else return 0;
        }

        public bool IsActive()
        {
            if (TravelStartDate > DateTime.Today) return true;
            else return false;
        }

        public override string ToString()
        {
            return "Order number: " + OrderNumber.ToString() + Environment.NewLine + "" + 
                    DatabaseMethods.SelectOffers().Where(x => x.OfferNumber == TravelOfferNumber).First().ToString() + Environment.NewLine + 
                    "Client: " + DatabaseMethods.SelectClients().Where(x => x.ClientNumber == OrderClientNumber).First().Name + " " + DatabaseMethods.SelectClients().Where(x => x.ClientNumber == OrderClientNumber).First().LastName + Environment.NewLine + 
                    "Worker: " + DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == ServiceWorkerNumber).First().Name + " " + DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == ServiceWorkerNumber).First().LastName + Environment.NewLine + 
                    "Order price: €" + OrderPrice.ToString() + Environment.NewLine + 
                    "Travelers amount: " + OrderClientsAmount.ToString() + Environment.NewLine + 
                    "Travel start date: " + TravelStartDate.ToShortDateString() + Environment.NewLine + 
                    "Order registered on: " + OrderRegisterDate.ToShortDateString();
        }
    }
}
