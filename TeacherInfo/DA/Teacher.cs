using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherInfo
{
    internal class Teacher
    {
        public int TeacherId;
        public string TeacherName;
        public int Age;
        public string City;

        public Teacher()
        {

        }
        public Teacher(int teacherid, string teachername, int age, string city)
        {
            TeacherId = teacherid;
            TeacherName = teachername;
            Age = age;
            City = city;
        }
    }
}
