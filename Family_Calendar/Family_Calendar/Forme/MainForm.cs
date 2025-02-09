using Family_Calendar.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Calendar.NewFolder1
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
         
            
               
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string selectedDate = calendar.SelectionStart.ToShortDateString();
            using (EventForm eventForm = new EventForm(selectedDate))
            {
                if (eventForm.ShowDialog() == DialogResult.OK)
                {
                    listEvents.Items.Add($"{selectedDate}: {eventForm.EventText}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listEvents.SelectedItem != null)
            {
                listEvents.Items.Remove(listEvents.SelectedItem);
            }
            else
            {
                MessageBox.Show("Izaberite događaj koji želite obrisati!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
