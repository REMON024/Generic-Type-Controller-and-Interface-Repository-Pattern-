using Generic_Contrller.IService;
using Generic_Contrller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Contrller.Service
{
    public class TeacherService : IGenericService<Teacher>
    {
        List<Teacher> lstTeacher = new List<Teacher>();

        public TeacherService()
        {
            for (int i = 0; i < 9; i++)
            {
                lstTeacher.Add(new Teacher()
                {
                    TeacherId = i,
                    Name = "Teacher" + 1,
                    Subject = "Subject" + 1

                });


            }
        }
        public List<Teacher> Delete(int Id)
        {
            lstTeacher.RemoveAll(x => x.TeacherId == Id);
            return lstTeacher;
        }

        public List<Teacher> GetAll()
        {
            return lstTeacher.ToList();
        }

        public Teacher GetById(int Id)
        {
            return lstTeacher.Where(x => x.TeacherId == Id).FirstOrDefault();
        }

        public List<Teacher> Insert(Teacher Insert)
        {
            lstTeacher.Add(Insert);

            return lstTeacher;
        }
    }
}
