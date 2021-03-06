﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class NearestDeparturesForm : Form
    {
        private bool _isWorkerOrders = false;
        public NearestDeparturesForm()
        {
            InitializeComponent();
        }

        public NearestDeparturesForm(bool isWorkerOrders)
        {
            _isWorkerOrders = isWorkerOrders;
            InitializeComponent();
        }

        private void NearestDeparturesForm_Load(object sender, EventArgs e)
        {
            nearestDeparturesListView.View = View.Details;
            nearestDeparturesListView.GridLines = true;
            nearestDeparturesListView.FullRowSelect = true;
            nearestDeparturesListView.Columns.Add("No.", 50);
            nearestDeparturesListView.Columns.Add("Travel destination", 360);
            nearestDeparturesListView.Columns.Add("Worker", 240);
            nearestDeparturesListView.Columns.Add("Client", 240);
            nearestDeparturesListView.Columns.Add("Price", 120);
            nearestDeparturesListView.Columns.Add("Order created", 170);
            nearestDeparturesListView.Columns.Add("Travel start date", 200);
            nearestDeparturesListView.Columns.Add("Travelers", 150);
            if (_isWorkerOrders == false)
            {
                List<Order> list = DatabaseMethods.SelectOrders();
                Order[] orders = new Order[list.Count()];
                int i = 0;
                foreach (Order order in list)
                {
                    orders[i] = order;
                    i++;
                }
                Array.Sort(orders);
                nearestDeparturesListView.Columns.RemoveAt(7);
                foreach (Order order in orders)
                {
                    if (order.IsActive())
                    {
                        string[] arr = new string[7];
                        arr[0] = order.OrderNumber.ToString();
                        arr[1] = DatabaseMethods.SelectOffers().Where(x => x.OfferNumber == order.TravelOfferNumber).First().TravelDestination;
                        arr[2] = DatabaseMethods.SelectClients().Where(x => x.ClientNumber == order.OrderClientNumber).First().Name + " " + DatabaseMethods.SelectClients().Where(x => x.ClientNumber == order.OrderClientNumber).First().LastName;
                        arr[3] = DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == order.ServiceWorker.WorkerNumber).First().Name + " " + DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == order.ServiceWorker.WorkerNumber).First().LastName;
                        arr[4] = "€" + string.Format("{0:F2}", order.OrderPrice);
                        arr[5] = order.OrderRegisterDate.ToShortDateString();
                        arr[6] = order.TravelStartDate.ToShortDateString();
                        ListViewItem itm = new ListViewItem(arr);
                        nearestDeparturesListView.Items.Add(itm);
                    }
                }
            } 
        }
    }
}
