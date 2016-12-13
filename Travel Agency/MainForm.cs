using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Travel_Agency.Properties;

namespace Travel_Agency
{
    public partial class MainForm : Form
    {
        public delegate void EmailSendEventHandler<T>(T sender, EmailSendEventArgs e);
        public MainForm()
        {
            InitializeComponent();
            Task.Run(() => SetButtonImages());
            Task.Run(() => ReadBudgetValues());
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Budget.Bankrupt += BankruptHandler;
            Font = new Font(Program.ReadSetting("Font name", "User.config"), Convert.ToInt32(Program.ReadSetting("Font size", "User.config")));
            StartThreadQuantityUpdate();
        }

        private void SetButtonImages()
        {
            SetButtonProperties(addWorker, Resources.add);
            SetButtonProperties(addOrder, Resources.add);
            SetButtonProperties(addClient, Resources.add);
            SetButtonProperties(addOffer, Resources.add);
            SetButtonProperties(showWorkersButton, Resources.show);
            SetButtonProperties(showOrdersButton, Resources.show);
            SetButtonProperties(showClientsButton, Resources.show);
            SetButtonProperties(showOffersButton, Resources.show);
            SetButtonProperties(nearestReturnsButton, Resources.leave);
            SetButtonProperties(payOutSalaryButton, Resources.salary);
            SetButtonProperties(changeWorkerPositionButton, Resources.position);
            SetButtonProperties(raiseCutSalaryButton, Resources.raise_cut);
            SetButtonProperties(showWorkerOrdersbutton, Resources.orders);
            SetButtonProperties(sendEmailButton, Resources.mail);
        }
        private void SetButtonProperties(Button button, Image image)
        {
            button.Image = image;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }
        public async void StartThreadQuantityUpdate()
        {
            await SetLabelsAwait();
        }

        private async Task SetLabelsAwait()
        {
            clientsQuantity.Text = (await GetLabelTextAsync(DatabaseMethods.SelectClients().Count, "Number of clients: "));
            offersQuantity.Text = (await GetLabelTextAsync(DatabaseMethods.SelectClients().Count(), "Number of offers: "));
            workersQuantity.Text = (await GetLabelTextAsync(DatabaseMethods.SelectClients().Count(), "Number of workers: "));
            ordersQuantity.Text = (await GetLabelTextAsync(DatabaseMethods.SelectClients().Count(), "Number of orders: "));
            activeOrders.Text = (await GetLabelTextAsync(CheckActiveOrders(), "Active orders: "));
            if (!Budget.IsBankrupt())
            {
                budgetBalance.BackColor = DefaultBackColor;
                budgetBalance.Text = (await GetLabelTextAsync((int)Budget.Balance, "Budget balance: €"));
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
            int activeOrders = 0;
            List<Order> list = DatabaseMethods.SelectOrders();
            if (list.Count() > 0)
            {
                foreach (Order order in list)
                {
                    if (order.TravelStartDate > DateTime.Today) activeOrders++;
                }
            }
            return activeOrders;
        }

        private void GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Task.Run(() => SaveBudgetValues());
        }

        private void ReadBudgetValues()
        {
            using (StreamReader file = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + @"\" + Program.ReadSetting("Budget file source", "App.config"), false))
            {
                Budget.Balance = double.Parse(file.ReadLine());
                Budget.Income = double.Parse(file.ReadLine());
                Budget.Outcome = double.Parse(file.ReadLine());
                Budget.Profit = double.Parse(file.ReadLine());
            }
        }

        private void SaveBudgetValues()
        {
            using (StreamWriter file = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + @"\" + Program.ReadSetting("Budget file source", "App.config"), false))
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
            List<Offer> offerList = DatabaseMethods.SelectOffers();
            if (offerList.Count() > 0)
            {
                List<string> list = offerList.Select(i => i.OfferNumber + ". " + i.TravelDestination + ", " + i.HotelRanking + ", " + i.Feeding + ", €" + i.Price).ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Offer), this);
                showObject.Text = "Show offers";
                showObject.ShowDialog();
            }
            else MessageBox.Show("No offers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            List<Order> orderList = DatabaseMethods.SelectOrders();
            if (orderList.Count() > 0)
            {
                List<string> list = orderList.Select(i => i.OrderNumber + ". " + i.OrderClient.Name + " " + i.OrderClient.LastName + " " + i.TravelOffer.TravelDestination).ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Order), this);
                showObject.Text = "Show orders";
                showObject.ShowDialog();
            }
            else MessageBox.Show("No orders!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWorkersButton_Click(object sender, EventArgs e)
        {
            List<Worker> workerList = DatabaseMethods.SelectWorkers();
            if (workerList.Count() > 0)
            {
                List<string> list = workerList.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Worker), this);
                showObject.Text = "Show workers";
                showObject.ShowDialog();
            }
            else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowClientsButton_Click(object sender, EventArgs e)
        {
            List<Client> clientList = DatabaseMethods.SelectClients();
            if (clientList.Count() > 0)
            {
                List<string> list = clientList.Select(i => i.Name + " " + i.LastName + " [Client number: " + i.ClientNumber + "]").ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Client), this);
                showObject.Text = "Show clients";
                showObject.ShowDialog();
            }
            else MessageBox.Show("No clients!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<Worker> workerList = DatabaseMethods.SelectWorkers();
            if (workerList.Count() > 0)
            {
                Worker worker = null;
                int number = Convert.ToInt32(sender.objectBox.SelectedItem.ToString().Split('.').First());
                worker = workerList.Where(x => x.WorkerNumber == number).First();

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
            else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PayOutSalaryButton_Click(object sender, EventArgs e)
        {
            List<Worker> workerList = DatabaseMethods.SelectWorkers();
            if (workerList.Count() > 0)
            {
                List<string> list = workerList.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Worker), this);
                showObject.Text = "Pay out salary";
                showObject.showButton.Text = "Pay out salary";
                showObject.showButton.Size = new Size(564, 51);
                showObject.deleteButton.Visible = false;
                showObject.ShowDialog();
            }
            else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChangeWorkerPositionButton_Click(object sender, EventArgs e)
        {
            List<Worker> workerList = DatabaseMethods.SelectWorkers();
            if (workerList.Count() > 0)
            {
                List<string> list = workerList.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                ChangeShiftForm changeShiftForm = new ChangeShiftForm(new BindingSource(list, null));
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

        private void RaiseCutSalaryButton_Click(object sender, EventArgs e)
        {
            List<Worker> workerList = DatabaseMethods.SelectWorkers();
            if (workerList.Count() > 0)
            {
                List<string> list = workerList.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                RaiseCutSalaryForm raiseCutSalaryForm = new RaiseCutSalaryForm(new BindingSource(list, null));
                raiseCutSalaryForm.ShowDialog();
            }
            else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWorkerOrdersbutton_Click(object sender, EventArgs e)
        {
            List<Worker> workerList = DatabaseMethods.SelectWorkers();
            if (workerList.Count() > 0)
            {
                List<string> list = workerList.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Order), this);
                showObject.Text = "Show worker's orders";
                showObject.showButton.Text = "Show worker's orders";
                showObject.showButton.Size = new Size(564, 51);
                showObject.deleteButton.Visible = false;
                showObject.ShowDialog();
            }
            else MessageBox.Show("No workers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            List<string> positions = new List<string>();
            List<int> positionCount = new List<int>();
            var empl = DatabaseMethods.SelectWorkers().GroupBy(emp => emp.Position);
            foreach (var worker in empl)
            {
                positions.Add(worker.Key);
                positionCount.Add(worker.Count());
            }
            chart1.Series[0].LegendText = "Number of workers";
            RemoveGrid(chart1);
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].Points.DataBindXY(positions, positionCount);
            StartThreadQuantityUpdate();
        }

        private void chartsTab_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    List<string> positions = new List<string>();
                    List<int> positionCount = new List<int>();
                    var empl = DatabaseMethods.SelectWorkers().GroupBy(emp => emp.Position);
                    foreach(var worker in empl)
                    {
                        positions.Add(worker.Key);
                        positionCount.Add(worker.Count());
                    }
                    chart1.Series[0].LegendText = "Number of workers";
                    RemoveGrid(chart1);
                    chart1.Series["Series1"].IsValueShownAsLabel = true;
                    chart1.Series["Series1"].Points.DataBindXY(positions, positionCount);
                    break;
                case 1:
                    List<string> workers = new List<string>();
                    List<double> salaries = new List<double>();
                    foreach (Worker worker in DatabaseMethods.SelectWorkers().OrderByDescending(x => x.Salary).Take(5).ToList())
                    {
                        workers.Add(worker.Name + " " + worker.LastName);
                        salaries.Add(DatabaseMethods.SelectWorkers().Where(x => x.Name + " " + x.LastName == worker.Name + " " + worker.LastName).Single().Salary);
                    }
                    chart2.Series[0].LegendText = "Salary per month in €";
                    RemoveGrid(chart2);
                    chart2.Series["Series1"].IsValueShownAsLabel = true;
                    chart2.Series["Series1"].Points.DataBindXY(workers, salaries);
                    break;
                case 2:
                    workers = new List<string>();
                    salaries = new List<double>();
                    foreach (Worker worker in DatabaseMethods.SelectWorkers().OrderByDescending(x => x.Salary).Skip(DatabaseMethods.SelectWorkers().Count - 5).ToList())
                    {
                        workers.Add(worker.Name + " " + worker.LastName);
                        salaries.Add(DatabaseMethods.SelectWorkers().Where(x => x.Name + " " + x.LastName == worker.Name + " " + worker.LastName).Single().Salary);
                    }
                    chart3.Series[0].LegendText = "Salary per month in €";
                    RemoveGrid(chart3);
                    chart3.Series["Series1"].IsValueShownAsLabel = true;
                    chart3.Series["Series1"].Points.DataBindXY(workers, salaries);
                    break;
                case 3:
                    List<Order> orders = DatabaseMethods.SelectOrders();
                    List<Offer> offers = DatabaseMethods.SelectOffers();
                    var join = orders.OrderByDescending(order => order.TravelStartDate).Reverse().Join(offers,
                                        ord => ord.TravelOffer.OfferNumber,
                                        off => off.OfferNumber,
                                        (ord, off) => new { ord.TravelStartDate, off.Price, ord.OrderClientsAmount}).GroupBy(grp => grp.TravelStartDate);
                    List<string> dates = new List<string>();
                    List<double> prices = new List<double>();
                    foreach (var item in join)
                    {
                        dates.Add(item.Key.ToShortDateString());
                        prices.Add(item.Select(price => price.Price * price.OrderClientsAmount).Sum());
                    }
                    chart4.Series[0].LegendText = "Total income for day in €";
                    RemoveGrid(chart4);
                    chart4.Series["Series1"].IsValueShownAsLabel = true;
                    chart4.Series["Series1"].Points.DataBindXY(dates, prices);
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void RemoveGrid(Chart chart)
        {
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
    }
}
