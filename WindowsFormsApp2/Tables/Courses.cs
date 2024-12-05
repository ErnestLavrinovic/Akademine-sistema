using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tables
{
    internal class Courses
    {
        public ObjectId _id;
        public string CourseName;
        public Lecturers lecturer;
        public List<Groups> groups;
    }
}
