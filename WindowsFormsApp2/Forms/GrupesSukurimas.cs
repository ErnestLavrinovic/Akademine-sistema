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
    public partial class GrupesSukurimas : Form
    {
        db DB = new db();
        public bool confirm = false;
        public GrupesSukurimas()
        {
            InitializeComponent();
        }

        private void Atsaukti_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Patvirtinti_Click(object sender, EventArgs e)
        {
            
            string groupname = GrupesPavadinimas.Text;
            var Group = new Groups { GroupName = groupname };
            var Groups = DB.GetDatabase().GetCollection<Groups>("Groups");

            var check = Groups.AsQueryable().Where(g => g.GroupName==groupname).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("Tokia grupe jau egistuoja.");
                return;
            }
            else
            {
                Groups.InsertOne(Group);
                MessageBox.Show("Nauja grupe sekmingai sukurta.");
                Hide();
            }
        }

        private void GrupesPavadinimas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
