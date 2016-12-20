using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class AddOfferForm : Form
    {
        private MainForm _mainForm;

        public AddOfferForm()
        {
            InitializeComponent();
        }

        public AddOfferForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void PriceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            priceValue.Text = "€" + priceTrackBar.Value.ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (countriesComboBox.SelectedIndex == -1)
            {
                countriesComboBox.BackColor = Color.Salmon;
            }
            else
            {
                countriesComboBox.BackColor = Color.LightGreen;
            }
            if (feedingComboBox.SelectedIndex == -1)
            {
                feedingComboBox.BackColor = Color.Salmon;
            }
            else
            {
                feedingComboBox.BackColor = Color.LightGreen;
            }
            if (rankingComboBox.SelectedIndex == -1)
            {
                rankingComboBox.BackColor = Color.Salmon;
            }
            else
            {
                rankingComboBox.BackColor = Color.LightGreen;
            }
            if (locationTextBox.Text == "")
            {
                locationTextBox.BackColor = Color.Salmon;
            }
            else
            {
                locationTextBox.BackColor = Color.LightGreen;
            }
            if (priceTrackBar.Value <= 20)
            {
                priceTrackBar.BackColor = Color.Salmon;
            }
            else
            {
                priceTrackBar.BackColor = Color.LightGreen;
            }
            if (daysTrackBar.Value <= 1)
            {
                daysTrackBar.BackColor = Color.Salmon;
            }
            else
            {
                daysTrackBar.BackColor = Color.LightGreen;
            }
            if (priceTrackBar.BackColor == Color.LightGreen && locationTextBox.BackColor == Color.LightGreen && rankingComboBox.BackColor == Color.LightGreen && feedingComboBox.BackColor == Color.LightGreen && countriesComboBox.BackColor == Color.LightGreen && daysTrackBar.BackColor == Color.LightGreen)
            {
                Offer offer = new Offer(countriesComboBox.SelectedItem.ToString() + ", " + locationTextBox.Text, feedingComboBox.SelectedItem.ToString(), priceTrackBar.Value, daysTrackBar.Value, rankingComboBox.SelectedItem.ToString(), new List<ILogger> { new LogFileWritter(), new ScreenObjectInfoWritter() });
                DatabaseMethods.InsertOffer(offer);
                _mainForm.StartThreadQuantityUpdate();
                Dispose();
            }
        }

        private void DaysTrackBar_ValueChanged(object sender, EventArgs e)
        {
            dayValue.Text = daysTrackBar.Value.ToString();
        }
    }
}
