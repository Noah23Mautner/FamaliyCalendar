using Family_Calendar.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Calendar
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            

            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



            string username = txtEmail.Text;
            string password = txtPassword.Text;
            string role = "";

            if (username == "admin" && password == "admin123")
            {
                role = "admin";
            }
            else if (username == "user" && password == "user123")
            {
                role = "user";
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Prijava uspešna!", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            MainForm mainForm = new MainForm(username, role); // Prosleđujemo username i ulogu
            mainForm.ShowDialog();
            this.Close();




        }
    }
}
