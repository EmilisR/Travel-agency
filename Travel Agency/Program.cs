using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;

namespace Travel_Agency
{
    static class Program
    {
        public static Dictionary<int, Order> allOrders = new Dictionary<int, Order>();
        public static Dictionary<int, Offer> allOffers = new Dictionary<int, Offer>();
        public static Dictionary<int, Client> allClients = new Dictionary<int, Client>();
        public static Dictionary<int, Worker> allWorkers = new Dictionary<int, Worker>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public class Client
        {
            public DateTime RegisterDate { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            private static int _howManyClients = 0;
            public string Email { get; set; }
            public string MobileNumber { get; set; }
            public int ClientNumber { get; private set; }
            public static event MainForm.EmailSendEventHandler<Client> EmailSend;
        }

        public class Order
        {
            public virtual Offer TravelOffer { get; set; }
            public virtual Client OrderClient { get; set; }
            public virtual Worker ServiceWorker { get; set; }
            public DateTime OrderRegisterDate { get; set; }
            public DateTime TravelStartDate { get; set; }
            public int OrderNumber { get; private set; }
            public int OrderPrice { get; set; }
            public int OrderClientsAmount { get; set; }

            public static event MainForm.EmailSendEventHandler<Order> EmailSend;
        }
        public class Offer
        {
            public int OfferNumber { get; private set; }
            public string TravelDestination { get; set; }
            public string Feeding { get; set; }
            public int Price { get; set; }
            public int TravelTime { get; set; }
            public string HotelRanking { get; set; }
        }
        public class Worker
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
            private List<Order> _orders = new List<Order>();
        }


        public class TravelAgencyContext : DbContext
        {
            public DbSet<Offer> Offers { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<Worker> Workers { get; set; }
        }

    }
}
