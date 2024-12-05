using Microsoft.Identity.Client;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp2.Tables.Users;

namespace WindowsFormsApp2.Forms
{
    public partial class AdminDashboard : Form
    {
        db DB = new db();
        List<Groups> grupes = new List<Groups>();
        List<Lecturers> lecturers = new List<Lecturers>();
        List<Courses> courses = new List<Courses>();

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void refreshGroupList()
        {
            grupes = DB.GetDatabase().GetCollection<Groups>("Groups").Find(Builders<Groups>.Filter.Empty).ToList();
            GrupesPasirinkimas.Items.Clear();
            GrupesPasirinkimas3.Items.Clear();
            foreach (var grupe in grupes)
            {
                GrupesPasirinkimas.Items.Add(grupe.GroupName);
                GrupesPasirinkimas3.Items.Add(grupe.GroupName);
            }
            refreshLecturerList();
        }
        private void refreshLecturerList()
        {
            lecturers = DB.GetDatabase().GetCollection<Lecturers>("Lecturers").Find(Builders<Lecturers>.Filter.Empty).ToList();
            DestytojuPasirinkimas.Items.Clear();
            foreach (var lecturer in lecturers)
            {
                DestytojuPasirinkimas.Items.Add(lecturer.User.FullName);
            }
        }

        private void refreshCourseList()
        {
            courses = DB.GetDatabase().GetCollection<Courses>("Courses").Find(Builders<Courses>.Filter.Empty).ToList();
            comboBoxIstrintiDalyka.Items.Clear();
            foreach (var course in courses)
            {
                comboBoxIstrintiDalyka.Items.Add(course.CourseName);
            }
        }

        private void hidepanels()
        {
            StudentoPanele.Hide();
            DestytojoPanele.Hide();
            AdminPanel.Hide();
            GrupiuPanele.Hide();
            DalykuPanele.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //user ivedimo pasirinkimas
        {
            hidepanels();
            if (comboBox1.SelectedIndex == 0) // Studento panele
            {
                hidepanels();
                StudentoPanele.Show();
                grupes = DB.GetDatabase().GetCollection<Groups>("Groups").Find(Builders<Groups>.Filter.Empty).ToList();
                var groupcount = grupes.Count;
                GrupesPasirinkimas.Items.Clear();
                refreshGroupList();
                GrupesPasirinkimas.Items.Add("Prideti nauja grupe");
            }
            else if (comboBox1.SelectedIndex == 1) // Destytoju pridejimas
            {
                hidepanels();
                DestytojoPanele.Show();
                DestytojoPanele.BringToFront();
            }
            else if (comboBox1.SelectedIndex == 2) // Administratoriaus pridejimas
            {
                hidepanels();
                AdminPanel.Show();
                AdminPanel.BringToFront();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e) //draw new user pasirinkimo combobox
        {
            hidepanels();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Studentas");
            comboBox1.Items.Add("Destytojas");
            comboBox1.Items.Add("Administratorius");

            comboBoxGroupsCourses.Items.Clear();
            comboBoxGroupsCourses.Items.Add("Grupes");
            comboBoxGroupsCourses.Items.Add("Dalykai");



            grupes = DB.GetDatabase().GetCollection<Groups>("Groups").Find(Builders<Groups>.Filter.Empty).ToList();
            var groupcount = grupes.Count;
            refreshGroupList();
            refreshLecturerList();
            refreshCourseList();

        }

        private void PridetiConfirm_Click(object sender, EventArgs e)
        {
            string username = StudentoVardas.Text;
            string password = StudentoPavarde.Text;
            //grupe

            var user = DB.GetDatabase().GetCollection<Users>("Users").
                AsQueryable().Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Toks studentas jau egistuoja.");
                return;
            }
            else if(StudentoVardas.Text == "Vardas" || StudentoPavarde.Text == "Pavarde")
            {
                MessageBox.Show("Prasome Ivesti studento varda ir pavarde.");
                return;
            }
            else if (StudentoVardas.Text == "" || StudentoPavarde.Text == "")
            {
                MessageBox.Show("Prasome Ivesti studento varda ir pavarde.");
                return;
            }
            else if (GrupesPasirinkimas.SelectedIndex == -1)
            {
                MessageBox.Show("Prasome pasirinkti grupe.");
                return;
            }
            else
            {
                DB.Transaction(delegate (IClientSession session)
                {
                    var Users = DB.GetDatabase().GetCollection<Users>("Users");
                    var User = new Users { Username = username, Password = password, UserRole = Role.Student, FullName = $"{username} {password}" };
                    Users.InsertOne(User);
                    var Student = new Students { User = User, EnrollmentDate = dateTimePicker1.Value , grupe = grupes[GrupesPasirinkimas.SelectedIndex] };
                    var Students = DB.GetDatabase().GetCollection<Students>("Students");
                    Students.InsertOne(Student);
                });
                MessageBox.Show("Studentas pridetas sekmingai.");
                StudentoPanele.Hide();
            }
        }
        private void DestytojoPatvirtinimoMygtukas_Click(object sender, EventArgs e)
        {
            string username = DestytojoVardas.Text;
            string password = DestytojoPavarde.Text;
            var user = DB.GetDatabase().GetCollection<Users>("Users").
                AsQueryable().Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Toks destytojas jau egistuoja.");
                return;
            }
            else if (DestytojoVardas.Text == "Vardas" || DestytojoPavarde.Text == "Pavarde")
            {
                MessageBox.Show("Prasome Ivesti destytojo varda ir pavarde.");
                return;
            }
            else if (DestytojoVardas.Text == "" || DestytojoPavarde.Text == "")
            {
                MessageBox.Show("Prasome Ivesti destytojo varda ir pavarde.");
                return;
            }
            else
            {
                DB.Transaction(delegate (IClientSession session)
                {
                    var Users = DB.GetDatabase().GetCollection<Users>("Users");
                    var User = new Users { Username = username, Password = password, UserRole = Role.Lecturer, FullName = $"{username} {password}" };
                    Users.InsertOne(User);
                    var Lecturer = new Lecturers { User = User};
                    var Lecturers = DB.GetDatabase().GetCollection<Lecturers>("Lecturers");
                    Lecturers.InsertOne(Lecturer);
                });
                MessageBox.Show("Destytojas pridetas sekmingai.");
                refreshLecturerList();
                DestytojoPanele.Hide();
            }
        }
        private void AdminoPatvirtinimoMygtukas_Click(object sender, EventArgs e)
        {
            string username = AdminoVardas.Text;
            string password = AdminoPavarde.Text;
            var user = DB.GetDatabase().GetCollection<Users>("Users").
                AsQueryable().Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Toks administratorius jau egistuoja.");
                return;
            }
            else if (AdminoVardas.Text == "Vardas" || AdminoPavarde.Text == "Pavarde")
            {
                MessageBox.Show("Prasome Ivesti administratoriaus varda ir pavarde.");
                return;
            }
            else if (AdminoVardas.Text == "" || AdminoPavarde.Text == "")
            {
                MessageBox.Show("Prasome Ivesti administratoriaus varda ir pavarde.");
                return;
            }
            else
            {
                DB.Transaction(delegate (IClientSession session)
                {
                    var Users = DB.GetDatabase().GetCollection<Users>("Users");
                    var User = new Users { Username = username, Password = password, UserRole = Role.Admin, FullName = $"{username} {password}" };
                    Users.InsertOne(User);
                    var Admin = new Admins { User = User };
                    var Admins = DB.GetDatabase().GetCollection<Admins>("Admins");
                    Admins.InsertOne(Admin);
                });
                MessageBox.Show("Administratorius pridetas sekmingai.");
                AdminPanel.Hide();
            }
        }

        private void GrupesPasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GrupesPasirinkimas.SelectedIndex == grupes.Count)
            {
                new GrupesSukurimas().ShowDialog();
                grupes = DB.GetDatabase().GetCollection<Groups>("Groups").Find(Builders<Groups>.Filter.Empty).ToList();
                var groupcount = grupes.Count;
                GrupesPasirinkimas.Items.Clear();
                refreshGroupList();
                GrupesPasirinkimas.Items.Add("Prideti nauja grupe");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void StudentoPanele_Paint(object sender, PaintEventArgs e)
        {

        }
        private void StudentoVardas_TextChanged(object sender, EventArgs e)
        {

        }
        private void StudentoPavarde_TextChanged(object sender, EventArgs e)
        {

        }
        private void AdminoVardas_TextChanged(object sender, EventArgs e)
        {

        }
        private void AdminoPavarde_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DestytojoPanele_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AtsauktiConfirm_Click(object sender, EventArgs e)
        {
            hidepanels();
        }
        private void AtsauktiConfirm1_Click(object sender, EventArgs e)
        {
            hidepanels();
        }
        private void AtsauktiConfirm2_Click(object sender, EventArgs e)
        {
            hidepanels();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void comboBoxGroupsCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroupsCourses.SelectedIndex == 0)
            {
                hidepanels();
                GrupiuPanele.Show();
                GrupiuPanele.BringToFront();
            }
            if (comboBoxGroupsCourses.SelectedIndex == 1)
            {
                hidepanels();
                DalykuPanele.Show();
                DalykuPanele.BringToFront();
            }
        }

        private void GrupiuPanele_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GrupiuPanelePatvirtinti_Click(object sender, EventArgs e)
        {
            hidepanels();
        }

        private void GrupiuPaneleAtsaukti_Click(object sender, EventArgs e)
        {
            hidepanels();
        }

        private void DalykuPanele_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DalykuPaneleAtsaukti_Click(object sender, EventArgs e)
        {
            hidepanels();
        }

        private void DalykuPanelePatvirtinti_Click(object sender, EventArgs e)
        {
            hidepanels();
        }

        private void GrupesPavadinimas_TextChanged(object sender, EventArgs e)
        {

        }

        private void SukurtiGrupe_Click(object sender, EventArgs e)
        {
            string newgroupname = GrupesPavadinimas.Text;
            if(newgroupname == "")
            {
                MessageBox.Show("Grupes pavadinimas negali buti tuscias");
                return;
            }
            else if (newgroupname == "Grupes pavadinimas")
            {
                MessageBox.Show("Prasove ivesti grupes pavadinimas");
                return;
            }
            else
            {
                string groupname = GrupesPavadinimas.Text;
                var Group = new Groups { GroupName = groupname };
                var Groups = DB.GetDatabase().GetCollection<Groups>("Groups");

                var check = Groups.AsQueryable().Where(g => g.GroupName == groupname).FirstOrDefault();
                if (check != null)
                {
                    MessageBox.Show("Tokia grupe jau egistuoja.");
                    return;
                }
                else
                {
                    Groups.InsertOne(Group);
                    refreshGroupList();
                    MessageBox.Show("Nauja grupe sekmingai sukurta.");
                    return;
                }
            }

        }

        private void IstrintiGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                grupes = DB.GetDatabase().GetCollection<Groups>("Groups").Find(Builders<Groups>.Filter.Empty).ToList();
                var groupsCollection = DB.GetDatabase().GetCollection<Groups>("Groups");
                string check = grupes[GrupesPasirinkimas3.SelectedIndex].GroupName;
                DialogResult result = MessageBox.Show(
                string.Format("Ar tikrai norite istrinti grupe {0}?", check),
                "Patvirtinimas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                // Handle the user's response
                if (result == DialogResult.Yes)
                {
                    var filter = Builders<Groups>.Filter.Eq(g => g.GroupName, check);
                    groupsCollection.DeleteOne(filter);
                    refreshGroupList();
                    MessageBox.Show("Grupė buvo pašalinta.");
                }
                else
                {
                    // User clicked No
                    MessageBox.Show("Veiksmas buvo atšauktas.");
                }
                refreshGroupList();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prasome pasirinkti kita grupe");
                return;
            }
        }

        private void GrupesPasirinkimas3_SelectedIndexChanged(object sender, EventArgs e) //istrinti
        {

            
        }

        private void MoveToRedactionForm_Click(object sender, EventArgs e)
        {
            new GroupAssigment().Show();
        }

        private void SukurtiDalyka_Click(object sender, EventArgs e)
        {
            DB.Transaction(delegate (IClientSession session)
            {
                var Courses = DB.GetDatabase().GetCollection<Courses>("Courses");
                var Course = new Courses { CourseName = DalykoPavadinimas.Text , lecturer = lecturers[DestytojuPasirinkimas.SelectedIndex] };
                Courses.InsertOne(Course);
            });
            MessageBox.Show("Dalykas sukurtas sekmingai");
            DalykoPavadinimas.Clear();
            refreshLecturerList();
            refreshCourseList();
            return;
        }

        private void DalykoPavadinimas_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestytojuPasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIstrintiDalyka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIstrintiDalyka_Click(object sender, EventArgs e)
        {
            try
            {
                courses = DB.GetDatabase().GetCollection<Courses>("Courses").Find(Builders<Courses>.Filter.Empty).ToList();
                var coursesCollection = DB.GetDatabase().GetCollection<Courses>("Courses");
                string check = courses[comboBoxIstrintiDalyka.SelectedIndex].CourseName;
                DialogResult result = MessageBox.Show(
                string.Format("Ar tikrai norite istrinti dalyka {0}?", check),
                "Patvirtinimas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                // Handle the user's response
                if (result == DialogResult.Yes)
                {
                    var filter = Builders<Courses>.Filter.Eq(c => c.CourseName, check);
                    coursesCollection.DeleteOne(filter);

                    refreshCourseList();
                    MessageBox.Show("Dalykas buvo pašalintas.");
                }
                else
                {
                    // User clicked No
                    MessageBox.Show("Veiksmas buvo atšauktas.");
                }

                refreshCourseList();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prasome pasirinkti kita dalyka");
                return;
            }
        }
    }
}
