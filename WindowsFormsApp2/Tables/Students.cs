using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tables
{
    public class Students
    {
        public ObjectId _id;
        public Users User;
        public Groups grupe;
        public DateTime EnrollmentDate;
    }
}
