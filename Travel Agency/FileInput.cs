using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace Travel_Agency
{
    public partial class FileInput : Form
    {
        public static string OffersFilePath;
        public static string ClientsFilePath;
        public static string OrdersFilePath;
        public static string WorkersFilePath;
        private delegate void ClearDictionary();

        public FileInput()
        {
            InitializeComponent();
            goNextButton.Enabled = false;
            new Thread(ReadBudgetValues).Start();
        }

        private void ReadBudgetValues()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + ReadSetting("Budget file source", "App.config")))
                {
                    string line;
                    List<string> lines = new List<string>(4);
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    Budget.Balance = Convert.ToDouble(lines[0]);
                    Budget.Income = Convert.ToDouble(lines[1]);
                    Budget.Outcome = Convert.ToDouble(lines[2]);
                    Budget.Profit = Convert.ToDouble(lines[3]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The file could not be read:\n" + e.Message + "\nCreating new file with default values");
                Budget.Balance = 0;
                Budget.Income = 0;
                Budget.Outcome = 0;
                Budget.Profit = 0;
            }
        }

        public static string ReadSetting(string key, string filePath)
        {
            string result = null;
            try
            {
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\" + filePath; // full path to the config file
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                AppSettingsSection section = (AppSettingsSection)config.GetSection("appSettings");
                result = section.Settings[key].Value.ToString() ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return result;
        }

        private void UpdateProgressBar(long position, long length)
        {
            progressBar.Value = (int)((position / (decimal)length) * 100);
        }

        private void LoadFile(string filePath, byte[] readTag, string tag, Type type, Button button)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            long length = fileInfo.Length;
            IFormatter formatter = new BinaryFormatter();
            Stream sr = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            sr.Read(readTag, 0, tag.Length);
            if (Encoding.ASCII.GetString(readTag) == tag)
            {
                while (sr.Position < sr.Length)
                {
                    UpdateProgressBar(sr.Position, sr.Length);
                    if (type == typeof(Order))
                    {
                        Order newObject = (Order)formatter.Deserialize(sr);
                        Program.allOrders.Add(newObject.OrderNumber, newObject);
                    }
                    if (type == typeof(Worker))
                    {
                        Worker newObject = (Worker)formatter.Deserialize(sr);
                        newObject.ClearListOfOrders();
                        Program.allWorkers.Add(newObject.WorkerNumber, newObject);
                    }
                    if (type == typeof(Offer))
                    {
                        Offer newObject = (Offer)formatter.Deserialize(sr);
                        Program.allOffers.Add(newObject.OfferNumber, newObject);
                    }
                    if (type == typeof(Client))
                    {
                        Client newObject = (Client)formatter.Deserialize(sr);
                        Program.allClients.Add(newObject.ClientNumber, newObject);
                    }
                }
                UpdateProgressBar(sr.Length, sr.Length);
                button.BackColor = Color.LightGreen;
                button.Enabled = false;
                sr.Close();
                if (progressBar.Value == 100 && workersFileButton.BackColor == Color.LightGreen && offersFileButton.BackColor == Color.LightGreen && clientsFileButton.BackColor == Color.LightGreen && ordersFileButton.BackColor == Color.LightGreen)
                {
                    goNextButton.Enabled = true;
                }
            }
            else throw new WrongDataFileException("Wrong " + tag + " file!");
        }

        private void TryReadFromFile(string filePath, byte[] readTag, string fileTag, Type type, Button button, ClearDictionary clear)
        {
            try
            {
                LoadFile(filePath, readTag, fileTag, type, button);
            }
            catch (WrongDataFileException w)
            {
                MessageBox.Show(w.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar.Value = 0;
                clear();
            }
        }

        private void OffersFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OffersFilePath = openFileDialog.FileName;
                byte[] readTag = { 15, 15, 15, 15, 15, 15 };
                TryReadFromFile(OffersFilePath, readTag, "offers", new Offer().GetType(), offersFileButton, new ClearDictionary(Program.allOffers.Clear));
            }
        }

        private void WorkersFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                WorkersFilePath = openFileDialog.FileName;
                byte[] readTag = { 15, 15, 15, 15, 15, 15, 15 };
                TryReadFromFile(WorkersFilePath, readTag, "workers", new Worker().GetType(), workersFileButton, new ClearDictionary(Program.allWorkers.Clear));
            }
        }

        private void ClientsFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClientsFilePath = openFileDialog.FileName;
                byte[] readTag = { 15, 15, 15, 15, 15, 15, 15 };
                TryReadFromFile(ClientsFilePath, readTag, "clients", new Client().GetType(), clientsFileButton, new ClearDictionary(Program.allClients.Clear));
            }
        }

        private void OrdersFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OrdersFilePath = openFileDialog.FileName;
                byte[] readTag = { 15, 15, 15, 15, 15, 15 };
                TryReadFromFile(OrdersFilePath, readTag, "orders", new Order().GetType(), ordersFileButton, new ClearDictionary(Program.allClients.Clear));
            }
        }

        private void GoNextButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FileInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }
    }
}
