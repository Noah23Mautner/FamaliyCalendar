using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Calendar.Forme
{
    public partial class EventForm : Form
    {

        public string SelectedDate { get; set; }
        public string EventText { get; private set; }
        public EventForm(string date)
        {
            InitializeComponent();
            SelectedDate = date;
            lblDate.Text = "Datum: " + date;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEvent.Text))
            {
                EventText = txtEvent.Text;
                DialogResult = DialogResult.OK; // Oznaka da je uspešno dodano
                Close();
            }
            else
            {
                MessageBox.Show("Unesite opis događaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Zatvaranje bez dodavanja
            Close();
        }
    }
}
