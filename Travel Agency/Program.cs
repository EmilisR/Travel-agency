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
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }
        }
        public class Offer
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }
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


        public class BloggingContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
        }

    }
}
