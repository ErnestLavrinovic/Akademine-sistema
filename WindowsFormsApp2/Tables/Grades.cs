using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tables
{
    internal class Grades
    {
        public ObjectId _id;
        public int grade;
        public Courses course;
        public Students student;
    }
}
