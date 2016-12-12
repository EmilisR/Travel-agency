using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class MainForm : Form
    {
        private bool isChartCreated { get; set; }
        public delegate void EmailSendEventHandler<T>(T sender, EmailSendEventArgs e);
        public MainForm()
        {
            InitializeComponent();
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            Budget.Bankrupt += BankruptHandler;
            Font = new Font(Program.ReadSetting("Font name", "User.config"), Convert.ToInt32(Program.ReadSetting("Font size", "User.config")));
            StartThreadQuantityUpdate();
            isChartCreated = false;
        }

        public async void StartThreadQuantityUpdate()
        {
            await SetLabelsAwait();
        }

        private async Task SetLabelsAwait()
        {
            using (var db = new TravelAgencyContext())
            {
                clientsQuantity.Text = (await GetLabelTextAsync(db.Clients.Count(), "Number of clients: "));
                offersQuantity.Text = (await GetLabelTextAsync(db.Offers.Count(), "Number of offers: "));
                workersQuantity.Text = (await GetLabelTextAsync(db.Workers.Count(), "Number of workers: "));
                ordersQuantity.Text = (await GetLabelTextAsync(db.Orders.Count(), "Number of orders: "));
                activeOrders.Text = (await GetLabelTextAsync(CheckActiveOrders(), "Active orders: "));
                if (!Budget.IsBankrupt())
                {
                    budgetBalance.BackColor = DefaultBackColor;
                    budgetBalance.Text = (await GetLabelTextAsync((int)Budget.Balance, "Budget balance: €"));
                }
            }
        }

        Action<Label> MakeLabelBankrupt = (label) =>
        {
            label.Text = "BANKRUPT!!!";
            label.BackColor = Color.Red;
        };

        private void BankruptHandler(BankruptEventArgs args)
        {
            MakeLabelBankrupt(budgetBalance);
            MessageBox.Show("Travel agency reached bankrupt! Current balance: €" + args.CurrentBalance, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private Task<string> GetLabelTextAsync(int number, string tag)
        {
            return Task.Run(() => GetLabelText(number, tag));
        }

        private string GetLabelText(int number, string tag)
        {
            return tag + number.ToString();
        }

        private int CheckActiveOrders()
        {
            using (var db = new TravelAgencyContext())
            {
                int activeOrders = 0;
                if (db.Orders.Count() > 0)
                {
                    foreach (Order order in db.Orders)
                    {
                        if (order.TravelStartDate > DateTime.Today) activeOrders++;
                    }
                }
                return activeOrders;
            }
        }

        private Task SaveObjectsTask<T>(List<T> objects, string filePath, string tag)
        {
            Task task = new Task(() => SaveObjects(objects, filePath, tag));
            return task;
        }

        private void SaveObjects<T>(List<T> objects, string filePath, string tag)
        {
            Stream streamWriter = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            byte[] tagByte = Encoding.ASCII.GetBytes(tag);
            streamWriter.Write(tagByte, 0, tag.Length);
            foreach (T item in objects)
            {
                formatter.Serialize(streamWriter, item);
            }
            streamWriter.Close();
        }

        private void GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Thread(SaveBudgetValues).Start();
        }

        private void SaveBudgetValues()
        {
            using (StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + Program.ReadSetting("Budget file source", "App.config"), false))
            {
                file.WriteLine(Budget.Balance);
                file.WriteLine(Budget.Income);
                file.WriteLine(Budget.Outcome);
                file.WriteLine(Budget.Profit);
            }
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm(this);
            addWorkerForm.ShowDialog();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(this);
            addOrderForm.ShowDialog();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(this);
            addClientForm.ShowDialog();
        }

        private void AddOffer_Click(object sender, EventArgs e)
        {
            AddOfferForm addOfferForm = new AddOfferForm(this);
            addOfferForm.ShowDialog();
        }

        private void ShowOffersButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Offers.Count() > 0)
                {
                    List<string> list = db.Offers.Select(i => i.OfferNumber + ". " + i.TravelDestination + ", " + i.HotelRanking + ", " + i.Feeding + ", €" + i.Price).ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Offer), this);
                    showObject.Text = "Show offers";
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No offers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Orders.Count() > 0)
                {
                    List<string> list = db.Orders.Select(i => i.OrderNumber + ". " + i.OrderClient.Name + " " + i.OrderClient.LastName + " " + i.TravelOffer.TravelDestination).ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Order), this);
                    showObject.Text = "Show orders";
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No orders!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowWorkersButton_Click(object sender, EventArgs e)
        {
            int number;
            using (var db = new TravelAgencyContext())
            { number = db.Workers.Count(); }
            if (number > 0)
            {
                List<String> list;
                using (var db = new TravelAgencyContext())
                {
                    list = db.Workers.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                }

                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Worker), this);
                showObject.Text = "Show workers";
                showObject.ShowDialog();
            }
            else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowClientsButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Clients.Count() > 0)
                {
                    List<string> list = db.Clients.Select(i => i.Name + " " + i.LastName + " [Client number: " + i.ClientNumber + "]").ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Client), this);
                    showObject.Text = "Show clients";
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No clients!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NearestDeparturesButton_Click(object sender, EventArgs e)
        {
            NearestDeparturesForm nearestDeparturesForm = new NearestDeparturesForm();
            nearestDeparturesForm.ShowDialog();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(Properties.Resources.image);
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            SendInformationByEmailForm sendByEmail = new SendInformationByEmailForm();
            sendByEmail.ShowDialog();
        }

        public static void PayOutSalaryHandler(ShowObject sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                Worker worker = null;
                int number = Convert.ToInt32(sender.objectBox.SelectedItem.ToString().Split('.').First());
                worker = db.Workers.Where(x => x.WorkerNumber == number).First();

                if (Budget.Balance - worker.Salary > Convert.ToDouble(Program.ReadSetting("Limit of bankrupt", "App.config")))
                {
                    MessageBox.Show("Paid out €" + worker.Salary + " to " + worker.Name + " " + worker.LastName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    worker.PaySalary();
                    sender.Dispose();
                }
                else
                {
                    worker.PaySalary();
                    sender.Dispose();
                }
            }
        }

        private void PayOutSalaryButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Workers.Count() > 0)
                {
                    List<string> list = db.Workers.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Worker), this);
                    showObject.Text = "Pay out salary";
                    showObject.showButton.Text = "Pay out salary";
                    showObject.showButton.Size = new Size(240, 23);
                    showObject.deleteButton.Visible = false;
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeWorkerPositionButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Workers.Count() > 0)
                {
                    List<string> list = db.Workers.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                    ChangeShiftForm changeShiftForm = new ChangeShiftForm(new BindingSource(list, null));
                    AddWorkerForm addWorker = new AddWorkerForm();
                    changeShiftForm.establishmentComboBox.Items.AddRange(new object[] {
                        "Operations manager",
                        "Quality control, safety, environmental manager",
                        "Accountant, bookkeeper, controller",
                        "Office manager",
                        "Receptionist",
                        "Foreperson, supervisor, lead person",
                        "Marketing manager",
                        "Purchasing manager",
                        "Shipping and receiving person or manager",
                        "Professional staff"
                    });
                    changeShiftForm.establishmentLabel.Text = "Position: ";
                    changeShiftForm.ShowDialog();
                }
                else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RaiseCutSalaryButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Workers.Count() > 0)
                {
                    List<string> list = db.Workers.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                    RaiseCutSalaryForm raiseCutSalaryForm = new RaiseCutSalaryForm(new BindingSource(list, null));
                    raiseCutSalaryForm.ShowDialog();
                }
                else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowWorkerOrdersbutton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Workers.Count() > 0)
                {
                    List<string> list = db.Workers.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Order), this);
                    showObject.Text = "Show worker's orders";
                    showObject.showButton.Text = "Show worker's orders";
                    showObject.showButton.Size = new Size(240, 23);
                    showObject.deleteButton.Visible = false;
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                db.Workers.Load();
                List<string> positions = new List<string>();
                List<int> positionCount = new List<int>();
                foreach (Worker worker in db.Workers.Local.ToList())
                {
                    if (!positions.Contains(worker.Position))
                    {
                        positions.Add(worker.Position);
                        positionCount.Add(db.Workers.Local.Where(x => x.Position == worker.Position).Count());
                    }
                }
                chart1.Series["Series1"].Points.DataBindXY(positions, positionCount);
                StartThreadQuantityUpdate();
            }
        }

        private void chartsTab_Selected(object sender, TabControlEventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                db.Workers.Load();
                switch (e.TabPageIndex)
                {
                    case 0:
                        List<string> positions = new List<string>();
                        List<int> positionCount = new List<int>();
                        foreach (Worker worker in db.Workers.Local.ToList())
                        {
                            if (!positions.Contains(worker.Position))
                            {
                                positions.Add(worker.Position);
                                positionCount.Add(db.Workers.Local.Where(x => x.Position == worker.Position).Count());
                            }
                        }
                        chart1.Series["Series1"].Points.DataBindXY(positions, positionCount);
                        break;
                    case 1:
                        List<string> workers = new List<string>();
                        List<double> salaries = new List<double>();
                        foreach (Worker worker in db.Workers.Local.OrderByDescending(x => x.Salary).Take(5).ToList())
                        {
                            workers.Add(worker.Name + " " + worker.LastName);
                            salaries.Add(db.Workers.Local.Where(x => x.Name + " " + x.LastName == worker.Name + " " + worker.LastName).Single().Salary);
                        }
                        chart2.Series["Series1"].Points.DataBindXY(workers, salaries);
                        break;
                }
            }   
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
