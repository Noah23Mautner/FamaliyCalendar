using Family_Calendar.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Family_Calendar.NewFolder1
{
    public partial class MainForm : Form
    {
        private static string filePath = "events.xml";

        public MainForm(string username, string role)
        {
            InitializeComponent();

            if (role != "admin")
            {
                button1.Visible = false;
            }




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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); 
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            List<EventData> events = new List<EventData>();

            foreach (var item in listEvents.Items)
            {
                string[] parts = item.ToString().Split(':');
                if (parts.Length >= 2)
                {
                    string date = parts[0].Trim();
                    string description = string.Join(":", parts.Skip(1)).Trim();
                    events.Add(new EventData { Date = date, Description = description });
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<EventData>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, events);
            }

            MessageBox.Show("Događaji su uspješno spremljeni!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public class EventData
        {
            public string Date { get; set; }
            public string Description { get; set; }
        }

        private void btnUčitaj_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Nema spremljenih događaja!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<EventData>));
            using (StreamReader reader = new StreamReader(filePath))
            {
                List<EventData> events = (List<EventData>)serializer.Deserialize(reader);
                listEvents.Items.Clear();
                foreach (var ev in events)
                {
                    listEvents.Items.Add($"{ev.Date}: {ev.Description}");
                }
            }

            MessageBox.Show("Događaji su uspješno učitani!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
