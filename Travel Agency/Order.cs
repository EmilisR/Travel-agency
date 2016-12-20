using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    public partial class Order : IComparable<Order>
    {
        public Order() { }
        public Order(int offerNumber, int clientNumber, Worker worker, int orderClientsAmount, DateTime travelStartDate, List<ILogger> logs)
        {
            TravelOfferNumber = offerNumber;
            ServiceWorker = worker;
            OrderClientNumber = clientNumber;
            OrderRegisterDate = DateTime.Now;
            TravelStartDate = travelStartDate;
            List<Order> list = DatabaseMethods.SelectOrders();
            if (list.Count > 0)
            {
                OrderNumber = list.Select(x => x.OrderNumber).Max() + 1;
            }
            else OrderNumber = 1;
            OrderClientsAmount = orderClientsAmount;
            OrderPrice = DatabaseMethods.SelectOffers().Where(x => x.OfferNumber == TravelOfferNumber).First().Price * orderClientsAmount;
            AddOrderPriceToBudget(OrderPrice);
            string email = DatabaseMethods.SelectClients().Where(x => x.ClientNumber == OrderClientNumber).First().Email;
            foreach (ILogger log in logs)
            {
                if (log != null) log.WriteToLog(this, OrderRegisterDate, "Created order", email);
            }
        }

        public void AddOrderPriceToBudget(int orderPrice)
        {
            Budget.AddToBudget(orderPrice);
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
                    "Worker: " + ServiceWorker.Name + " " + ServiceWorker.LastName + Environment.NewLine + 
                    "Order price: €" + OrderPrice.ToString() + Environment.NewLine + 
                    "Travelers amount: " + OrderClientsAmount.ToString() + Environment.NewLine + 
                    "Travel start date: " + TravelStartDate.ToShortDateString() + Environment.NewLine + 
                    "Order registered on: " + OrderRegisterDate.ToShortDateString();
        }
    }
}
