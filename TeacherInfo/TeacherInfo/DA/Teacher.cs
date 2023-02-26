using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherInfo
{
    internal class Teacher
    {
        public int Id;
        public string Name;
        public int Age;
        public string City;

        public Teacher()
        {

        }
        public Teacher(int id, string name, int age, string city)
        {
            Id = id;
            Name = name;
            Age = age;
            City = city;
        }
    }
}
