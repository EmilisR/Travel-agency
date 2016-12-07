using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class AddWorkerForm : Form
    {
        private MainForm _mainForm;

        public AddWorkerForm()
        {
            InitializeComponent();
        }

        public AddWorkerForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void salaryTrackBar_ValueChanged(object sender, EventArgs e)
        {
            salaryValue.Text = "€" + salaryTrackBar.Value.ToString();
        }

        private void workingHoursTrackBar_ValueChanged(object sender, EventArgs e)
        {
            workingHoursValue.Text = workingHoursTrackBar.Value.ToString() + " hours";
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(nameTextBox.Text, pattern: @"^[a-zA-ZąčęėįšųūžĄČĘĖĮŠŲŪŽ]+$"))
            {
                nameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                nameTextBox.BackColor = Color.Salmon;
            }
            if (Regex.IsMatch(lastNameTextBox.Text, pattern: @"^[a-zA-ZąčęėįšųūžĄČĘĖĮŠŲŪŽ]+$"))
            {
                lastNameTextBox.BackColor = Color.LightGreen;
            }
            else 
            {
                lastNameTextBox.BackColor = Color.Salmon;
            }
            if (positionComboBox.SelectedIndex != -1)
            {
                positionComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                positionComboBox.BackColor = Color.Salmon;
            }
            if (salaryTrackBar.Value > 350)
            {
                salaryTrackBar.BackColor = Color.LightGreen;
            }
            else
            {
                salaryTrackBar.BackColor = Color.Salmon;
            }
            if (workingHoursTrackBar.Value >= 12)
            {
                workingHoursTrackBar.BackColor = Color.LightGreen;
            }
            else
            {
                workingHoursTrackBar.BackColor = Color.Salmon;
            }
            if (nameTextBox.BackColor == Color.LightGreen && lastNameTextBox.BackColor == Color.LightGreen && positionComboBox.BackColor == Color.LightGreen && salaryTrackBar.BackColor == Color.LightGreen && workingHoursTrackBar.BackColor == Color.LightGreen)
            {
                Worker worker = new Worker(nameTextBox.Text, lastNameTextBox.Text, positionComboBox.SelectedItem.ToString(), salaryTrackBar.Value, workingHoursTrackBar.Value, new LogFileWritter(), new ScreenObjectInfoWritter());
                Program.allWorkers.Add(worker.WorkerNumber, worker);
                _mainForm.StartThreadQuantityUpdate();
                Dispose();
            }
        }
    }
}
