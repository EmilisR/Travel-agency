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
                    Worker worker = Program.allWorkers[Convert.ToInt32(workersBox.SelectedItem.ToString().Split('.').First())];
                    string oldPosition = worker.Position;
                    worker.Position = establishmentComboBox.SelectedItem.ToString();
                    MessageBox.Show("Old position: " + oldPosition + "\nNew position: " + worker.Position, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
            }
            else
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
                    Worker worker = Program.allWorkers[Convert.ToInt32(workersBox.SelectedItem.ToString().Split('.').First())];
                    double previuosSalary = worker.Salary;
                    int previuosWorkingHours = worker.WorkingHoursPerWeek;
                    if (establishmentComboBox.SelectedItem.ToString() == "Full time")
                    {
                        worker.ChangeEstablishment(1);
                    }
                    if (establishmentComboBox.SelectedItem.ToString() == "1/2 time")
                    {
                        worker.ChangeEstablishment(0.5);
                    }
                    if (establishmentComboBox.SelectedItem.ToString() == "3/4 time")
                    {
                        worker.ChangeEstablishment(0.75);
                    }
                    if (establishmentComboBox.SelectedItem.ToString() == "1/4 time")
                    {
                        worker.ChangeEstablishment(0.25);
                    }
                    MessageBox.Show("Previuos salary: €" + previuosSalary + ", new salary: €" + worker.Salary + "\nPreviuos working hours: " + previuosWorkingHours + ", new working hours: " + worker.WorkingHoursPerWeek, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
            }
        }
    }
}
