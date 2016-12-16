namespace Travel_Agency
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class TravelAgencyContext : DbContext
    {
        // Your context has been configured to use a 'TravelAgencyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Travel_Agency.TravelAgencyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TravelAgencyContext' 
        // connection string in the application configuration file.
        public TravelAgencyContext()
            : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emili\Desktop\Travel_Agency.TravelAgencyContext.mdf;Integrated Security=True;Connect Timeout=30")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }

    public partial class Client
    {
        public DateTime RegisterDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        [Key]
        public int ClientNumber { get; set; }
    }

    public partial class Order
    {
        public int TravelOfferNumber { get; set; }
        public int OrderClientNumber { get; set; }
        public int ServiceWorkerNumber { get; set; }
        public DateTime OrderRegisterDate { get; set; }
        public DateTime TravelStartDate { get; set; }
        [Key]
        public int OrderNumber { get; private set; }
        public int OrderPrice { get; set; }
        public int OrderClientsAmount { get; set; }
    }
    public partial class Offer
    {
        [Key]
        public int OfferNumber { get; private set; }
        public string TravelDestination { get; set; }
        public string Feeding { get; set; }
        public int Price { get; set; }
        public int TravelTime { get; set; }
        public string HotelRanking { get; set; }
    }
    public partial class Worker
    {
        public DateTime RegisterDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int WorkingHoursPerWeek { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        [Key]
        public int WorkerNumber { get; set; }
        public virtual List<Order> WorkerOrders { get; set; }
    }
    public static partial class Budget
    {
        public static double Balance { get; set; }
        public static double Income { get; set; }
        public static double Outcome { get; set; }
        public static double Profit { get; set; }
    }
}