using MongoDB.Bson;
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
    public partial class GroupAssigment : Form
    {
        db DB = new db();
        List<Groups> grupes = new List<Groups>();
        List<Users> users = new List<Users>();
        List<Students> students = new List<Students>();

        private void LoadGroups()
        {
            var groupsCollection = DB.GetDatabase().GetCollection<Groups>("Groups");
            var groups = groupsCollection.Find(Builders<Groups>.Filter.Empty).ToList();

            GrupesPasirinkimas.Items.Clear();
            foreach (var group in groups)
            {
                GrupesPasirinkimas.Items.Add(group.GroupName);
            }
        }
        private void LoadStudentsList()
        {
            var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");
            var students = studentsCollection.Find(Builders<Students>.Filter.Empty).ToList();
            dataGridViewAllStudents.DataSource = students.Select(s => new   //all students tab
            {
                Name = s.User.FullName,
                GroupName = s.grupe != null ? s.grupe.GroupName : "Unassigned" // Handle null case
            }).ToList();

            var filter = Builders<Students>.Filter.Eq(s => s.grupe.GroupName, null);
            var unassignedStudents = studentsCollection.Find(filter).ToList();
            dataGridViewUnassignedStudents.DataSource = unassignedStudents.Select(s => new   //unassigned students tab
            {
                Name = s.User.FullName,
                GroupName = s.grupe != null ? s.grupe.GroupName : "Unassigned" // Handle null case
            }).ToList();
        }

        private void LoadStudentsForSelectedGroup(string groupName)
        {
            var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");

            var filter = Builders<Students>.Filter.Eq(s => s.grupe.GroupName, groupName);
            var groupStudents = studentsCollection.Find(filter).ToList();

            dataGridViewAssignedStudents.DataSource = groupStudents.Select(s => new
            {
                Name = s.User.FullName,
                GroupName = s.grupe.GroupName
            }).ToList();
        }

        public GroupAssigment()
        {
            InitializeComponent();
        }

        private void hidepanels()
        {

        }

        private void GroupAssigment_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadStudentsList();

        }

        private void GrupesPasirinkimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GrupesPasirinkimas.SelectedItem != "Pasirinkite grupe")
            {
                string selectedGroup = GrupesPasirinkimas.SelectedItem.ToString();
                LoadStudentsForSelectedGroup(selectedGroup);
            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignedStudents.SelectedRows.Count > 0)
            {
                string groupName = GrupesPasirinkimas.SelectedItem.ToString();
                var selectedRow = dataGridViewAssignedStudents.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");

                var filter = Builders<Students>.Filter.Eq(s => s.User.FullName, name);
                var update = Builders<Students>.Update.Set(s => s.grupe.GroupName, null);
                studentsCollection.UpdateOne(filter, update);

                // Refresh lists
                LoadStudentsList();
                LoadStudentsForSelectedGroup(groupName);
            }
            else
            {
                MessageBox.Show("Please select a student to unassign.");
            }
        }

        private void btnUnassignFromGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllStudents.SelectedRows.Count > 0)
            {
                string groupName = GrupesPasirinkimas.SelectedItem.ToString();
                var selectedRow = dataGridViewAllStudents.SelectedRows[0];
                var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");

                string name = selectedRow.Cells["Name"].Value.ToString();
                var filter = Builders<Students>.Filter.Eq(s => s.User.FullName, name);
                var update = Builders<Students>.Update.Set(s => s.grupe.GroupName, null);
                studentsCollection.UpdateOne(filter, update);

                // Refresh lists
                LoadStudentsList();
                LoadStudentsForSelectedGroup(groupName);
            }
            else
            {
                MessageBox.Show("Please select a student to unassign.");
            }
        }

        private void btnAssignFromAll_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllStudents.SelectedRows.Count > 0 && GrupesPasirinkimas.SelectedItem != null)
            {
                string groupName = GrupesPasirinkimas.SelectedItem.ToString();
                var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");

                foreach (DataGridViewRow row in dataGridViewAllStudents.SelectedRows)
                {
                    string name = row.Cells["Name"].Value.ToString();
                    var filter = Builders<Students>.Filter.Eq("User.FullName", name);
                    var update = Builders<Students>.Update.Set(s => s.grupe.GroupName, groupName);

                    studentsCollection.UpdateOne(filter, update);
                    
                }
                LoadStudentsList();
                LoadStudentsForSelectedGroup(groupName);
            }
            else
            {
                MessageBox.Show("Please select a student and a group.");
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dataGridViewUnassignedStudents.SelectedRows.Count > 0 && GrupesPasirinkimas.SelectedItem != null)
            {
                var selectedRow = dataGridViewUnassignedStudents.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string groupName = GrupesPasirinkimas.SelectedItem.ToString();

                var studentsCollection = DB.GetDatabase().GetCollection<Students>("Students");

                var filter = Builders<Students>.Filter.And(
                    Builders<Students>.Filter.Eq("User.FullName", name)
                );

                var update = Builders<Students>.Update.Set(s => s.grupe.GroupName, groupName);
                studentsCollection.UpdateOne(filter, update);

                // refresh lists
                LoadStudentsList();
                LoadStudentsForSelectedGroup(groupName);
            }
            else
            {
                MessageBox.Show("Please select a student and a group.");
            }
        }


    }
}
