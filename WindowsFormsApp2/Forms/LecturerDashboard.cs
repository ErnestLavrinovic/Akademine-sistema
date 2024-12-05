using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Tables;

namespace WindowsFormsApp2.Forms
{
    public partial class LecturerDashboard : Form
    {


        private string username;
        private string password;
        db DB = new db();

        List<Groups> grupes = new List<Groups>();
        List<Lecturers> lecturers = new List<Lecturers>();
        List<Courses> courses = new List<Courses>();
        public LecturerDashboard(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            string fullname = username + " " + password;
            labelGreeting.Text = $"Sveiki, {fullname}!";
            refreshCourseList();
            refreshGroupList();
            GradingPanel.Hide();

            comboBoxDalykas.SelectedIndexChanged += comboBoxDalykas_SelectedIndexChanged;
            comboBoxGrupe.SelectedIndexChanged += comboBoxGrupe_SelectedIndexChanged;

        }
        private void refreshCourseList()
        {
            string fullname = username + " " + password; 
            var filter = Builders<Courses>.Filter.Eq("lecturer.User.FullName", fullname);
            courses = DB.GetDatabase().GetCollection<Courses>("Courses").Find(filter).ToList();
            comboBoxDalykas.Items.Clear();
            foreach (var course in courses)
            {
                comboBoxDalykas.Items.Add(course.CourseName);
            }
        }
        private void refreshGroupList()
        {
            grupes = DB.GetDatabase().GetCollection<Groups>("Groups").Find(Builders<Groups>.Filter.Empty).ToList();
            comboBoxAssignAGroup.Items.Clear();
            comboBoxGrupe.Items.Clear();
            foreach (var grupe in grupes)
            {
                comboBoxAssignAGroup.Items.Add(grupe.GroupName);
                comboBoxGrupe.Items.Add(grupe.GroupName);
            }
        }

        private void comboBoxGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGrupe.SelectedIndex == -1)
            {
                MessageBox.Show("Pasirinkite grupe.");
                return;
            }

            string selectedGroupName = comboBoxGrupe.SelectedItem.ToString();

            var selectedGroup = grupes.FirstOrDefault(g => g.GroupName == selectedGroupName);

            if (selectedGroup == null)
            {
                MessageBox.Show("Grupe nerasta.");
                comboBoxStudent.Items.Clear();
                return;
            }

            var students = DB.GetDatabase()
                             .GetCollection<Students>("Students")
                             .Find(Builders<Students>.Filter.Eq(s => s.grupe.GroupName, selectedGroupName))
                             .ToList();

            comboBoxStudent.Items.Clear();
            foreach (var student in students)
            {
                comboBoxStudent.Items.Add(student.User.FullName);
            }
        }

        private void comboBoxDalykas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDalykas.SelectedIndex == -1)
            {
                MessageBox.Show("Pasirinkite dalyka.");
                return;
            }

            string selectedCourseName = comboBoxDalykas.SelectedItem.ToString();

            var selectedCourse = courses.FirstOrDefault(c => c.CourseName == selectedCourseName);

            if (selectedCourse == null || selectedCourse.groups == null)
            {
                MessageBox.Show("Siame dalyke nera priskirtu grupiu.");
                comboBoxGrupe.Items.Clear();
                return;
            }

            comboBoxGrupe.Items.Clear();
            foreach (var group in selectedCourse.groups)
            {
                comboBoxGrupe.Items.Add(group.GroupName);
            }
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradingPanel.Hide();
            GradingPanel.Show();
            labelDalykas.Text = $"Dalykas: {comboBoxDalykas.Text}";
            labelGrupe.Text = $"Grupe: {comboBoxGrupe.Text}";
            labelStudentas.Text = $"Studentas: {comboBoxStudent.Text}";
            LoadGradeHistory();
        }

        private void comboBoxAssignAGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAssignGroupToCourse_Click(object sender, EventArgs e)
        {
            if (comboBoxDalykas.SelectedIndex == -1 || comboBoxAssignAGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Pasirinkite grupe ir dalyka.");
                return;
            }
            string selectedCourseName = comboBoxDalykas.SelectedItem.ToString();
            string selectedGroupName = comboBoxAssignAGroup.SelectedItem.ToString();            

            var course = courses.FirstOrDefault(c => c.CourseName == selectedCourseName);
            var group = DB.GetDatabase().GetCollection<Groups>("Groups")
                  .Find(Builders<Groups>.Filter.Eq(g => g.GroupName, selectedGroupName))
                  .FirstOrDefault();
            if (course == null || group == null)
            {
                MessageBox.Show("Error: Grupe ar dalykas nerastas");
                return;
            }

            if (course.groups == null)
                course.groups = new List<Groups>();

            if (course.groups.Any(g => g.GroupName == selectedGroupName))
            {
                MessageBox.Show("Si grupe jau yra priskirta prie sio dalyko");
                return;
            }
            course.groups.Add(group);
            var coursesCollection = DB.GetDatabase().GetCollection<Courses>("Courses");
            var filter = Builders<Courses>.Filter.Eq(c => c._id, course._id);
            var update = Builders<Courses>.Update.Set(c => c.groups, course.groups);
            coursesCollection.UpdateOne(filter, update);

            refreshGroupList();
            MessageBox.Show($"Grupe {selectedGroupName} sekmingai priskirta prie dalyko {selectedCourseName}.");

        } //priskirti grupe prie dalyko

        private void buttonPaskirtiPazymi_Click(object sender, EventArgs e)
        {
            if (comboBoxDalykas.SelectedIndex == -1 || comboBoxGrupe.SelectedIndex == -1 || comboBoxStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Prasome pasirinkti dalyka, grupe ir studenta.");
                return;
            }

            string selectedStudentName = comboBoxStudent.SelectedItem.ToString();
            string selectedCourseName = comboBoxDalykas.SelectedItem.ToString();
            int grade = (int)numericUpDownGrade.Value;

            SaveGrade(selectedStudentName, selectedCourseName, grade);
            LoadGradeHistory(); // Refresh grade history
        }
        private void SaveGrade(string studentName, string courseName, int gradeValue)
        {
            var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");
            var coursesCollection = DB.GetDatabase().GetCollection<Courses>("Courses");
            var gradesCollection = DB.GetDatabase().GetCollection<Grades>("Grades");

            var studentFilter = Builders<Students>.Filter.Eq(s => s.User.FullName, studentName);
            var student = studentsCollection.Find(studentFilter).FirstOrDefault();

            if (student == null)
            {
                MessageBox.Show("Studentas nerastas.");
                return;
            }

            var courseFilter = Builders<Courses>.Filter.Eq(c => c.CourseName, courseName);
            var course = coursesCollection.Find(courseFilter).FirstOrDefault();

            if (course == null)
            {
                MessageBox.Show("Dalykas nerastas.");
                return;
            }

            var grade = new Grades
            {
                grade = gradeValue,
                course = course,
                student = student
            };

            gradesCollection.InsertOne(grade);

            MessageBox.Show($"Pazymys {gradeValue} issaugotas studentui {studentName} dalyke {courseName}.");
        }
        private void LoadGradeHistory()
        {
            if (comboBoxDalykas.SelectedIndex == -1 || comboBoxStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Pasirinkite dalyka ir studenta.");
                return;
            }

            string selectedStudentName = comboBoxStudent.SelectedItem.ToString();
            string selectedCourseName = comboBoxDalykas.SelectedItem.ToString();

            var gradesCollection = DB.GetDatabase().GetCollection<Grades>("Grades");

            var grades = gradesCollection
                .Find(Builders<Grades>.Filter.And(
                    Builders<Grades>.Filter.Eq(g => g.student.User.FullName, selectedStudentName),
                    Builders<Grades>.Filter.Eq(g => g.course.CourseName, selectedCourseName)))
                .ToList();

            if (grades == null || !grades.Any())
            {
                dataGridViewGrades.DataSource = new List<object>
        {
            new { Grade = "Nera pazymiu", CourseName = string.Empty, StudentName = string.Empty }
        };
                return;
            }

            var gradeHistory = grades.Select(g => new
            {
                Grade = g.grade,
                CourseName = g.course.CourseName,
                StudentName = g.student.User.FullName
            }).ToList();

            double averageGrade = gradeHistory.Average(g => g.Grade);

            gradeHistory.Add(new
            {
                Grade = (int)averageGrade, 
                CourseName = "Vidurkis",  
                StudentName = string.Empty 
            });

            dataGridViewGrades.DataSource = gradeHistory;

            dataGridViewGrades.Columns["Grade"].HeaderText = "Pazymys";
            dataGridViewGrades.Columns["CourseName"].HeaderText = "Dalykas";
            dataGridViewGrades.Columns["StudentName"].HeaderText = "Studentas";
        }

    }
}
