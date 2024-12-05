using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Tables;

namespace WindowsFormsApp2.Forms
{
    public partial class LoginForm : Form
    {
        db DB = new db();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var user = DB.GetDatabase().GetCollection<Users>("Users").
                AsQueryable().Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (user != null)
            {
                this.Hide(); // Hide the login form
                if (user.UserRole == Users.Role.Student)
                {
                    new StudentDashboard(username, password).Show();
                }
                else if (user.UserRole == Users.Role.Lecturer)
                {
                    new LecturerDashboard(username, password).Show();
                }
                else if (user.UserRole == Users.Role.Admin)
                {
                    new AdminDashboard().Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        //quick login

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "Va";
            string password = "Pa";
            new StudentDashboard(username, password).Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = "Lec";
            string password = "Turer3";
            new LecturerDashboard(username, password).Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            Hide();
        }
    }
}
