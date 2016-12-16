using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class RaiseCutSalaryForm : Form
    {
        public RaiseCutSalaryForm(object dataSource)
        {
            InitializeComponent();
            workersBox.DataSource = dataSource;
        }

        private void RaiseButton_Click(object sender, EventArgs e)
        {
            if (workersBox.SelectedIndex != -1)
            {
                workersBox.BackColor = Color.LightGreen;
            }
            else
            {
                workersBox.BackColor = Color.Salmon;
            }
            if (moneyTrackBar.Value > 0)
            {
                moneyTrackBar.BackColor = Color.LightGreen;
            }
            else
            {
                moneyTrackBar.BackColor = Color.Salmon;
            }
            if (workersBox.BackColor == Color.LightGreen && moneyTrackBar.BackColor == Color.LightGreen)
            {
                Worker worker = null;
                int number = Convert.ToInt32(workersBox.SelectedItem.ToString().Split('.').First());
                worker = DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == number).First();
                double oldSalary = worker.Salary;
                worker.RaiseSalary(moneyTrackBar.Value);
                DatabaseMethods.UpdateWorker(worker);
                MessageBox.Show("Old salary: €" + oldSalary + "\nNew salary: €" + worker.Salary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            if (workersBox.SelectedIndex != -1)
            {
                workersBox.BackColor = Color.LightGreen;
            }
            else
            {
                workersBox.BackColor = Color.Salmon;
            }
            if (moneyTrackBar.Value > 0)
            {
                moneyTrackBar.BackColor = Color.LightGreen;
            }
            else
            {
                moneyTrackBar.BackColor = Color.Salmon;
            }
            if (workersBox.BackColor == Color.LightGreen && moneyTrackBar.BackColor == Color.LightGreen)
            {
                Worker worker = null;
                int number = Convert.ToInt32(workersBox.SelectedItem.ToString().Split('.').First());
                worker = DatabaseMethods.SelectWorkers().Where(x => x.WorkerNumber == number).First();
                double oldSalary = worker.Salary;
                if (oldSalary - moneyTrackBar.Value < 0)
                {
                    moneyTrackBar.BackColor = Color.Salmon;
                    MessageBox.Show("Salary cannot be negative! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    worker.CutSalary(moneyTrackBar.Value);
                    DatabaseMethods.UpdateWorker(worker);
                    MessageBox.Show("Old salary: €" + oldSalary + "\nNew salary: €" + worker.Salary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
            }
        }

        private void MoneyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            valueLabel.Text = "€" + moneyTrackBar.Value.ToString();
        }
    }
}
