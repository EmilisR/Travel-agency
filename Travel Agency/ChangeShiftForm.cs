using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class ChangeShiftForm : Form
    {
        public ChangeShiftForm(object dataSource)
        {
            InitializeComponent();
            workersBox.DataSource = dataSource;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (establishmentComboBox.Items.Count > 4)
            {
                if (establishmentComboBox.SelectedIndex == -1)
                {
                    establishmentComboBox.BackColor = Color.Salmon;
                }
                else
                {
                    establishmentComboBox.BackColor = Color.LightGreen;
                }
                if (workersBox.SelectedIndex == -1)
                {
                    workersBox.BackColor = Color.Salmon;
                }
                else
                {
                    workersBox.BackColor = Color.LightGreen;
                }
                if (establishmentComboBox.SelectedIndex != -1 && workersBox.SelectedIndex != 1)
                {
                    Worker worker = null;
                    int workerNumber = Convert.ToInt32(workersBox.SelectedItem.ToString().Split('.').First());
                    worker = DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == workerNumber).First();
                    string oldPosition = worker.Position;
                    worker.Position = establishmentComboBox.SelectedItem.ToString();
                    DatabaseMethods.UpdateWorker(worker);
                    MessageBox.Show("Old position: " + oldPosition + Environment.NewLine + "New position: " + worker.Position, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
            }
        }
    }
}
