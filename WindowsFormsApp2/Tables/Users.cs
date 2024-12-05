using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tables
{
    public class Users
    {
        public ObjectId _id;
        public string Username;
        public string Password;
        public Role UserRole;
            public enum Role{
            Admin, Lecturer, Student
        }

        public string FullName;
        
    }

}
