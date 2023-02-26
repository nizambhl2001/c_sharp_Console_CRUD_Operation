using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherInfo
{
    internal interface ITeacherRepository
    {
        List<Teacher> Get();
        Teacher Get(int id);

        bool Add(Teacher model);
        bool Update(Teacher model);
        bool Delete(int id);
    }
}
