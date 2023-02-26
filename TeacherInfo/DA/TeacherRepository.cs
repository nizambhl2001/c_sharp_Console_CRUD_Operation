using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TeacherInfo
{
    internal class TeacherRepository : ITeacherRepository
    {
        List<Teacher> listTeacher = new List<Teacher>(){

            new Teacher(1, "MD. Aslam",32, "Bhola"),
            new Teacher(2, "Abdul Motaleb",32, "Dhaka"),
            new Teacher(3, "Khairul Alam",40, "Khulna"),
            new Teacher(4, "Abdul Malek",32, "Barisal"),
            new Teacher(5, "MD. Khokan",35, "Dhaka"),
            new Teacher(6, "Khairul Islam",40, "Khulna"),

        };
        public List<Teacher> Get()
        {
            return listTeacher.OrderBy(x => x.TeacherName).ToList();
        }

        public Teacher Get(int id)
        {
           Teacher oTeacher = listTeacher.Where(x => x.TeacherId == id).FirstOrDefault();
            return oTeacher;
        }

        public bool Add(Teacher model)
        {
            listTeacher.Add(model);
            return true;
        }
        public bool Update(Teacher model)
        {
            bool isExecuted = false;
            Teacher oTeacher = listTeacher.Where(x => x.TeacherId == model.TeacherId).FirstOrDefault();
            if (oTeacher != null)
            {
                listTeacher.Remove(oTeacher);
                listTeacher.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int id)
        {
            bool isExecuted = false;
            Teacher oTeacher = listTeacher.Where(x => x.TeacherId == id).FirstOrDefault();
            if (oTeacher != null)
            {
                listTeacher.Remove(oTeacher);
                isExecuted = true;
            }
            return isExecuted;
        }

       
       
    }
}
