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
    public partial class StudentDashboard : Form
    {
        private string username;
        private string password;
        db DB = new db();
        Students loggedInStudent;
        public StudentDashboard(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            string fullname = username + " " + password;
            labelGreeting.Text = $"Sveiki, {fullname}!";

            FetchLoggedInStudent();
            LoadStudentGroup();
            LoadAssignedCourses();
            labelSelectedCourse.Text = "Pasirinkite dalyka";

            dataGridViewCourses.CellClick += dataGridViewCourses_CellContentClick;

        }
        private void FetchLoggedInStudent()
        {
            loggedInStudent = DB.GetDatabase().GetCollection<Students>("Students").Find(Builders<Students>.Filter.Eq(s => s.User.Username, username)).FirstOrDefault();

            if (loggedInStudent == null)
            {
                MessageBox.Show("Klaida: Studentas nerastas.");
                Close();
            }
        }
        private void LoadStudentGroup()
        {
            if (loggedInStudent.grupe.GroupName != null)
            {
                labelGroup.Text = $"Grupe: {loggedInStudent.grupe.GroupName}";
            }
            else { labelGroup.Text = "Jūs nepriklausote jokiai grupei."; }
        }
        private void LoadAssignedCourses()
        {
            var coursesCollection = DB.GetDatabase().GetCollection<Courses>("Courses");
            var assignedCourses = coursesCollection.Find(Builders<Courses>.Filter.ElemMatch(c => c.groups, g => g.GroupName == loggedInStudent.grupe.GroupName)).ToList();
            if (assignedCourses == null || !assignedCourses.Any())
            {
                dataGridViewCourses.DataSource = new List<object>
            {
            new { CourseName = "Nėra priskirtų dalykų", LecturerName = string.Empty }
            };
                return;
            }

            var courseData = assignedCourses.Select(c => new
            {
                CourseName = c.CourseName,
                LecturerName = c.lecturer.User.FullName
            }).ToList();

            dataGridViewCourses.DataSource = courseData;

            dataGridViewCourses.Columns["CourseName"].HeaderText = "Dalykas";
            dataGridViewCourses.Columns["LecturerName"].HeaderText = "Dėstytojas";

        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedCourseName = dataGridViewCourses.Rows[e.RowIndex].Cells["CourseName"].Value.ToString();

                LoadGradesForSelectedCourse(selectedCourseName);
                labelSelectedCourse.Text = selectedCourseName;
            }
        }
        private void LoadGradesForSelectedCourse(string selectedCourseName)
        {
            var gradesCollection = DB.GetDatabase().GetCollection<Grades>("Grades");

            var grades = gradesCollection
                .Find(Builders<Grades>.Filter.And(
                    Builders<Grades>.Filter.Eq(g => g.student._id, loggedInStudent._id),
                    Builders<Grades>.Filter.Eq(g => g.course.CourseName, selectedCourseName)))
                .ToList();

            if (grades == null || !grades.Any())
            {
                dataGridViewGrades.DataSource = new List<object>
        {
            new { Grade = "Nera pazymiu" }
        };
                return;
            }

            var gradeData = grades.Select(g => new
            {
                Grade = g.grade
            }).ToList();

            dataGridViewGrades.DataSource = gradeData;
            dataGridViewGrades.Columns["Grade"].HeaderText = "Pazymys";
        }

    }
}
