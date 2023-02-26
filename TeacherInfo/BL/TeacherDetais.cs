using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherInfo
{
    internal class TeacherDetais
    {
        ITeacherRepository _repository;
        public TeacherDetais(ITeacherRepository repository)
        {
            _repository = repository;
        }
        public List<Teacher> Get()
        {
            return _repository.Get();
        }
        public Teacher Get(int id)
        {
            return _repository.Get(id);
        }
        public bool Add(Teacher model)
        {
            return _repository.Add(model);
        }

        public bool Update(Teacher model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
