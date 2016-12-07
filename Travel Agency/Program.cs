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
        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }

            public virtual List<Post> Posts { get; set; }
        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }
        }

        public class BloggingContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
        }

    }
}
