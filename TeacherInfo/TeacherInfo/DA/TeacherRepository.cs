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
            new Teacher(1, "Abdul Motaleb",32, "Bhola"),
            new Teacher(1, "Khairul Alam",40, "Bhola"),

        };
        public List<Teacher> Get()
        {
            return listTeacher.OrderBy(x => x.Name).ToList();
        }

        public Teacher Get(int id)
        {
           Teacher oTeacher = listTeacher.Where(x => x.Id == id).FirstOrDefault();
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
            Teacher oTeacher = listTeacher.Where(x => x.Id == model.Id).FirstOrDefault();
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
            Teacher oTeacher = listTeacher.Where(x => x.Id == id).FirstOrDefault();
            if (oTeacher != null)
            {
                listTeacher.Remove(oTeacher);
                isExecuted = true;
            }
            return isExecuted;
        }

       
       
    }
}
