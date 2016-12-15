﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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
                    list = db.Workers.Include(x => x.WorkerOrders).ToList();
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
                    list = db.Orders.Include(x => x.TravelOffer).Include(y => y.ServiceWorker).Include(z => z.OrderClient).ToList();
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
        public static void Insert()
        {
            using (var db = new TravelAgencyContext())
            {

            }
        }
        public static void Update()
        {
            using (var db = new TravelAgencyContext())
            {

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
    }
}