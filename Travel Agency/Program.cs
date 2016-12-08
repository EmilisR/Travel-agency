using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;

namespace Travel_Agency
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            using (var db = new TravelAgencyContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var client = new Client { Name = name, ClientNumber = 1, Email = "emilis@ruzveltas.lt", LastName = "Ruzveltas", MobileNumber = "+37064373827", RegisterDate = DateTime.Now  };
                db.Clients.Add(client);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Clients
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name + " " + item.MobileNumber);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        

    }
}
