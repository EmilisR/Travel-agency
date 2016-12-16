using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace Travel_Agency
{
    class DatabaseMethods
    {
        public static List<Worker> SelectWorkers()
        {
            List<Worker> list = new List<Worker>();
            using (var db = new TravelAgencyContext())
            {
                if (db.Workers.Count() > 0)
                {
                    list = db.Workers.ToList();
                }
            }
            return list;
        }
        public static List<Order> SelectOrders()
        {
            List<Order> list = new List<Order>();
            using (var db = new TravelAgencyContext())
            {
                if (db.Orders.Count() > 0)
                {
                    list = db.Orders.ToList();
                }
            }
            return list;
        }
        public static List<Offer> SelectOffers()
        {
            List<Offer> list = new List<Offer>();
            using (var db = new TravelAgencyContext())
            {
                if (db.Offers.Count() > 0)
                {
                    list = db.Offers.ToList();
                }
            }
            return list;
        }
        public static List<Client> SelectClients()
        {
            List<Client> list = new List<Client>();
            using (var db = new TravelAgencyContext())
            {
                if (db.Clients.Count() > 0)
                {
                    list = db.Clients.ToList();
                }
            }
            return list;
        }
        public static List<Order> SelectWorkerOrders(Worker worker)
        {
            List<Order> list = new List<Order>();
            using (var db = new TravelAgencyContext())
            {
                if (db.Workers.Where(x => x.WorkerNumber == worker.WorkerNumber).First().WorkerOrders.Count() > 0)
                {
                    list = db.Workers.Where(x => x.WorkerNumber == worker.WorkerNumber).First().WorkerOrders.ToList();
                }
            }
            return list;
        }
        public static bool InsertOrder(Order order)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Orders.Count();
                db.Orders.Add(order);
                db.SaveChanges();
                if (count + 1 == db.Orders.Count())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool InsertWorker(Worker worker)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Workers.Count();
                db.Workers.Add(worker);
                db.SaveChanges();
                if (count + 1 == db.Workers.Count())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool InsertOffer(Offer offer)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Offers.Count();
                db.Offers.Add(offer);
                db.SaveChanges();
                if (count + 1 == db.Offers.Count())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool InsertClient(Client client)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Clients.Count();
                db.Clients.Add(client);
                db.SaveChanges();
                if (count + 1 == db.Clients.Count())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool InsertWorkerOrder(Order order, Worker worker)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Workers.Where(x => x.WorkerNumber == worker.WorkerNumber).First().WorkerOrders.Count;
                db.Workers.Where(x => x.WorkerNumber == worker.WorkerNumber).First().WorkerOrders.Add(order);
                db.SaveChanges();
                if (count + 1 == db.Workers.Where(x => x.WorkerNumber == worker.WorkerNumber).First().WorkerOrders.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void UpdateWorker(Worker worker)
        {
            using (var db = new TravelAgencyContext())
            {
                db.Entry(worker).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool DeleteWorker(int number)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Workers.Count();
                Worker worker = null;
                worker = db.Workers.Where(x => x.WorkerNumber == number).First();
                db.Workers.Remove(worker);
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw ex;
                }
                if (db.Workers.Count() + 1 == count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool DeleteOrder(int number)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Orders.Count();
                Order order = null;
                order = db.Orders.Where(x => x.OrderNumber == number).First();
                db.Orders.Remove(order);
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw ex;
                }
                if (db.Orders.Count() + 1 == count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool DeleteOffer(int number)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Offers.Count();
                Offer offer = null;
                offer = db.Offers.Where(x => x.OfferNumber == number).First();
                db.Offers.Remove(offer);
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw ex;
                }
                if (db.Offers.Count() + 1 == count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool DeleteClient(int number)
        {
            using (var db = new TravelAgencyContext())
            {
                int count = db.Clients.Count();
                Client client = null;
                client = db.Clients.Where(x => x.ClientNumber == number).First();
                db.Clients.Remove(client);
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw ex;
                }
                if (db.Clients.Count() + 1 == count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static Client SelectClientFromQuery(string query)
        {
            Client client = null;
            using (var db = new TravelAgencyContext())
            {
                if (db.Clients.Count() > 0)
                {
                    client = db.Clients.SqlQuery(query).ToList().First();
                }
            }
            return client;
        }
        public static Order SelectOrderFromQuery(string query)
        {
            Order order = null;
            using (var db = new TravelAgencyContext())
            {
                if (db.Orders.Count() > 0)
                {
                    order = db.Orders.SqlQuery(query).ToList().First();
                }
            }
            return order;
        }
    }
}
